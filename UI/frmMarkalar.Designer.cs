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
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMarkalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(12, 48);
            gridControl1.MainView = gridViewMarkalar;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(343, 188);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewMarkalar });
            // 
            // gridViewMarkalar
            // 
            gridViewMarkalar.GridControl = gridControl1;
            gridViewMarkalar.Name = "gridViewMarkalar";
            gridViewMarkalar.RowClick += gridViewMarkalar_RowClick;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(12, 3);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(46, 13);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Marka adı";
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(118, 19);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(75, 23);
            simpleButton1.TabIndex = 2;
            simpleButton1.Text = "Ekle";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.Location = new Point(199, 19);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(75, 23);
            simpleButton2.TabIndex = 3;
            simpleButton2.Text = "Güncelle";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // simpleButton3
            // 
            simpleButton3.Location = new Point(280, 19);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new Size(75, 23);
            simpleButton3.TabIndex = 4;
            simpleButton3.Text = "Sil";
            simpleButton3.Click += simpleButton3_Click;
            // 
            // textEdit1
            // 
            textEdit1.EditValue = "";
            textEdit1.Location = new Point(12, 22);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(100, 20);
            textEdit1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(641, -3);
            label1.Name = "label1";
            label1.Size = new Size(0, 13);
            label1.TabIndex = 6;
            label1.Visible = false;
            // 
            // frmMarkalar
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 244);
            Controls.Add(label1);
            Controls.Add(textEdit1);
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
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
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
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private Label label1;
    }
}