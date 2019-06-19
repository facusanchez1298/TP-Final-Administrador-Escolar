namespace Presentacion
{
    partial class VentAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentAdministrador));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnProf = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPanel
            // 
            this.btnPanel.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Location = new System.Drawing.Point(841, 12);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(841, 12);
            // 
            // btnMaterias
            // 
            this.btnMaterias.FlatAppearance.BorderSize = 0;
            this.btnMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnMaterias.Image = global::Presentacion.Properties.Resources.book;
            this.btnMaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterias.Location = new System.Drawing.Point(3, 101);
            this.btnMaterias.Size = new System.Drawing.Size(247, 40);
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnPersonal.Image = global::Presentacion.Properties.Resources.empleados;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Location = new System.Drawing.Point(0, 239);
            this.btnPersonal.Size = new System.Drawing.Size(256, 40);
            this.btnPersonal.Text = "      Cambiar Contraseña";
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnAulas
            // 
            this.btnAulas.FlatAppearance.BorderSize = 0;
            this.btnAulas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnAulas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnAulas.Image = global::Presentacion.Properties.Resources.university;
            this.btnAulas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAulas.Location = new System.Drawing.Point(0, 5);
            this.btnAulas.Size = new System.Drawing.Size(250, 40);
            this.btnAulas.Click += new System.EventHandler(this.btnAulas_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.Controls.Add(this.btnCursos);
            this.MenuVertical.Controls.Add(this.btnProf);
            this.MenuVertical.Controls.Add(this.btnAlumnos);
            this.MenuVertical.Controls.SetChildIndex(this.btnCerrarSesion, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnAulas, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnPersonal, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnMaterias, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnAlumnos, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnProf, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnCursos, 0);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCerrarSesion.Image = global::Presentacion.Properties.Resources.sign_out__1_;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 417);
            this.btnCerrarSesion.Size = new System.Drawing.Size(250, 48);
            // 
            // TitleBar
            // 
            this.TitleBar.Controls.Add(this.pictureBox2);
            this.TitleBar.Controls.SetChildIndex(this.btnMaximizar, 0);
            this.TitleBar.Controls.SetChildIndex(this.btnRestaurar, 0);
            this.TitleBar.Controls.SetChildIndex(this.btnCerrar, 0);
            this.TitleBar.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.TitleBar.Controls.SetChildIndex(this.btnPanel, 0);
            this.TitleBar.Controls.SetChildIndex(this.pictureBox2, 0);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Location = new System.Drawing.Point(819, 12);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(863, 12);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.producto;
            this.pictureBox2.Location = new System.Drawing.Point(12, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlumnos.Image = global::Presentacion.Properties.Resources.student__3_;
            this.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.Location = new System.Drawing.Point(0, 147);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(250, 40);
            this.btnAlumnos.TabIndex = 3;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnProf
            // 
            this.btnProf.FlatAppearance.BorderSize = 0;
            this.btnProf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnProf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProf.Image = global::Presentacion.Properties.Resources.teacher__1_;
            this.btnProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProf.Location = new System.Drawing.Point(0, 193);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(250, 40);
            this.btnProf.TabIndex = 4;
            this.btnProf.Text = "Profesores";
            this.btnProf.UseVisualStyleBackColor = true;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCursos.Image = global::Presentacion.Properties.Resources.clientes;
            this.btnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursos.Location = new System.Drawing.Point(-6, 51);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(256, 40);
            this.btnCursos.TabIndex = 6;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // VentAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 520);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentAdministrador";
            this.Opacity = 1D;
            this.Text = "VentAdministrador";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button btnProf;
        public System.Windows.Forms.Button btnAlumnos;
        public System.Windows.Forms.Button btnCursos;
    }
}