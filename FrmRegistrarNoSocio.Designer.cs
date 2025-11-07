namespace ClubDeportivo
{
    partial class FrmRegistrarNoSocio
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
            lblTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDni = new Label();
            lblMail = new Label();
            txtDni = new TextBox();
            txtMail = new TextBox();
            lblPagoDiario = new Label();
            txtPagoDiario = new TextBox();
            btnRegistrar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Gold;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.WindowText;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(800, 58);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar no socio";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(156, 107);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(92, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(281, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(326, 34);
            txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(156, 172);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(92, 28);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(281, 172);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(326, 34);
            txtApellido.TabIndex = 4;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(156, 241);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(52, 28);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMail.Location = new Point(156, 306);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(55, 28);
            lblMail.TabIndex = 6;
            lblMail.Text = "Mail:";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDni.Location = new Point(281, 241);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(326, 34);
            txtDni.TabIndex = 7;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMail.Location = new Point(281, 306);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(326, 34);
            txtMail.TabIndex = 8;
            // 
            // lblPagoDiario
            // 
            lblPagoDiario.AutoSize = true;
            lblPagoDiario.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPagoDiario.Location = new Point(156, 372);
            lblPagoDiario.Name = "lblPagoDiario";
            lblPagoDiario.Size = new Size(119, 28);
            lblPagoDiario.TabIndex = 9;
            lblPagoDiario.Text = "Pago diario:";
            // 
            // txtPagoDiario
            // 
            txtPagoDiario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPagoDiario.Location = new Point(281, 369);
            txtPagoDiario.Name = "txtPagoDiario";
            txtPagoDiario.Size = new Size(326, 34);
            txtPagoDiario.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Khaki;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(182, 457);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(186, 46);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Khaki;
            btnVolver.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(405, 457);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(186, 46);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmRegistrarNoSocio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 532);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPagoDiario);
            Controls.Add(lblPagoDiario);
            Controls.Add(txtMail);
            Controls.Add(txtDni);
            Controls.Add(lblMail);
            Controls.Add(lblDni);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "FrmRegistrarNoSocio";
            Text = "FrmRegistrarNoSocio";
            Load += FrmRegistrarNoSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDni;
        private Label lblMail;
        private TextBox txtDni;
        private TextBox txtMail;
        private Label lblPagoDiario;
        private TextBox txtPagoDiario;
        private Button btnRegistrar;
        private Button btnVolver;
    }
}