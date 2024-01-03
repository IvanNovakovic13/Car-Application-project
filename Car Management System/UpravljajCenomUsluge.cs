using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Management_System
{
    public partial class UpravljajCenomUsluge : Form
    {
        SqlCommand cm = new SqlCommand();
        dbconnect dbconnect = new dbconnect();
        string title = "Sistem za automobile";
        bool provera = false;
        Podesavanja settings;

        public UpravljajCenomUsluge(Podesavanja sett)
        {
            InitializeComponent();
            settings = sett;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                proveriPolje();
                if (provera)
                {
                    if (MessageBox.Show("Da li ste sigurni da želite da registrujete ovaj trosak?", "Registrovanje troška", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connection = dbconnect.connect())
                        {
                            connection.Open();

                            using (SqlCommand cmd = new SqlCommand("INSERT INTO CenaUsluge(nazivTroska, cena, datum) VALUES (@nazivTroska, @cena, @datum)", connection))
                            {
                                cmd.Parameters.AddWithValue("@nazivTroska", txtBoxNazivTroska.Text);
                                cmd.Parameters.AddWithValue("@cena", txtBoxCena.Text);
                                cmd.Parameters.AddWithValue("@datum", dateTimePickerDatum.Value);

                                cmd.ExecuteNonQuery();
                            }

                            connection.Close();

                            MessageBox.Show("Trošak je uspešno registrovan u sistem!", title);
                            clear();
                            this.Close();
                            settings.ucitajCenuUsluge();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                proveriPolje();
                if (provera)
                {
                    if (MessageBox.Show("Da li ste sigurni da želite da izmenite ovaj trosak?", "Izmena troška", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connection = dbconnect.connect())
                        {
                            connection.Open();

                            using (SqlCommand cmd = new SqlCommand(" UPDATE CenaUsluge SET nazivTroska=@nazivTroska, cena=@cena, datum=@datum WHERE id=@id ", connection))
                            {
                                cmd.Parameters.AddWithValue("@id", lblCid.Text);
                                cmd.Parameters.AddWithValue("@nazivTroska", txtBoxNazivTroska.Text);
                                cmd.Parameters.AddWithValue("@cena", txtBoxCena.Text);
                                cmd.Parameters.AddWithValue("@datum", dateTimePickerDatum.Value);

                                cmd.ExecuteNonQuery();
                            }

                            connection.Close();

                            MessageBox.Show("Trošak je uspešno izmenjen unutar sistema!", title);
                            clear();
                            this.Close();
                            this.Dispose();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtBoxCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            // dozvoli samo brojeve
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // samo jedna decimala
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        #region funkcije
        public void proveriPolje()
        {
            if (string.IsNullOrEmpty(txtBoxNazivTroska.Text) || string.IsNullOrEmpty(txtBoxCena.Text))
            {
                MessageBox.Show("Niste popunili sva potrebna polja!", "Upozorenje");
                provera = false;
            }
            else
            {
                provera = true;
            }
        }

        public void clear()
        {
            txtBoxCena.Clear();
            txtBoxNazivTroska.Clear();
            dateTimePickerDatum.Value = DateTime.Now;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        #endregion funkcije
    }
}
