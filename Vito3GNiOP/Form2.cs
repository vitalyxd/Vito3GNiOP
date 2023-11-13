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

namespace Vito3GNiOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Povratak_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
        }

        private void Izracun_Click(object sender, EventArgs e)
        {
            try
            {

                double faktortrenja = double.Parse(FaktorTrenja.Text);

                if (faktortrenja <= 0)
                {
                    MessageBox.Show("Faktor trenja ne moze biti manji ili jednak nuli!");
                    return;
                }

                double normsila = double.Parse(NormalnaSilaFN.Text);



                double FT = faktortrenja * normsila;
                SilaTrenjaFT.Text = "Sila trenja iznosi: " + FT.ToString() + " N";

            }
            catch (FormatException) 
            {
                MessageBox.Show("Unesite ispravne vrijednosti");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
