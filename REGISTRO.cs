using OtpNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;


namespace VALIDACION_QR
{
    public partial class REGISTRO : Form
    {
        private string secretKey;
        public REGISTRO()
        {
            InitializeComponent();
        }

        private void ButtonCance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)

        {
            byte[] randomKey = KeyGeneration.GenerateRandomKey(20);

            secretKey = Google.Authenticator.Base32Encoding.ToString(randomKey);
            string url = $"otpauth://totp/VALIDACIONQR:{textBoxUsuario.Text}?secret={secretKey}&issuer=VALIDACIONQR";

            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.QR_CODE;

            var barcodeBitmap = barcodeWriter.Write(url);
            picQrCode.Image = barcodeBitmap;

        }


        private void REGISTRO_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string claveIngresada = txtClave.Text;
            var totp = new Totp(Base32Encoding.ToBytes(secretKey));
            bool esClaveValida = totp.VerifyTotp(claveIngresada, out long timeStepMatched);

            if (esClaveValida)
            {

                MessageBox.Show("Usuario registrado con Exito.");
                // La clave es válida, puedes redirigir a tu formulario de inicio
                Inicio formularioInicio = new Inicio();
                formularioInicio.Show();

                // O realizar otras acciones necesarias después de la autenticación
            }
            else
            {
                MessageBox.Show("Clave incorrecta. Inténtalo nuevamente.");
            }
            using (SqlConnection connection = new SqlConnection("server=ROBBENSON;database=Validacion;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    string username = textBoxUsuario.Text;
                    string password = textBoxContraseña.Text;
                    string secretKey = textBoxConfirmar.Text;

                    // Consulta SQL para la inserción
                    string query = "INSERT INTO Usuarios(Username, Password, SecretKey) VALUES (@Username, @Password, @SecretKey)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agrega parámetros
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@SecretKey", secretKey);

                        // Ejecuta la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Inserción exitosa");
                        }
                        else
                        {
                            Console.WriteLine("La inserción no tuvo éxito");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
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

