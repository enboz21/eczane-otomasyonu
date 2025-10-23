using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Interface;
using DevExpress.XtraEditors;
using Entities;
using Entities.DTOs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UI
{
    public partial class frmMarkalar : DevExpress.XtraEditors.XtraForm
    {
        protected readonly IMarkaS _markas;
        public frmMarkalar(IMarkaS marka)
        {
            InitializeComponent();
            _markas = marka;
        }

        private void frmMarkalar_Load(object sender, EventArgs e)
        {
            try
            {
                //
                yenile();
                Temizle();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(
                    "Veriler yüklenirken bir hata oluştu!\n\n" +
                    "Hata Detayı: " + ex.Message + "\n\n" +
                    "(Inner Exception: " + ex.InnerException?.Message + ")",
                    "Ciddi Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private async void yenile()
        {
            var marka = await _markas.GetAll();
            gridControl1.DataSource = marka;
            gridViewMarkalar.Columns["MarkaId"].Visible = false;
            gridViewMarkalar.Columns["Ilaclar"].Visible = false;
        }
        private void Temizle()
        {
            textEdit1.Text = "";
            label1.Text = "-1";
        }

        private void gridViewMarkalar_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Marka secilen = gridViewMarkalar.GetFocusedRow() as Marka;

            if (secilen != null)
            {
                textEdit1.Text = secilen.MarkaAdi;
                label1.Text = secilen.MarkaId.ToString();
            }
            else
            {
                label1.Text = "-1";
            }
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text == null)
            {
                XtraMessageBox.Show("Lütfen bir Marka seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Marka yeni = new Marka();
            yeni.MarkaAdi = textEdit1.Text;
            yeni.Aktif = true;
            await _markas.Add(yeni);
            XtraMessageBox.Show("Yeni marka başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            yenile();
            Temizle();
        }

        private async void simpleButton3_Click(object sender, EventArgs e)
        {
            int secilen;
            bool idParseBasarili = int.TryParse(label1.Text, out secilen);

            if (!idParseBasarili || secilen <= 0)
            {
                XtraMessageBox.Show("Lütfen silmek için listeden bir Marka seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult onay = XtraMessageBox.Show(
                $"Seçili Markayı (ID: {secilen}) silmek istediğinizden emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (onay == DialogResult.No)
            {
                return;
            }
            try
            {

                await _markas.Delete(secilen);

                XtraMessageBox.Show("marka başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                yenile();
                Temizle();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Silme işlemi sırasında bir hata oluştu:\n\n" + ex.Message,
                    "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void simpleButton2_Click(object sender, EventArgs e)
        {
            int secilenId;
            bool idParseBasarili = int.TryParse(label1.Text, out secilenId);

            if (!idParseBasarili || secilenId <= 0)
            {
                XtraMessageBox.Show("Lütfen güncellemek için listeden bir marka seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Önce mevcut ilacı veritabanından al
                var mevcut = await _markas.GetById(secilenId);
                if (mevcut == null)
                {
                    XtraMessageBox.Show("Seçili ilaç bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mevcut ilacın değerlerini güncelle
                mevcut.MarkaAdi = textEdit1.Text;
                mevcut.Aktif = true;
                await _markas.Update(mevcut);

                XtraMessageBox.Show("İlaç başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                yenile();
                Temizle();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu:\n\n" + ex.Message,
                    "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}