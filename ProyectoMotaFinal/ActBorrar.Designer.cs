namespace ProyectoMotaFinal
{
    partial class ActBorrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActBorrar));
            btnActualizar = new Button();
            txtPrecio = new TextBox();
            txtMarca = new TextBox();
            txtTipo = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbl1 = new Label();
            btnBorrar = new Button();
            lblID = new Label();
            txtID = new TextBox();
            pictureBox1 = new PictureBox();
            TrkStock = new TrackBar();
            LblStock = new Label();
            label1 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrkStock).BeginInit();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkSeaGreen;
            btnActualizar.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.SeaGreen;
            btnActualizar.Location = new Point(375, 298);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(111, 26);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Microsoft New Tai Lue", 12F);
            txtPrecio.Location = new Point(355, 249);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(145, 28);
            txtPrecio.TabIndex = 19;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Microsoft New Tai Lue", 12F);
            txtMarca.Location = new Point(355, 99);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(145, 28);
            txtMarca.TabIndex = 18;
            // 
            // txtTipo
            // 
            txtTipo.Font = new Font("Microsoft New Tai Lue", 12F);
            txtTipo.Location = new Point(355, 149);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(145, 28);
            txtTipo.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft New Tai Lue", 12F);
            txtNombre.Location = new Point(355, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(145, 28);
            txtNombre.TabIndex = 16;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label5.Location = new Point(283, 197);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 15;
            label5.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label4.Location = new Point(278, 251);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 14;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label3.Location = new Point(278, 101);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 13;
            label3.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            label2.Location = new Point(288, 151);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 12;
            label2.Text = "Tipo";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            lbl1.Location = new Point(266, 44);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(73, 21);
            lbl1.TabIndex = 11;
            lbl1.Text = "Nombre";
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Sienna;
            btnBorrar.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            btnBorrar.ForeColor = Color.SandyBrown;
            btnBorrar.Location = new Point(272, 299);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(82, 25);
            btnBorrar.TabIndex = 22;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            lblID.Location = new Point(35, 304);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 21);
            lblID.TabIndex = 23;
            lblID.Text = "ID";
            lblID.Click += lblID_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("Microsoft New Tai Lue", 12F);
            txtID.Location = new Point(81, 298);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(120, 28);
            txtID.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, -24);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 326);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // TrkStock
            // 
            TrkStock.Location = new Point(355, 197);
            TrkStock.Maximum = 25;
            TrkStock.Minimum = 1;
            TrkStock.Name = "TrkStock";
            TrkStock.Size = new Size(110, 45);
            TrkStock.TabIndex = 26;
            TrkStock.Value = 1;
            TrkStock.Scroll += TrkStock_Scroll;
            // 
            // LblStock
            // 
            LblStock.AutoSize = true;
            LblStock.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblStock.Location = new Point(462, 203);
            LblStock.Name = "LblStock";
            LblStock.Size = new Size(21, 20);
            LblStock.TabIndex = 27;
            LblStock.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 220);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 28;
            label1.Text = "1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(444, 222);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 29;
            label6.Text = "25";
            // 
            // ActBorrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 352);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(LblStock);
            Controls.Add(TrkStock);
            Controls.Add(pictureBox1);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(btnBorrar);
            Controls.Add(btnActualizar);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "ActBorrar";
            Text = "ActBorrar";
            Load += ActBorrar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrkStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private TextBox txtPrecio;
        private TextBox txtMarca;
        private TextBox txtTipo;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbl1;
        private Button btnBorrar;
        private Label lblID;
        private TextBox txtID;
        private PictureBox pictureBox1;
        private TrackBar TrkStock;
        private Label LblStock;
        private Label label1;
        private Label label6;
    }
}