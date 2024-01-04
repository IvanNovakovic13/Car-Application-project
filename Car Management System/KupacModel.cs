using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Management_System
{
    public partial class KupacModel : Form
    {
        SqlCommand cm = new SqlCommand();
        bool provera = false;
        dbconnect dbconnect = new dbconnect();
        string naslov = "Sistem za automobile";
        Kupac kup;
        
        public KupacModel(Kupac kup)
        {
            InitializeComponent();
            this.kup = kup;
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
                    if (MessageBox.Show("Da li ste sigurni da želite da registrujete ovog kupca?", "Registracija kupaca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connection = dbconnect.connect())
                        {
                            connection.Open();

                            using (SqlCommand cmd = new SqlCommand("INSERT INTO Kupac(vid,ime, telefon, VoziloBr, modelVozila, adresa, poeni) VALUES (@vid,@ime, @telefon, @VoziloBr, @modelVozila, @adresa, @poeni)", connection))
                            {
                                cmd.Parameters.AddWithValue("@vid", cmbBoxTipVozila.SelectedValue);
                                cmd.Parameters.AddWithValue("@ime", txtBoxImeIPrezime.Text);
                                cmd.Parameters.AddWithValue("@telefon", txtBoxTelefon.Text);
                                cmd.Parameters.AddWithValue("@VoziloBr", txtBoxAutoBr.Text);
                                cmd.Parameters.AddWithValue("@modelVozila", txtBoxModelAuta.Text);
                                cmd.Parameters.AddWithValue("@adresa", txtBoxAdresa.Text);
                                cmd.Parameters.AddWithValue("@poeni", Poeni.Value);

                                cmd.ExecuteNonQuery();
                            }

                            connection.Close();

                            MessageBox.Show("Kupac je uspešno registrovan u sistem!!!", naslov);
                            provera = false;
                            Clear();
                            kup.ucitajKupce(); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri unosu kupca: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void KupacModel_Load(object sender, EventArgs e)
        {
            // Za dodavanje liste vozila u kombo box
            cmbBoxTipVozila.DataSource = TipVozila();
            cmbBoxTipVozila.DisplayMember = "ime";
            cmbBoxTipVozila.ValueMember = "id";
        }

        #region Metoda

        // Funkcija za tip vozila
        public DataTable TipVozila()
        {
            cm = new SqlCommand("SELECT * FROM tipVozila ", dbconnect.connect());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            adapter.SelectCommand = cm;
            adapter.Fill(dataTable);

            return dataTable;
        }

        public void Clear()
        {
            txtBoxImeIPrezime.Clear();
            txtBoxAdresa.Clear();
            txtBoxAutoBr.Clear();
            txtBoxModelAuta.Clear();
            txtBoxTelefon.Clear();
            cmbBoxTipVozila.SelectedIndex = 0;
            Poeni.Value = 0;

            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
        }

        public void proveriPolje()
        {
            provera = true;

            if (string.IsNullOrWhiteSpace(txtBoxAdresa.Text) || string.IsNullOrWhiteSpace(txtBoxImeIPrezime.Text) || string.IsNullOrWhiteSpace(txtBoxTelefon.Text) || string.IsNullOrWhiteSpace(txtBoxAutoBr.Text) || string.IsNullOrWhiteSpace(txtBoxModelAuta.Text))
            {
                MessageBox.Show("Niste uneli sva odgovarajuća polja!!");
                provera = false;
                return; // da vrati nazad na formu
            }
        }

        #endregion Metoda
    }
}
