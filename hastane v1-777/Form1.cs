using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_v1_777
{
    public partial class Form1 : Form
    {
        Hasta hasta1 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hasta1 = new Hasta();  

            hasta1.ad = txtAd.Text;
            hasta1.soyad = txtSoyad.Text;
            hasta1.dtarih = dateTimePicker1.Value;
            hasta1.kronikHastalik = rbKronikvar.Checked;
            hasta1.kanGrup = cmbKan.Text;
            
            if (rbKronikvar.Checked)
            {
                hasta1.kronikHastalik = true;

            }
            else
            {
                hasta1.kronikHastalik = false;
            }
        }
    }
}
