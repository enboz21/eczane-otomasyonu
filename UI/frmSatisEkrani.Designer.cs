namespace UI
{
    partial class frmSatisEkrani
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
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(6, 33);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(100, 20);
            textEdit1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(112, 31);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(75, 23);
            simpleButton1.TabIndex = 1;
            simpleButton1.Text = "bul";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new Point(74, 76);
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Size = new Size(100, 20);
            lookUpEdit1.TabIndex = 2;
            // 
            // spinEdit1
            // 
            spinEdit1.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEdit1.Location = new Point(74, 102);
            spinEdit1.Name = "spinEdit1";
            spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEdit1.Size = new Size(100, 20);
            spinEdit1.TabIndex = 3;
            // 
            // simpleButton2
            // 
            simpleButton2.Location = new Point(180, 74);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(75, 23);
            simpleButton2.TabIndex = 4;
            simpleButton2.Text = "Sepete ekle";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(12, 139);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(619, 245);
            gridControl1.TabIndex = 5;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.RowClick += gridView1_RowClick;
            // 
            // simpleButton3
            // 
            simpleButton3.Location = new Point(180, 101);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new Size(75, 23);
            simpleButton3.TabIndex = 6;
            simpleButton3.Text = "Sepetten çıkar";
            simpleButton3.Click += simpleButton3_Click;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(76, 59);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(0, 13);
            labelControl1.TabIndex = 7;
            // 
            // simpleButton4
            // 
            simpleButton4.Location = new Point(556, 102);
            simpleButton4.Name = "simpleButton4";
            simpleButton4.Size = new Size(75, 23);
            simpleButton4.TabIndex = 8;
            simpleButton4.Text = "Tamamla";
            simpleButton4.Click += simpleButton4_Click;
            // 
            // simpleButton5
            // 
            simpleButton5.Location = new Point(556, 73);
            simpleButton5.Name = "simpleButton5";
            simpleButton5.Size = new Size(75, 23);
            simpleButton5.TabIndex = 9;
            simpleButton5.Text = "Yeni satış";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 17);
            label1.Name = "label1";
            label1.Size = new Size(58, 13);
            label1.TabIndex = 10;
            label1.Text = "Ürün bilgisi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 79);
            label2.Name = "label2";
            label2.Size = new Size(62, 13);
            label2.TabIndex = 11;
            label2.Text = "Sonkullanım";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 104);
            label3.Name = "label3";
            label3.Size = new Size(56, 13);
            label3.TabIndex = 12;
            label3.Text = "Satıi adedi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 59);
            label4.Name = "label4";
            label4.Size = new Size(68, 13);
            label4.TabIndex = 13;
            label4.Text = "Toplam tutar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(631, 17);
            label5.Name = "label5";
            label5.Size = new Size(0, 13);
            label5.TabIndex = 14;
            label5.Visible = false;
            // 
            // frmSatisEkrani
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 394);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(simpleButton5);
            Controls.Add(simpleButton4);
            Controls.Add(labelControl1);
            Controls.Add(simpleButton3);
            Controls.Add(gridControl1);
            Controls.Add(simpleButton2);
            Controls.Add(spinEdit1);
            Controls.Add(lookUpEdit1);
            Controls.Add(simpleButton1);
            Controls.Add(textEdit1);
            Name = "frmSatisEkrani";
            Text = "frmSatisEkrani";
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}