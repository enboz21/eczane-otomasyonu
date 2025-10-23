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
using Microsoft.Extensions.DependencyInjection;

namespace UI
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Formac<TForm>() where TForm : DevExpress.XtraEditors.XtraForm
        {
            foreach (var form in this.MdiChildren)
            {
                if (form is TForm)
                {
                    form.BringToFront();
                    return;
                }
            }
            var formToOpen = Program.ServiceProvider.GetRequiredService<TForm>();
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }
        private void btnMarkaYonetimi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formac<frmMarkalar>();
        }
        private void btnIlacYonetimi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formac<frmIlaclar>();
        }
        private void btnKategoriYonetimi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formac<frmKategoriler>();
        }
        private void btnTedarikciYonetimi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formac<frmTedarikciler>();
        }
        private void btnStokGiris_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formac<frmStokGiris>();
        }
        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}