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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botons_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(n1.Text);
            int numero2 = Convert.ToInt32(n2.Text);
            int respuesta;

            respuesta = numero1 + numero2;
            rpta.Text = Convert.ToString(respuesta);
        }

        private void botonr_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(n1.Text);
            int numero2 = Convert.ToInt32(n2.Text);
            int respuesta;

            respuesta = numero1 - numero2;
            rpta.Text = Convert.ToString(respuesta);
        }

        private void botonm_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(n1.Text);
            int numero2 = Convert.ToInt32(n2.Text);
            int respuesta;

            respuesta = numero1 * numero2;
            rpta.Text = Convert.ToString(respuesta);
        }

        private void botond_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(n1.Text);          
            double numero2 = Convert.ToDouble(n2.Text);
            double respuesta;
            if (numero2 == 0)
            {
                warning.Text = "Warning: nose puede dividir entre 0";
            }

            else
            {
                respuesta = numero1 / numero2;
                Type type = respuesta.GetType();
                rpta.Text = Convert.ToString(respuesta);

            }
        }

        private void n1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
