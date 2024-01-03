using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Car_Management_System
{
    public partial class UpravljajVozilom : Form
    {
        SqlCommand cm = new SqlCommand();
        dbconnect dbconnect = new dbconnect();
        string naslov = "Sistem za automobile";
        Podesavanja podesavanja;

        public UpravljajVozilom(Podesavanja settings)
        {
            InitializeComponent();
            this.podesavanja = settings;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txtBoxNaziv.Text))
                {
                    MessageBox.Show("Ovo polje je obavezno!!", "Upozorenje");
                    return;
                }
                if (MessageBox.Show("Da li ste sigurni da želite da registrujete ovo vozilo?", "Registracija vozila", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = dbconnect.connect())
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand("INSERT INTO TipVozila(ime, vrsta) VALUES (@ime, @vrsta)", connection))
                        {
                            cmd.Parameters.AddWithValue("@ime", txtBoxNaziv.Text);
                            cmd.Parameters.AddWithValue("@vrsta", comboBoxVrsta.Text);

                            cmd.ExecuteNonQuery();
                        }

                        connection.Close();

                        MessageBox.Show("Vozilo je uspešno registrovano u sistem!!!", naslov);
                        clear();
                        this.Close(); 
                        podesavanja.ucitajCenuUsluge();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, naslov);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBoxNaziv.Text))
                {
                    MessageBox.Show("Ovo polje je obavezno!!", "Upozorenje");
                    return;
                }
                if (MessageBox.Show("Da li ste sigurni da želite da izmenite ovo vozilo?", "Azuiranje vozila", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = dbconnect.connect())
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand("UPDATE TipVozila SET ime=@ime, vrsta=@vrsta WHERE id=@id", connection))
                        {
                            cmd.Parameters.AddWithValue("@id", lblVid.Text);
                            cmd.Parameters.AddWithValue("@ime", txtBoxNaziv.Text);
                            cmd.Parameters.AddWithValue("@vrsta", comboBoxVrsta.Text);

                            cmd.ExecuteNonQuery();
                        }

                        connection.Close();

                        MessageBox.Show("Vozilo je uspešno izmenjeno u sistemu!!!", naslov);
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, naslov);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        #region method
        public void clear()
        {
            txtBoxNaziv.Clear();
            comboBoxVrsta.SelectedIndex = 0;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        #endregion method

    }
}
