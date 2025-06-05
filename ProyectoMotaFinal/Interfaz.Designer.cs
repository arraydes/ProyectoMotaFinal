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
            dgvInventario.Location = new Point(0, 44);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new Size(800, 406);
            dgvInventario.TabIndex = 0;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(12, 12);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnConfig
            // 
            btnConfig.Location = new Point(689, 10);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(94, 23);
            btnConfig.TabIndex = 2;
            btnConfig.Text = "Configuracion";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(608, 10);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 3;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // Interfaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConectar);
            Controls.Add(btnConfig);
            Controls.Add(btnInsertar);
            Controls.Add(dgvInventario);
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
