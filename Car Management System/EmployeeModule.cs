using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Management_System
{
    public partial class EmployeeModule : Form
    {
        SqlCommand cm = new SqlCommand();
        dbconnect dbconnect = new dbconnect();
        string title = "Sistem za automobile";

        public EmployeeModule()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // za unos zaposlenog u bazu
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Da li ste sigurni da želite da registrujete ovog zaposlenog?", "Registracija zaposlenih", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = dbconnect.connect())
                    {
                        connection.Open(); // Otvorite vezu ovde

                        using (SqlCommand cm = new SqlCommand("INSERT INTO Zaposleni(ime, telefon, adresa, [datum rodjenja], pol, uloga, zarada, sifra) VALUES (@ime, @telefon, @adresa, @datum_rodjenja, @pol, @uloga, @zarada, @sifra)", connection))
                        {
                            cm.Parameters.AddWithValue("@ime", txtBoxImeIPrezime.Text);
                            cm.Parameters.AddWithValue("@telefon", txtBoxTelefon.Text);
                            cm.Parameters.AddWithValue("@adresa", txtBoxAdresa.Text);
                            cm.Parameters.AddWithValue("@datum_rodjenja", dtRodjenja.Value);
                            cm.Parameters.AddWithValue("@pol", radioButton1.Checked ? "Musko" : "Zensko");
                            cm.Parameters.AddWithValue("@uloga", comboBoxUloga.Text);
                            cm.Parameters.AddWithValue("@zarada", txtBoxZarada.Text);
                            cm.Parameters.AddWithValue("@sifra", txtBoxSifra.Text);

                            cm.ExecuteNonQuery();
                        }

                        connection.Close(); // Zatvorite vezu nakon izvršenja upita
                    }

                    MessageBox.Show("Zaposleni je uspešno registrovan u sistem!!!", title);
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Implementirajte ažuriranje zaposlenog
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        #region Metode
        public void Clear()
        {
            txtBoxImeIPrezime.Clear();
            txtBoxTelefon.Clear();
            txtBoxAdresa.Clear();
            txtBoxSifra.Clear();
            txtBoxZarada.Clear();

            dtRodjenja.Value = DateTime.Now;
            comboBoxUloga.SelectedIndex = 3; // Rola radnik je difoltna
        }
        #endregion Metode
    }
}
