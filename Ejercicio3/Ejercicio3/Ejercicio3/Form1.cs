using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtTextbox1.Text);
            int numero2 = int.Parse(txtTextbox2.Text);
            int resultado;
            int operacion;
            resultado = (numero1 + numero2) * (numero1 - numero2);
            operacion = (numero1 - numero2) * (numero1 - numero2);
            etResultado.Text = "El resultado es: " + resultado;
            etOperacion.Text = "El resultado de la operacion es: " + operacion;
        }
    }
}
