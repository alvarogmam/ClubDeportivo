namespace ClubDeportivo
{
    partial class FrmCobrarCuota
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

        private Label lblTituloCobrarCuota;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTituloCobrarCuota = new Label();
            lblIngreseDni = new Label();
            txtDni = new TextBox();
            btnBuscar = new Button();
            dgvSocio = new DataGridView();
            cboMedioPago = new ComboBox();
            lblMedioDePago = new Label();
            cboCuotas = new ComboBox();
            lblCuotas = new Label();
            lblMontoTotal = new Label();
            lblTotal = new Label();
            btnPagar = new Button();
            btnVolver = new Button();
            btnGenerarCuota = new Button();
            lblMonto = new Label();
            txtMonto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSocio).BeginInit();
            SuspendLayout();
            // 
            // lblTituloCobrarCuota
            // 
            lblTituloCobrarCuota.BackColor = Color.Gold;
            lblTituloCobrarCuota.Dock = DockStyle.Top;
            lblTituloCobrarCuota.Font = new Font("Segoe MDL2 Assets", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloCobrarCuota.Location = new Point(0, 0);
            lblTituloCobrarCuota.Name = "lblTituloCobrarCuota";
            lblTituloCobrarCuota.Size = new Size(997, 55);
            lblTituloCobrarCuota.TabIndex = 0;
            lblTituloCobrarCuota.Text = "Crobrar Cuota";
            lblTituloCobrarCuota.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIngreseDni
            // 
            lblIngreseDni.AutoSize = true;
            lblIngreseDni.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngreseDni.Location = new Point(67, 89);
            lblIngreseDni.Name = "lblIngreseDni";
            lblIngreseDni.Size = new Size(156, 28);
            lblIngreseDni.TabIndex = 1;
            lblIngreseDni.Text = "Ingrese un DNI:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(238, 86);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(475, 31);
            txtDni.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Khaki;
            btnBuscar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(738, 83);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 40);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvSocio
            // 
            dgvSocio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSocio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocio.Location = new Point(67, 147);
            dgvSocio.Name = "dgvSocio";
            dgvSocio.RowHeadersWidth = 62;
            dgvSocio.Size = new Size(822, 104);
            dgvSocio.TabIndex = 4;
            // 
            // cboMedioPago
            // 
            cboMedioPago.FormattingEnabled = true;
            cboMedioPago.Location = new Point(360, 348);
            cboMedioPago.Name = "cboMedioPago";
            cboMedioPago.Size = new Size(233, 33);
            cboMedioPago.TabIndex = 5;
            cboMedioPago.SelectedIndexChanged += cboMedioPago_SelectedIndexChanged;
            // 
            // lblMedioDePago
            // 
            lblMedioDePago.AutoSize = true;
            lblMedioDePago.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedioDePago.Location = new Point(67, 348);
            lblMedioDePago.Name = "lblMedioDePago";
            lblMedioDePago.Size = new Size(288, 28);
            lblMedioDePago.TabIndex = 6;
            lblMedioDePago.Text = "Seleccione un medio de pago:";
            // 
            // cboCuotas
            // 
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Location = new Point(738, 348);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(112, 33);
            cboCuotas.TabIndex = 7;
            cboCuotas.SelectedIndexChanged += cboCuotas_SelectedIndexChanged;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCuotas.Location = new Point(643, 353);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(79, 28);
            lblCuotas.TabIndex = 8;
            lblCuotas.Text = "Cuotas:";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMontoTotal.Location = new Point(67, 412);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(125, 28);
            lblMontoTotal.TabIndex = 9;
            lblMontoTotal.Text = "Monto total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.ControlDarkDark;
            lblTotal.Location = new Point(223, 408);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 32);
            lblTotal.TabIndex = 10;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.PaleGreen;
            btnPagar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagar.Location = new Point(432, 476);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(172, 54);
            btnPagar.TabIndex = 11;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Khaki;
            btnVolver.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(672, 476);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(172, 54);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGenerarCuota
            // 
            btnGenerarCuota.BackColor = Color.Gold;
            btnGenerarCuota.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarCuota.Location = new Point(197, 476);
            btnGenerarCuota.Name = "btnGenerarCuota";
            btnGenerarCuota.Size = new Size(172, 54);
            btnGenerarCuota.TabIndex = 13;
            btnGenerarCuota.Text = "Generar cuota";
            btnGenerarCuota.UseVisualStyleBackColor = false;
            btnGenerarCuota.Click += btnGenerarCuota_Click;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonto.Location = new Point(67, 288);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(174, 28);
            lblMonto.TabIndex = 14;
            lblMonto.Text = "Ingrese el monto:";
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMonto.Location = new Point(250, 288);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(343, 34);
            txtMonto.TabIndex = 15;
            // 
            // FrmCobrarCuota
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 565);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(btnGenerarCuota);
            Controls.Add(btnVolver);
            Controls.Add(btnPagar);
            Controls.Add(lblTotal);
            Controls.Add(lblMontoTotal);
            Controls.Add(lblCuotas);
            Controls.Add(cboCuotas);
            Controls.Add(lblMedioDePago);
            Controls.Add(cboMedioPago);
            Controls.Add(dgvSocio);
            Controls.Add(btnBuscar);
            Controls.Add(txtDni);
            Controls.Add(lblIngreseDni);
            Controls.Add(lblTituloCobrarCuota);
            Name = "FrmCobrarCuota";
            Text = "FrmCobrarCuota";
            Load += FrmCobrarCuota_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreseDni;
        private TextBox txtDni;
        private Button btnBuscar;
        private DataGridView dgvSocio;
        private ComboBox cboMedioPago;
        private Label lblMedioDePago;
        private ComboBox cboCuotas;
        private Label lblCuotas;
        private Label lblMontoTotal;
        private Label lblTotal;
        private Button btnPagar;
        private Button btnVolver;
        private Button btnGenerarCuota;
        private Label lblMonto;
        private TextBox txtMonto;
    }
}