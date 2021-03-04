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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TVRHUSM\\MSSQLSERVER01;Initial Catalog=backend;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //TextBox taki verileri Sql deki Calisan tablosuna kaydediyor
            SqlCommand yazdir2 = new SqlCommand("Insert Into Calisan (CalisanID,CalisanAdi,CalisanSoyadi,DepartmanAdi) Values ('" + textBoxCalisanID.Text.ToString() + "','" + textBoxCalisanAdi.Text + "','" + textBoxCalisanSoyadi.Text + "','" + textBoxdepartman.Text.ToString() + "')", baglanti);
            yazdir2.ExecuteNonQuery();
            //TextBox taki verileri Sql deki Calisan tablosuna kaydediyor
            SqlCommand yazdir3 = new SqlCommand("Insert Into Firma (FirmaID,FirmaAdi) Values ('" + textBoxfirmaID.Text.ToString() + "','" + textBoxFirmaAdi.Text  +  "')", baglanti);
            yazdir3.ExecuteNonQuery();
            SqlCommand yazdir4 = new SqlCommand("Insert Into Calisan (FirmaID) Values ('" + textBoxfirmaID.Text.ToString()  + "')", baglanti);
            yazdir4.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}
