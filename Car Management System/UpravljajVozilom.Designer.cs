namespace Car_Management_System
{
    partial class UpravljajVozilom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpravljajVozilom));
            txtBoxNaziv = new TextBox();
            label7 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnClose = new Button();
            button1 = new Button();
            lblVid = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            label6 = new Label();
            comboBoxVrsta = new ComboBox();
            SuspendLayout();
            // 
            // txtBoxNaziv
            // 
            txtBoxNaziv.Location = new Point(259, 102);
            txtBoxNaziv.Name = "txtBoxNaziv";
            txtBoxNaziv.Size = new Size(437, 34);
            txtBoxNaziv.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 102);
            label7.Name = "label7";
            label7.Size = new Size(102, 28);
            label7.TabIndex = 14;
            label7.Text = "Karoserija:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(270, 31);
            label1.TabIndex = 12;
            label1.Text = "Registracija vrste vozila";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 38);
            panel1.TabIndex = 13;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(653, 44);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 42);
            btnClose.TabIndex = 23;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(947, -161);
            button1.Name = "button1";
            button1.Size = new Size(43, 42);
            button1.TabIndex = 30;
            button1.UseVisualStyleBackColor = true;
            // 
            // lblVid
            // 
            lblVid.AutoSize = true;
            lblVid.Location = new Point(16, 227);
            lblVid.Name = "lblVid";
            lblVid.Size = new Size(41, 28);
            lblVid.TabIndex = 29;
            lblVid.Text = "Vid";
            lblVid.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.Location = new Point(606, 215);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 53);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(443, 215);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 53);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 255);
            btnSave.Location = new Point(263, 215);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 53);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 153);
            label6.Name = "label6";
            label6.Size = new Size(61, 28);
            label6.TabIndex = 24;
            label6.Text = "Klasa:";
            // 
            // comboBoxVrsta
            // 
            comboBoxVrsta.FormattingEnabled = true;
            comboBoxVrsta.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBoxVrsta.Location = new Point(259, 150);
            comboBoxVrsta.Name = "comboBoxVrsta";
            comboBoxVrsta.Size = new Size(437, 36);
            comboBoxVrsta.TabIndex = 31;
            // 
            // MenageVehicleType
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(708, 280);
            Controls.Add(comboBoxVrsta);
            Controls.Add(button1);
            Controls.Add(lblVid);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(btnClose);
            Controls.Add(txtBoxNaziv);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenageVehicleType";
            Text = "MenageVehicle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtBoxNaziv;
        private Label label7;
        private Label label1;
        private Panel panel1;
        private Button btnClose;
        private Button button1;
        public Label lblVid;
        public Button btnCancel;
        public Button btnUpdate;
        public Button btnSave;
        private Label label6;
        public ComboBox comboBoxVrsta;
    }
}