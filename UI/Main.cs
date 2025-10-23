using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace UI
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Formac(DevExpress.XtraEditors.XtraForm formToOpen)
        {
            foreach (var form in this.MdiChildren)
            {
                if (form.GetType() == formToOpen.GetType())
                {
                    form.BringToFront();
                    return;
                }
            }
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }

        private void btnMarkaYonetimi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formac(new frmMarkalar());
        }
        private void btnIlacYonetimi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formac(new frmIlaclar());
        }

        private void btnKategoriYonetimi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formac(new frmKategoriler());
        }

        private void btnTedarikciYonetimi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formac(new frmTedarikciler());
        }

        private void btnStokGiris_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formac(new frmStokGiris());
        }
    }
}