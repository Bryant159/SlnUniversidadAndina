
namespace CapaPresentacion
{
    partial class frmRector
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
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnApoyar = new System.Windows.Forms.Button();
            this.btnTrabajar = new System.Windows.Forms.Button();
            this.btnDarIndicaciones = new System.Windows.Forms.Button();
            this.txtAñoRectorado = new System.Windows.Forms.TextBox();
            this.btnHacerActividades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(281, 85);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(281, 169);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 1;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(94, 66);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(94, 107);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 3;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(94, 152);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 4;
            // 
            // btnApoyar
            // 
            this.btnApoyar.Location = new System.Drawing.Point(12, 274);
            this.btnApoyar.Name = "btnApoyar";
            this.btnApoyar.Size = new System.Drawing.Size(75, 23);
            this.btnApoyar.TabIndex = 5;
            this.btnApoyar.Text = "Apoyar";
            this.btnApoyar.UseVisualStyleBackColor = true;
            this.btnApoyar.Click += new System.EventHandler(this.btnApoyar_Click);
            // 
            // btnTrabajar
            // 
            this.btnTrabajar.Location = new System.Drawing.Point(109, 274);
            this.btnTrabajar.Name = "btnTrabajar";
            this.btnTrabajar.Size = new System.Drawing.Size(75, 23);
            this.btnTrabajar.TabIndex = 6;
            this.btnTrabajar.Text = "Trabajar";
            this.btnTrabajar.UseVisualStyleBackColor = true;
            this.btnTrabajar.Click += new System.EventHandler(this.btnTrabajar_Click);
            // 
            // btnDarIndicaciones
            // 
            this.btnDarIndicaciones.Location = new System.Drawing.Point(205, 274);
            this.btnDarIndicaciones.Name = "btnDarIndicaciones";
            this.btnDarIndicaciones.Size = new System.Drawing.Size(97, 23);
            this.btnDarIndicaciones.TabIndex = 7;
            this.btnDarIndicaciones.Text = "Dar Indicaciones";
            this.btnDarIndicaciones.UseVisualStyleBackColor = true;
            this.btnDarIndicaciones.Click += new System.EventHandler(this.btnDarIndicaciones_Click);
            // 
            // txtAñoRectorado
            // 
            this.txtAñoRectorado.Location = new System.Drawing.Point(94, 199);
            this.txtAñoRectorado.Name = "txtAñoRectorado";
            this.txtAñoRectorado.Size = new System.Drawing.Size(100, 20);
            this.txtAñoRectorado.TabIndex = 8;
            // 
            // btnHacerActividades
            // 
            this.btnHacerActividades.Location = new System.Drawing.Point(325, 274);
            this.btnHacerActividades.Name = "btnHacerActividades";
            this.btnHacerActividades.Size = new System.Drawing.Size(107, 23);
            this.btnHacerActividades.TabIndex = 9;
            this.btnHacerActividades.Text = "Hacer Actividades";
            this.btnHacerActividades.UseVisualStyleBackColor = true;
            this.btnHacerActividades.Click += new System.EventHandler(this.btnHacerActividades_Click);
            // 
            // frmRector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 374);
            this.Controls.Add(this.btnHacerActividades);
            this.Controls.Add(this.txtAñoRectorado);
            this.Controls.Add(this.btnDarIndicaciones);
            this.Controls.Add(this.btnTrabajar);
            this.Controls.Add(this.btnApoyar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Name = "frmRector";
            this.Text = "fmrRector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnApoyar;
        private System.Windows.Forms.Button btnTrabajar;
        private System.Windows.Forms.Button btnDarIndicaciones;
        private System.Windows.Forms.TextBox txtAñoRectorado;
        private System.Windows.Forms.Button btnHacerActividades;
    }
}