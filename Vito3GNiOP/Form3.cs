using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vito3GNiOP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Povratak_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
        }

        private void Ro_TextChanged(object sender, EventArgs e)
        {

        }

        private void Izracun_Click(object sender, EventArgs e)
        {
            try
            {
                double otpornost = double.Parse(Ro.Text);

                if (otpornost <= 0)
                {
                    MessageBox.Show("Otpornost ne moze biti manja ili jednaka nuli!");
                    return;
                }

                double duljina = double.Parse(Duljina.Text);

                if (duljina <= 0)
                {
                    MessageBox.Show("Duljina vodina ne moze biti manja ili jednaka nuli!");
                    return;
                }

                double povrsina_poprecnog_presjeka = double.Parse(PovrsinaPoprecnogPresjeka.Text);

                if (povrsina_poprecnog_presjeka <= 0)
                {
                    MessageBox.Show("Povrsina poprecnog presjeka ne moze biti manja ili jednaka nuli!");
                    return;

                    
                }
                double otpor = otpornost * (duljina / povrsina_poprecnog_presjeka);
                Otpor.Text = "Otpor iznosi: " + otpor.ToString() + " Ω";
            }
            catch (FormatException)
            {
                MessageBox.Show("Unesite ispravne vrijednosti!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
