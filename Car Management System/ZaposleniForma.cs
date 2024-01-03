using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Management_System
{
    public partial class ZaposleniForma : Form
    {
        SqlCommand cm = new SqlCommand();
        dbconnect dbcon = new dbconnect();
        SqlDataReader dr;
        String naslov = "Sistem za automobile";

        public ZaposleniForma()
        {
            InitializeComponent();
            ucitajZaposlene();
        }

        private void txtBoxPretraga_TextChanged(object sender, EventArgs e)
        {
            ucitajZaposlene();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvZaposleniModel module = new dgvZaposleniModel(this);
            module.btnUpdate.Enabled = false;
            module.ShowDialog();
        }

        #region Metode

        public void ucitajZaposlene()
        {
            try
            {
                int i = 0;
                dgvZaposleni.Rows.Clear();
                cm = new SqlCommand("SELECT * FROM Zaposleni WHERE CONCAT(ime, adresa, uloga) LIKE '%' + @pretraga + '%'", dbcon.connect());
                cm.Parameters.AddWithValue("@pretraga", txtBoxPretraga.Text);
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvZaposleni.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), DateTime.Parse(dr[4].ToString()).ToShortDateString(), dr[8].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                }
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, naslov);
            }
        }

        #endregion Metode

        private void dgvZaposleni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvZaposleni.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                dgvZaposleniModel module = new dgvZaposleniModel(this);
                module.lblEid.Text = dgvZaposleni.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtBoxImeIPrezime.Text = dgvZaposleni.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txtBoxTelefon.Text = dgvZaposleni.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txtBoxAdresa.Text = dgvZaposleni.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.dtRodjenja.Value = DateTime.Parse(dgvZaposleni.Rows[e.RowIndex].Cells[5].Value.ToString());
                module.radioButton1.Checked = dgvZaposleni.Rows[e.RowIndex].Cells[6].Value.ToString() == "Muski" ? true : false;
                module.txtBoxZarada.Text = dgvZaposleni.Rows[e.RowIndex].Cells[7].Value.ToString();
                module.txtBoxSifra.Text = dgvZaposleni.Rows[e.RowIndex].Cells[8].Value.ToString();

                module.btnSave.Enabled = false;
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Jeste li sigurni da želite da izbrišete korisnika?", "Obrišite korisnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("DELETE FROM ZAPOSLENI WHERE id = @id", dbcon.connect());
                        cm.Parameters.AddWithValue("@id", dgvZaposleni.Rows[e.RowIndex].Cells[1].Value.ToString());
                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("Podaci o zaposlenom su uspešno uklonjeni!!", naslov, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, naslov);
                }
            }
        }
    }
}
