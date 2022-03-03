using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);

            if (radioButton1.Checked)
            {
                double kok = Math.Sqrt(sayi);
                MessageBox.Show("Girdiğiniz Sayının Karekökü: " + kok);
            }
            else if (radioButton2.Checked)
            {
                double kare = Math.Pow(sayi, 2);
                MessageBox.Show("Girdiğiniz Sayının Karesi: " + kare);
            }
            else if (radioButton3.Checked)
            {
                double kup = Math.Pow(sayi, 3);
                MessageBox.Show("Girdiğiniz Sayının Küpü: " + kup);
            }

        }
    }
}
