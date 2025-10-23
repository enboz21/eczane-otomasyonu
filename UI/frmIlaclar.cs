using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Business.Interface;
using DevExpress.XtraEditors;
using Entities;
using Entities.DTOs;
namespace UI
{
    public partial class frmIlaclar : DevExpress.XtraEditors.XtraForm
    {
        protected readonly IMarkaS _markas;
        protected readonly IKategoriS _kategoris;
        protected readonly IIlacS _ilacs;
        /*IMarkaS _markas = new MarkaS();
        IKategoriS _kategoris = new KategoriS();
        IIlacS _ilacs = new IlacS();*/

        public frmIlaclar(IKategoriS kategoris, IIlacS ilacs, IMarkaS markas)
        //public frmIlaclar(KategoriS kategoris, IlacS ilacs, MarkaS markas)
        {
            InitializeComponent();
            _kategoris = kategoris;
            _ilacs = ilacs;
            _markas = markas;
        }

        private async void frmIlaclar_Load(object sender, EventArgs e)
        {
            try
            {
                var markal = await _markas.GetAll();
                Markalo.Properties.DataSource = markal;
                Markalo.Properties.DisplayMember = "MarkaAdi";
                Markalo.Properties.ValueMember = "MarkaId";
                Markalo.Properties.PopulateColumns();
                Markalo.Properties.Columns["MarkaId"].Visible = false;
                Markalo.Properties.Columns["Aktif"].Visible = false;
                Markalo.Properties.Columns["Ilaclar"].Visible = false;
                //
                var Kat = await _kategoris.GetAll();
                Katagorilo.Properties.DataSource = Kat;
                Katagorilo.Properties.DisplayMember = "KategoriAdi";
                Katagorilo.Properties.ValueMember = "KategoriID";
                Katagorilo.Properties.PopulateColumns();
                Katagorilo.Properties.Columns["KategoriID"].Visible = false;
                Katagorilo.Properties.Columns["Ilaclar"].Visible = false;
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

        private async void EkleBT_Click(object sender, EventArgs e)
        {
            if (Markalo.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen bir Marka seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Katagorilo.EditValue == null)
            {
                XtraMessageBox.Show("Lütfen bir Kategori seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Ilac yeniIlac = new Ilac();
            yeniIlac.IlacAdi = textEdit1.Text;
            yeniIlac.Barkod = textEdit2.Text;
            yeniIlac.ReceteTuru = textEdit3.Text;
            yeniIlac.Birim = textEdit4.Text;
            yeniIlac.SatisFiyati = Fiyat.Value;
            yeniIlac.Aktif = true;
            yeniIlac.MarkaId = (int)Markalo.EditValue;
            yeniIlac.KategoriID = (int)Katagorilo.EditValue;
            await _ilacs.Add(yeniIlac);
            XtraMessageBox.Show("Yeni ilaç başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            yenile();
            Temizle();
        }

        private async void GüncelleBT_Click(object sender, EventArgs e)
        {
            int secilenId;
            bool idParseBasarili = int.TryParse(label1.Text, out secilenId);

            if (!idParseBasarili || secilenId <= 0)
            {
                XtraMessageBox.Show("Lütfen güncellemek için listeden bir ilaç seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Önce mevcut ilacı veritabanından al
                var mevcutIlac = await _ilacs.GetById(secilenId);
                if (mevcutIlac == null)
                {
                    XtraMessageBox.Show("Seçili ilaç bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mevcut ilacın değerlerini güncelle
                mevcutIlac.IlacAdi = textEdit1.Text;
                mevcutIlac.Barkod = textEdit2.Text;
                mevcutIlac.ReceteTuru = textEdit3.Text;
                mevcutIlac.Birim = textEdit4.Text;
                mevcutIlac.SatisFiyati = Fiyat.Value;
                mevcutIlac.Aktif = true;
                mevcutIlac.MarkaId = (int)Markalo.EditValue;
                mevcutIlac.KategoriID = (int)Katagorilo.EditValue;

                await _ilacs.Update(mevcutIlac);

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

        private async void yenile()
        {
            var ilacl = await _ilacs.GetIlacByDetay();
            gcIlaclar.DataSource = ilacl;
            var k = await _kategoris.GetById(1);
            gvILaclar.Columns["IlacId"].Visible = false;
            gvILaclar.Columns["KategoriID"].Visible = false;
            gvILaclar.Columns["MarkaId"].Visible = false;
        }
        private void Temizle()
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            Fiyat.Value = 0;
            Markalo.EditValue = null;
            Katagorilo.EditValue = null;
            label1.Text = "-1";
        }

        private async void SilBT_Click(object sender, EventArgs e)
        {
            int secilenId;
            bool idParseBasarili = int.TryParse(label1.Text, out secilenId);

            if (!idParseBasarili || secilenId <= 0)
            {
                XtraMessageBox.Show("Lütfen silmek için listeden bir ilaç seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult onay = XtraMessageBox.Show(
                $"Seçili ilacı (ID: {secilenId}) silmek istediğinizden emin misiniz?",
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

                await _ilacs.Delete(secilenId);

                XtraMessageBox.Show("İlaç başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                yenile();
                Temizle();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Silme işlemi sırasında bir hata oluştu:\n\n" + ex.Message,
                    "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvILaclar_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            IlacDetayDto secilenDto = gvILaclar.GetFocusedRow() as IlacDetayDto;

            if (secilenDto != null)
            {
                textEdit1.Text = secilenDto.IlacAdi;
                textEdit2.Text = secilenDto.Barkod;
                textEdit3.Text = secilenDto.ReceteTuru;
                textEdit4.Text = secilenDto.Birim;
                Fiyat.Value = secilenDto.SatisFiyati;
                Markalo.EditValue = secilenDto.MarkaId;
                Katagorilo.EditValue = secilenDto.KategoriID;
                label1.Text = secilenDto.IlacId.ToString();
            }
            else
            {
                label1.Text = "-1";
            }
        }
    }
}