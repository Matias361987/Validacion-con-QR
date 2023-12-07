namespace VALIDACION_QR
{
    partial class Form1
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBoxUsuario2 = new System.Windows.Forms.TextBox();
            this.textBoxContraseña2 = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.Registrarse = new System.Windows.Forms.LinkLabel();
            this.picQrCode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(40, 103);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(64, 20);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(40, 156);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(92, 20);
            this.labelContraseña.TabIndex = 1;
            this.labelContraseña.Text = "Contraseña";
            // 
            // textBoxUsuario2
            // 
            this.textBoxUsuario2.Location = new System.Drawing.Point(195, 103);
            this.textBoxUsuario2.Name = "textBoxUsuario2";
            this.textBoxUsuario2.Size = new System.Drawing.Size(100, 26);
            this.textBoxUsuario2.TabIndex = 2;
            // 
            // textBoxContraseña2
            // 
            this.textBoxContraseña2.Location = new System.Drawing.Point(195, 153);
            this.textBoxContraseña2.Name = "textBoxContraseña2";
            this.textBoxContraseña2.Size = new System.Drawing.Size(100, 26);
            this.textBoxContraseña2.TabIndex = 3;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(44, 224);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(104, 45);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(183, 224);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(112, 45);
            this.buttonIngresar.TabIndex = 5;
            this.buttonIngresar.Text = "Continuar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // Registrarse
            // 
            this.Registrarse.AutoSize = true;
            this.Registrarse.Location = new System.Drawing.Point(131, 323);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(91, 20);
            this.Registrarse.TabIndex = 7;
            this.Registrarse.TabStop = true;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // picQrCode
            // 
            this.picQrCode.Location = new System.Drawing.Point(349, 103);
            this.picQrCode.Name = "picQrCode";
            this.picQrCode.Size = new System.Drawing.Size(292, 240);
            this.picQrCode.TabIndex = 17;
            this.picQrCode.TabStop = false;
            this.picQrCode.Click += new System.EventHandler(this.picQrCode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Escanea el Codigo QR:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(349, 416);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(118, 26);
            this.txtClave.TabIndex = 19;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Paso 2: Ingresa la clave que indica la aplicación";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(519, 416);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(122, 37);
            this.btnRegistrar.TabIndex = 21;
            this.btnRegistrar.Text = "Ingresar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Paso 1: Registrar dispositivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 508);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picQrCode);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxContraseña2);
            this.Controls.Add(this.textBoxUsuario2);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox textBoxUsuario2;
        private System.Windows.Forms.TextBox textBoxContraseña2;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.LinkLabel Registrarse;
        private System.Windows.Forms.PictureBox picQrCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label6;
    }
}

