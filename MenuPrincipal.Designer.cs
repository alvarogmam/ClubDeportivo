namespace ClubDeportivo
{
    partial class FrmMenuPrincipal
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
            lblMenuPrincipal = new Label();
            lblUsuario = new Label();
            lblRol = new Label();
            btnRegistrarSocio = new Button();
            btnRegistrarNoSocio = new Button();
            btnCobrarCuota = new Button();
            btnCobrarActividad = new Button();
            btnEmitirCarnet = new Button();
            btnListaVencimientos = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            lblMenuPrincipal.BackColor = Color.Gold;
            lblMenuPrincipal.Dock = DockStyle.Top;
            lblMenuPrincipal.Font = new Font("Segoe MDL2 Assets", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuPrincipal.ForeColor = SystemColors.WindowText;
            lblMenuPrincipal.Location = new Point(0, 0);
            lblMenuPrincipal.Name = "lblMenuPrincipal";
            lblMenuPrincipal.Size = new Size(778, 62);
            lblMenuPrincipal.TabIndex = 0;
            lblMenuPrincipal.Text = "Menu Principal - Club Deportivo";
            lblMenuPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            lblMenuPrincipal.Click += lblMenuPrincipal_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.WindowFrame;
            lblUsuario.Location = new Point(20, 70);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 24);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.ForeColor = SystemColors.WindowFrame;
            lblRol.Location = new Point(20, 110);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(42, 24);
            lblRol.TabIndex = 2;
            lblRol.Text = "Rol:";
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.BackColor = Color.Khaki;
            btnRegistrarSocio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarSocio.ForeColor = SystemColors.MenuText;
            btnRegistrarSocio.Location = new Point(109, 190);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(265, 90);
            btnRegistrarSocio.TabIndex = 3;
            btnRegistrarSocio.Text = "Registrar Socio";
            btnRegistrarSocio.UseVisualStyleBackColor = false;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.BackColor = Color.Khaki;
            btnRegistrarNoSocio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarNoSocio.ForeColor = SystemColors.WindowText;
            btnRegistrarNoSocio.Location = new Point(394, 190);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(265, 90);
            btnRegistrarNoSocio.TabIndex = 4;
            btnRegistrarNoSocio.Text = "Registrar No Socio";
            btnRegistrarNoSocio.UseVisualStyleBackColor = false;
            // 
            // btnCobrarCuota
            // 
            btnCobrarCuota.BackColor = Color.Khaki;
            btnCobrarCuota.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCobrarCuota.ForeColor = SystemColors.WindowText;
            btnCobrarCuota.Location = new Point(109, 310);
            btnCobrarCuota.Name = "btnCobrarCuota";
            btnCobrarCuota.Size = new Size(265, 90);
            btnCobrarCuota.TabIndex = 5;
            btnCobrarCuota.Text = "Cobrar Cuota";
            btnCobrarCuota.UseVisualStyleBackColor = false;
            // 
            // btnCobrarActividad
            // 
            btnCobrarActividad.BackColor = Color.Khaki;
            btnCobrarActividad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCobrarActividad.ForeColor = SystemColors.WindowText;
            btnCobrarActividad.Location = new Point(394, 310);
            btnCobrarActividad.Name = "btnCobrarActividad";
            btnCobrarActividad.Size = new Size(265, 90);
            btnCobrarActividad.TabIndex = 6;
            btnCobrarActividad.Text = "Cobrar Actividad";
            btnCobrarActividad.UseVisualStyleBackColor = false;
            // 
            // btnEmitirCarnet
            // 
            btnEmitirCarnet.BackColor = Color.Khaki;
            btnEmitirCarnet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmitirCarnet.ForeColor = SystemColors.WindowText;
            btnEmitirCarnet.Location = new Point(109, 430);
            btnEmitirCarnet.Name = "btnEmitirCarnet";
            btnEmitirCarnet.Size = new Size(265, 90);
            btnEmitirCarnet.TabIndex = 7;
            btnEmitirCarnet.Text = "Emitir Carnet";
            btnEmitirCarnet.UseVisualStyleBackColor = false;
            // 
            // btnListaVencimientos
            // 
            btnListaVencimientos.BackColor = Color.Khaki;
            btnListaVencimientos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListaVencimientos.ForeColor = SystemColors.WindowText;
            btnListaVencimientos.Location = new Point(394, 430);
            btnListaVencimientos.Name = "btnListaVencimientos";
            btnListaVencimientos.Size = new Size(265, 90);
            btnListaVencimientos.TabIndex = 8;
            btnListaVencimientos.Text = "Lista de vencimientos";
            btnListaVencimientos.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Orange;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.WindowText;
            btnSalir.Location = new Point(686, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(80, 40);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(778, 594);
            Controls.Add(btnSalir);
            Controls.Add(btnListaVencimientos);
            Controls.Add(btnEmitirCarnet);
            Controls.Add(btnCobrarActividad);
            Controls.Add(btnCobrarCuota);
            Controls.Add(btnRegistrarNoSocio);
            Controls.Add(btnRegistrarSocio);
            Controls.Add(lblRol);
            Controls.Add(lblUsuario);
            Controls.Add(lblMenuPrincipal);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            Load += FrmMenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenuPrincipal;
        private Label lblUsuario;
        private Label lblRol;
        private Button btnRegistrarSocio;
        private Button btnRegistrarNoSocio;
        private Button btnCobrarCuota;
        private Button btnCobrarActividad;
        private Button btnEmitirCarnet;
        private Button btnListaVencimientos;
        private Button btnSalir;
    }
}