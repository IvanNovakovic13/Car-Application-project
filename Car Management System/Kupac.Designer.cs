namespace Car_Management_System
{
    partial class Kupac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kupac));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnAdd = new Button();
            txtBoxPretraga = new TextBox();
            label1 = new Label();
            dgvKupci = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            ime = new DataGridViewTextBoxColumn();
            telefon = new DataGridViewTextBoxColumn();
            VoziloBr = new DataGridViewTextBoxColumn();
            VoziloModel = new DataGridViewTextBoxColumn();
            VoziloTip = new DataGridViewTextBoxColumn();
            adresa = new DataGridViewTextBoxColumn();
            poeni = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKupci).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtBoxPretraga);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 401);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 79);
            panel1.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(900, 12);
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
            // dgvKupci
            // 
            dgvKupci.AllowUserToAddRows = false;
            dgvKupci.AllowUserToDeleteRows = false;
            dgvKupci.AllowUserToResizeColumns = false;
            dgvKupci.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dgvKupci.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvKupci.BackgroundColor = Color.White;
            dgvKupci.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKupci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKupci.ColumnHeadersHeight = 35;
            dgvKupci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKupci.Columns.AddRange(new DataGridViewColumn[] { No, id, ime, telefon, VoziloBr, VoziloModel, VoziloTip, adresa, poeni, Edit, Delete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvKupci.DefaultCellStyle = dataGridViewCellStyle3;
            dgvKupci.Dock = DockStyle.Fill;
            dgvKupci.EnableHeadersVisualStyles = false;
            dgvKupci.GridColor = Color.FromArgb(255, 255, 128);
            dgvKupci.Location = new Point(0, 0);
            dgvKupci.Name = "dgvKupci";
            dgvKupci.RowHeadersWidth = 51;
            dgvKupci.RowTemplate.Height = 29;
            dgvKupci.Size = new Size(967, 401);
            dgvKupci.TabIndex = 3;
            dgvKupci.CellContentClick += dgvKupci_CellContentClick;
            // 
            // No
            // 
            No.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            No.HeaderText = "No";
            No.MinimumWidth = 6;
            No.Name = "No";
            No.Width = 66;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 56;
            // 
            // ime
            // 
            ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ime.HeaderText = "Ime";
            ime.MinimumWidth = 6;
            ime.Name = "ime";
            ime.Width = 71;
            // 
            // telefon
            // 
            telefon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            telefon.HeaderText = "Telefon";
            telefon.MinimumWidth = 6;
            telefon.Name = "telefon";
            telefon.Width = 101;
            // 
            // VoziloBr
            // 
            VoziloBr.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VoziloBr.HeaderText = "Auto br.";
            VoziloBr.MinimumWidth = 6;
            VoziloBr.Name = "VoziloBr";
            // 
            // VoziloModel
            // 
            VoziloModel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            VoziloModel.HeaderText = "Model auta";
            VoziloModel.MinimumWidth = 6;
            VoziloModel.Name = "VoziloModel";
            VoziloModel.Width = 139;
            // 
            // VoziloTip
            // 
            VoziloTip.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            VoziloTip.HeaderText = "Tip vozila";
            VoziloTip.MinimumWidth = 6;
            VoziloTip.Name = "VoziloTip";
            VoziloTip.Width = 122;
            // 
            // adresa
            // 
            adresa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            adresa.HeaderText = "Adresa";
            adresa.MinimumWidth = 6;
            adresa.Name = "adresa";
            // 
            // poeni
            // 
            poeni.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            poeni.HeaderText = "Poeni";
            poeni.MinimumWidth = 6;
            poeni.Name = "poeni";
            poeni.Width = 87;
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
            // Kupac
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(967, 480);
            Controls.Add(dgvKupci);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kupac";
            Text = "Kupac";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKupci).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAdd;
        private TextBox txtBoxPretraga;
        private Label label1;
        public DataGridView dgvKupci;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn ime;
        private DataGridViewTextBoxColumn telefon;
        private DataGridViewTextBoxColumn VoziloBr;
        private DataGridViewTextBoxColumn VoziloModel;
        private DataGridViewTextBoxColumn VoziloTip;
        private DataGridViewTextBoxColumn adresa;
        private DataGridViewTextBoxColumn poeni;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}