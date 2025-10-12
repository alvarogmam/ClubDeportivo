namespace ClubDeportivo
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            picLogo = new PictureBox();
            lblTituloLogin = new Label();
            lblUsuario = new Label();
            lblPass = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(50, 150);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(180, 180);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTituloLogin
            // 
            lblTituloLogin.BackColor = Color.Gold;
            lblTituloLogin.Dock = DockStyle.Top;
            lblTituloLogin.Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLogin.ForeColor = SystemColors.WindowFrame;
            lblTituloLogin.Location = new Point(0, 0);
            lblTituloLogin.Name = "lblTituloLogin";
            lblTituloLogin.Size = new Size(800, 70);
            lblTituloLogin.TabIndex = 1;
            lblTituloLogin.Text = "LOGIN";
            lblTituloLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe MDL2 Assets", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(307, 150);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(92, 28);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe MDL2 Assets", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.Location = new Point(307, 239);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(129, 28);
            lblPass.TabIndex = 3;
            lblPass.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(443, 147);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(253, 31);
            txtUsuario.TabIndex = 4;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.ForeColor = Color.DimGray;
            txtPass.Location = new Point(443, 236);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(253, 31);
            txtPass.TabIndex = 5;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Gold;
            btnIngresar.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(307, 341);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(389, 49);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(lblPass);
            Controls.Add(lblUsuario);
            Controls.Add(lblTituloLogin);
            Controls.Add(picLogo);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblTituloLogin;
        private Label lblUsuario;
        private Label lblPass;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnIngresar;
    }
}
