namespace Car_Management_System
{
    partial class dgvZaposleniModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dgvZaposleniModel));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblSifra = new Label();
            label7 = new Label();
            label8 = new Label();
            dtRodjenja = new DateTimePicker();
            txtBoxAdresa = new TextBox();
            txtBoxTelefon = new TextBox();
            txtBoxImeIPrezime = new TextBox();
            comboBoxUloga = new ComboBox();
            txtBoxZarada = new TextBox();
            label9 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            txtBoxSifra = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            lblEid = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 38);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(8, 54);
            label1.Name = "label1";
            label1.Size = new Size(264, 31);
            label1.TabIndex = 0;
            label1.Text = "Registracija zaposlenih";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 1;
            label2.Text = "Datum rodjenja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 185);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 2;
            label3.Text = "Adresa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 287);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 3;
            label4.Text = "Uloga:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 335);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 4;
            label5.Text = "Zarada:";
            // 
            // lblSifra
            // 
            lblSifra.AutoSize = true;
            lblSifra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSifra.Location = new Point(12, 393);
            lblSifra.Name = "lblSifra";
            lblSifra.Size = new Size(55, 28);
            lblSifra.TabIndex = 5;
            lblSifra.Text = "Sifra:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 98);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 6;
            label7.Text = "Ime i prezime:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(366, 143);
            label8.Name = "label8";
            label8.Size = new Size(78, 28);
            label8.TabIndex = 7;
            label8.Text = "Telefon:";
            // 
            // dtRodjenja
            // 
            dtRodjenja.CustomFormat = "dd/MM/yyyy";
            dtRodjenja.Format = DateTimePickerFormat.Custom;
            dtRodjenja.Location = new Point(184, 144);
            dtRodjenja.Name = "dtRodjenja";
            dtRodjenja.Size = new Size(111, 27);
            dtRodjenja.TabIndex = 8;
            // 
            // txtBoxAdresa
            // 
            txtBoxAdresa.Location = new Point(94, 189);
            txtBoxAdresa.Multiline = true;
            txtBoxAdresa.Name = "txtBoxAdresa";
            txtBoxAdresa.Size = new Size(854, 80);
            txtBoxAdresa.TabIndex = 9;
            // 
            // txtBoxTelefon
            // 
            txtBoxTelefon.Location = new Point(450, 144);
            txtBoxTelefon.Name = "txtBoxTelefon";
            txtBoxTelefon.Size = new Size(498, 27);
            txtBoxTelefon.TabIndex = 10;
            // 
            // txtBoxImeIPrezime
            // 
            txtBoxImeIPrezime.Location = new Point(184, 98);
            txtBoxImeIPrezime.Name = "txtBoxImeIPrezime";
            txtBoxImeIPrezime.Size = new Size(764, 27);
            txtBoxImeIPrezime.TabIndex = 11;
            // 
            // comboBoxUloga
            // 
            comboBoxUloga.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUloga.FlatStyle = FlatStyle.Popup;
            comboBoxUloga.FormattingEnabled = true;
            comboBoxUloga.Items.AddRange(new object[] { "Menadžer", "Kasir", "Radnik", "Direktor" });
            comboBoxUloga.Location = new Point(94, 287);
            comboBoxUloga.Name = "comboBoxUloga";
            comboBoxUloga.Size = new Size(854, 28);
            comboBoxUloga.TabIndex = 12;
            comboBoxUloga.SelectedIndexChanged += comboBoxUloga_SelectedIndexChanged;
            // 
            // txtBoxZarada
            // 
            txtBoxZarada.Location = new Point(94, 339);
            txtBoxZarada.Name = "txtBoxZarada";
            txtBoxZarada.Size = new Size(482, 27);
            txtBoxZarada.TabIndex = 13;
            txtBoxZarada.KeyPress += txtBoxZarada_KeyPress_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(631, 341);
            label9.Name = "label9";
            label9.Size = new Size(43, 28);
            label9.TabIndex = 14;
            label9.Text = "Pol:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(723, 337);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 32);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Muski";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(860, 339);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(88, 32);
            radioButton2.TabIndex = 16;
            radioButton2.Text = "Zenski";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtBoxSifra
            // 
            txtBoxSifra.Location = new Point(94, 397);
            txtBoxSifra.Name = "txtBoxSifra";
            txtBoxSifra.Size = new Size(854, 27);
            txtBoxSifra.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 255);
            btnSave.Location = new Point(231, 448);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 53);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(482, 448);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 53);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.Location = new Point(736, 448);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 53);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblEid
            // 
            lblEid.AutoSize = true;
            lblEid.Location = new Point(12, 464);
            lblEid.Name = "lblEid";
            lblEid.Size = new Size(30, 20);
            lblEid.TabIndex = 21;
            lblEid.Text = "Eid";
            lblEid.Visible = false;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(914, 43);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 42);
            btnClose.TabIndex = 22;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvZaposleniModel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 504);
            Controls.Add(btnClose);
            Controls.Add(lblEid);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtBoxSifra);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label9);
            Controls.Add(txtBoxZarada);
            Controls.Add(comboBoxUloga);
            Controls.Add(txtBoxImeIPrezime);
            Controls.Add(txtBoxTelefon);
            Controls.Add(txtBoxAdresa);
            Controls.Add(dtRodjenja);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblSifra);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dgvZaposleniModel";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblSifra;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnClose;
        public Label lblEid;
        public DateTimePicker dtRodjenja;
        public TextBox txtBoxAdresa;
        public TextBox txtBoxTelefon;
        public TextBox txtBoxImeIPrezime;
        public ComboBox comboBoxUloga;
        public TextBox txtBoxZarada;
        public RadioButton radioButton1;
        public RadioButton radioButton2;
        public TextBox txtBoxSifra;
        public Button btnSave;
        public Button btnUpdate;
        public Button btnCancel;
    }
}