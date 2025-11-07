namespace ClubDeportivo
{
    partial class FrmListadoSocios
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
            dgvSocios = new DataGridView();
            txtBuscar = new TextBox();
            btnActualizarLista = new Button();
            btnVolver = new Button();
            lblTituloListaSocios = new Label();
            lblBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            SuspendLayout();
            // 
            // dgvSocios
            // 
            dgvSocios.BackgroundColor = Color.LightYellow;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(143, 116);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.RowHeadersWidth = 62;
            dgvSocios.Size = new Size(647, 225);
            dgvSocios.TabIndex = 0;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(226, 79);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(289, 31);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnActualizarLista
            // 
            btnActualizarLista.BackColor = Color.Khaki;
            btnActualizarLista.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarLista.ForeColor = SystemColors.WindowText;
            btnActualizarLista.Location = new Point(267, 366);
            btnActualizarLista.Name = "btnActualizarLista";
            btnActualizarLista.Size = new Size(191, 51);
            btnActualizarLista.TabIndex = 2;
            btnActualizarLista.Text = "Actualizar";
            btnActualizarLista.UseVisualStyleBackColor = false;
            btnActualizarLista.Click += btnActualizar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Khaki;
            btnVolver.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.WindowText;
            btnVolver.Location = new Point(471, 366);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(191, 51);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblTituloListaSocios
            // 
            lblTituloListaSocios.BackColor = Color.Gold;
            lblTituloListaSocios.Dock = DockStyle.Top;
            lblTituloListaSocios.Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloListaSocios.ForeColor = SystemColors.WindowText;
            lblTituloListaSocios.Location = new Point(0, 0);
            lblTituloListaSocios.Name = "lblTituloListaSocios";
            lblTituloListaSocios.Size = new Size(928, 55);
            lblTituloListaSocios.TabIndex = 4;
            lblTituloListaSocios.Text = "LISTADO DE SOCIOS";
            lblTituloListaSocios.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(143, 79);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(77, 28);
            lblBuscar.TabIndex = 5;
            lblBuscar.Text = "Buscar:";
            // 
            // FrmListadoSocios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 450);
            Controls.Add(lblBuscar);
            Controls.Add(lblTituloListaSocios);
            Controls.Add(btnVolver);
            Controls.Add(btnActualizarLista);
            Controls.Add(txtBuscar);
            Controls.Add(dgvSocios);
            Name = "FrmListadoSocios";
            Text = "FrmListadoSocios";
            Load += FrmListadoSocios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSocios;
        private TextBox txtBuscar;
        private Button btnActualizarLista;
        private Button btnVolver;
        private Label lblTituloListaSocios;
        private Label lblBuscar;
    }
}