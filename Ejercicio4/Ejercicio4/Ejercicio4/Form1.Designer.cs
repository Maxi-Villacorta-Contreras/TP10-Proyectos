namespace Ejercicio4
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
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.etLetra = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.etVocal = new System.Windows.Forms.Label();
            this.etNovocal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMuestra
            // 
            this.txtMuestra.Location = new System.Drawing.Point(248, 48);
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(100, 20);
            this.txtMuestra.TabIndex = 0;
            // 
            // etLetra
            // 
            this.etLetra.AutoSize = true;
            this.etLetra.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etLetra.ForeColor = System.Drawing.SystemColors.Highlight;
            this.etLetra.Location = new System.Drawing.Point(64, 45);
            this.etLetra.Name = "etLetra";
            this.etLetra.Size = new System.Drawing.Size(169, 24);
            this.etLetra.TabIndex = 1;
            this.etLetra.Text = "Ingrese una letra:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Perpetua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnIngresar.Location = new System.Drawing.Point(248, 86);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(79, 33);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // etVocal
            // 
            this.etVocal.AutoSize = true;
            this.etVocal.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etVocal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.etVocal.Location = new System.Drawing.Point(141, 139);
            this.etVocal.Name = "etVocal";
            this.etVocal.Size = new System.Drawing.Size(56, 22);
            this.etVocal.TabIndex = 3;
            this.etVocal.Text = "Vocal";
            // 
            // etNovocal
            // 
            this.etNovocal.AutoSize = true;
            this.etNovocal.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etNovocal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.etNovocal.Location = new System.Drawing.Point(351, 139);
            this.etNovocal.Name = "etNovocal";
            this.etNovocal.Size = new System.Drawing.Size(81, 22);
            this.etNovocal.TabIndex = 4;
            this.etNovocal.Text = "No vocal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 261);
            this.Controls.Add(this.etNovocal);
            this.Controls.Add(this.etVocal);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.etLetra);
            this.Controls.Add(this.txtMuestra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMuestra;
        private System.Windows.Forms.Label etLetra;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label etVocal;
        private System.Windows.Forms.Label etNovocal;
    }
}

