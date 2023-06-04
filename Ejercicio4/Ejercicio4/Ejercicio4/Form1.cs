using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string vocal =txtMuestra.Text;
            if ((vocal == "a" || vocal == "e" || vocal == "i" || vocal == "o" || vocal == "u" || vocal == "A" || vocal == "E" || vocal == "I" || vocal == "O" || vocal == "U"))
            {
                etVocal.Text = "Es una vocal?  Si :)";
            }
            else
            {
                etNovocal.Text = "No es una vocal :(";
            }
        }
    }
}
