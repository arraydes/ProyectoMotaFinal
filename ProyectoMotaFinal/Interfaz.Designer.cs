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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz));
            dgvInventario = new DataGridView();
            btnInsertar = new Button();
            btnConfig = new Button();
            btnConectar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            actualizarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.ContextMenuStrip = contextMenuStrip1;
            dgvInventario.Location = new Point(0, 44);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.Size = new Size(800, 406);
            dgvInventario.TabIndex = 0;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.Goldenrod;
            btnInsertar.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            btnInsertar.ForeColor = Color.PaleGoldenrod;
            btnInsertar.Location = new Point(12, 12);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(91, 26);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = SystemColors.ControlDark;
            btnConfig.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            btnConfig.Location = new Point(627, 10);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(145, 28);
            btnConfig.TabIndex = 2;
            btnConfig.Text = "Configuración";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnConectar
            // 
            btnConectar.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            btnConectar.Location = new Point(508, 10);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(100, 26);
            btnConectar.TabIndex = 3;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { actualizarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(147, 28);
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(146, 24);
            actualizarToolStripMenuItem.Text = "Actualizar";
            actualizarToolStripMenuItem.Click += actualizarToolStripMenuItem_Click;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Interfaz";
            Text = "Instrumentos";
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInventario;
        private Button btnInsertar;
        private Button btnConfig;
        private Button btnConectar;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem actualizarToolStripMenuItem;
    }
}
