namespace CentralTelefonica
{
    partial class FrmMenu
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
            this.btnGenerarLlamada = new System.Windows.Forms.Button();
            this.btnFactTotal = new System.Windows.Forms.Button();
            this.btnFacturacionLocal = new System.Windows.Forms.Button();
            this.btnFacturacionProv = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            this.btnGenerarLlamada.Location = new System.Drawing.Point(12, 24);
            this.btnGenerarLlamada.Name = "btnGenerarLlamada";
            this.btnGenerarLlamada.Size = new System.Drawing.Size(301, 55);
            this.btnGenerarLlamada.TabIndex = 0;
            this.btnGenerarLlamada.Text = "Generar Llamada";
            this.btnGenerarLlamada.UseVisualStyleBackColor = true;
            this.btnGenerarLlamada.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFactTotal
            // 
            this.btnFactTotal.Location = new System.Drawing.Point(12, 85);
            this.btnFactTotal.Name = "btnFactTotal";
            this.btnFactTotal.Size = new System.Drawing.Size(301, 55);
            this.btnFactTotal.TabIndex = 1;
            this.btnFactTotal.Text = "Facturacion Total";
            this.btnFactTotal.UseVisualStyleBackColor = true;
            // 
            // btnFacturacionLocal
            // 
            this.btnFacturacionLocal.Location = new System.Drawing.Point(12, 146);
            this.btnFacturacionLocal.Name = "btnFacturacionLocal";
            this.btnFacturacionLocal.Size = new System.Drawing.Size(301, 55);
            this.btnFacturacionLocal.TabIndex = 2;
            this.btnFacturacionLocal.Text = "Facturacion Local";
            this.btnFacturacionLocal.UseVisualStyleBackColor = true;
            // 
            // btnFacturacionProv
            // 
            this.btnFacturacionProv.Location = new System.Drawing.Point(12, 207);
            this.btnFacturacionProv.Name = "btnFacturacionProv";
            this.btnFacturacionProv.Size = new System.Drawing.Size(301, 55);
            this.btnFacturacionProv.TabIndex = 3;
            this.btnFacturacionProv.Text = "Facturacion Provincial";
            this.btnFacturacionProv.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(12, 268);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(301, 55);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 335);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.btnFacturacionProv);
            this.Controls.Add(this.btnFacturacionLocal);
            this.Controls.Add(this.btnFactTotal);
            this.Controls.Add(this.btnGenerarLlamada);
            this.Name = "FrmMenu";
            this.Text = "Central Telefonica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarLlamada;
        private System.Windows.Forms.Button btnFactTotal;
        private System.Windows.Forms.Button btnFacturacionLocal;
        private System.Windows.Forms.Button btnFacturacionProv;
        private System.Windows.Forms.Button Salir;
    }
}