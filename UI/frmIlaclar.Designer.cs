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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
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
            gcIlaclar.Location = new Point(10, 114);
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
            textEdit1.EditValue = "";
            textEdit1.Location = new Point(76, 7);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(100, 20);
            textEdit1.TabIndex = 1;
            // 
            // Fiyat
            // 
            Fiyat.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            Fiyat.Location = new Point(245, 87);
            Fiyat.Name = "Fiyat";
            Fiyat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Fiyat.Size = new Size(100, 20);
            Fiyat.TabIndex = 2;
            // 
            // Markalo
            // 
            Markalo.Location = new Point(245, 62);
            Markalo.Name = "Markalo";
            Markalo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Markalo.Size = new Size(100, 20);
            Markalo.TabIndex = 3;
            // 
            // Katagorilo
            // 
            Katagorilo.Location = new Point(245, 37);
            Katagorilo.Name = "Katagorilo";
            Katagorilo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Katagorilo.Size = new Size(100, 20);
            Katagorilo.TabIndex = 4;
            // 
            // EkleBT
            // 
            EkleBT.Location = new Point(599, 85);
            EkleBT.Name = "EkleBT";
            EkleBT.Size = new Size(75, 23);
            EkleBT.TabIndex = 5;
            EkleBT.Text = "Ekle";
            EkleBT.Click += EkleBT_Click;
            // 
            // GüncelleBT
            // 
            GüncelleBT.Location = new Point(680, 85);
            GüncelleBT.Name = "GüncelleBT";
            GüncelleBT.Size = new Size(75, 23);
            GüncelleBT.TabIndex = 6;
            GüncelleBT.Text = "Güncelle";
            GüncelleBT.Click += GüncelleBT_Click;
            // 
            // SilBT
            // 
            SilBT.Location = new Point(761, 86);
            SilBT.Name = "SilBT";
            SilBT.Size = new Size(75, 23);
            SilBT.TabIndex = 7;
            SilBT.Text = "Sil";
            SilBT.Click += SilBT_Click;
            // 
            // textEdit2
            // 
            textEdit2.EditValue = "";
            textEdit2.Location = new Point(76, 36);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(100, 20);
            textEdit2.TabIndex = 8;
            // 
            // textEdit3
            // 
            textEdit3.EditValue = "";
            textEdit3.Location = new Point(76, 62);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(100, 20);
            textEdit3.TabIndex = 9;
            // 
            // textEdit4
            // 
            textEdit4.EditValue = "";
            textEdit4.Location = new Point(76, 88);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(41, 13);
            label2.TabIndex = 12;
            label2.Text = "İlaç adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 40);
            label3.Name = "label3";
            label3.Size = new Size(55, 13);
            label3.TabIndex = 13;
            label3.Text = "Barkod no";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 65);
            label4.Name = "label4";
            label4.Size = new Size(64, 13);
            label4.TabIndex = 15;
            label4.Text = "Reçete türü";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 91);
            label5.Name = "label5";
            label5.Size = new Size(52, 13);
            label5.TabIndex = 14;
            label5.Text = "Birim türü";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 65);
            label6.Name = "label6";
            label6.Size = new Size(36, 13);
            label6.TabIndex = 16;
            label6.Text = "Marka";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(182, 90);
            label7.Name = "label7";
            label7.Size = new Size(57, 13);
            label7.TabIndex = 17;
            label7.Text = "Satış fiyatı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(182, 39);
            label8.Name = "label8";
            label8.Size = new Size(47, 13);
            label8.TabIndex = 18;
            label8.Text = "İlaç türü";
            // 
            // frmIlaclar
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 365);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}