namespace UI
{
    partial class frmIlaclar
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
            gcIlaclar = new DevExpress.XtraGrid.GridControl();
            gvILaclar = new DevExpress.XtraGrid.Views.Grid.GridView();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            Fiyat = new DevExpress.XtraEditors.SpinEdit();
            Markalo = new DevExpress.XtraEditors.LookUpEdit();
            Katagorilo = new DevExpress.XtraEditors.LookUpEdit();
            EkleBT = new DevExpress.XtraEditors.SimpleButton();
            GüncelleBT = new DevExpress.XtraEditors.SimpleButton();
            SilBT = new DevExpress.XtraEditors.SimpleButton();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gcIlaclar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvILaclar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Fiyat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Markalo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Katagorilo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            SuspendLayout();
            // 
            // gcIlaclar
            // 
            gcIlaclar.Location = new Point(12, 227);
            gcIlaclar.MainView = gvILaclar;
            gcIlaclar.Name = "gcIlaclar";
            gcIlaclar.Size = new Size(829, 245);
            gcIlaclar.TabIndex = 0;
            gcIlaclar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvILaclar });
            // 
            // gvILaclar
            // 
            gvILaclar.GridControl = gcIlaclar;
            gvILaclar.Name = "gvILaclar";
            gvILaclar.RowClick += gvILaclar_RowClick;
            // 
            // textEdit1
            // 
            textEdit1.EditValue = "İLac Adı";
            textEdit1.Location = new Point(62, 36);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(100, 20);
            textEdit1.TabIndex = 1;
            // 
            // Fiyat
            // 
            Fiyat.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            Fiyat.Location = new Point(288, 99);
            Fiyat.Name = "Fiyat";
            Fiyat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Fiyat.Size = new Size(100, 20);
            Fiyat.TabIndex = 2;
            // 
            // Markalo
            // 
            Markalo.Location = new Point(288, 64);
            Markalo.Name = "Markalo";
            Markalo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Markalo.Size = new Size(100, 20);
            Markalo.TabIndex = 3;
            // 
            // Katagorilo
            // 
            Katagorilo.Location = new Point(425, 64);
            Katagorilo.Name = "Katagorilo";
            Katagorilo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Katagorilo.Size = new Size(100, 20);
            Katagorilo.TabIndex = 4;
            // 
            // EkleBT
            // 
            EkleBT.Location = new Point(670, 39);
            EkleBT.Name = "EkleBT";
            EkleBT.Size = new Size(75, 23);
            EkleBT.TabIndex = 5;
            EkleBT.Text = "Ekle";
            EkleBT.Click += EkleBT_Click;
            // 
            // GüncelleBT
            // 
            GüncelleBT.Location = new Point(670, 68);
            GüncelleBT.Name = "GüncelleBT";
            GüncelleBT.Size = new Size(75, 23);
            GüncelleBT.TabIndex = 6;
            GüncelleBT.Text = "Güncelle";
            GüncelleBT.Click += GüncelleBT_Click;
            // 
            // SilBT
            // 
            SilBT.Location = new Point(670, 97);
            SilBT.Name = "SilBT";
            SilBT.Size = new Size(75, 23);
            SilBT.TabIndex = 7;
            SilBT.Text = "Sil";
            SilBT.Click += SilBT_Click;
            // 
            // textEdit2
            // 
            textEdit2.EditValue = "Barkod";
            textEdit2.Location = new Point(62, 65);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(100, 20);
            textEdit2.TabIndex = 8;
            // 
            // textEdit3
            // 
            textEdit3.EditValue = "Reçete Türü";
            textEdit3.Location = new Point(62, 91);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(100, 20);
            textEdit3.TabIndex = 9;
            // 
            // textEdit4
            // 
            textEdit4.EditValue = "Birim";
            textEdit4.Location = new Point(62, 117);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(100, 20);
            textEdit4.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, -1);
            label1.Name = "label1";
            label1.Size = new Size(0, 13);
            label1.TabIndex = 11;
            label1.Visible = false;
            // 
            // frmIlaclar
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 484);
            Controls.Add(label1);
            Controls.Add(textEdit4);
            Controls.Add(textEdit3);
            Controls.Add(textEdit2);
            Controls.Add(SilBT);
            Controls.Add(GüncelleBT);
            Controls.Add(EkleBT);
            Controls.Add(Katagorilo);
            Controls.Add(Markalo);
            Controls.Add(Fiyat);
            Controls.Add(textEdit1);
            Controls.Add(gcIlaclar);
            Name = "frmIlaclar";
            Text = "frmIlaclar";
            Load += frmIlaclar_Load;
            ((System.ComponentModel.ISupportInitialize)gcIlaclar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvILaclar).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Fiyat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Markalo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Katagorilo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcIlaclar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvILaclar;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SpinEdit Fiyat;
        private DevExpress.XtraEditors.LookUpEdit Markalo;
        private DevExpress.XtraEditors.LookUpEdit Katagorilo;
        private DevExpress.XtraEditors.SimpleButton EkleBT;
        private DevExpress.XtraEditors.SimpleButton GüncelleBT;
        private DevExpress.XtraEditors.SimpleButton SilBT;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private Label label1;
    }
}