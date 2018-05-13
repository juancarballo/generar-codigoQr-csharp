namespace GenerarQR
{
    partial class frm_principal
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
            this.pn_generador = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_generar_qr = new System.Windows.Forms.Button();
            this.tb_texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pn_generador
            // 
            this.pn_generador.BackColor = System.Drawing.Color.DarkCyan;
            this.pn_generador.Location = new System.Drawing.Point(16, 15);
            this.pn_generador.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pn_generador.Name = "pn_generador";
            this.pn_generador.Size = new System.Drawing.Size(400, 400);
            this.pn_generador.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 553);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_generar_qr
            // 
            this.btn_generar_qr.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar_qr.Location = new System.Drawing.Point(258, 505);
            this.btn_generar_qr.Name = "btn_generar_qr";
            this.btn_generar_qr.Size = new System.Drawing.Size(158, 31);
            this.btn_generar_qr.TabIndex = 2;
            this.btn_generar_qr.Text = "Generar QR";
            this.btn_generar_qr.UseVisualStyleBackColor = true;
            this.btn_generar_qr.Click += new System.EventHandler(this.btn_generar_qr_Click);
            // 
            // tb_texto
            // 
            this.tb_texto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_texto.Location = new System.Drawing.Point(15, 423);
            this.tb_texto.MaxLength = 65;
            this.tb_texto.Multiline = true;
            this.tb_texto.Name = "tb_texto";
            this.tb_texto.Size = new System.Drawing.Size(400, 76);
            this.tb_texto.TabIndex = 1;
            this.tb_texto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(428, 549);
            this.Controls.Add(this.tb_texto);
            this.Controls.Add(this.btn_generar_qr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pn_generador);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_principal";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de código QR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_generador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_generar_qr;
        private System.Windows.Forms.TextBox tb_texto;
    }
}

