namespace UI
{
    partial class frmStokGiris
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
            Ilaclo = new DevExpress.XtraEditors.LookUpEdit();
            Tedarikcilo = new DevExpress.XtraEditors.LookUpEdit();
            Adet = new DevExpress.XtraEditors.SpinEdit();
            Alıs_Fiyati = new DevExpress.XtraEditors.SpinEdit();
            btnStokEdit = new DevExpress.XtraEditors.SimpleButton();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)Ilaclo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Tedarikcilo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Adet.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Alıs_Fiyati.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // Ilaclo
            // 
            Ilaclo.Location = new Point(12, 12);
            Ilaclo.Name = "Ilaclo";
            Ilaclo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Ilaclo.Size = new Size(100, 20);
            Ilaclo.TabIndex = 0;
            // 
            // Tedarikcilo
            // 
            Tedarikcilo.Location = new Point(12, 38);
            Tedarikcilo.Name = "Tedarikcilo";
            Tedarikcilo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Tedarikcilo.Size = new Size(100, 20);
            Tedarikcilo.TabIndex = 1;
            // 
            // Adet
            // 
            Adet.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            Adet.Location = new Point(12, 64);
            Adet.Name = "Adet";
            Adet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Adet.Size = new Size(100, 20);
            Adet.TabIndex = 2;
            // 
            // Alıs_Fiyati
            // 
            Alıs_Fiyati.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            Alıs_Fiyati.Location = new Point(12, 90);
            Alıs_Fiyati.Name = "Alıs_Fiyati";
            Alıs_Fiyati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Alıs_Fiyati.Size = new Size(100, 20);
            Alıs_Fiyati.TabIndex = 3;
            // 
            // btnStokEdit
            // 
            btnStokEdit.Location = new Point(37, 142);
            btnStokEdit.Name = "btnStokEdit";
            btnStokEdit.Size = new Size(75, 23);
            btnStokEdit.TabIndex = 5;
            btnStokEdit.Text = "Ekle";
            btnStokEdit.Click += btnStokEdit_Click;
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(12, 116);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(100, 20);
            dateEdit1.TabIndex = 6;
            // 
            // frmStokGiris
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(134, 183);
            Controls.Add(dateEdit1);
            Controls.Add(btnStokEdit);
            Controls.Add(Alıs_Fiyati);
            Controls.Add(Adet);
            Controls.Add(Tedarikcilo);
            Controls.Add(Ilaclo);
            Name = "frmStokGiris";
            Text = "frmStokGiris";
            Load += frmStokGiris_Load;
            ((System.ComponentModel.ISupportInitialize)Ilaclo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Tedarikcilo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Adet.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Alıs_Fiyati.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit Ilaclo;
        private DevExpress.XtraEditors.LookUpEdit Tedarikcilo;
        private DevExpress.XtraEditors.SpinEdit Adet;
        private DevExpress.XtraEditors.SpinEdit Alıs_Fiyati;
        private DevExpress.XtraEditors.SimpleButton btnStokEdit;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
    }
}