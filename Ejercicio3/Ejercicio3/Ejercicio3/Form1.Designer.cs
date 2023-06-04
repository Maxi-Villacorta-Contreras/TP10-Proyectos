namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.etPrimer = new System.Windows.Forms.Label();
            this.etSegundo = new System.Windows.Forms.Label();
            this.txtTextbox1 = new System.Windows.Forms.TextBox();
            this.txtTextbox2 = new System.Windows.Forms.TextBox();
            this.etResultado = new System.Windows.Forms.Label();
            this.etOperacion = new System.Windows.Forms.Label();
            this.btnBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etPrimer
            // 
            this.etPrimer.AutoSize = true;
            this.etPrimer.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etPrimer.Location = new System.Drawing.Point(17, 26);
            this.etPrimer.Name = "etPrimer";
            this.etPrimer.Size = new System.Drawing.Size(165, 15);
            this.etPrimer.TabIndex = 0;
            this.etPrimer.Text = "Ingrese el primer numero(a):";
            // 
            // etSegundo
            // 
            this.etSegundo.AutoSize = true;
            this.etSegundo.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etSegundo.Location = new System.Drawing.Point(17, 69);
            this.etSegundo.Name = "etSegundo";
            this.etSegundo.Size = new System.Drawing.Size(175, 15);
            this.etSegundo.TabIndex = 1;
            this.etSegundo.Text = "Ingrese el segundo numero(b):";
            // 
            // txtTextbox1
            // 
            this.txtTextbox1.Location = new System.Drawing.Point(188, 21);
            this.txtTextbox1.Name = "txtTextbox1";
            this.txtTextbox1.Size = new System.Drawing.Size(100, 20);
            this.txtTextbox1.TabIndex = 2;
            // 
            // txtTextbox2
            // 
            this.txtTextbox2.Location = new System.Drawing.Point(198, 66);
            this.txtTextbox2.Name = "txtTextbox2";
            this.txtTextbox2.Size = new System.Drawing.Size(100, 20);
            this.txtTextbox2.TabIndex = 3;
            // 
            // etResultado
            // 
            this.etResultado.AutoSize = true;
            this.etResultado.Font = new System.Drawing.Font("Perpetua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etResultado.Location = new System.Drawing.Point(62, 133);
            this.etResultado.Name = "etResultado";
            this.etResultado.Size = new System.Drawing.Size(153, 18);
            this.etResultado.TabIndex = 4;
            this.etResultado.Text = "Resultado(a+b)*(a-b)";
            // 
            // etOperacion
            // 
            this.etOperacion.AutoSize = true;
            this.etOperacion.Font = new System.Drawing.Font("Perpetua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etOperacion.Location = new System.Drawing.Point(65, 169);
            this.etOperacion.Name = "etOperacion";
            this.etOperacion.Size = new System.Drawing.Size(150, 18);
            this.etOperacion.TabIndex = 5;
            this.etOperacion.Text = "Operacion(a-b)*(a-b)";
            // 
            // btnBoton
            // 
            this.btnBoton.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBoton.Location = new System.Drawing.Point(310, 151);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(75, 23);
            this.btnBoton.TabIndex = 6;
            this.btnBoton.Text = "Calcular";
            this.btnBoton.UseVisualStyleBackColor = true;
            this.btnBoton.Click += new System.EventHandler(this.btnBoton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 293);
            this.Controls.Add(this.btnBoton);
            this.Controls.Add(this.etOperacion);
            this.Controls.Add(this.etResultado);
            this.Controls.Add(this.txtTextbox2);
            this.Controls.Add(this.txtTextbox1);
            this.Controls.Add(this.etSegundo);
            this.Controls.Add(this.etPrimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etPrimer;
        private System.Windows.Forms.Label etSegundo;
        private System.Windows.Forms.TextBox txtTextbox1;
        private System.Windows.Forms.TextBox txtTextbox2;
        private System.Windows.Forms.Label etResultado;
        private System.Windows.Forms.Label etOperacion;
        private System.Windows.Forms.Button btnBoton;
    }
}

