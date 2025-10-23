namespace UI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnMarkaYonetimi = new DevExpress.XtraBars.BarButtonItem();
            btnIlacYonetimi = new DevExpress.XtraBars.BarButtonItem();
            btnKategoriYonetimi = new DevExpress.XtraBars.BarButtonItem();
            btnTedarikciYonetimi = new DevExpress.XtraBars.BarButtonItem();
            btnStokGiris = new DevExpress.XtraBars.BarButtonItem();
            btnSatisEkrani = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, btnMarkaYonetimi, btnIlacYonetimi, btnKategoriYonetimi, btnTedarikciYonetimi, btnStokGiris, btnSatisEkrani });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 7;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(864, 158);
            ribbon.StatusBar = ribbonStatusBar;
            ribbon.Click += ribbon_Click;
            // 
            // btnMarkaYonetimi
            // 
            btnMarkaYonetimi.Caption = "Marka Yönetimi";
            btnMarkaYonetimi.Id = 1;
            btnMarkaYonetimi.Name = "btnMarkaYonetimi";
            btnMarkaYonetimi.ItemClick += btnMarkaYonetimi_ItemClick;
            // 
            // btnIlacYonetimi
            // 
            btnIlacYonetimi.Caption = "İlaç Yönetimi";
            btnIlacYonetimi.Id = 2;
            btnIlacYonetimi.Name = "btnIlacYonetimi";
            btnIlacYonetimi.ItemClick += btnIlacYonetimi_ItemClick;
            // 
            // btnKategoriYonetimi
            // 
            btnKategoriYonetimi.Caption = "Kategori Yönetimi";
            btnKategoriYonetimi.Id = 3;
            btnKategoriYonetimi.Name = "btnKategoriYonetimi";
            btnKategoriYonetimi.ItemClick += btnKategoriYonetimi_ItemClick;
            // 
            // btnTedarikciYonetimi
            // 
            btnTedarikciYonetimi.Caption = "Tedarikçi Yönetimi";
            btnTedarikciYonetimi.Id = 4;
            btnTedarikciYonetimi.Name = "btnTedarikciYonetimi";
            btnTedarikciYonetimi.ItemClick += btnTedarikciYonetimi_ItemClick;
            // 
            // btnStokGiris
            // 
            btnStokGiris.Caption = "Stok Giriş Ekranı";
            btnStokGiris.Id = 5;
            btnStokGiris.Name = "btnStokGiris";
            btnStokGiris.ItemClick += btnStokGiris_ItemClick;
            // 
            // btnSatisEkrani
            // 
            btnSatisEkrani.Caption = "Yeni Satış Ekranı";
            btnSatisEkrani.Id = 6;
            btnSatisEkrani.Name = "btnSatisEkrani";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2, ribbonPageGroup3 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "ANA İŞLEMLER";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnMarkaYonetimi);
            ribbonPageGroup1.ItemLinks.Add(btnIlacYonetimi);
            ribbonPageGroup1.ItemLinks.Add(btnKategoriYonetimi);
            ribbonPageGroup1.ItemLinks.Add(btnTedarikciYonetimi);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Tanımlamalar";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(btnStokGiris);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "Stok İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(btnSatisEkrani);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "Satış İşlemleri";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 437);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(864, 24);
            // 
            // ribbonPage4
            // 
            ribbonPage4.Name = "ribbonPage4";
            ribbonPage4.Text = "ribbonPage4";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 461);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            IsMdiContainer = true;
            Name = "Main";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarButtonItem btnMarkaYonetimi;
        private DevExpress.XtraBars.BarButtonItem btnIlacYonetimi;
        private DevExpress.XtraBars.BarButtonItem btnKategoriYonetimi;
        private DevExpress.XtraBars.BarButtonItem btnTedarikciYonetimi;
        private DevExpress.XtraBars.BarButtonItem btnStokGiris;
        private DevExpress.XtraBars.BarButtonItem btnSatisEkrani;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}