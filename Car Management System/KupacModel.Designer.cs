namespace Car_Management_System
{
    partial class KupacModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KupacModel));
            btnClose = new Button();
            lblCid = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            txtBoxAdresa = new TextBox();
            txtBoxImeIPrezime = new TextBox();
            txtBoxTelefon = new TextBox();
            label8 = new Label();
            label7 = new Label();
            lblSifra = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            txtBoxAutoBr = new TextBox();
            txtBoxModelAuta = new TextBox();
            cmbBoxTipVozila = new ComboBox();
            Poeni = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)Poeni).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(911, 43);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 42);
            btnClose.TabIndex = 46;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblCid
            // 
            lblCid.AutoSize = true;
            lblCid.Location = new Point(48, 538);
            lblCid.Name = "lblCid";
            lblCid.Size = new Size(41, 28);
            lblCid.TabIndex = 45;
            lblCid.Text = "Cid";
            lblCid.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.Location = new Point(772, 522);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 53);
            btnCancel.TabIndex = 44;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(518, 522);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 53);
            btnUpdate.TabIndex = 43;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 255);
            btnSave.Location = new Point(267, 522);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 53);
            btnSave.TabIndex = 42;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtBoxAdresa
            // 
            txtBoxAdresa.Location = new Point(140, 370);
            txtBoxAdresa.Multiline = true;
            txtBoxAdresa.Name = "txtBoxAdresa";
            txtBoxAdresa.Size = new Size(802, 78);
            txtBoxAdresa.TabIndex = 41;
            txtBoxAdresa.Text = " ";
            // 
            // txtBoxImeIPrezime
            // 
            txtBoxImeIPrezime.Location = new Point(140, 98);
            txtBoxImeIPrezime.Name = "txtBoxImeIPrezime";
            txtBoxImeIPrezime.Size = new Size(805, 34);
            txtBoxImeIPrezime.TabIndex = 35;
            txtBoxImeIPrezime.Text = " ";
            // 
            // txtBoxTelefon
            // 
            txtBoxTelefon.Location = new Point(140, 152);
            txtBoxTelefon.Name = "txtBoxTelefon";
            txtBoxTelefon.Size = new Size(805, 34);
            txtBoxTelefon.TabIndex = 34;
            txtBoxTelefon.Text = " ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 144);
            label8.Name = "label8";
            label8.Size = new Size(78, 28);
            label8.TabIndex = 31;
            label8.Text = "Telefon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(5, 104);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 30;
            label7.Text = "Ime i prezime:";
            // 
            // lblSifra
            // 
            lblSifra.AutoSize = true;
            lblSifra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSifra.Location = new Point(12, 475);
            lblSifra.Name = "lblSifra";
            lblSifra.Size = new Size(64, 28);
            lblSifra.TabIndex = 29;
            lblSifra.Text = "Poeni:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 262);
            label5.Name = "label5";
            label5.Size = new Size(129, 28);
            label5.TabIndex = 28;
            label5.Text = "Model vozila:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 27;
            label4.Text = "Vozilo br:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(5, 54);
            label1.Name = "label1";
            label1.Size = new Size(228, 31);
            label1.TabIndex = 24;
            label1.Text = "Registracija kupaca";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 38);
            panel1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 318);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 47;
            label2.Text = "Tip vozila:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 371);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 48;
            label3.Text = "Adresa:";
            // 
            // txtBoxAutoBr
            // 
            txtBoxAutoBr.Location = new Point(140, 206);
            txtBoxAutoBr.Name = "txtBoxAutoBr";
            txtBoxAutoBr.Size = new Size(805, 34);
            txtBoxAutoBr.TabIndex = 49;
            txtBoxAutoBr.Text = " ";
            // 
            // txtBoxModelAuta
            // 
            txtBoxModelAuta.Location = new Point(140, 260);
            txtBoxModelAuta.Name = "txtBoxModelAuta";
            txtBoxModelAuta.Size = new Size(805, 34);
            txtBoxModelAuta.TabIndex = 50;
            txtBoxModelAuta.Text = " ";
            // 
            // cmbBoxTipVozila
            // 
            cmbBoxTipVozila.FormattingEnabled = true;
            cmbBoxTipVozila.Location = new Point(140, 314);
            cmbBoxTipVozila.Name = "cmbBoxTipVozila";
            cmbBoxTipVozila.Size = new Size(802, 36);
            cmbBoxTipVozila.TabIndex = 51;
            cmbBoxTipVozila.Text = " ";
            // 
            // Poeni
            // 
            Poeni.Enabled = false;
            Poeni.Location = new Point(140, 473);
            Poeni.Name = "Poeni";
            Poeni.Size = new Size(802, 34);
            Poeni.TabIndex = 53;
            // 
            // KupacModel
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(950, 628);
            Controls.Add(Poeni);
            Controls.Add(cmbBoxTipVozila);
            Controls.Add(txtBoxModelAuta);
            Controls.Add(txtBoxAutoBr);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(lblCid);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtBoxAdresa);
            Controls.Add(txtBoxImeIPrezime);
            Controls.Add(txtBoxTelefon);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblSifra);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KupacModel";
            Text = "KupacModel";
            Load += KupacModel_Load;
            ((System.ComponentModel.ISupportInitialize)Poeni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        public Label lblCid;
        public Button btnCancel;
        public Button btnUpdate;
        public Button btnSave;
        public TextBox txtBoxSifra;
        public RadioButton radioButton2;
        public RadioButton radioButton1;
        private Label label9;
        public TextBox txtBoxZarada;
        public ComboBox comboBoxUloga;
        public TextBox txtBoxImeIPrezime;
        public TextBox txtBoxTelefon;
        public TextBox txtBoxAdresa;
        public DateTimePicker dtRodjenja;
        private Label label8;
        private Label label7;
        private Label lblSifra;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        public TextBox txtBoxAutoBr;
        public TextBox txtBoxModelAuta;
        public ComboBox cmbBoxTipVozila;
        public NumericUpDown Poeni;
    }
}