namespace Ejercicio1
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
            this.btnBoton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btIngresenomre = new System.Windows.Forms.Label();
            this.btMatrix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBoton
            // 
            this.btnBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBoton.Location = new System.Drawing.Point(140, 125);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(83, 28);
            this.btnBoton.TabIndex = 0;
            this.btnBoton.Text = "Apretar";
            this.btnBoton.UseVisualStyleBackColor = true;
            this.btnBoton.Click += new System.EventHandler(this.btnBoton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btIngresenomre
            // 
            this.btIngresenomre.AutoSize = true;
            this.btIngresenomre.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIngresenomre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btIngresenomre.Location = new System.Drawing.Point(22, 39);
            this.btIngresenomre.Name = "btIngresenomre";
            this.btIngresenomre.Size = new System.Drawing.Size(166, 17);
            this.btIngresenomre.TabIndex = 2;
            this.btIngresenomre.Text = "Ingrese su nombre:";
            // 
            // btMatrix
            // 
            this.btMatrix.AutoSize = true;
            this.btMatrix.Font = new System.Drawing.Font("Stencil", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMatrix.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btMatrix.Location = new System.Drawing.Point(22, 72);
            this.btMatrix.Name = "btMatrix";
            this.btMatrix.Size = new System.Drawing.Size(19, 16);
            this.btMatrix.TabIndex = 3;
            this.btMatrix.Text = ":)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 261);
            this.Controls.Add(this.btMatrix);
            this.Controls.Add(this.btIngresenomre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBoton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label btIngresenomre;
        private System.Windows.Forms.Label btMatrix;
    }
}

