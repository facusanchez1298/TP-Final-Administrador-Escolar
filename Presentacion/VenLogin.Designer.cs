namespace Presentacion
{
    partial class VenLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new MiLibreria.ErrorTxtBox();
            this.txtContraceña = new MiLibreria.ErrorTxtBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rBtnAdministrador = new System.Windows.Forms.RadioButton();
            this.rBtnProfesor = new System.Windows.Forms.RadioButton();
            this.rBtnAlumno = new System.Windows.Forms.RadioButton();
            this.lblErrorConexion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.Size = new System.Drawing.Size(344, 41);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 531);
            this.panel1.Size = new System.Drawing.Size(344, 15);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Location = new System.Drawing.Point(294, 12);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(316, 12);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(121, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(13, 316);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(306, 20);
            this.txtUsuario.SoloNumeros = true;
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Validar = true;
            // 
            // txtContraceña
            // 
            this.txtContraceña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtContraceña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraceña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraceña.ForeColor = System.Drawing.Color.White;
            this.txtContraceña.Location = new System.Drawing.Point(13, 372);
            this.txtContraceña.Name = "txtContraceña";
            this.txtContraceña.PasswordChar = '*';
            this.txtContraceña.Size = new System.Drawing.Size(306, 20);
            this.txtContraceña.SoloNumeros = false;
            this.txtContraceña.TabIndex = 1;
            this.txtContraceña.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(95, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraceña";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(26, 448);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(270, 42);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar Sesion";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.utn_logo01;
            this.pictureBox1.Location = new System.Drawing.Point(109, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // rBtnAdministrador
            // 
            this.rBtnAdministrador.AutoSize = true;
            this.rBtnAdministrador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rBtnAdministrador.Location = new System.Drawing.Point(26, 242);
            this.rBtnAdministrador.Name = "rBtnAdministrador";
            this.rBtnAdministrador.Size = new System.Drawing.Size(88, 17);
            this.rBtnAdministrador.TabIndex = 9;
            this.rBtnAdministrador.TabStop = true;
            this.rBtnAdministrador.Text = "Administrador";
            this.rBtnAdministrador.UseVisualStyleBackColor = true;
            // 
            // rBtnProfesor
            // 
            this.rBtnProfesor.AutoSize = true;
            this.rBtnProfesor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rBtnProfesor.Location = new System.Drawing.Point(137, 242);
            this.rBtnProfesor.Name = "rBtnProfesor";
            this.rBtnProfesor.Size = new System.Drawing.Size(64, 17);
            this.rBtnProfesor.TabIndex = 10;
            this.rBtnProfesor.TabStop = true;
            this.rBtnProfesor.Text = "Profesor";
            this.rBtnProfesor.UseVisualStyleBackColor = true;
            // 
            // rBtnAlumno
            // 
            this.rBtnAlumno.AutoSize = true;
            this.rBtnAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rBtnAlumno.Location = new System.Drawing.Point(236, 242);
            this.rBtnAlumno.Name = "rBtnAlumno";
            this.rBtnAlumno.Size = new System.Drawing.Size(60, 17);
            this.rBtnAlumno.TabIndex = 11;
            this.rBtnAlumno.TabStop = true;
            this.rBtnAlumno.Text = "Alumno";
            this.rBtnAlumno.UseVisualStyleBackColor = true;
            // 
            // lblErrorConexion
            // 
            this.lblErrorConexion.Image = global::Presentacion.Properties.Resources.exclamation_mark__2_;
            this.lblErrorConexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorConexion.Location = new System.Drawing.Point(12, 405);
            this.lblErrorConexion.Name = "lblErrorConexion";
            this.lblErrorConexion.Size = new System.Drawing.Size(65, 23);
            this.lblErrorConexion.TabIndex = 12;
            this.lblErrorConexion.Text = "label3";
            this.lblErrorConexion.Visible = false;
            // 
            // VenLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 546);
            this.Controls.Add(this.lblErrorConexion);
            this.Controls.Add(this.rBtnAlumno);
            this.Controls.Add(this.rBtnProfesor);
            this.Controls.Add(this.rBtnAdministrador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtContraceña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VenLogin";
            this.Opacity = 0.9D;
            this.Text = "VenLogin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VenLogin_MouseDown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.TitleBar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtContraceña, 0);
            this.Controls.SetChildIndex(this.btnIniciar, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.rBtnAdministrador, 0);
            this.Controls.SetChildIndex(this.rBtnProfesor, 0);
            this.Controls.SetChildIndex(this.rBtnAlumno, 0);
            this.Controls.SetChildIndex(this.lblErrorConexion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MiLibreria.ErrorTxtBox txtUsuario;
        private MiLibreria.ErrorTxtBox txtContraceña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rBtnAdministrador;
        private System.Windows.Forms.RadioButton rBtnProfesor;
        private System.Windows.Forms.RadioButton rBtnAlumno;
        public System.Windows.Forms.Label lblErrorConexion;
    }
}