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

namespace BackendDeveloperApplyProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TVRHUSM\\MSSQLSERVER01;Initial Catalog=backend;Integrated Security=True");

        private void buttondepartman_Click(object sender, EventArgs e)
        {
            SqlDataAdapter calisan_data = new SqlDataAdapter("Select DepartmanAdi from Calisan", baglanti);
           
            DataSet ds1 = new DataSet();          
            calisan_data.Fill(ds1);
            dataGridViewDepartman.DataSource = ds1.Tables[0];
        }

        private void buttonFirma_Click(object sender, EventArgs e)
        {
            SqlDataAdapter firma_data = new SqlDataAdapter("Select f.FirmaAdi,count(c.CalisanAdi) as 'Çalışan Sayısı' From Calisan c Inner Join Firma f  on c.FirmaID=f.FirmaID group by FirmaAdi", baglanti);

            DataSet ds2 = new DataSet();
            firma_data.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];
        }

        private void buttonCalisan_Click(object sender, EventArgs e)
        {
            SqlDataAdapter c_data = new SqlDataAdapter("Select CalisanAdi,CalisanSoyadi from Calisan order by CalisanID desc", baglanti);

            DataSet ds3 = new DataSet();
            c_data.Fill(ds3);
            dataGridView2.DataSource = ds3.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter f_data = new SqlDataAdapter("Select c.CalisanAdi,c.CalisanSoyadi,f.FirmaAdi  From Calisan c Inner Join Firma f  on c.FirmaID=f.FirmaID order by c.DepartmanAdi", baglanti);

            DataSet ds4 = new DataSet();
            f_data.Fill(ds4);
            dataGridView3.DataSource = ds4.Tables[0];
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
