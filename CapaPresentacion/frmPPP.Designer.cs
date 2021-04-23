
namespace CapaPresentacion
{
    partial class frmPPP
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
            this.Escribir = new System.Windows.Forms.Button();
            this.btnAprender = new System.Windows.Forms.Button();
            this.btnExperiencia = new System.Windows.Forms.Button();
            this.btnTrabajar = new System.Windows.Forms.Button();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.txtCelEncargado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(318, 71);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // Escribir
            // 
            this.Escribir.Location = new System.Drawing.Point(318, 124);
            this.Escribir.Name = "Escribir";
            this.Escribir.Size = new System.Drawing.Size(75, 23);
            this.Escribir.TabIndex = 1;
            this.Escribir.Text = "Escribir";
            this.Escribir.UseVisualStyleBackColor = true;
            this.Escribir.Click += new System.EventHandler(this.Escribir_Click);
            // 
            // btnAprender
            // 
            this.btnAprender.Location = new System.Drawing.Point(36, 248);
            this.btnAprender.Name = "btnAprender";
            this.btnAprender.Size = new System.Drawing.Size(75, 23);
            this.btnAprender.TabIndex = 2;
            this.btnAprender.Text = "Aprender";
            this.btnAprender.UseVisualStyleBackColor = true;
            this.btnAprender.Click += new System.EventHandler(this.btnAprender_Click);
            // 
            // btnExperiencia
            // 
            this.btnExperiencia.Location = new System.Drawing.Point(144, 248);
            this.btnExperiencia.Name = "btnExperiencia";
            this.btnExperiencia.Size = new System.Drawing.Size(75, 23);
            this.btnExperiencia.TabIndex = 3;
            this.btnExperiencia.Text = "Experiencia";
            this.btnExperiencia.UseVisualStyleBackColor = true;
            this.btnExperiencia.Click += new System.EventHandler(this.btnExperiencia_Click);
            // 
            // btnTrabajar
            // 
            this.btnTrabajar.Location = new System.Drawing.Point(272, 248);
            this.btnTrabajar.Name = "btnTrabajar";
            this.btnTrabajar.Size = new System.Drawing.Size(75, 23);
            this.btnTrabajar.TabIndex = 4;
            this.btnTrabajar.Text = "Trabajar";
            this.btnTrabajar.UseVisualStyleBackColor = true;
            this.btnTrabajar.Click += new System.EventHandler(this.btnTrabajar_Click);
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(79, 46);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(100, 20);
            this.txtLugar.TabIndex = 5;
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(79, 96);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(100, 20);
            this.txtEncargado.TabIndex = 6;
            // 
            // txtCelEncargado
            // 
            this.txtCelEncargado.Location = new System.Drawing.Point(79, 149);
            this.txtCelEncargado.Name = "txtCelEncargado";
            this.txtCelEncargado.Size = new System.Drawing.Size(100, 20);
            this.txtCelEncargado.TabIndex = 7;
            // 
            // frmPPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 365);
            this.Controls.Add(this.txtCelEncargado);
            this.Controls.Add(this.txtEncargado);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.btnTrabajar);
            this.Controls.Add(this.btnExperiencia);
            this.Controls.Add(this.btnAprender);
            this.Controls.Add(this.Escribir);
            this.Controls.Add(this.btnLeer);
            this.Name = "frmPPP";
            this.Text = "fmrPPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button Escribir;
        private System.Windows.Forms.Button btnAprender;
        private System.Windows.Forms.Button btnExperiencia;
        private System.Windows.Forms.Button btnTrabajar;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.TextBox txtCelEncargado;
    }
}