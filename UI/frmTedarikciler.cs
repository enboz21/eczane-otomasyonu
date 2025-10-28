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
namespace UI
{
    public partial class frmTedarikciler : DevExpress.XtraEditors.XtraForm
    {
        protected readonly ITedarikS _tedarikcis;
        public frmTedarikciler(ITedarikS tedarik)
        {
            InitializeComponent();
            _tedarikcis = tedarik;
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text == null)
            {
                XtraMessageBox.Show("Lütfen bir Marka seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Tedarikci yeni = new Tedarikci();
            yeni.TedarikciAdi = textEdit1.Text;
            yeni.Adres = textEdit2.Text;
            yeni.Eposta = textEdit3.Text;
            yeni.Telefon = textEdit4.Text;

            yeni.Aktif = true;
            await _tedarikcis.Add(yeni);
            XtraMessageBox.Show("Yeni marka başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var mevcut = await _tedarikcis.GetById(secilenId);
                if (mevcut == null)
                {
                    XtraMessageBox.Show("Seçili ilaç bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                mevcut.TedarikciAdi = textEdit1.Text;
                mevcut.Adres = textEdit2.Text;
                mevcut.Eposta = textEdit3.Text;
                mevcut.Telefon = textEdit4.Text;
                await _tedarikcis.Update(mevcut);

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

        private async void simpleButton3_Click(object sender, EventArgs e)
        {
            int secilen;
            bool idParseBasarili = int.TryParse(label1.Text, out secilen);

            if (!idParseBasarili || secilen <= 0)
            {
                XtraMessageBox.Show("Lütfen silmek için listeden bir Tedarikci seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult onay = XtraMessageBox.Show(
                $"Seçili Tedarikciyi (ID: {secilen}) silmek istediğinizden emin misiniz?",
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

                await _tedarikcis.Delete(secilen);

                XtraMessageBox.Show("Tedarikci başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                yenile();
                Temizle();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Silme işlemi sırasında bir hata oluştu:\n\n" + ex.Message,
                    "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTedarikciler_Load(object sender, EventArgs e)
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
            var tedari = await _tedarikcis.GetAll();
            gridControl1.DataSource = tedari;
            gridViewMarkalar.PopulateColumns();
            gridViewMarkalar.Columns["TedarikciId"].Visible = false;
            gridViewMarkalar.Columns["Stoklar"].Visible = false;
        }
        private void Temizle()
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            label1.Text = "-1";
        }

        private void gridViewMarkalar_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Tedarikci secilen = gridViewMarkalar.GetFocusedRow() as Tedarikci;

            if (secilen != null)
            {
                textEdit1.Text = secilen.TedarikciAdi;
                textEdit2.Text = secilen.Adres;
                textEdit3.Text = secilen.Eposta;
                textEdit4.Text = secilen.Telefon;

                label1.Text = secilen.TedarikciId.ToString();
            }
            else
            {
                label1.Text = "-1";
            }
        }



    }
}