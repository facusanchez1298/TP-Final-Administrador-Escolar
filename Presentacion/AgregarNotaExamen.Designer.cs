namespace Presentacion
{
    partial class AgregarNotaExamen
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
            this.buttonSubirNota = new System.Windows.Forms.Button();
            this.buttonEditarNota = new System.Windows.Forms.Button();
            this.selector = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nota = new MiLibreria.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 243);
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.Tag = "Agregar";
            this.label1.Text = "Nota";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.add_file__1_;
            this.pictureBox1.Location = new System.Drawing.Point(494, 65);
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(494, 368);
            this.btnSalir.Size = new System.Drawing.Size(140, 42);
            this.btnSalir.TabIndex = 5;
            // 
            // buttonSubirNota
            // 
            this.buttonSubirNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubirNota.AutoSize = true;
            this.buttonSubirNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.buttonSubirNota.FlatAppearance.BorderSize = 0;
            this.buttonSubirNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubirNota.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubirNota.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSubirNota.Image = global::Presentacion.Properties.Resources.upload_file;
            this.buttonSubirNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubirNota.Location = new System.Drawing.Point(494, 268);
            this.buttonSubirNota.Name = "buttonSubirNota";
            this.buttonSubirNota.Size = new System.Drawing.Size(140, 38);
            this.buttonSubirNota.TabIndex = 3;
            this.buttonSubirNota.Tag = "Agregar";
            this.buttonSubirNota.Text = " Subir Nota";
            this.buttonSubirNota.UseVisualStyleBackColor = false;
            this.buttonSubirNota.Click += new System.EventHandler(this.buttonSubirNota_Click);
            // 
            // buttonEditarNota
            // 
            this.buttonEditarNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditarNota.AutoSize = true;
            this.buttonEditarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.buttonEditarNota.FlatAppearance.BorderSize = 0;
            this.buttonEditarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarNota.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarNota.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEditarNota.Image = global::Presentacion.Properties.Resources.edit;
            this.buttonEditarNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarNota.Location = new System.Drawing.Point(494, 312);
            this.buttonEditarNota.Name = "buttonEditarNota";
            this.buttonEditarNota.Size = new System.Drawing.Size(140, 38);
            this.buttonEditarNota.TabIndex = 4;
            this.buttonEditarNota.Tag = "Agregar";
            this.buttonEditarNota.Text = "   Editar Nota";
            this.buttonEditarNota.UseVisualStyleBackColor = false;
            // 
            // selector
            // 
            this.selector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selector.Items.Add("1 examen");
            this.selector.Items.Add("2 examen");
            this.selector.Items.Add("3 examen");
            this.selector.Items.Add("1 recuperatorio");
            this.selector.Items.Add("2 recuperatorio");
            this.selector.Location = new System.Drawing.Point(494, 216);
            this.selector.Name = "selector";
            this.selector.ReadOnly = true;
            this.selector.Size = new System.Drawing.Size(140, 20);
            this.selector.TabIndex = 1;
            this.selector.Tag = "Agregar";
            this.selector.Text = "domainUpDown1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(36, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agregar Notas";
            // 
            // nota
            // 
            this.nota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nota.Location = new System.Drawing.Point(542, 242);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(92, 20);
            this.nota.SoloNumeros = true;
            this.nota.TabIndex = 6;
            this.nota.Tag = "Agregar";
            this.nota.Validar = true;
            // 
            // AgregarNotaExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.buttonEditarNota);
            this.Controls.Add(this.buttonSubirNota);
            this.Name = "AgregarNotaExamen";
            this.Text = "AgregarNotaExamen";
            this.Controls.SetChildIndex(this.buttonSubirNota, 0);
            this.Controls.SetChildIndex(this.buttonEditarNota, 0);
            this.Controls.SetChildIndex(this.selector, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.nota, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonSubirNota;
        public System.Windows.Forms.Button buttonEditarNota;
        private System.Windows.Forms.DomainUpDown selector;
        public System.Windows.Forms.Label label2;
        private MiLibreria.ErrorTxtBox nota;
    }
}