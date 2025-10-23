namespace UI
{
    partial class frmMarkalar
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
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridViewMarkalar = new DevExpress.XtraGrid.Views.Grid.GridView();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMarkalar).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(12, 122);
            gridControl1.MainView = gridViewMarkalar;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1039, 367);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewMarkalar });
            // 
            // gridViewMarkalar
            // 
            gridViewMarkalar.GridControl = gridControl1;
            gridViewMarkalar.Name = "gridViewMarkalar";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(12, 94);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(47, 13);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Marka Adı";
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(285, 38);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(75, 23);
            simpleButton1.TabIndex = 2;
            simpleButton1.Text = "Ekle";
            // 
            // simpleButton2
            // 
            simpleButton2.Location = new Point(366, 38);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(75, 23);
            simpleButton2.TabIndex = 3;
            simpleButton2.Text = "Güncelle";
            // 
            // simpleButton3
            // 
            simpleButton3.Location = new Point(447, 38);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new Size(75, 23);
            simpleButton3.TabIndex = 4;
            simpleButton3.Text = "Sil";
            // 
            // frmMarkalar
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 501);
            Controls.Add(simpleButton3);
            Controls.Add(simpleButton2);
            Controls.Add(simpleButton1);
            Controls.Add(labelControl1);
            Controls.Add(gridControl1);
            Name = "frmMarkalar";
            Text = "frmMarkalar";
            Load += frmMarkalar_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMarkalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMarkalar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}