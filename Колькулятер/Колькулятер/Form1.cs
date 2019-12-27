using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Колькулятер
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приветики");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(rnd.Next(0, 100));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

    }
}
