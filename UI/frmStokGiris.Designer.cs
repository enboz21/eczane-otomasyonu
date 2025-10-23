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
            Ilac = new DevExpress.XtraEditors.LookUpEdit();
            Tedarikci = new DevExpress.XtraEditors.LookUpEdit();
            Adet = new DevExpress.XtraEditors.SpinEdit();
            Alıs_Fiyati = new DevExpress.XtraEditors.SpinEdit();
            SKT = new DevExpress.XtraEditors.SpinEdit();
            btnStokEdit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)Ilac.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Tedarikci.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Adet.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Alıs_Fiyati.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SKT.Properties).BeginInit();
            SuspendLayout();
            // 
            // Ilac
            // 
            Ilac.Location = new Point(12, 12);
            Ilac.Name = "Ilac";
            Ilac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Ilac.Size = new Size(100, 20);
            Ilac.TabIndex = 0;
            // 
            // Tedarikci
            // 
            Tedarikci.Location = new Point(12, 38);
            Tedarikci.Name = "Tedarikci";
            Tedarikci.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Tedarikci.Size = new Size(100, 20);
            Tedarikci.TabIndex = 1;
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
            // SKT
            // 
            SKT.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            SKT.Location = new Point(12, 116);
            SKT.Name = "SKT";
            SKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            SKT.Size = new Size(100, 20);
            SKT.TabIndex = 4;
            // 
            // btnStokEdit
            // 
            btnStokEdit.Location = new Point(37, 142);
            btnStokEdit.Name = "btnStokEdit";
            btnStokEdit.Size = new Size(75, 23);
            btnStokEdit.TabIndex = 5;
            btnStokEdit.Text = "Ekle";
            // 
            // frmStokGiris
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(134, 183);
            Controls.Add(btnStokEdit);
            Controls.Add(SKT);
            Controls.Add(Alıs_Fiyati);
            Controls.Add(Adet);
            Controls.Add(Tedarikci);
            Controls.Add(Ilac);
            Name = "frmStokGiris";
            Text = "frmStokGiris";
            ((System.ComponentModel.ISupportInitialize)Ilac.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Tedarikci.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Adet.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Alıs_Fiyati.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)SKT.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit Ilac;
        private DevExpress.XtraEditors.LookUpEdit Tedarikci;
        private DevExpress.XtraEditors.SpinEdit Adet;
        private DevExpress.XtraEditors.SpinEdit Alıs_Fiyati;
        private DevExpress.XtraEditors.SpinEdit SKT;
        private DevExpress.XtraEditors.SimpleButton btnStokEdit;
    }
}