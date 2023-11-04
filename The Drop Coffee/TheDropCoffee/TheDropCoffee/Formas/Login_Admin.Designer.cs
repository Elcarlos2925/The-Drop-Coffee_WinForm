namespace TheDropCoffee.Formas
{
    partial class Login_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new RJCodeAdvance.RJControls.RJButton();
            this.lblPasswordAdmin = new System.Windows.Forms.Label();
            this.lblUsuarioAdmin = new System.Windows.Forms.Label();
            this.txtUsuarioAdmin = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnIniciarseciònEmpleado = new RJCodeAdvance.RJControls.RJButton();
            this.txtPasswordAdmin = new RJCodeAdvance.RJControls.RJTextBox();
            this.ImaBoxLoginAdmin = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImaBoxLoginAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Location = new System.Drawing.Point(36, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 369);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.lblPasswordAdmin);
            this.panel2.Controls.Add(this.lblUsuarioAdmin);
            this.panel2.Controls.Add(this.txtUsuarioAdmin);
            this.panel2.Controls.Add(this.btnIniciarseciònEmpleado);
            this.panel2.Controls.Add(this.txtPasswordAdmin);
            this.panel2.Location = new System.Drawing.Point(31, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 367);
            this.panel2.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSalir.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.btnSalir.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnSalir.BorderRadius = 10;
            this.btnSalir.BorderSize = 2;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalir.Location = new System.Drawing.Point(64, 285);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 40);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.TextColor = System.Drawing.Color.Transparent;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblPasswordAdmin
            // 
            this.lblPasswordAdmin.AutoSize = true;
            this.lblPasswordAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordAdmin.Location = new System.Drawing.Point(40, 139);
            this.lblPasswordAdmin.Name = "lblPasswordAdmin";
            this.lblPasswordAdmin.Size = new System.Drawing.Size(79, 16);
            this.lblPasswordAdmin.TabIndex = 5;
            this.lblPasswordAdmin.Text = "Contraseña:";
            // 
            // lblUsuarioAdmin
            // 
            this.lblUsuarioAdmin.AutoSize = true;
            this.lblUsuarioAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioAdmin.Location = new System.Drawing.Point(40, 73);
            this.lblUsuarioAdmin.Name = "lblUsuarioAdmin";
            this.lblUsuarioAdmin.Size = new System.Drawing.Size(57, 16);
            this.lblUsuarioAdmin.TabIndex = 4;
            this.lblUsuarioAdmin.Text = "Usuario:";
            // 
            // txtUsuarioAdmin
            // 
            this.txtUsuarioAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuarioAdmin.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtUsuarioAdmin.BorderFocusColor = System.Drawing.Color.SeaShell;
            this.txtUsuarioAdmin.BorderRadius = 10;
            this.txtUsuarioAdmin.BorderSize = 2;
            this.txtUsuarioAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuarioAdmin.Location = new System.Drawing.Point(28, 90);
            this.txtUsuarioAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuarioAdmin.Multiline = false;
            this.txtUsuarioAdmin.Name = "txtUsuarioAdmin";
            this.txtUsuarioAdmin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsuarioAdmin.PasswordChar = false;
            this.txtUsuarioAdmin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsuarioAdmin.PlaceholderText = "";
            this.txtUsuarioAdmin.Size = new System.Drawing.Size(225, 31);
            this.txtUsuarioAdmin.TabIndex = 1;
            this.txtUsuarioAdmin.Texts = "Ingrese Usuario";
            this.txtUsuarioAdmin.UnderlinedStyle = false;
            this.txtUsuarioAdmin.Enter += new System.EventHandler(this.txtUsuarioAdmin_Enter);
            this.txtUsuarioAdmin.Leave += new System.EventHandler(this.txtUsuarioAdmin_Leave);
            // 
            // btnIniciarseciònEmpleado
            // 
            this.btnIniciarseciònEmpleado.BackColor = System.Drawing.Color.BurlyWood;
            this.btnIniciarseciònEmpleado.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.btnIniciarseciònEmpleado.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnIniciarseciònEmpleado.BorderRadius = 10;
            this.btnIniciarseciònEmpleado.BorderSize = 2;
            this.btnIniciarseciònEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarseciònEmpleado.FlatAppearance.BorderSize = 0;
            this.btnIniciarseciònEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarseciònEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarseciònEmpleado.ForeColor = System.Drawing.Color.Transparent;
            this.btnIniciarseciònEmpleado.Location = new System.Drawing.Point(64, 227);
            this.btnIniciarseciònEmpleado.Name = "btnIniciarseciònEmpleado";
            this.btnIniciarseciònEmpleado.Size = new System.Drawing.Size(150, 40);
            this.btnIniciarseciònEmpleado.TabIndex = 3;
            this.btnIniciarseciònEmpleado.Text = "Iniciar Sesión";
            this.btnIniciarseciònEmpleado.TextColor = System.Drawing.Color.Transparent;
            this.btnIniciarseciònEmpleado.UseVisualStyleBackColor = false;
            this.btnIniciarseciònEmpleado.Click += new System.EventHandler(this.btnIniciarseciònEmpleado_Click);
            // 
            // txtPasswordAdmin
            // 
            this.txtPasswordAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.txtPasswordAdmin.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtPasswordAdmin.BorderFocusColor = System.Drawing.Color.SeaShell;
            this.txtPasswordAdmin.BorderRadius = 10;
            this.txtPasswordAdmin.BorderSize = 2;
            this.txtPasswordAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPasswordAdmin.Location = new System.Drawing.Point(28, 159);
            this.txtPasswordAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordAdmin.Multiline = false;
            this.txtPasswordAdmin.Name = "txtPasswordAdmin";
            this.txtPasswordAdmin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPasswordAdmin.PasswordChar = false;
            this.txtPasswordAdmin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPasswordAdmin.PlaceholderText = "";
            this.txtPasswordAdmin.Size = new System.Drawing.Size(225, 31);
            this.txtPasswordAdmin.TabIndex = 2;
            this.txtPasswordAdmin.Texts = "Ingrese Contraseña";
            this.txtPasswordAdmin.UnderlinedStyle = false;
            this.txtPasswordAdmin.Enter += new System.EventHandler(this.txtPasswordAdmin_Enter);
            this.txtPasswordAdmin.Leave += new System.EventHandler(this.txtPasswordAdmin_Leave);
            // 
            // ImaBoxLoginAdmin
            // 
            this.ImaBoxLoginAdmin.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ImaBoxLoginAdmin.BorderColor = System.Drawing.Color.SaddleBrown;
            this.ImaBoxLoginAdmin.BorderColor2 = System.Drawing.Color.SeaShell;
            this.ImaBoxLoginAdmin.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ImaBoxLoginAdmin.BorderSize = 2;
            this.ImaBoxLoginAdmin.GradientAngle = 60F;
            this.ImaBoxLoginAdmin.Image = ((System.Drawing.Image)(resources.GetObject("ImaBoxLoginAdmin.Image")));
            this.ImaBoxLoginAdmin.Location = new System.Drawing.Point(116, 10);
            this.ImaBoxLoginAdmin.Name = "ImaBoxLoginAdmin";
            this.ImaBoxLoginAdmin.Size = new System.Drawing.Size(100, 100);
            this.ImaBoxLoginAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImaBoxLoginAdmin.TabIndex = 2;
            this.ImaBoxLoginAdmin.TabStop = false;
            // 
            // Login_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.ImaBoxLoginAdmin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Admin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImaBoxLoginAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJTextBox txtPasswordAdmin;
        private System.Windows.Forms.Label lblPasswordAdmin;
        private System.Windows.Forms.Label lblUsuarioAdmin;
        private RJCodeAdvance.RJControls.RJTextBox txtUsuarioAdmin;
        private RJCodeAdvance.RJControls.RJButton btnIniciarseciònEmpleado;
        private RJCodeAdvance.RJControls.RJCircularPictureBox ImaBoxLoginAdmin;
        private RJCodeAdvance.RJControls.RJButton btnSalir;
    }
}