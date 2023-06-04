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

namespace Stok_Otomasyonu
{
    public partial class frmSatışListele : Form
    {
        public frmSatışListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=OSAMAH0109;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void satışlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];

            baglanti.Close();
        }
        private void frmSatışListele_Load(object sender, EventArgs e)
        {
            satışlistele(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from satis where barkodno= '" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün satıştan çıkarıldı");
            daset.Tables["satis"].Clear();
            satışlistele();
           
        }

        private void txtAdSoyadAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satis where adsoyad like '%" + txtAdSoyadAra.Text + "%'",baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
