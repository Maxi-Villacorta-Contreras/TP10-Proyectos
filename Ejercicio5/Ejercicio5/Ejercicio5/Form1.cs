using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bynIniciar_Click(object sender, EventArgs e)
        {
            int H = 0, M = 0, S = 0;
            do
            {
                etMostrar.Text = H + ":" + M + ":" + S;
                S = S + 1;
                MessageBox.Show(H + ":" + M + ":" + S);
                if (S==59)
                {
                    M = M + 1;
                    S = 0;
                    if(M==59)
                    {
                        H = H + 1;
                        M = 0;
                    }
                }
            } while (H<24);
        }
    }
}
