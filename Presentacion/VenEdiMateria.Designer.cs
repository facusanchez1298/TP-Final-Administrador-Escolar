namespace Presentacion
{
    partial class VenEdiMateria
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
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxProfesor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // errorTxtBox2
            // 
            this.errorTxtBox2.Validar = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(283, 55);
            this.label1.Size = new System.Drawing.Size(31, 24);
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(240, 98);
            this.label2.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Location = new System.Drawing.Point(197, 272);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(382, 272);
            // 
            // errorTxtBox1
            // 
            this.errorTxtBox1.SoloNumeros = true;
            this.errorTxtBox1.Validar = true;
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.Text = "Agregar Materia";
            // 
            // TitleBar
            // 
            this.TitleBar.Size = new System.Drawing.Size(588, 40);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 340);
            this.panel1.Size = new System.Drawing.Size(588, 15);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(240, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Profesor:";
            // 
            // cBoxProfesor
            // 
            this.cBoxProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.cBoxProfesor.ForeColor = System.Drawing.Color.White;
            this.cBoxProfesor.FormattingEnabled = true;
            this.cBoxProfesor.Location = new System.Drawing.Point(329, 139);
            this.cBoxProfesor.Name = "cBoxProfesor";
            this.cBoxProfesor.Size = new System.Drawing.Size(210, 21);
            this.cBoxProfesor.TabIndex = 12;
            // 
            // VenEdiMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(588, 355);
            this.Controls.Add(this.cBoxProfesor);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "VenEdiMateria";
            this.Text = "VenAgrMateria";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.errorTxtBox1, 0);
            this.Controls.SetChildIndex(this.errorTxtBox2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.TitleBar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cBoxProfesor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cBoxProfesor;
    }
}