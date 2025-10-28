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
using DataAccess.Interface;
using DevExpress.XtraEditors;

namespace UI
{
    public partial class frmStokRaporu : DevExpress.XtraEditors.XtraForm
    {
        protected readonly IStokS _stoks;
        public frmStokRaporu(IStokS stokS)
        {
            InitializeComponent();
            _stoks = stokS;
        }

        private async void frmStokRaporu_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = await _stoks.StokDetay();
            /*gridView1.Columns["StokId"].Visible = false;
            gridView1.Columns["SatisDetaylar"].Visible = false;
            gridView1.Columns["IlacId"].Visible = false;
            gridView1.Columns["TedarikciId"].Visible = false;*/
        }
    }
}