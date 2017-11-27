using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SinemaKoltuk s = new SinemaKoltuk();
        Musteri m2 = new Musteri();

        private void btnBiletAl_Click(object sender, EventArgs e)
        {

            m2.AdSoyad = txtAd.Text;
            m2.KoltukNo = Convert.ToInt32(nmKoltukNo.Value);
            if(txtAd.Text=="")
            {
                MessageBox.Show("Lütfen Ad Soyad girin");
            }
        
            else if (txtAd.Text!="")
            {
                MessageBox.Show(s.l.InsertPos(m2.KoltukNo, m2));
                MessageBox.Show(s.l.DisplayElements());
            }
            txtAd.Text = "";
            nmKoltukNo.Value = 1;
            
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {

            m2.AdSoyad = txtAd.Text;
            m2.KoltukNo = Convert.ToInt32(nmKoltukNo.Value);
            if (txtAd.Text == "")
            {
                MessageBox.Show("Lütfen Ad Soyad girin");
            }
          
            else if (txtAd.Text != "")
            {
                MessageBox.Show(s.l.DeletePos(m2.KoltukNo, m2));
                MessageBox.Show(s.l.DisplayElements());
            }
            txtAd.Text = "";
            nmKoltukNo.Value = 1;
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s.l.DoluKoltuklar());
        }

        private void btnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s.l.BosKoltuklar());
            
        }

        private void btnOgren_Click(object sender, EventArgs e)
        {
            m2.AdSoyad = txtAd.Text;
            if (txtAd.Text == "")
            {
                MessageBox.Show("Lütfen Ad Soyad girin");
            }
            else
            {
                MessageBox.Show(s.l.GetElement(m2));
                txtAd.Text = "";
                nmKoltukNo.Value = 1;
            }
            
        }
    }
}
