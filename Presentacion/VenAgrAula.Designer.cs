namespace Presentacion
{
    partial class VenAgrAula
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
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxInternet = new System.Windows.Forms.ComboBox();
            this.cBoxProyector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // errorTxtBox2
            // 
            this.errorTxtBox2.SoloNumeros = true;
            this.errorTxtBox2.Validar = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(243, 55);
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.Text = "Capacidad:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            // 
            // errorTxtBox1
            // 
            this.errorTxtBox1.SoloNumeros = true;
            this.errorTxtBox1.Validar = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 9);
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.Text = "Agregar Aula";
            // 
            // TitleBar
            // 
            this.TitleBar.Size = new System.Drawing.Size(650, 40);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 308);
            this.panel1.Size = new System.Drawing.Size(650, 15);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(233, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Internet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(223, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Proyector:";
            // 
            // cBoxInternet
            // 
            this.cBoxInternet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.cBoxInternet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cBoxInternet.FormattingEnabled = true;
            this.cBoxInternet.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cBoxInternet.Location = new System.Drawing.Point(329, 142);
            this.cBoxInternet.Name = "cBoxInternet";
            this.cBoxInternet.Size = new System.Drawing.Size(210, 21);
            this.cBoxInternet.TabIndex = 13;
            // 
            // cBoxProyector
            // 
            this.cBoxProyector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.cBoxProyector.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cBoxProyector.FormattingEnabled = true;
            this.cBoxProyector.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cBoxProyector.Location = new System.Drawing.Point(329, 183);
            this.cBoxProyector.Name = "cBoxProyector";
            this.cBoxProyector.Size = new System.Drawing.Size(210, 21);
            this.cBoxProyector.TabIndex = 14;
            // 
            // VenAgrAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 323);
            this.Controls.Add(this.cBoxProyector);
            this.Controls.Add(this.cBoxInternet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "VenAgrAula";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.errorTxtBox1, 0);
            this.Controls.SetChildIndex(this.errorTxtBox2, 0);
            this.Controls.SetChildIndex(this.TitleBar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cBoxInternet, 0);
            this.Controls.SetChildIndex(this.cBoxProyector, 0);
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
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cBoxInternet;
        public System.Windows.Forms.ComboBox cBoxProyector;
    }
}