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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TVRHUSM\\MSSQLSERVER01;Initial Catalog=backend;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            //isTakip tablosundaki tüm verileri datagridView e getirir
            SqlDataAdapter calisan_data = new SqlDataAdapter("Select * from Calisan", baglanti);
            //TeknikKart tablosundaki tüm verileri datagridView e getirir
            SqlDataAdapter firma_data = new SqlDataAdapter("Select * from Firma", baglanti);
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();

            calisan_data.Fill(ds1);
            firma_data.Fill(ds2);

            dataGridView1.DataSource = ds1.Tables[0];
            dataGridView2.DataSource = ds2.Tables[0];
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //İsTakip tablosundaki Durum bilgisinin girilen id deki durumu girilen durum bilgisiyle değiştirir
            SqlCommand guncelle = new SqlCommand("Update Calisan set FirmaID=@yenifirmaid where CalisanID=@calisanid ", baglanti);
            guncelle.Parameters.AddWithValue("@yenifirmaid", textBoxYeniFirmaId.Text);
            guncelle.Parameters.AddWithValue("@calisanid", textBoxCalisanId.Text);
            _ = guncelle.ExecuteNonQuery();
            //Girilen yeni Durum bilgisinden sonra isTakip tablosunun güncel halini ekrana yazdırır
            SqlDataAdapter goster = new SqlDataAdapter("Select * from Calisan", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("DELETE FROM Calisan WHERE CalisanID=@CalisanID ", baglanti);
          
            sil.Parameters.AddWithValue("@CalisanID",textBoxCalısanIDsil.Text);
            _ = sil.ExecuteNonQuery();
            SqlDataAdapter goster = new SqlDataAdapter("Select * from Calisan", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();

        }
    }
}
