namespace ProyectoMotaFinal
{
    partial class Interfaz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvInventario = new DataGridView();
            btnInsertar = new Button();
            btnConfig = new Button();
            btnConectar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(0, 59);
            dgvInventario.Margin = new Padding(3, 4, 3, 4);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.Size = new Size(914, 541);
            dgvInventario.TabIndex = 0;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(14, 16);
            btnInsertar.Margin = new Padding(3, 4, 3, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(86, 31);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnConfig
            // 
            btnConfig.Location = new Point(750, 13);
            btnConfig.Margin = new Padding(3, 4, 3, 4);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(133, 31);
            btnConfig.TabIndex = 2;
            btnConfig.Text = "Configuracion";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(658, 13);
            btnConectar.Margin = new Padding(3, 4, 3, 4);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(86, 31);
            btnConectar.TabIndex = 3;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // Interfaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnConectar);
            Controls.Add(btnConfig);
            Controls.Add(btnInsertar);
            Controls.Add(dgvInventario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Interfaz";
            Text = "Instrumentos";
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInventario;
        private Button btnInsertar;
        private Button btnConfig;
        private Button btnConectar;
    }
}
