using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackendDeveloperApplyProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); //form2 göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz
        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show(); //form3 göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz
        }

        private void buttonlistele_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show(); //form5 göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz
        }
    }
}
