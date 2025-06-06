namespace ProyectoMotaFinal
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIP = new TextBox();
            txtPuerto = new TextBox();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            btnGuardar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label1.Location = new Point(231, 54);
            label1.Name = "label1";
            label1.Size = new Size(30, 27);
            label1.TabIndex = 0;
            label1.Text = "IP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label2.Location = new Point(359, 142);
            label2.Name = "label2";
            label2.Size = new Size(118, 27);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label3.Location = new Point(374, 54);
            label3.Name = "label3";
            label3.Size = new Size(75, 27);
            label3.TabIndex = 2;
            label3.Text = "Puerto";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label4.Location = new Point(206, 142);
            label4.Name = "label4";
            label4.Size = new Size(84, 27);
            label4.TabIndex = 3;
            label4.Text = "Usuario";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIP
            // 
            txtIP.Font = new Font("Microsoft New Tai Lue", 12F);
            txtIP.Location = new Point(188, 78);
            txtIP.Margin = new Padding(3, 4, 3, 4);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(114, 34);
            txtIP.TabIndex = 4;
            // 
            // txtPuerto
            // 
            txtPuerto.Font = new Font("Microsoft New Tai Lue", 12F);
            txtPuerto.Location = new Point(359, 78);
            txtPuerto.Margin = new Padding(3, 4, 3, 4);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(114, 34);
            txtPuerto.TabIndex = 5;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Microsoft New Tai Lue", 12F);
            txtContrasena.Location = new Point(359, 172);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(118, 34);
            txtContrasena.TabIndex = 6;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Microsoft New Tai Lue", 12F);
            txtUsuario.Location = new Point(188, 172);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(114, 34);
            txtUsuario.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SeaShell;
            btnGuardar.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.Sienna;
            btnGuardar.Location = new Point(263, 236);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 31);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Configuracion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 292);
            Controls.Add(pictureBox1);
            Controls.Add(btnGuardar);
            Controls.Add(txtUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(txtPuerto);
            Controls.Add(txtIP);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Configuracion";
            Text = "Configuracion";
            Load += Configuracion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIP;
        private TextBox txtPuerto;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private Button btnGuardar;
        private PictureBox pictureBox1;
    }
}