using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int resultado;
            resultado = numero1 + numero2;
            btnResultado.Text = "La suma es: " + resultado;
            

        }

        private void etResta_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int resultado;
            resultado = numero1 - numero2;
            btnResultado.Text = "La resta es: " + resultado;
        }

        private void etMultiplicar_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int resultado;
            resultado = numero1 * numero2;
            btnResultado.Text = "La multiplicacion es: " + resultado;
        }

        private void etDividir_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int resultado;
            resultado = numero1 / numero2;
            btnResultado.Text = "La division es: " + resultado;
        }
    }
}
