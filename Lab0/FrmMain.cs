using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0
{
    public partial class Lab0 : Form
    {

        const double PI = 3.14159 ;
        public Lab0()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello "+txtEnterName.Text+ " !");
            double radius = Convert.ToDouble(txtEnterRadius.Text);
            txtEnterRadius.Text = calcArea(radius).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public double calcArea(double radius)
        {
            return PI * radius * radius;

        }
    }
}
