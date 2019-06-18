namespace Presentacion
{
    partial class VentProfesor
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
            this.btnCargarExamenes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelformularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Location = new System.Drawing.Point(768, 12);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(768, 12);
            // 
            // btnMaterias
            // 
            this.btnMaterias.FlatAppearance.BorderSize = 0;
            this.btnMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnMaterias.Image = global::Presentacion.Properties.Resources.book;
            this.btnMaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterias.Location = new System.Drawing.Point(0, 60);
            this.btnMaterias.Size = new System.Drawing.Size(250, 48);
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnPersonal.Image = global::Presentacion.Properties.Resources.empleados;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Location = new System.Drawing.Point(-7, 114);
            this.btnPersonal.Size = new System.Drawing.Size(257, 48);
            this.btnPersonal.Text = "  Cambiar Contraseña";
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnAulas
            // 
            this.btnAulas.FlatAppearance.BorderSize = 0;
            this.btnAulas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnAulas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnAulas.Image = global::Presentacion.Properties.Resources.university;
            this.btnAulas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAulas.Location = new System.Drawing.Point(0, 6);
            this.btnAulas.Size = new System.Drawing.Size(250, 48);
            this.btnAulas.Click += new System.EventHandler(this.btnAulas_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.Controls.Add(this.btnCargarExamenes);
            this.MenuVertical.Size = new System.Drawing.Size(250, 451);
            this.MenuVertical.Controls.SetChildIndex(this.btnAulas, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnPersonal, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnMaterias, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnCerrarSesion, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnCargarExamenes, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(568, 451);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCerrarSesion.Image = global::Presentacion.Properties.Resources.sign_out__1_;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 397);
            this.btnCerrarSesion.Size = new System.Drawing.Size(250, 48);
            // 
            // panelformularios
            // 
            this.panelformularios.Size = new System.Drawing.Size(568, 451);
            // 
            // TitleBar
            // 
            this.TitleBar.Size = new System.Drawing.Size(818, 40);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 491);
            this.panel1.Size = new System.Drawing.Size(818, 15);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Location = new System.Drawing.Point(602, 12);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(646, 12);
            // 
            // btnCargarExamenes
            // 
            this.btnCargarExamenes.FlatAppearance.BorderSize = 0;
            this.btnCargarExamenes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnCargarExamenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCargarExamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarExamenes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarExamenes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCargarExamenes.Image = global::Presentacion.Properties.Resources.upload_file;
            this.btnCargarExamenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarExamenes.Location = new System.Drawing.Point(0, 168);
            this.btnCargarExamenes.Name = "btnCargarExamenes";
            this.btnCargarExamenes.Size = new System.Drawing.Size(250, 43);
            this.btnCargarExamenes.TabIndex = 4;
            this.btnCargarExamenes.Text = "Cargas Examenes";
            this.btnCargarExamenes.UseVisualStyleBackColor = true;
            this.btnCargarExamenes.Click += new System.EventHandler(this.btnCargarExamenes_Click);
            // 
            // VentProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 506);
            this.Name = "VentProfesor";
            this.Text = "VentProfesor";
            ((System.ComponentModel.ISupportInitialize)(this.btnPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelformularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarExamenes;
    }
}