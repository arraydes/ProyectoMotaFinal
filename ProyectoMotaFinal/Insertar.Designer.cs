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
            btnInsertar = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label1 = new Label();
            LblStock = new Label();
            TrkStock = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrkStock).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            lbl1.Location = new Point(281, 58);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(73, 21);
            lbl1.TabIndex = 0;
            lbl1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label2.Location = new Point(303, 141);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label3.Location = new Point(293, 98);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 2;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label4.Location = new Point(293, 234);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label5.Location = new Point(298, 184);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 4;
            label5.Text = "Stock";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft New Tai Lue", 12F);
            txtNombre.Location = new Point(360, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(140, 28);
            txtNombre.TabIndex = 5;
            // 
            // txtTipo
            // 
            txtTipo.Font = new Font("Microsoft New Tai Lue", 12F);
            txtTipo.Location = new Point(360, 141);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(140, 28);
            txtTipo.TabIndex = 6;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Microsoft New Tai Lue", 12F);
            txtMarca.Location = new Point(360, 98);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(140, 28);
            txtMarca.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Microsoft New Tai Lue", 12F);
            txtPrecio.Location = new Point(360, 234);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(140, 28);
            txtPrecio.TabIndex = 8;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.Goldenrod;
            btnInsertar.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            btnInsertar.ForeColor = Color.PaleGoldenrod;
            btnInsertar.Location = new Point(351, 306);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(103, 26);
            btnInsertar.TabIndex = 10;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 344);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(449, 208);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 33;
            label6.Text = "25";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 206);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 32;
            label1.Text = "1";
            // 
            // LblStock
            // 
            LblStock.AutoSize = true;
            LblStock.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblStock.Location = new Point(467, 189);
            LblStock.Name = "LblStock";
            LblStock.Size = new Size(21, 20);
            LblStock.TabIndex = 31;
            LblStock.Text = "...";
            // 
            // TrkStock
            // 
            TrkStock.Location = new Point(360, 183);
            TrkStock.Maximum = 25;
            TrkStock.Minimum = 1;
            TrkStock.Name = "TrkStock";
            TrkStock.Size = new Size(110, 45);
            TrkStock.TabIndex = 30;
            TrkStock.Value = 1;
            TrkStock.Scroll += TrkStock_Scroll;
            // 
            // Insertar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 352);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(LblStock);
            Controls.Add(TrkStock);
            Controls.Add(pictureBox1);
            Controls.Add(btnInsertar);
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
            Name = "Insertar";
            Text = "Insertar";
            Load += Insertar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrkStock).EndInit();
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
        private Button btnInsertar;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label1;
        private Label LblStock;
        private TrackBar TrkStock;
    }
}