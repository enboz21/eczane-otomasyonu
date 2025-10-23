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
    public partial class frmStokGiris : DevExpress.XtraEditors.XtraForm
    {
        protected readonly IStokS _stoks;
        protected readonly IIlacS _ilacs;
        protected readonly ITedarikS _tedarikcis;
        public frmStokGiris(IStokS stok, IIlacS ılac, ITedarikS tedarik)
        {
            InitializeComponent();
            _stoks = stok;
            _ilacs = ılac;
            _tedarikcis = tedarik;
        }

        private async void frmStokGiris_Load(object sender, EventArgs e)
        {
            var ılac = await _ilacs.GetAll();
            Ilaclo.Properties.DataSource = ılac;
            Ilaclo.Properties.DisplayMember = "IlacAdi";
            Ilaclo.Properties.ValueMember = "IlacId";
            Ilaclo.Properties.PopulateColumns();
            Ilaclo.Properties.Columns["IlacId"].Visible = false;
            Ilaclo.Properties.Columns["Barkod"].Visible = false;
            Ilaclo.Properties.Columns["ReceteTuru"].Visible = false;
            Ilaclo.Properties.Columns["Birim"].Visible = false;
            Ilaclo.Properties.Columns["SatisFiyati"].Visible = false;
            Ilaclo.Properties.Columns["Aktif"].Visible = false;
            Ilaclo.Properties.Columns["KategoriID"].Visible = false;
            Ilaclo.Properties.Columns["MarkaId"].Visible = false;
            Ilaclo.Properties.Columns["Kategori"].Visible = false;
            Ilaclo.Properties.Columns["Marka"].Visible = false;
            Ilaclo.Properties.Columns["Stoklar"].Visible = false;
            Ilaclo.Properties.Columns["SatisDetaylar"].Visible = false;

            var te = await _tedarikcis.GetAll();
            Tedarikcilo.Properties.DataSource = te;
            Tedarikcilo.Properties.DisplayMember = "TedarikciAdi";
            Tedarikcilo.Properties.ValueMember = "TedarikciId";
            Tedarikcilo.Properties.PopulateColumns();
            Tedarikcilo.Properties.Columns["TedarikciId"].Visible = false;
            Tedarikcilo.Properties.Columns["Telefon"].Visible = false;
            Tedarikcilo.Properties.Columns["Adres"].Visible = false;
            Tedarikcilo.Properties.Columns["Eposta"].Visible = false;
            Tedarikcilo.Properties.Columns["Aktif"].Visible = false;
        }

        private async void btnStokEdit_Click(object sender, EventArgs e)
        {
            if ((int)Ilaclo.EditValue <= 0)
            {
                XtraMessageBox.Show("Lütfen bir İlaç seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateEdit1.DateTime <= DateTime.Now)
            {
                XtraMessageBox.Show("Lütfen geçerli bir son kullanma tarihi seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Alıs_Fiyati.Value <= 0)
            {
                XtraMessageBox.Show("Lütfen geçerli bir alış fiyatı girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((int)Tedarikcilo.EditValue <= 0)
            {
                XtraMessageBox.Show("Lütfen bir Tedarikçi seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((int)Adet.Value <= 0)
            {
                XtraMessageBox.Show("Lütfen geçerli bir adet girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Stok yeni = new Stok();
            yeni.IlacId = (int)Ilaclo.EditValue;
            yeni.TedarikciId = (int)Tedarikcilo.EditValue;
            yeni.SonKullanmaTarihi = dateEdit1.DateTime;
            yeni.AlisFiyati = Alıs_Fiyati.Value;
            yeni.MevcutAdet = (int)Adet.Value;
            await _stoks.Add(yeni);
            XtraMessageBox.Show("Yeni Stok başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}