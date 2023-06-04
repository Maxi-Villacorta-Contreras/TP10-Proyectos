namespace Ejercicio6
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
            this.btnIngresarcapacidad = new System.Windows.Forms.Button();
            this.txtMuestre = new System.Windows.Forms.TextBox();
            this.etCDs = new System.Windows.Forms.Label();
            this.etResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresarcapacidad
            // 
            this.btnIngresarcapacidad.Font = new System.Drawing.Font("Perpetua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarcapacidad.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnIngresarcapacidad.Location = new System.Drawing.Point(204, 108);
            this.btnIngresarcapacidad.Name = "btnIngresarcapacidad";
            this.btnIngresarcapacidad.Size = new System.Drawing.Size(118, 46);
            this.btnIngresarcapacidad.TabIndex = 0;
            this.btnIngresarcapacidad.Text = "Ingresar la capacidad";
            this.btnIngresarcapacidad.UseVisualStyleBackColor = true;
            this.btnIngresarcapacidad.Click += new System.EventHandler(this.btnIngresarcapacidad_Click);
            // 
            // txtMuestre
            // 
            this.txtMuestre.Location = new System.Drawing.Point(261, 40);
            this.txtMuestre.Name = "txtMuestre";
            this.txtMuestre.Size = new System.Drawing.Size(100, 20);
            this.txtMuestre.TabIndex = 1;
            // 
            // etCDs
            // 
            this.etCDs.AutoSize = true;
            this.etCDs.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etCDs.Location = new System.Drawing.Point(30, 38);
            this.etCDs.Name = "etCDs";
            this.etCDs.Size = new System.Drawing.Size(225, 22);
            this.etCDs.TabIndex = 2;
            this.etCDs.Text = "Calcule el numero de CDs:";
            // 
            // etResultado
            // 
            this.etResultado.AutoSize = true;
            this.etResultado.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etResultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.etResultado.Location = new System.Drawing.Point(82, 184);
            this.etResultado.Name = "etResultado";
            this.etResultado.Size = new System.Drawing.Size(62, 15);
            this.etResultado.TabIndex = 3;
            this.etResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 261);
            this.Controls.Add(this.etResultado);
            this.Controls.Add(this.etCDs);
            this.Controls.Add(this.txtMuestre);
            this.Controls.Add(this.btnIngresarcapacidad);
            this.Name = "Form1";
            this.Text = "MaxiVillacorta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarcapacidad;
        private System.Windows.Forms.TextBox txtMuestre;
        private System.Windows.Forms.Label etCDs;
        private System.Windows.Forms.Label etResultado;
    }
}

