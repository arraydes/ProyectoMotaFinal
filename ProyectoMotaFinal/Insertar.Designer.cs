namespace ProyectoMotaFinal
{
    partial class Insertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insertar));
            lbl1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtTipo = new TextBox();
            txtMarca = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btnInsertar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            lbl1.Location = new Point(321, 77);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(89, 27);
            lbl1.TabIndex = 0;
            lbl1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label2.Location = new Point(346, 188);
            label2.Name = "label2";
            label2.Size = new Size(54, 27);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label3.Location = new Point(335, 130);
            label3.Name = "label3";
            label3.Size = new Size(71, 27);
            label3.TabIndex = 2;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label4.Location = new Point(335, 312);
            label4.Name = "label4";
            label4.Size = new Size(71, 27);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label5.Location = new Point(340, 246);
            label5.Name = "label5";
            label5.Size = new Size(64, 27);
            label5.TabIndex = 4;
            label5.Text = "Stock";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft New Tai Lue", 12F);
            txtNombre.Location = new Point(411, 70);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 34);
            txtNombre.TabIndex = 5;
            // 
            // txtTipo
            // 
            txtTipo.Font = new Font("Microsoft New Tai Lue", 12F);
            txtTipo.Location = new Point(411, 188);
            txtTipo.Margin = new Padding(3, 4, 3, 4);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(159, 34);
            txtTipo.TabIndex = 6;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Microsoft New Tai Lue", 12F);
            txtMarca.Location = new Point(411, 130);
            txtMarca.Margin = new Padding(3, 4, 3, 4);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(159, 34);
            txtMarca.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Microsoft New Tai Lue", 12F);
            txtPrecio.Location = new Point(411, 312);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(159, 34);
            txtPrecio.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Microsoft New Tai Lue", 12F);
            txtStock.Location = new Point(411, 246);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(159, 34);
            txtStock.TabIndex = 9;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.Goldenrod;
            btnInsertar.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            btnInsertar.ForeColor = Color.PaleGoldenrod;
            btnInsertar.Location = new Point(401, 408);
            btnInsertar.Margin = new Padding(3, 4, 3, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(118, 35);
            btnInsertar.TabIndex = 10;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 459);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Insertar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 469);
            Controls.Add(pictureBox1);
            Controls.Add(btnInsertar);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtMarca);
            Controls.Add(txtTipo);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Insertar";
            Text = "Insertar";
            Load += Insertar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtTipo;
        private TextBox txtMarca;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button btnInsertar;
        private PictureBox pictureBox1;
    }
}