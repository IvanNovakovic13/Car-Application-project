using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Management_System
{
    public partial class Kupac : Form
    {
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        dbconnect dbconnect = new dbconnect();
        string naslov = "Sistem za automobile";

        public Kupac()
        {
            InitializeComponent();
            ucitajKupce();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            KupacModel model = new KupacModel(this);
            model.btnUpdate.Enabled = false;
            model.ShowDialog();
        }

        private void dgvKupci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvKupci.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                KupacModel module = new KupacModel(this);
                module.lblCid.Text = dgvKupci.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                module.txtBoxImeIPrezime.Text = dgvKupci.Rows[e.RowIndex].Cells["Ime"].Value.ToString();
                module.txtBoxTelefon.Text = dgvKupci.Rows[e.RowIndex].Cells["Telefon"].Value.ToString();
                module.txtBoxAutoBr.Text = dgvKupci.Rows[e.RowIndex].Cells["VoziloBr"].Value.ToString();
                module.txtBoxModelAuta.Text = dgvKupci.Rows[e.RowIndex].Cells["VoziloModel"].Value.ToString();
                module.cmbBoxTipVozila.SelectedValue = dgvKupci.Rows[e.RowIndex].Cells["id"].Value;
                module.txtBoxAdresa.Text = dgvKupci.Rows[e.RowIndex].Cells["Adresa"].Value.ToString();
                module.Poeni.Value = decimal.Parse(dgvKupci.Rows[e.RowIndex].Cells["Poeni"].Value.ToString());

                module.btnSave.Enabled = false;
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Jeste li sigurni da želite da izbrišete kupca?", "Obrišite kupca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("DELETE FROM kupac WHERE id = @id", dbconnect.connect());
                        cm.Parameters.AddWithValue("@id", dgvKupci.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                        dbconnect.open();
                        cm.ExecuteNonQuery();
                        dbconnect.close();
                        MessageBox.Show("Podaci o kupcu su uspešno uklonjeni!!", naslov, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, naslov);
                }
            }
        }

        private void txtBoxPretraga_TextChanged(object sender, EventArgs e)
        {
            ucitajKupce();
        }

        private void Kupac_Load(object sender, EventArgs e)
        {
            ucitajKupce();
        }

        #region Metode
        public void ucitajKupce()
        {
            try
            {
                int i = 0; // za broj kupaca
                dgvKupci.Rows.Clear();
                cm = new SqlCommand("SELECT k.id, k.ime, telefon, voziloBr, modelVozila, v.id AS VoziloID, v.ime, adresa, poeni FROM Kupac AS k INNER JOIN TipVozila AS v ON k.id = v.id WHERE CONCAT(k.ime, voziloBr, modelVozila) LIKE '%' + @pretraga + '%'", dbconnect.connect());
                cm.Parameters.AddWithValue("@pretraga", txtBoxPretraga.Text);
                dbconnect.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvKupci.Rows.Add(i, dr["id"], dr["ime"], dr["telefon"], dr["voziloBr"], dr["modelVozila"], dr["VoziloID"], dr["adresa"], dr["poeni"]);
                }

                dbconnect.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju kupaca: " + ex.Message, naslov);
            }
        }
        #endregion Metode
    }
}
