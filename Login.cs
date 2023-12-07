using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QRCoder;
using Google.Authenticator;
using OtpSharp;
using ZXing;
using System.Windows.Controls;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VALIDACION_QR
{
    public partial class Form1 : Form
    {
        private string secretKey;
        public Form1()
        {
            InitializeComponent();
        }

        public object Usuario { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            REGISTRO form = new REGISTRO();
            form.ShowDialog();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string username = textBoxUsuario2.Text;
            string password = textBoxContraseña2.Text;
            


            byte[] randomKey = KeyGeneration.GenerateRandomKey(20);

            secretKey = Google.Authenticator.Base32Encoding.ToString(randomKey);
            string url = $"otpauth://totp/VALIDACIONQR:{textBoxUsuario2.Text}?secret={secretKey}&issuer=VALIDACIONQR";

            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.QR_CODE;

            var barcodeBitmap = barcodeWriter.Write(url);
            picQrCode.Image = barcodeBitmap;



            using (SqlConnection connection = new SqlConnection("server=ROBBENSON;database=Validacion;Integrated Security=True"))
            {
                {
                    try
                    {
                       connection.Open();
                        

                        string username2 = textBoxUsuario2.Text;
                        string password2 = textBoxContraseña2.Text;

                        string query = $"SELECT * FROM Usuarios WHERE Username = '{username}' AND Password = '{password}'";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Agrega parámetros
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password);

                            // Ejecuta la consulta
                            int userCount = (int)command.ExecuteScalar();

                            if (userCount > 0)
                            {
                                MessageBox.Show("Inicio de sesión exitoso");

                                // Abre el formulario de inicio
                                Inicio formularioInicio = new Inicio();
                                formularioInicio.Show();

                                // Cierra el formulario actual si es necesario
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }


            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            REGISTRO formulario = new REGISTRO();
            formulario.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picQrCode_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string claveIngresada = txtClave.Text;
            var totp = new Totp(Base32Encoding.ToBytes(secretKey));
            bool esClaveValida = totp.VerifyTotp(claveIngresada, out long timeStepMatched);



            if (esClaveValida)
            {

                MessageBox.Show("Ingreso realizado con exito.");
                // La clave es válida, puedes redirigir a tu formulario de inicio
                Inicio formularioInicio = new Inicio();
                formularioInicio.Show();

                // O realizar otras acciones necesarias después de la autenticación
            }
            else
            {
                MessageBox.Show("Clave incorrecta. Inténtalo nuevamente.");
            }
    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


