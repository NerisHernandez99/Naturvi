namespace Naturvida
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.ingresar = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.passwor = new System.Windows.Forms.Label();
            this.texuser = new System.Windows.Forms.TextBox();
            this.texpasswor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Alerta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(187, 291);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(107, 28);
            this.ingresar.TabIndex = 0;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.UseWaitCursor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(71, 134);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(76, 20);
            this.user.TabIndex = 1;
            this.user.Text = "Usuario:";
            this.user.UseWaitCursor = true;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(142, 179);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(0, 20);
            this.pass.TabIndex = 2;
            this.pass.UseWaitCursor = true;
            // 
            // passwor
            // 
            this.passwor.AutoSize = true;
            this.passwor.Location = new System.Drawing.Point(56, 179);
            this.passwor.Name = "passwor";
            this.passwor.Size = new System.Drawing.Size(107, 20);
            this.passwor.TabIndex = 3;
            this.passwor.Text = "Contraseña:";
            this.passwor.UseWaitCursor = true;
            // 
            // texuser
            // 
            this.texuser.Location = new System.Drawing.Point(187, 134);
            this.texuser.Name = "texuser";
            this.texuser.Size = new System.Drawing.Size(201, 26);
            this.texuser.TabIndex = 4;
            this.texuser.UseWaitCursor = true;
            this.texuser.TextChanged += new System.EventHandler(this.texuser_TextChanged);
            // 
            // texpasswor
            // 
            this.texpasswor.Location = new System.Drawing.Point(187, 176);
            this.texpasswor.Name = "texpasswor";
            this.texpasswor.Size = new System.Drawing.Size(201, 26);
            this.texpasswor.TabIndex = 5;
            this.texpasswor.UseSystemPasswordChar = true;
            this.texpasswor.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistema de informacion  Tienda Naturista NaturVida";
            this.label1.UseWaitCursor = true;
            // 
            // Alerta
            // 
            this.Alerta.AutoSize = true;
            this.Alerta.BackColor = System.Drawing.Color.Ivory;
            this.Alerta.ForeColor = System.Drawing.Color.Red;
            this.Alerta.Location = new System.Drawing.Point(136, 254);
            this.Alerta.Name = "Alerta";
            this.Alerta.Size = new System.Drawing.Size(252, 20);
            this.Alerta.TabIndex = 8;
            this.Alerta.Text = "usuario o contraseña invalidos";
            this.Alerta.UseWaitCursor = true;
            this.Alerta.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(539, 348);
            this.Controls.Add(this.Alerta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texpasswor);
            this.Controls.Add(this.texuser);
            this.Controls.Add(this.passwor);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.ingresar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.RightToLeftLayout = true;
            this.Text = "Ingreso Usuario";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label user;
        public System.Windows.Forms.Label pass;
        public System.Windows.Forms.Label passwor;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox texuser;
        public System.Windows.Forms.TextBox texpasswor;
        public System.Windows.Forms.Button ingresar;
        public System.Windows.Forms.Label Alerta;
    }
}

