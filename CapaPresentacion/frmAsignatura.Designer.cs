
namespace CapaPresentacion
{
    partial class frmAsignatura
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
            this.btnEstudiar = new System.Windows.Forms.Button();
            this.btnAprender = new System.Windows.Forms.Button();
            this.btnPresentarTrabajos = new System.Windows.Forms.Button();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.txtTrabajosPendientes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(346, 55);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(346, 107);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 1;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnEstudiar
            // 
            this.btnEstudiar.Location = new System.Drawing.Point(12, 213);
            this.btnEstudiar.Name = "btnEstudiar";
            this.btnEstudiar.Size = new System.Drawing.Size(75, 23);
            this.btnEstudiar.TabIndex = 2;
            this.btnEstudiar.Text = "Estudiar";
            this.btnEstudiar.UseVisualStyleBackColor = true;
            this.btnEstudiar.Click += new System.EventHandler(this.btnEstudiar_Click);
            // 
            // btnAprender
            // 
            this.btnAprender.Location = new System.Drawing.Point(122, 213);
            this.btnAprender.Name = "btnAprender";
            this.btnAprender.Size = new System.Drawing.Size(75, 23);
            this.btnAprender.TabIndex = 3;
            this.btnAprender.Text = "Aprender";
            this.btnAprender.UseVisualStyleBackColor = true;
            this.btnAprender.Click += new System.EventHandler(this.btnAprender_Click);
            // 
            // btnPresentarTrabajos
            // 
            this.btnPresentarTrabajos.Location = new System.Drawing.Point(243, 213);
            this.btnPresentarTrabajos.Name = "btnPresentarTrabajos";
            this.btnPresentarTrabajos.Size = new System.Drawing.Size(111, 23);
            this.btnPresentarTrabajos.TabIndex = 4;
            this.btnPresentarTrabajos.Text = "Presentar Trabajos";
            this.btnPresentarTrabajos.UseVisualStyleBackColor = true;
            this.btnPresentarTrabajos.Click += new System.EventHandler(this.btnPresentarTrabajos_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(94, 32);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(162, 20);
            this.txtNombres.TabIndex = 5;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(94, 70);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(162, 20);
            this.txtHoras.TabIndex = 6;
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(94, 110);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(162, 20);
            this.txtCreditos.TabIndex = 7;
            // 
            // txtTrabajosPendientes
            // 
            this.txtTrabajosPendientes.Location = new System.Drawing.Point(94, 150);
            this.txtTrabajosPendientes.Name = "txtTrabajosPendientes";
            this.txtTrabajosPendientes.Size = new System.Drawing.Size(162, 20);
            this.txtTrabajosPendientes.TabIndex = 8;
            // 
            // fmrAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 309);
            this.Controls.Add(this.txtTrabajosPendientes);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.btnPresentarTrabajos);
            this.Controls.Add(this.btnAprender);
            this.Controls.Add(this.btnEstudiar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Name = "fmrAsignatura";
            this.Text = "fmrAsignatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnEstudiar;
        private System.Windows.Forms.Button btnAprender;
        private System.Windows.Forms.Button btnPresentarTrabajos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.TextBox txtTrabajosPendientes;
    }
}