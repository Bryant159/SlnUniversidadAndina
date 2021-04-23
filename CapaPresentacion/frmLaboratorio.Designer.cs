
namespace CapaPresentacion
{
    partial class frmLaboratorio
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnInvestigar = new System.Windows.Forms.Button();
            this.btnObservar = new System.Windows.Forms.Button();
            this.btnAprender = new System.Windows.Forms.Button();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtAforo = new System.Windows.Forms.TextBox();
            this.txtCantHerramientas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(308, 58);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(308, 116);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 1;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnInvestigar
            // 
            this.btnInvestigar.Location = new System.Drawing.Point(21, 230);
            this.btnInvestigar.Name = "btnInvestigar";
            this.btnInvestigar.Size = new System.Drawing.Size(75, 23);
            this.btnInvestigar.TabIndex = 2;
            this.btnInvestigar.Text = "Investigar";
            this.btnInvestigar.UseVisualStyleBackColor = true;
            this.btnInvestigar.Click += new System.EventHandler(this.btnInvestigar_Click);
            // 
            // btnObservar
            // 
            this.btnObservar.Location = new System.Drawing.Point(132, 230);
            this.btnObservar.Name = "btnObservar";
            this.btnObservar.Size = new System.Drawing.Size(75, 23);
            this.btnObservar.TabIndex = 3;
            this.btnObservar.Text = "Observar";
            this.btnObservar.UseVisualStyleBackColor = true;
            this.btnObservar.Click += new System.EventHandler(this.btnObservar_Click);
            // 
            // btnAprender
            // 
            this.btnAprender.Location = new System.Drawing.Point(238, 230);
            this.btnAprender.Name = "btnAprender";
            this.btnAprender.Size = new System.Drawing.Size(75, 23);
            this.btnAprender.TabIndex = 4;
            this.btnAprender.Text = "Aprender";
            this.btnAprender.UseVisualStyleBackColor = true;
            this.btnAprender.Click += new System.EventHandler(this.btnAprender_Click);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(66, 49);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(141, 20);
            this.txtUbicacion.TabIndex = 5;
            // 
            // txtAforo
            // 
            this.txtAforo.Location = new System.Drawing.Point(66, 88);
            this.txtAforo.Name = "txtAforo";
            this.txtAforo.Size = new System.Drawing.Size(141, 20);
            this.txtAforo.TabIndex = 6;
            // 
            // txtCantHerramientas
            // 
            this.txtCantHerramientas.Location = new System.Drawing.Point(66, 132);
            this.txtCantHerramientas.Name = "txtCantHerramientas";
            this.txtCantHerramientas.Size = new System.Drawing.Size(141, 20);
            this.txtCantHerramientas.TabIndex = 7;
            // 
            // fmrLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 309);
            this.Controls.Add(this.txtCantHerramientas);
            this.Controls.Add(this.txtAforo);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.btnAprender);
            this.Controls.Add(this.btnObservar);
            this.Controls.Add(this.btnInvestigar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Name = "fmrLaboratorio";
            this.Text = "fmrLaboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnInvestigar;
        private System.Windows.Forms.Button btnObservar;
        private System.Windows.Forms.Button btnAprender;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtAforo;
        private System.Windows.Forms.TextBox txtCantHerramientas;
    }
}