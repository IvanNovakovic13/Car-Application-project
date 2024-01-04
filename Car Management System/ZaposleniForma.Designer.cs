namespace Car_Management_System
{
    partial class ZaposleniForma
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaposleniForma));
            dgvZaposleni = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1 = new Panel();
            btnAdd = new Button();
            txtBoxPretraga = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvZaposleni
            // 
            dgvZaposleni.AllowUserToAddRows = false;
            dgvZaposleni.AllowUserToDeleteRows = false;
            dgvZaposleni.AllowUserToResizeColumns = false;
            dgvZaposleni.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dgvZaposleni.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvZaposleni.BackgroundColor = Color.White;
            dgvZaposleni.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvZaposleni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvZaposleni.ColumnHeadersHeight = 35;
            dgvZaposleni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvZaposleni.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column10, Column6, Column7, Column8, Column9, Edit, Delete });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SteelBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvZaposleni.DefaultCellStyle = dataGridViewCellStyle4;
            dgvZaposleni.Dock = DockStyle.Top;
            dgvZaposleni.EnableHeadersVisualStyles = false;
            dgvZaposleni.GridColor = Color.FromArgb(255, 255, 128);
            dgvZaposleni.Location = new Point(0, 0);
            dgvZaposleni.Name = "dgvZaposleni";
            dgvZaposleni.RowHeadersWidth = 51;
            dgvZaposleni.RowTemplate.Height = 29;
            dgvZaposleni.Size = new Size(1005, 324);
            dgvZaposleni.TabIndex = 0;
            dgvZaposleni.CellContentClick += dgvZaposleni_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 66;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Id";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 56;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Ime";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 71;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Telefon";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 101;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Adresa";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column10.HeaderText = "Datum rodjenja";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 175;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Pol";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 66;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Uloga";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 92;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column8.DefaultCellStyle = dataGridViewCellStyle3;
            Column8.HeaderText = "Zarada";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 99;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "Sifra";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 78;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 6;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtBoxPretraga);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 324);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 79);
            panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(927, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(55, 55);
            btnAdd.TabIndex = 2;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtBoxPretraga
            // 
            txtBoxPretraga.Location = new Point(104, 25);
            txtBoxPretraga.Name = "txtBoxPretraga";
            txtBoxPretraga.Size = new Size(267, 34);
            txtBoxPretraga.TabIndex = 1;
            txtBoxPretraga.TextChanged += txtBoxPretraga_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 0;
            label1.Text = "Pretrazi";
            // 
            // ZaposleniForma
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1005, 403);
            Controls.Add(panel1);
            Controls.Add(dgvZaposleni);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ZaposleniForma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvZaposleni;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private Panel panel1;
        private Button btnAdd;
        private TextBox txtBoxPretraga;
        private Label label1;
    }
}