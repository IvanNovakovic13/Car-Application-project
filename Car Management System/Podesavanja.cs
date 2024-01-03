using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Management_System
{
    public partial class Podesavanja : Form
    {
        SqlCommand cm = new SqlCommand();
        dbconnect dbcon = new dbconnect();
        SqlDataReader dr;
        String naslov = "Sistem za automobile";

        public Podesavanja()
        {
            InitializeComponent();
            ucitajVozilo();
            ucitajCenuUsluge();
        }

        #region TipVozila
        private void txtBoxPretragaVozila_Click(object sender, EventArgs e)
        {
            ucitajVozilo();
        }

        private void dgvTipVozila_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvTipVozila.Columns[e.ColumnIndex].Name;
            if (colName == "EditTipVozila")
            {
                UpravljajVozilom module = new UpravljajVozilom(this);
                module.lblVid.Text = dgvTipVozila.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtBoxNaziv.Text = dgvTipVozila.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.comboBoxVrsta.Text = dgvTipVozila.Rows[e.RowIndex].Cells[3].Value.ToString();

                module.btnSave.Enabled = false;
                module.ShowDialog();
            }
            else if (colName == "DeleteTipVozila")
            {
                try
                {
                    if (MessageBox.Show("Jeste li sigurni da želite da izbrišete korisnika?", "Obrišite korisnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("DELETE FROM TipVozila WHERE id = @id", dbcon.connect());
                        cm.Parameters.AddWithValue("@id", dgvTipVozila.Rows[e.RowIndex].Cells[1].Value.ToString());
                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("Podaci o vozilu su uspešno uklonjeni!!", naslov, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, naslov);
                }
            }
            ucitajVozilo();
        }

        public void ucitajVozilo()
        {
            try
            {
                int i = 0;
                dgvTipVozila.Rows.Clear();
                cm = new SqlCommand("SELECT * FROM dbo.TipVozila WHERE CONCAT(ime, vrsta) LIKE '%' + @pretraga + '%'", dbcon.connect());
                cm.Parameters.AddWithValue("@pretraga", txtBoxPretragaVozila.Text);
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvTipVozila.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, naslov);
            }
        }

        public void ucitajCenuUsluge()
        {
            try
            {
                int i = 0;
                dgvCenaUsluge.Rows.Clear();
                cm = new SqlCommand("SELECT * FROM dbo.CenaUsluge WHERE CONCAT(nazivTroska, cena, datum) LIKE '%' + @pretraga + '%'", dbcon.connect());
                cm.Parameters.AddWithValue("@pretraga", txtBoxCenaUsluge.Text);
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvCenaUsluge.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[3].ToString(), dr[2].ToString());
                }
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, naslov);
            }
        }
        #endregion TipVozila

        #region CenaUsluge
        private void btnCenaUsluge_Click(object sender, EventArgs e)
        {
            UpravljajCenomUsluge model = new UpravljajCenomUsluge(this);
            model.btnUpdate.Enabled = false;
            model.ShowDialog();
        }

        private void txtBoxCenaUsluge_TextChanged(object sender, EventArgs e)
        {
            ucitajCenuUsluge();
        }

        private void dgvCenaUsluge_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCenaUsluge.Columns[e.ColumnIndex].Name;

            if (colName == "EditCenaUsluge")
            {
                UpravljajCenomUsluge module = new UpravljajCenomUsluge(this);

                // Provera da li red u DataGridView sadrži podatke
                if (e.RowIndex >= 0 && e.RowIndex < dgvCenaUsluge.Rows.Count)
                {
                    module.lblCid.Text = dgvCenaUsluge.Rows[e.RowIndex].Cells[1].Value?.ToString();
                    module.txtBoxCena.Text = dgvCenaUsluge.Rows[e.RowIndex].Cells[4].Value?.ToString();
                    module.dateTimePickerDatum.Value = Convert.ToDateTime(dgvCenaUsluge.Rows[e.RowIndex].Cells[3].Value);
                    module.txtBoxNazivTroska.Text = dgvCenaUsluge.Rows[e.RowIndex].Cells[2].Value?.ToString();

                    module.btnSave.Enabled = false;
                    module.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Odabir reda nije validan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (colName == "DeleteCenaUsluge")
            {
                try
                {
                    if (MessageBox.Show("Jeste li sigurni da želite da izbrišete korisnika?", "Obrišite korisnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("DELETE FROM CenaUsluge WHERE id = @id", dbcon.connect());
                        cm.Parameters.AddWithValue("@id", dgvCenaUsluge.Rows[e.RowIndex].Cells[1].Value?.ToString());
                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("Podaci o usluzi su uspešno uklonjeni!!", naslov, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, naslov);
                }
            }

            ucitajCenuUsluge();
        }
        #endregion CenaUsluge

        private void btnAddVozilo_Click(object sender, EventArgs e)
        {
            UpravljajVozilom tip = new UpravljajVozilom(this);
            tip.btnUpdate.Enabled = false;
            tip.ShowDialog();
        }
    }
}
