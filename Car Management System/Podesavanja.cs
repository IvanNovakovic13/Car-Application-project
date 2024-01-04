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
        bool imaPodatke = false;

        public Podesavanja()
        {
            InitializeComponent();
            ucitajVozilo();
            ucitajCenuUsluge();
            UcitajKompaniju();
        }

        #region TipVozila
        private void txtBoxPretragaVozila_Click(object sender, EventArgs e)
        {
            ucitajVozilo();
        }

        private void dgvTipVozila_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void btnAddVozilo_Click(object sender, EventArgs e)
        {
            UpravljajVozilom tip = new UpravljajVozilom(this);
            tip.btnUpdate.Enabled = false;
            tip.ShowDialog();
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

        #region PodaciOKompaniji
        public void UcitajKompaniju()
        {
            try
            {
                dbcon.open();
                cm = new SqlCommand("Select * from Kompanija", dbcon.connect());
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    imaPodatke = true;
                    txtBoxNazivKompanije.Text = dr["ime"].ToString();
                    txtBoxAdresaKompanije.Text = dr["adresa"].ToString();
                }
                else
                {
                    txtBoxNazivKompanije.Clear();
                    txtBoxAdresaKompanije.Clear();
                }
                dr.Close();
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, naslov);
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Sačuvaj podatke o kompaniji?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (imaPodatke)
                    {
                        dbcon.ExcecuteQuerry("UPDATE kompanija SET ime ='" + txtBoxNazivKompanije.Text + "', adresa='" + txtBoxAdresaKompanije.Text + "'");
                    }
                    else
                    {
                        dbcon.ExcecuteQuerry("INSERT INTO kompanija (ime, adresa) values('" + txtBoxNazivKompanije.Text + "', '" + txtBoxAdresaKompanije.Text + "')");
                    }
                    MessageBox.Show("Podaci o kompaniji su uspešno sačuvani", "Čuvanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, naslov);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBoxAdresaKompanije.Clear();
            txtBoxNazivKompanije.Clear();
        }
        #endregion PodaciOKompaniji

       
    }
}
