namespace Car_Management_System
{
    partial class Podesavanja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Podesavanja));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvTipVozila = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Ime = new DataGridViewTextBoxColumn();
            Level = new DataGridViewTextBoxColumn();
            EditTipVozila = new DataGridViewImageColumn();
            DeleteTipVozila = new DataGridViewImageColumn();
            tabCenaUsluge = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            btnAddVozilo = new Button();
            txtBoxPretragaVozila = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            btnCenaUsluge = new Button();
            txtBoxCenaUsluge = new TextBox();
            label2 = new Label();
            dgvCenaUsluge = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            imeUsluge = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            cenaUsluge = new DataGridViewTextBoxColumn();
            EditCenaUsluge = new DataGridViewImageColumn();
            DeleteCenaUsluge = new DataGridViewImageColumn();
            tabPage3 = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            txtBoxAdresaKompanije = new TextBox();
            label4 = new Label();
            txtBoxNazivKompanije = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTipVozila).BeginInit();
            tabCenaUsluge.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCenaUsluge).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTipVozila
            // 
            dgvTipVozila.AllowUserToAddRows = false;
            dgvTipVozila.AllowUserToDeleteRows = false;
            dgvTipVozila.AllowUserToResizeColumns = false;
            dgvTipVozila.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dgvTipVozila.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTipVozila.BackgroundColor = Color.White;
            dgvTipVozila.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTipVozila.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTipVozila.ColumnHeadersHeight = 35;
            dgvTipVozila.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTipVozila.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Ime, Level, EditTipVozila, DeleteTipVozila });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTipVozila.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTipVozila.Dock = DockStyle.Top;
            dgvTipVozila.EnableHeadersVisualStyles = false;
            dgvTipVozila.GridColor = Color.FromArgb(255, 255, 128);
            dgvTipVozila.Location = new Point(3, 3);
            dgvTipVozila.Name = "dgvTipVozila";
            dgvTipVozila.RowHeadersWidth = 51;
            dgvTipVozila.RowTemplate.Height = 29;
            dgvTipVozila.Size = new Size(936, 362);
            dgvTipVozila.TabIndex = 7;
            dgvTipVozila.CellContentClick += dgvTipVozila_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 56;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Id";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 49;
            // 
            // Ime
            // 
            Ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ime.HeaderText = "Ime";
            Ime.MinimumWidth = 6;
            Ime.Name = "Ime";
            // 
            // Level
            // 
            Level.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Level.HeaderText = "Level";
            Level.MinimumWidth = 6;
            Level.Name = "Level";
            Level.Width = 70;
            // 
            // EditTipVozila
            // 
            EditTipVozila.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EditTipVozila.HeaderText = "";
            EditTipVozila.Image = (Image)resources.GetObject("EditTipVozila.Image");
            EditTipVozila.MinimumWidth = 6;
            EditTipVozila.Name = "EditTipVozila";
            EditTipVozila.Width = 6;
            // 
            // DeleteTipVozila
            // 
            DeleteTipVozila.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DeleteTipVozila.HeaderText = "";
            DeleteTipVozila.Image = (Image)resources.GetObject("DeleteTipVozila.Image");
            DeleteTipVozila.MinimumWidth = 6;
            DeleteTipVozila.Name = "DeleteTipVozila";
            DeleteTipVozila.Width = 6;
            // 
            // tabCenaUsluge
            // 
            tabCenaUsluge.Controls.Add(tabPage1);
            tabCenaUsluge.Controls.Add(tabPage2);
            tabCenaUsluge.Controls.Add(tabPage3);
            tabCenaUsluge.Dock = DockStyle.Fill;
            tabCenaUsluge.ImeMode = ImeMode.NoControl;
            tabCenaUsluge.Location = new Point(0, 0);
            tabCenaUsluge.Name = "tabCenaUsluge";
            tabCenaUsluge.SelectedIndex = 0;
            tabCenaUsluge.Size = new Size(950, 480);
            tabCenaUsluge.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(dgvTipVozila);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(942, 447);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tip vozila";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnAddVozilo);
            panel1.Controls.Add(txtBoxPretragaVozila);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 355);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 89);
            panel1.TabIndex = 8;
            // 
            // btnAddVozilo
            // 
            btnAddVozilo.BackColor = SystemColors.ActiveCaption;
            btnAddVozilo.FlatStyle = FlatStyle.Flat;
            btnAddVozilo.Image = (Image)resources.GetObject("btnAddVozilo.Image");
            btnAddVozilo.Location = new Point(871, 18);
            btnAddVozilo.Name = "btnAddVozilo";
            btnAddVozilo.Size = new Size(55, 55);
            btnAddVozilo.TabIndex = 3;
            btnAddVozilo.UseVisualStyleBackColor = false;
            btnAddVozilo.Click += btnAddVozilo_Click;
            // 
            // txtBoxPretragaVozila
            // 
            txtBoxPretragaVozila.Location = new Point(104, 32);
            txtBoxPretragaVozila.Name = "txtBoxPretragaVozila";
            txtBoxPretragaVozila.Size = new Size(267, 27);
            txtBoxPretragaVozila.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 31);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 0;
            label1.Text = "Pretrazi";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(dgvCenaUsluge);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(942, 447);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cena usluge";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnCenaUsluge);
            panel2.Controls.Add(txtBoxCenaUsluge);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 355);
            panel2.Name = "panel2";
            panel2.Size = new Size(936, 89);
            panel2.TabIndex = 9;
            // 
            // btnCenaUsluge
            // 
            btnCenaUsluge.FlatStyle = FlatStyle.Flat;
            btnCenaUsluge.Image = (Image)resources.GetObject("btnCenaUsluge.Image");
            btnCenaUsluge.Location = new Point(871, 18);
            btnCenaUsluge.Name = "btnCenaUsluge";
            btnCenaUsluge.Size = new Size(55, 55);
            btnCenaUsluge.TabIndex = 3;
            btnCenaUsluge.UseVisualStyleBackColor = true;
            btnCenaUsluge.Click += btnCenaUsluge_Click;
            // 
            // txtBoxCenaUsluge
            // 
            txtBoxCenaUsluge.Location = new Point(104, 32);
            txtBoxCenaUsluge.Name = "txtBoxCenaUsluge";
            txtBoxCenaUsluge.Size = new Size(267, 27);
            txtBoxCenaUsluge.TabIndex = 1;
            txtBoxCenaUsluge.TextChanged += txtBoxCenaUsluge_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 31);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 0;
            label2.Text = "Pretrazi";
            // 
            // dgvCenaUsluge
            // 
            dgvCenaUsluge.AllowUserToAddRows = false;
            dgvCenaUsluge.AllowUserToDeleteRows = false;
            dgvCenaUsluge.AllowUserToResizeColumns = false;
            dgvCenaUsluge.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.DarkGray;
            dgvCenaUsluge.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCenaUsluge.BackgroundColor = Color.White;
            dgvCenaUsluge.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvCenaUsluge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCenaUsluge.ColumnHeadersHeight = 35;
            dgvCenaUsluge.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCenaUsluge.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, imeUsluge, Datum, cenaUsluge, EditCenaUsluge, DeleteCenaUsluge });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.SteelBlue;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvCenaUsluge.DefaultCellStyle = dataGridViewCellStyle6;
            dgvCenaUsluge.Dock = DockStyle.Top;
            dgvCenaUsluge.EnableHeadersVisualStyles = false;
            dgvCenaUsluge.GridColor = Color.FromArgb(255, 255, 128);
            dgvCenaUsluge.Location = new Point(3, 3);
            dgvCenaUsluge.Name = "dgvCenaUsluge";
            dgvCenaUsluge.RowHeadersWidth = 51;
            dgvCenaUsluge.RowTemplate.Height = 29;
            dgvCenaUsluge.Size = new Size(936, 362);
            dgvCenaUsluge.TabIndex = 8;
            dgvCenaUsluge.CellContentClick += dgvCenaUsluge_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "No";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 56;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "Id";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 49;
            // 
            // imeUsluge
            // 
            imeUsluge.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            imeUsluge.HeaderText = "Ime";
            imeUsluge.MinimumWidth = 6;
            imeUsluge.Name = "imeUsluge";
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Datum.HeaderText = "Datum";
            Datum.MinimumWidth = 6;
            Datum.Name = "Datum";
            Datum.Width = 81;
            // 
            // cenaUsluge
            // 
            cenaUsluge.HeaderText = "Cena";
            cenaUsluge.MinimumWidth = 6;
            cenaUsluge.Name = "cenaUsluge";
            cenaUsluge.Width = 125;
            // 
            // EditCenaUsluge
            // 
            EditCenaUsluge.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EditCenaUsluge.HeaderText = "";
            EditCenaUsluge.Image = (Image)resources.GetObject("EditCenaUsluge.Image");
            EditCenaUsluge.MinimumWidth = 6;
            EditCenaUsluge.Name = "EditCenaUsluge";
            EditCenaUsluge.Width = 6;
            // 
            // DeleteCenaUsluge
            // 
            DeleteCenaUsluge.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DeleteCenaUsluge.HeaderText = "";
            DeleteCenaUsluge.Image = (Image)resources.GetObject("DeleteCenaUsluge.Image");
            DeleteCenaUsluge.MinimumWidth = 6;
            DeleteCenaUsluge.Name = "DeleteCenaUsluge";
            DeleteCenaUsluge.Width = 6;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnCancel);
            tabPage3.Controls.Add(btnSave);
            tabPage3.Controls.Add(txtBoxAdresaKompanije);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(txtBoxNazivKompanije);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(942, 447);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Naziv kompanije";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.Location = new Point(620, 290);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 53);
            btnCancel.TabIndex = 42;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 255);
            btnSave.Location = new Point(435, 290);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(161, 53);
            btnSave.TabIndex = 41;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtBoxAdresaKompanije
            // 
            txtBoxAdresaKompanije.Location = new Point(281, 195);
            txtBoxAdresaKompanije.Name = "txtBoxAdresaKompanije";
            txtBoxAdresaKompanije.Size = new Size(500, 27);
            txtBoxAdresaKompanije.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 198);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 2;
            label4.Text = "Adresa Kompanije:";
            // 
            // txtBoxNazivKompanije
            // 
            txtBoxNazivKompanije.Location = new Point(281, 142);
            txtBoxNazivKompanije.Name = "txtBoxNazivKompanije";
            txtBoxNazivKompanije.Size = new Size(500, 27);
            txtBoxNazivKompanije.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 145);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 0;
            label3.Text = "Naziv Kompanije:";
            // 
            // Podesavanja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 480);
            Controls.Add(tabCenaUsluge);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Podesavanja";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)dgvTipVozila).EndInit();
            tabCenaUsluge.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCenaUsluge).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvTipVozila;
        private TabControl tabCenaUsluge;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dgvCenaUsluge;
        private Panel panel1;
        private Button btnAddVozilo;
        private TextBox txtBoxPretragaVozila;
        private Label label1;
        private Panel panel2;
        private Button btnCenaUsluge;
        private TextBox txtBoxCenaUsluge;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Level;
        private DataGridViewImageColumn EditTipVozila;
        private DataGridViewImageColumn DeleteTipVozila;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn imeUsluge;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn cenaUsluge;
        private DataGridViewImageColumn EditCenaUsluge;
        private DataGridViewImageColumn DeleteCenaUsluge;
        private Label label3;
        private Label label4;
        public Button btnCancel;
        public Button btnSave;
        public TextBox txtBoxNazivKompanije;
        public TextBox txtBoxAdresaKompanije;
    }
}
