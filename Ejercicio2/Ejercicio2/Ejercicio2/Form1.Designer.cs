namespace Ejercicio2
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
            this.etSuma = new System.Windows.Forms.Button();
            this.etResta = new System.Windows.Forms.Button();
            this.etMultiplicar = new System.Windows.Forms.Button();
            this.etDividir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btPrimernum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // etSuma
            // 
            this.etSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etSuma.Location = new System.Drawing.Point(165, 155);
            this.etSuma.Name = "etSuma";
            this.etSuma.Size = new System.Drawing.Size(75, 23);
            this.etSuma.TabIndex = 0;
            this.etSuma.Text = "Suma";
            this.etSuma.UseVisualStyleBackColor = true;
            this.etSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // etResta
            // 
            this.etResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etResta.Location = new System.Drawing.Point(306, 155);
            this.etResta.Name = "etResta";
            this.etResta.Size = new System.Drawing.Size(75, 23);
            this.etResta.TabIndex = 1;
            this.etResta.Text = "Resta";
            this.etResta.UseVisualStyleBackColor = true;
            this.etResta.Click += new System.EventHandler(this.etResta_Click);
            // 
            // etMultiplicar
            // 
            this.etMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etMultiplicar.Location = new System.Drawing.Point(165, 185);
            this.etMultiplicar.Name = "etMultiplicar";
            this.etMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.etMultiplicar.TabIndex = 2;
            this.etMultiplicar.Text = "Multiplicar";
            this.etMultiplicar.UseVisualStyleBackColor = true;
            this.etMultiplicar.Click += new System.EventHandler(this.etMultiplicar_Click);
            // 
            // etDividir
            // 
            this.etDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etDividir.Location = new System.Drawing.Point(306, 185);
            this.etDividir.Name = "etDividir";
            this.etDividir.Size = new System.Drawing.Size(75, 23);
            this.etDividir.TabIndex = 3;
            this.etDividir.Text = "Dividir";
            this.etDividir.UseVisualStyleBackColor = true;
            this.etDividir.Click += new System.EventHandler(this.etDividir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btPrimernum
            // 
            this.btPrimernum.AutoSize = true;
            this.btPrimernum.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrimernum.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btPrimernum.Location = new System.Drawing.Point(38, 42);
            this.btPrimernum.Name = "btPrimernum";
            this.btPrimernum.Size = new System.Drawing.Size(155, 16);
            this.btPrimernum.TabIndex = 6;
            this.btPrimernum.Text = "Ingrese el primer numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese el segundo numero:";
            // 
            // btnResultado
            // 
            this.btnResultado.AutoSize = true;
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnResultado.Location = new System.Drawing.Point(32, 129);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(89, 18);
            this.btnResultado.TabIndex = 8;
            this.btnResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 261);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btPrimernum);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.etDividir);
            this.Controls.Add(this.etMultiplicar);
            this.Controls.Add(this.etResta);
            this.Controls.Add(this.etSuma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button etSuma;
        private System.Windows.Forms.Button etResta;
        private System.Windows.Forms.Button etMultiplicar;
        private System.Windows.Forms.Button etDividir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label btPrimernum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnResultado;
    }
}

