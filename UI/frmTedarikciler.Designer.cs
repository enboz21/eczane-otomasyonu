namespace UI
{
    partial class frmTedarikciler
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
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMarkalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(12, 109);
            gridControl1.MainView = gridViewMarkalar;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(774, 244);
            gridControl1.TabIndex = 5;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewMarkalar });
            // 
            // gridViewMarkalar
            // 
            gridViewMarkalar.GridControl = gridControl1;
            gridViewMarkalar.Name = "gridViewMarkalar";
            gridViewMarkalar.RowClick += gridViewMarkalar_RowClick;
            // 
            // simpleButton3
            // 
            simpleButton3.Location = new Point(707, 79);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new Size(75, 23);
            simpleButton3.TabIndex = 9;
            simpleButton3.Text = "Sil";
            simpleButton3.Click += simpleButton3_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.Location = new Point(626, 79);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(75, 23);
            simpleButton2.TabIndex = 8;
            simpleButton2.Text = "Güncelle";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(545, 79);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(75, 23);
            simpleButton1.TabIndex = 7;
            simpleButton1.Text = "Ekle";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(117, 4);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(100, 20);
            textEdit1.TabIndex = 10;
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(117, 30);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(100, 20);
            textEdit2.TabIndex = 11;
            // 
            // textEdit3
            // 
            textEdit3.Location = new Point(117, 56);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(100, 20);
            textEdit3.TabIndex = 12;
            // 
            // textEdit4
            // 
            textEdit4.Location = new Point(117, 82);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(100, 20);
            textEdit4.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(696, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 13);
            label1.TabIndex = 14;
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 7);
            label2.Name = "label2";
            label2.Size = new Size(66, 13);
            label2.TabIndex = 15;
            label2.Text = "Tedarikci adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 33);
            label3.Name = "label3";
            label3.Size = new Size(81, 13);
            label3.TabIndex = 16;
            label3.Text = "Tedarikci adresi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 59);
            label4.Name = "label4";
            label4.Size = new Size(72, 13);
            label4.TabIndex = 17;
            label4.Text = "Tedarikci maili";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 85);
            label5.Name = "label5";
            label5.Size = new Size(99, 13);
            label5.TabIndex = 18;
            label5.Text = "tedarikci telefon no";
            // 
            // frmTedarikciler
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 365);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textEdit4);
            Controls.Add(textEdit3);
            Controls.Add(textEdit2);
            Controls.Add(textEdit1);
            Controls.Add(gridControl1);
            Controls.Add(simpleButton3);
            Controls.Add(simpleButton2);
            Controls.Add(simpleButton1);
            Name = "frmTedarikciler";
            Text = "frmTedarikciler";
            Load += frmTedarikciler_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMarkalar).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMarkalar;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}