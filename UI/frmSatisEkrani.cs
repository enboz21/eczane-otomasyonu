using Business.Interface;
using DevExpress.XtraEditors;
using Entities;
using Entities.DTOs;

namespace UI
{
    public partial class frmSatisEkrani : DevExpress.XtraEditors.XtraForm
    {
        protected readonly IIlacS _ılac;
        protected readonly IStokS _stok;
        protected readonly ISatisS _satis;
        public frmSatisEkrani(IStokS stok, ISatisS satis, IIlacS ılac)
        {
            InitializeComponent();
            _stok = stok;
            _satis = satis;
            _ılac = ılac;
        }
        List<SDDTO> _sepet = new List<SDDTO>();
        private Ilac _bulunanIlac = null;
        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            String aranan = textEdit1.Text;
            if (string.IsNullOrEmpty(aranan))
            {
                XtraMessageBox.Show("Lütfen barkod veya ilaç adı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _bulunanIlac = null;
            lookUpEdit1.Properties.DataSource = null;

            try
            {
                _bulunanIlac = await _ılac.GetByBarkodOrNameAsync(aranan);
                if (_bulunanIlac != null)
                {

                    List<Stok> loka = await _stok.GetAvailableBatchesOrderedByExpiryAsync(_bulunanIlac.IlacId);

                    if (loka.Any())
                    {
                        lookUpEdit1.Properties.DataSource = loka;
                        lookUpEdit1.Properties.DisplayMember = "SonKullanmaTarihi";
                        lookUpEdit1.Properties.ValueMember = "StokId";
                        lookUpEdit1.Properties.PopulateColumns();
                        lookUpEdit1.Properties.Columns["StokId"].Visible = false;
                        lookUpEdit1.Properties.Columns["IlacId"].Visible = false;
                        lookUpEdit1.Properties.Columns["TedarikciId"].Visible = false;
                        lookUpEdit1.Properties.Columns["AlisTarihi"].Visible = false;
                        lookUpEdit1.Properties.Columns["AlisFiyati"].Visible = false;
                        lookUpEdit1.Properties.Columns["MevcutAdet"].Visible = false;
                        lookUpEdit1.Properties.Columns["SatisDetaylar"].Visible = false;
                        lookUpEdit1.Properties.Columns["Ilac"].Visible = false;
                        lookUpEdit1.Properties.Columns["Tedarikci"].Visible = false;
                        textEdit1.Text = _bulunanIlac.IlacAdi;

                    }
                    else
                    {
                        XtraMessageBox.Show($"'{_bulunanIlac.IlacAdi}' isimli ilaç stokta bulunmamaktadır.", "Stok Yok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    XtraMessageBox.Show("Girilen barkod veya ada sahip ilaç bulunamadı.", "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ürün aranırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (_bulunanIlac == null)
                {
                    XtraMessageBox.Show("Lütfen önce satılacak ürünü bulun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                object secim = lookUpEdit1.EditValue;
                if (secim == null || !(secim is int))
                {
                    XtraMessageBox.Show("Lütfen satılacak parti (SKT) seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int adet = (int)spinEdit1.Value;
                if (adet <= 0)
                {
                    XtraMessageBox.Show("Lütfen 0'dan büyük bir adet girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var partiler = lookUpEdit1.Properties.DataSource as List<Stok>;
                if (partiler == null)
                {
                    XtraMessageBox.Show("Parti listesi bulunamadı. Ürünü tekrar arayın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Stok parti = partiler.FirstOrDefault(p => p.StokId == (int)secim);
                if (parti == null)
                {
                    XtraMessageBox.Show("Seçilen parti bilgisi alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (adet > parti.MevcutAdet)
                {
                    XtraMessageBox.Show($"Yetersiz stok! Seçilen partide sadece {parti.MevcutAdet} adet mevcut.", "Stok Yetersiz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SDDTO sepetItem = new SDDTO
                {
                    StokId = parti.StokId,
                    IlacId = _bulunanIlac.IlacId,
                    Adet = adet,
                    BirimFiyat = _bulunanIlac.SatisFiyati,
                    IlacAdi = _bulunanIlac.IlacAdi,
                    SonKullanımTariği = parti.SonKullanmaTarihi
                };
                _sepet.Add(sepetItem);
                gridControl1.DataSource = null;
                gridControl1.DataSource = _sepet;
                gridView1.Columns["SatisDetayId"].Visible = false;
                gridView1.Columns["SatisId"].Visible = false;
                gridView1.Columns["IlacId"].Visible = false;
                gridView1.Columns["StokId"].Visible = false;

                decimal top = _sepet.Sum(item => item.Adet * item.BirimFiyat);
                labelControl1.Text = $"{top:C2}";
                lookUpEdit1.Properties.DataSource = null;
                lookUpEdit1.EditValue = null;
                spinEdit1.Value = 0;
                textEdit1.Text = "";
                _bulunanIlac = null;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Sepete eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void simpleButton3_Click(object sender, EventArgs e)
        {
            _sepet.RemoveAt(Convert.ToInt32(label5.Text));
            decimal top = _sepet.Sum(item => item.Adet * item.BirimFiyat);
            labelControl1.Text = $"{top:C2}";
            gridControl1.DataSource = null;
            gridControl1.DataSource = _sepet;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            label5.Text = e.RowHandle.ToString();
        }

        private async void simpleButton4_Click(object sender, EventArgs e)
        {
            if (_sepet == null || !_sepet.Any())
            {
                XtraMessageBox.Show("Satışı tamamlamak için önce sepete ürün eklemelisiniz.", "Boş Sepet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult onay = XtraMessageBox.Show(
        $"Toplam {labelControl1.Text} tutarındaki satışı onaylıyor musunuz?",
        "Satış Onayı",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (onay == DialogResult.No)
            {
                return;
            }
            try
            {
                await _satis.PerformSale(new Satis(), _sepet);

                XtraMessageBox.Show("Satış başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                YeniSatisBaslat();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Satış işlemi sırasında bir hata oluştu:\n\n" + ex.Message,
                    "Satış Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void YeniSatisBaslat()
        {
            _sepet.Clear();
            gridControl1.DataSource = null;
            labelControl1.Text = "0.00 TL";
            _bulunanIlac = null;
            lookUpEdit1.Properties.DataSource = null;
            lookUpEdit1.EditValue = null;
            spinEdit1.Value = 0;
            textEdit1.Text = "";
        }
    }
}