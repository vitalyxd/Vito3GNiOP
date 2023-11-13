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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var NewForm = new Form2();
            NewForm.Show();
        }

        private void ElektricnaOtpornost_Click(object sender, EventArgs e)
        {
            var NewForm = new Form3();
            NewForm.Show();

        }
    }
}
