namespace VALIDACION_QR
{
    partial class REGISTRO
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxConfirmar = new System.Windows.Forms.TextBox();
            this.ButtonCance = new System.Windows.Forms.Button();
            this.buttonRegistra = new System.Windows.Forms.Button();
            this.picQrCode = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(123, 81);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(68, 20);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(95, 141);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(96, 20);
            this.labelContraseña.TabIndex = 1;
            this.labelContraseña.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Contraseña:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(246, 78);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 26);
            this.textBoxUsuario.TabIndex = 3;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(246, 135);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(100, 26);
            this.textBoxContraseña.TabIndex = 4;
            // 
            // textBoxConfirmar
            // 
            this.textBoxConfirmar.Location = new System.Drawing.Point(246, 198);
            this.textBoxConfirmar.Name = "textBoxConfirmar";
            this.textBoxConfirmar.Size = new System.Drawing.Size(100, 26);
            this.textBoxConfirmar.TabIndex = 5;
            // 
            // ButtonCance
            // 
            this.ButtonCance.Location = new System.Drawing.Point(99, 271);
            this.ButtonCance.Name = "ButtonCance";
            this.ButtonCance.Size = new System.Drawing.Size(97, 45);
            this.ButtonCance.TabIndex = 6;
            this.ButtonCance.Text = "Cancelar";
            this.ButtonCance.UseVisualStyleBackColor = true;
            this.ButtonCance.Click += new System.EventHandler(this.ButtonCance_Click);
            // 
            // buttonRegistra
            // 
            this.buttonRegistra.Location = new System.Drawing.Point(249, 271);
            this.buttonRegistra.Name = "buttonRegistra";
            this.buttonRegistra.Size = new System.Drawing.Size(97, 45);
            this.buttonRegistra.TabIndex = 7;
            this.buttonRegistra.Text = "Registrar";
            this.buttonRegistra.UseVisualStyleBackColor = true;
            this.buttonRegistra.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // picQrCode
            // 
            this.picQrCode.Location = new System.Drawing.Point(420, 107);
            this.picQrCode.Name = "picQrCode";
            this.picQrCode.Size = new System.Drawing.Size(292, 240);
            this.picQrCode.TabIndex = 18;
            this.picQrCode.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Paso 1: Registrar dispositivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Escanea el Codigo QR:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(590, 432);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(122, 37);
            this.btnRegistrar.TabIndex = 27;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Paso 2: Ingresa la clave que indica la aplicación";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(420, 432);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(118, 26);
            this.txtClave.TabIndex = 25;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // REGISTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 499);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picQrCode);
            this.Controls.Add(this.buttonRegistra);
            this.Controls.Add(this.ButtonCance);
            this.Controls.Add(this.textBoxConfirmar);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.Name = "REGISTRO";
            this.Text = "REGISTRO";
            this.Load += new System.EventHandler(this.REGISTRO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxConfirmar;
        private System.Windows.Forms.Button ButtonCance;
        private System.Windows.Forms.Button buttonRegistra;
        private System.Windows.Forms.PictureBox picQrCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClave;
    }
}