using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Eventick
{
    public class Correo
    {
        public SmtpClient client = new SmtpClient();
        public MailMessage msg = new MailMessage();
        public System.Net.NetworkCredential smtpCreds = new System.Net.NetworkCredential("soporteeventick@gmail.com", "eventick1234");

        public void RecuperarContraseña(string sendTo, MySqlConnection conexion)
        {
            try
            {
                //setup SMTP Host Here
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.Credentials = smtpCreds;
                client.EnableSsl = true;

                string contrasenia = "";
                string consulta = "";

                if (!sendTo.Contains("@"))
                {
                    consulta = String.Format("SELECT email FROM usuario WHERE nickname='{0}'", sendTo);
                    MySqlCommand hacer = new MySqlCommand(consulta, conexion);

                    MySqlDataReader lector = hacer.ExecuteReader();
                    lector.Read();
                    sendTo = lector.GetString(0);
                    lector.Close();
                }
                consulta = String.Format("SELECT contrasenia FROM usuario WHERE email='{0}'", sendTo);
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                contrasenia = reader.GetString(0);
                reader.Close();


                //converte string to MailAdress

                MailAddress to = new MailAddress(sendTo);
                MailAddress from = new MailAddress("soporteeventick@gmail.com");

                //set up message settings

                msg.Subject = "Recuperar contraseña";
                msg.Body = "Has soliciado recuperar tu contraseña.\n" +
                    "Tu contraseña es: " + contrasenia +
                    "\nTe recomendamos que cambies la contraseña.";
                msg.From = from;
                msg.To.Add(to);

                // Enviar E-mail

                client.Send(msg);
                MessageBox.Show("Revisa tu correo electrónico", "Correo enviado");

            }
            catch (Exception error)
            {
                MessageBox.Show("Unexpected Error: " + error);
            }

        }

        public string EnviarCodigo(string sendTo, MySqlConnection conexion)
        {
            try
            {
                //setup SMTP Host Here
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.Credentials = smtpCreds;
                client.EnableSsl = true;

                string contrasenia = "";
                string consulta = "";

                //converte string to MailAdress

                MailAddress to = new MailAddress(sendTo);
                MailAddress from = new MailAddress("soporteeventick@gmail.com");

                Random rand = new Random();

                string codigo = "";
                for (int i = 0; i <=5; i++)
                {
                    codigo += rand.Next(0, 9).ToString();
                }

                //set up message settings

                msg.Subject = "Código de verificación";
                msg.Body = "El código para crear tu cuenta es: "+codigo;
                msg.From = from;
                msg.To.Add(to);

                // Enviar E-mail

                client.Send(msg);
                
                MessageBox.Show("Revisa tu correo electrónico", "Correo enviado");
                return codigo;
            }
            catch (Exception error)
            {
                MessageBox.Show("Unexpected Error: " + error);
                return "";
            }

        }

    }
}