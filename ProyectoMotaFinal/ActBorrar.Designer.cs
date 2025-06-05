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
            btnActualizar = new Button();
            txtStock = new TextBox();
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
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(503, 309);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 31);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(199, 197);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(114, 27);
            txtStock.TabIndex = 20;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(26, 197);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(114, 27);
            txtPrecio.TabIndex = 19;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(386, 72);
            txtMarca.Margin = new Padding(3, 4, 3, 4);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(114, 27);
            txtMarca.TabIndex = 18;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(204, 72);
            txtTipo.Margin = new Padding(3, 4, 3, 4);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(114, 27);
            txtTipo.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(26, 72);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 16;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 161);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 15;
            label5.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 161);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 14;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 36);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 13;
            label3.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 36);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 12;
            label2.Text = "Tipo";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(26, 36);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(64, 20);
            lbl1.TabIndex = 11;
            lbl1.Text = "Nombre";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(366, 311);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 22;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(436, 161);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 23;
            lblID.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(390, 197);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 24;
            // 
            // ActBorrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 359);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(btnBorrar);
            Controls.Add(btnActualizar);
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
            Name = "ActBorrar";
            Text = "ActBorrar";
            Load += ActBorrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private TextBox txtStock;
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
    }
}