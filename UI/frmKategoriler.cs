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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UI
{
    public partial class frmKategoriler : DevExpress.XtraEditors.XtraForm
    {
        protected readonly IKategoriS _kategoris;
        public frmKategoriler(IKategoriS kategori)
        {
            InitializeComponent();
            _kategoris = kategori;
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text == null)
            {
                XtraMessageBox.Show("Lütfen bir Kategori seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Kategori yeni = new Kategori();
            yeni.KategoriAdi = textEdit1.Text;
            await _kategoris.Add(yeni);
            XtraMessageBox.Show("Yeni Kategori başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            yenile();
            Temizle();
        }

        private async void simpleButton2_Click(object sender, EventArgs e)
        {
            int secilenId;
            bool idParseBasarili = int.TryParse(label1.Text, out secilenId);

            if (!idParseBasarili || secilenId <= 0)
            {
                XtraMessageBox.Show("Lütfen güncellemek için listeden bir Tedarikci seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var mevcut = await _kategoris.GetById(secilenId);
                if (mevcut == null)
                {
                    XtraMessageBox.Show("Seçili Kategori bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                mevcut.KategoriAdi = textEdit1.Text;
                await _kategoris.Update(mevcut);

                XtraMessageBox.Show("Kategori başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                yenile();
                Temizle();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu:\n\n" + ex.Message,
                    "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void simpleButton3_Click(object sender, EventArgs e)
        {
            int secilen;
            bool idParseBasarili = int.TryParse(label1.Text, out secilen);

            if (!idParseBasarili || secilen <= 0)
            {
                XtraMessageBox.Show("Lütfen silmek için listeden bir Kategori seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult onay = XtraMessageBox.Show(
                $"Seçili Kategoriyi (ID: {secilen}) silmek istediğinizden emin misiniz?",
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

                await _kategoris.Delete(secilen);

                XtraMessageBox.Show("Kategori başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                yenile();
                Temizle();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Silme işlemi sırasında bir hata oluştu:\n\n" + ex.Message,
                    "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmKategoriler_Load(object sender, EventArgs e)
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
            var tedari = await _kategoris.GetAll();
            gridControl1.DataSource = tedari;
            gridViewMarkalar.Columns["KategoriID"].Visible = false;
            gridViewMarkalar.Columns["Ilaclar"].Visible = false;
        }
        private void Temizle()
        {
            textEdit1.Text = "";
            label1.Text = "-1";
        }
        private void gridViewMarkalar_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Kategori secilen = gridViewMarkalar.GetFocusedRow() as Kategori;

            if (secilen != null)
            {
                textEdit1.Text = secilen.KategoriAdi;

                label1.Text = secilen.KategoriID.ToString();
            }
            else
            {
                label1.Text = "-1";
            }
        }
    }
}