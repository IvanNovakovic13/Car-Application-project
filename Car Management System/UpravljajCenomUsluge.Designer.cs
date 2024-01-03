namespace Car_Management_System
{
    partial class UpravljajCenomUsluge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpravljajCenomUsluge));
            button1 = new Button();
            lblCid = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            lblCena = new Label();
            btnClose = new Button();
            lblTrosak = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblDatum = new Label();
            dateTimePickerDatum = new DateTimePicker();
            txtBoxNazivTroska = new TextBox();
            txtBoxCena = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(947, -159);
            button1.Name = "button1";
            button1.Size = new Size(43, 42);
            button1.TabIndex = 42;
            button1.UseVisualStyleBackColor = true;
            // 
            // lblCid
            // 
            lblCid.AutoSize = true;
            lblCid.Location = new Point(18, 373);
            lblCid.Name = "lblCid";
            lblCid.Size = new Size(31, 20);
            lblCid.TabIndex = 41;
            lblCid.Text = "Cid";
            lblCid.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.Location = new Point(608, 361);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 53);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(445, 361);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 53);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 255);
            btnSave.Location = new Point(265, 361);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 53);
            btnSave.TabIndex = 38;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblCena
            // 
            lblCena.AutoSize = true;
            lblCena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCena.Location = new Point(18, 169);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(59, 28);
            lblCena.TabIndex = 37;
            lblCena.Text = "Cena:";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(653, 46);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 42);
            btnClose.TabIndex = 36;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTrosak
            // 
            lblTrosak.AutoSize = true;
            lblTrosak.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTrosak.Location = new Point(12, 104);
            lblTrosak.Name = "lblTrosak";
            lblTrosak.Size = new Size(124, 28);
            lblTrosak.TabIndex = 34;
            lblTrosak.Text = "Naziv troška:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(310, 31);
            label1.TabIndex = 32;
            label1.Text = "Upravljanje cenama usluga";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 38);
            panel1.TabIndex = 33;
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatum.Location = new Point(18, 229);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(75, 28);
            lblDatum.TabIndex = 44;
            lblDatum.Text = "Datum:";
            // 
            // dateTimePickerDatum
            // 
            dateTimePickerDatum.Location = new Point(259, 240);
            dateTimePickerDatum.Name = "dateTimePickerDatum";
            dateTimePickerDatum.Size = new Size(437, 27);
            dateTimePickerDatum.TabIndex = 45;
            // 
            // txtBoxNazivTroska
            // 
            txtBoxNazivTroska.Location = new Point(259, 108);
            txtBoxNazivTroska.Name = "txtBoxNazivTroska";
            txtBoxNazivTroska.Size = new Size(437, 27);
            txtBoxNazivTroska.TabIndex = 46;
            // 
            // txtBoxCena
            // 
            txtBoxCena.Location = new Point(259, 169);
            txtBoxCena.Name = "txtBoxCena";
            txtBoxCena.Size = new Size(437, 27);
            txtBoxCena.TabIndex = 47;
            txtBoxCena.KeyPress += txtBoxCena_KeyPress;
            // 
            // UpravljajCenomUsluge
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(708, 426);
            Controls.Add(txtBoxCena);
            Controls.Add(txtBoxNazivTroska);
            Controls.Add(dateTimePickerDatum);
            Controls.Add(lblDatum);
            Controls.Add(button1);
            Controls.Add(lblCid);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(lblCena);
            Controls.Add(btnClose);
            Controls.Add(lblTrosak);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpravljajCenomUsluge";
            Text = "UpravljajCenomUsluge";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        public Label lblCid;
        public Button btnCancel;
        public Button btnUpdate;
        public Button btnSave;
        private Button btnClose;
        private Label label1;
        private Panel panel1;
        public Label lblCena;
        public Label lblTrosak;
        public Label lblDatum;
        public DateTimePicker dateTimePickerDatum;
        public TextBox txtBoxNazivTroska;
        public TextBox txtBoxCena;
    }
}