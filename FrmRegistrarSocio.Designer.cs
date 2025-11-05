namespace ClubDeportivo
{
    partial class FrmRegistrarSocio
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
            lblTituloRegSoc = new Label();
            lblNombreSocio = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDNI = new Label();
            lblMail = new Label();
            txtDNI = new TextBox();
            txtMail = new TextBox();
            lblAptoFisico = new Label();
            rbAptoSi = new RadioButton();
            rbAptoNo = new RadioButton();
            btnGuardar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblTituloRegSoc
            // 
            lblTituloRegSoc.BackColor = Color.Gold;
            lblTituloRegSoc.Dock = DockStyle.Top;
            lblTituloRegSoc.Font = new Font("Segoe MDL2 Assets", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRegSoc.ForeColor = SystemColors.WindowText;
            lblTituloRegSoc.Location = new Point(0, 0);
            lblTituloRegSoc.Name = "lblTituloRegSoc";
            lblTituloRegSoc.Size = new Size(800, 70);
            lblTituloRegSoc.TabIndex = 0;
            lblTituloRegSoc.Text = "Registrar Socio";
            lblTituloRegSoc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombreSocio
            // 
            lblNombreSocio.AutoSize = true;
            lblNombreSocio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreSocio.Location = new Point(130, 119);
            lblNombreSocio.Name = "lblNombreSocio";
            lblNombreSocio.Size = new Size(107, 32);
            lblNombreSocio.TabIndex = 1;
            lblNombreSocio.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(279, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(384, 34);
            txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(130, 182);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(107, 32);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(279, 182);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(384, 34);
            txtApellido.TabIndex = 4;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDNI.Location = new Point(130, 250);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(60, 32);
            lblDNI.TabIndex = 5;
            lblDNI.Text = "DNI:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMail.Location = new Point(130, 315);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(65, 32);
            lblMail.TabIndex = 6;
            lblMail.Text = "Mail:";
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDNI.Location = new Point(279, 248);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(384, 34);
            txtDNI.TabIndex = 7;
            txtDNI.TextChanged += txtDNI_TextChanged;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMail.Location = new Point(279, 313);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(384, 34);
            txtMail.TabIndex = 8;
            // 
            // lblAptoFisico
            // 
            lblAptoFisico.AutoSize = true;
            lblAptoFisico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAptoFisico.Location = new Point(130, 383);
            lblAptoFisico.Name = "lblAptoFisico";
            lblAptoFisico.Size = new Size(136, 32);
            lblAptoFisico.TabIndex = 9;
            lblAptoFisico.Text = "Apto Físico:";
            // 
            // rbAptoSi
            // 
            rbAptoSi.AutoSize = true;
            rbAptoSi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbAptoSi.ForeColor = SystemColors.WindowText;
            rbAptoSi.Location = new Point(325, 384);
            rbAptoSi.Name = "rbAptoSi";
            rbAptoSi.Size = new Size(54, 32);
            rbAptoSi.TabIndex = 11;
            rbAptoSi.TabStop = true;
            rbAptoSi.Text = "Si";
            rbAptoSi.UseVisualStyleBackColor = true;
            // 
            // rbAptoNo
            // 
            rbAptoNo.AutoSize = true;
            rbAptoNo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbAptoNo.ForeColor = SystemColors.WindowText;
            rbAptoNo.Location = new Point(430, 384);
            rbAptoNo.Name = "rbAptoNo";
            rbAptoNo.Size = new Size(68, 32);
            rbAptoNo.TabIndex = 12;
            rbAptoNo.TabStop = true;
            rbAptoNo.Text = "NO";
            rbAptoNo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LightGreen;
            btnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.WindowText;
            btnGuardar.Location = new Point(130, 483);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(249, 68);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Khaki;
            btnVolver.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.WindowText;
            btnVolver.Location = new Point(430, 483);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(233, 68);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmRegistrarSocio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(800, 591);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardar);
            Controls.Add(rbAptoNo);
            Controls.Add(rbAptoSi);
            Controls.Add(lblAptoFisico);
            Controls.Add(txtMail);
            Controls.Add(txtDNI);
            Controls.Add(lblMail);
            Controls.Add(lblDNI);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombreSocio);
            Controls.Add(lblTituloRegSoc);
            Name = "FrmRegistrarSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistrarSocio";
            Load += FrmRegistrarSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloRegSoc;
        private Label lblNombreSocio;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDNI;
        private Label lblMail;
        private TextBox txtDNI;
        private TextBox txtMail;
        private Label lblAptoFisico;
        private RadioButton rbAptoSi;
        private RadioButton rbAptoNo;
        private Button btnGuardar;
        private Button btnVolver;
    }
}