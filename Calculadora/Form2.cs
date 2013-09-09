using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gradosfa = Convert.ToDouble(fahrenheit.Text);
            double result;

            result = (((gradosfa - 32) * 5 )/ 9);
            rpta.Text = Convert.ToString(result);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
