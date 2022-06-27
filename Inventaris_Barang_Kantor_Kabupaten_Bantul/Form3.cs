using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventaris_Barang_Kantor_Kabupaten_Bantul
{
    public partial class Form3 : Form
    {
        DataTable dt;
        DataRow dr;
        String code;
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invetarisDataSet3.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter1.Fill(this.invetarisDataSet3.Barang);
            // TODO: This line of code loads data into the 'invetarisDataSet1.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.invetarisDataSet1.Barang);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveBrg_Click(object sender, EventArgs e)
        {
            btnSaveBrg.Enabled = true;
            txtKodeBrg.Enabled = true;
            txtNamaBrg.Enabled = true;
            txtIdPengurusBrg.Enabled = true;
            txtKeadaanBrg.Enabled = true;
            txtKeterangan.Enabled = true;
            txtHargaStn.Enabled = true;
            txtKuantitasBrg.Enabled = true;
            txtTotalHrg.Enabled = true;
            


            txtKodeBrg.Text = "";
            txtNamaBrg.Text = "";
            txtIdPengurusBrg.Text = "";
            txtKeadaanBrg.Text = "";
            txtKeterangan.Text = "";
            txtHargaStn.Text = "";
            txtKuantitasBrg.Text = "";
            txtTotalHrg.Text = "";
            

            
           

            dt = invetarisDataSet3.Tables["Barang"];
            dr = dt.NewRow();
            dr[0] = txtKodeBrg.Text;
            dr[1] = txtNamaBrg.Text;
            dr[2] = txtIdPengurusBrg.Text;
            dr[3] = txtKeadaanBrg.Text;
            dr[4] = txtKeterangan.Text;
            dr[5] = txtHargaStn.Text;
            dr[6] = txtKuantitasBrg.Text;
            dr[7] = txtTotalHrg.Text;
            dt.Rows.Add(dr);
            barangTableAdapter1.Update(invetarisDataSet3);
            txtKodeBrg.Text = System.Convert.ToString(dr[0]);
            txtKodeBrg.Enabled = false;
            txtNamaBrg.Enabled = false;
            txtIdPengurusBrg.Text = System.Convert.ToString(dr[2]);
            txtKeadaanBrg.Enabled = false;
            txtKeterangan.Enabled = false;
            txtHargaStn.Enabled = false;
            txtKuantitasBrg.Enabled = false;
            txtTotalHrg.Enabled = false;
            this.barangTableAdapter1.Fill(this.invetarisDataSet3.Barang);
            
            btnSaveBrg.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
