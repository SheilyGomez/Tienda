using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun.Cache;

namespace Presentacion
{
    class EnvioCorreo
    {
        private const string Usuario = "pedidosenvio.smart@gmail.com";
        private const string Contraseña = "cmqe sncr reqn xtwr";

        public static void EnviarCorreo(StringBuilder msg, DateTime Fecha, out string Error)
        {
            Error = "";

            try
            {
                msg.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(Usuario);
                mail.To.Add(Usuario);
                mail.Subject = $"Pedido de venta {UserLoginCache.LoginUser} {Fecha:g}";
                mail.Body = msg.ToString();
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(Usuario, Contraseña);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Error = "Éxito";
                MessageBox.Show(Error);
            }
            catch(Exception error)
            {
                Error = $"Error: {error}";
                MessageBox.Show(Error);
                return;
            }
        }
    }
}
