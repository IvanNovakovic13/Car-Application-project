using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Management_System
{
    public partial class dgvZaposleniModel : Form
    {
        SqlCommand cm = new SqlCommand();
        bool provera = false;
        dbconnect dbconnect = new dbconnect();
        string naslov = "Sistem za automobile";
        ZaposleniForma zaposleni;

        public dgvZaposleniModel(ZaposleniForma form)
        {
            InitializeComponent();
            comboBoxUloga.SelectedIndex = 3; // Rola radnik je difoltna
            zaposleni = form;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                proveriPolje();
                if (provera)
                {
                    if (MessageBox.Show("Da li ste sigurni da želite da registrujete ovog zaposlenog?", "Registracija zaposlenih", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connection = dbconnect.connect())
                        {
                            connection.Open();

                            using (SqlCommand cmd = new SqlCommand("INSERT INTO Zaposleni(ime, telefon, adresa, [datum rodjenja], pol, uloga, zarada, sifra) VALUES (@ime, @telefon, @adresa, @datum_rodjenja, @pol, @uloga, @zarada, @sifra)", connection))
                            {
                                cmd.Parameters.AddWithValue("@ime", txtBoxImeIPrezime.Text);
                                cmd.Parameters.AddWithValue("@telefon", txtBoxTelefon.Text);
                                cmd.Parameters.AddWithValue("@adresa", txtBoxAdresa.Text);
                                cmd.Parameters.AddWithValue("@datum_rodjenja", dtRodjenja.Value);
                                cmd.Parameters.AddWithValue("@pol", radioButton1.Checked ? "Musko" : "Zensko");
                                cmd.Parameters.AddWithValue("@uloga", comboBoxUloga.Text);
                                cmd.Parameters.AddWithValue("@zarada", txtBoxZarada.Text);
                                cmd.Parameters.AddWithValue("@sifra", txtBoxSifra.Text);

                                cmd.ExecuteNonQuery();
                            }

                            connection.Close();

                            MessageBox.Show("Zaposleni je uspešno registrovan u sistem!!!", naslov);
                            provera = false;
                            Clear();
                            zaposleni.ucitajZaposlene();
                        }
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
                proveriPolje();
                if (provera)
                {
                    if (MessageBox.Show("Da li ste sigurni da želite da izmenite ovog zaposlenog?", "Izmena zaposlenih", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connection = dbconnect.connect())
                        {
                            connection.Open();

                            using (SqlCommand cmd = new SqlCommand("UPDATE Zaposleni SET ime=@ime, telefon=@telefon, adresa=@adresa, [datum rodjenja]=@datum_rodjenja, pol=@pol, uloga=@uloga, zarada=@zarada, sifra=@sifra WHERE id=@id", connection))
                            {
                                cmd.Parameters.AddWithValue("@id", lblEid.Text);
                                cmd.Parameters.AddWithValue("@ime", txtBoxImeIPrezime.Text);
                                cmd.Parameters.AddWithValue("@telefon", txtBoxTelefon.Text);
                                cmd.Parameters.AddWithValue("@adresa", txtBoxAdresa.Text);
                                cmd.Parameters.AddWithValue("@datum_rodjenja", dtRodjenja.Value);
                                cmd.Parameters.AddWithValue("@pol", radioButton1.Checked ? "Musko" : "Zensko");
                                cmd.Parameters.AddWithValue("@uloga", comboBoxUloga.Text);
                                cmd.Parameters.AddWithValue("@zarada", txtBoxZarada.Text);
                                cmd.Parameters.AddWithValue("@sifra", txtBoxSifra.Text);

                                cmd.ExecuteNonQuery();
                            }

                            connection.Close();

                            MessageBox.Show("Podaci o zaposlenom su uspešno izmenjeni!", naslov);
                            Clear();
                            this.Close();
                            zaposleni.ucitajZaposlene();
                        }
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
            Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }

        private void comboBoxUloga_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUloga.Text == "Menadžer" || comboBoxUloga.Text == "Radnik")
            {
                this.Height = 504;
                txtBoxSifra.Clear();
                lblSifra.Visible = false;//da se ne bi videlo polje za unos sifre menadzeru i radniku
                txtBoxSifra.Visible = false;
            }
            else
            {
                lblSifra.Visible = true;
                txtBoxSifra.Visible = true;
                this.Height = 504;
            }
        }

        #region method
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

        public void proveriPolje()
        {
            provera = true;

            if (string.IsNullOrWhiteSpace(txtBoxAdresa.Text) || string.IsNullOrWhiteSpace(txtBoxImeIPrezime.Text) || string.IsNullOrWhiteSpace(txtBoxTelefon.Text) || string.IsNullOrWhiteSpace(txtBoxZarada.Text))
            {
                MessageBox.Show("Niste uneli sva odgovarajuća polja!!");
                provera = false;
            }
            else
            {
                if (proveriGodine(dtRodjenja.Value) < 18)
                {
                    MessageBox.Show("Osoba je maloletna!!", "Upozorenje");
                    provera = false;
                }
            }
        }

        public static int proveriGodine(DateTime godine)
        {
            int starost = DateTime.Now.Year - godine.Year;
            if (DateTime.Now.DayOfYear < godine.DayOfYear)
            {
                starost = starost - 1;
            }
            return starost;
        }

        private void txtBoxZarada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
        #endregion method

        private void txtBoxZarada_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //da dozvoli samo brojeve
            if(!char.IsControl(e.KeyChar) &&  !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            //samo jedna decimala
            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)){
                e.Handled = true;
            }
        }
    }
}
