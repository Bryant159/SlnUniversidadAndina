
namespace CapaPresentacion
{
    partial class frmDocente
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
            this.btnEnseñar = new System.Windows.Forms.Button();
            this.btnTrabajar = new System.Windows.Forms.Button();
            this.btnAprobarAlumno = new System.Windows.Forms.Button();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtLugarLaboral = new System.Windows.Forms.TextBox();
            this.btnDesaprobarAlumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(479, 72);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(479, 128);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 1;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnEnseñar
            // 
            this.btnEnseñar.Location = new System.Drawing.Point(41, 288);
            this.btnEnseñar.Name = "btnEnseñar";
            this.btnEnseñar.Size = new System.Drawing.Size(75, 23);
            this.btnEnseñar.TabIndex = 2;
            this.btnEnseñar.Text = "Enseñar";
            this.btnEnseñar.UseVisualStyleBackColor = true;
            this.btnEnseñar.Click += new System.EventHandler(this.btnEnseñar_Click);
            // 
            // btnTrabajar
            // 
            this.btnTrabajar.Location = new System.Drawing.Point(143, 288);
            this.btnTrabajar.Name = "btnTrabajar";
            this.btnTrabajar.Size = new System.Drawing.Size(75, 23);
            this.btnTrabajar.TabIndex = 3;
            this.btnTrabajar.Text = "Trabajar";
            this.btnTrabajar.UseVisualStyleBackColor = true;
            this.btnTrabajar.Click += new System.EventHandler(this.btnTrabajar_Click);
            // 
            // btnAprobarAlumno
            // 
            this.btnAprobarAlumno.Location = new System.Drawing.Point(250, 288);
            this.btnAprobarAlumno.Name = "btnAprobarAlumno";
            this.btnAprobarAlumno.Size = new System.Drawing.Size(95, 23);
            this.btnAprobarAlumno.TabIndex = 4;
            this.btnAprobarAlumno.Text = "Aprobar Alumno";
            this.btnAprobarAlumno.UseVisualStyleBackColor = true;
            this.btnAprobarAlumno.Click += new System.EventHandler(this.btnAprobarAlumno_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(143, 58);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(144, 20);
            this.txtApellidos.TabIndex = 5;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(143, 101);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(144, 20);
            this.txtNombres.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(143, 143);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(144, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // txtLugarLaboral
            // 
            this.txtLugarLaboral.Location = new System.Drawing.Point(143, 182);
            this.txtLugarLaboral.Name = "txtLugarLaboral";
            this.txtLugarLaboral.Size = new System.Drawing.Size(144, 20);
            this.txtLugarLaboral.TabIndex = 8;
            // 
            // btnDesaprobarAlumno
            // 
            this.btnDesaprobarAlumno.Location = new System.Drawing.Point(366, 288);
            this.btnDesaprobarAlumno.Name = "btnDesaprobarAlumno";
            this.btnDesaprobarAlumno.Size = new System.Drawing.Size(111, 23);
            this.btnDesaprobarAlumno.TabIndex = 9;
            this.btnDesaprobarAlumno.Text = "Desaprobar Alumno";
            this.btnDesaprobarAlumno.UseVisualStyleBackColor = true;
            this.btnDesaprobarAlumno.Click += new System.EventHandler(this.btnDesaprobarAlumno_Click);
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 397);
            this.Controls.Add(this.btnDesaprobarAlumno);
            this.Controls.Add(this.txtLugarLaboral);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.btnAprobarAlumno);
            this.Controls.Add(this.btnTrabajar);
            this.Controls.Add(this.btnEnseñar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Name = "frmDocente";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnEnseñar;
        private System.Windows.Forms.Button btnTrabajar;
        private System.Windows.Forms.Button btnAprobarAlumno;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtLugarLaboral;
        private System.Windows.Forms.Button btnDesaprobarAlumno;
    }
}