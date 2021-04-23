
namespace CapaPresentacion
{
    partial class frmNotas
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
            this.btnAprobado = new System.Windows.Forms.Button();
            this.btnDesaprobado = new System.Windows.Forms.Button();
            this.btnDispensado = new System.Windows.Forms.Button();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtCodAlumno = new System.Windows.Forms.TextBox();
            this.txtCantNotas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(313, 72);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(313, 121);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 1;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAprobado
            // 
            this.btnAprobado.Location = new System.Drawing.Point(31, 249);
            this.btnAprobado.Name = "btnAprobado";
            this.btnAprobado.Size = new System.Drawing.Size(75, 23);
            this.btnAprobado.TabIndex = 2;
            this.btnAprobado.Text = "Aprobado";
            this.btnAprobado.UseVisualStyleBackColor = true;
            this.btnAprobado.Click += new System.EventHandler(this.btnAprobado_Click);
            // 
            // btnDesaprobado
            // 
            this.btnDesaprobado.Location = new System.Drawing.Point(147, 249);
            this.btnDesaprobado.Name = "btnDesaprobado";
            this.btnDesaprobado.Size = new System.Drawing.Size(80, 23);
            this.btnDesaprobado.TabIndex = 3;
            this.btnDesaprobado.Text = "Desaprobado";
            this.btnDesaprobado.UseVisualStyleBackColor = true;
            this.btnDesaprobado.Click += new System.EventHandler(this.btnDesaprobado_Click);
            // 
            // btnDispensado
            // 
            this.btnDispensado.Location = new System.Drawing.Point(266, 249);
            this.btnDispensado.Name = "btnDispensado";
            this.btnDispensado.Size = new System.Drawing.Size(75, 23);
            this.btnDispensado.TabIndex = 4;
            this.btnDispensado.Text = "Dispensado";
            this.btnDispensado.UseVisualStyleBackColor = true;
            this.btnDispensado.Click += new System.EventHandler(this.btnDispensado_Click);
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(78, 43);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(129, 20);
            this.txtCurso.TabIndex = 5;
            // 
            // txtCodAlumno
            // 
            this.txtCodAlumno.Location = new System.Drawing.Point(78, 89);
            this.txtCodAlumno.Name = "txtCodAlumno";
            this.txtCodAlumno.Size = new System.Drawing.Size(129, 20);
            this.txtCodAlumno.TabIndex = 6;
            // 
            // txtCantNotas
            // 
            this.txtCantNotas.Location = new System.Drawing.Point(78, 137);
            this.txtCantNotas.Name = "txtCantNotas";
            this.txtCantNotas.Size = new System.Drawing.Size(129, 20);
            this.txtCantNotas.TabIndex = 7;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 370);
            this.Controls.Add(this.txtCantNotas);
            this.Controls.Add(this.txtCodAlumno);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.btnDispensado);
            this.Controls.Add(this.btnDesaprobado);
            this.Controls.Add(this.btnAprobado);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Name = "frmNotas";
            this.Text = "fmrNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnAprobado;
        private System.Windows.Forms.Button btnDesaprobado;
        private System.Windows.Forms.Button btnDispensado;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtCodAlumno;
        private System.Windows.Forms.TextBox txtCantNotas;
    }
}