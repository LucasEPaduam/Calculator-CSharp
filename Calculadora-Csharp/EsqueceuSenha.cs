using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Calculadora_Csharp
{
    internal class EsqueceuSenha
    {

        DataTable dt = new DataTable();


        public void sendEmail(string cpf, string nomeUser, string emailUser, string password)
        {
           
            
            try
            {

                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("calculatorsifsp@gmail.com", "inrokjzhaemseokv"),
                    EnableSsl = true
                };
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("calculatorsifsp@gmail.com"),
                    Subject = "Calculator - Esqueceu senha",
                    Body = "<h1>Olá " + nomeUser + " !!!</h1><p> Segue a senha solicitada: " + password + "</p>",
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(emailUser);         

                client.Send(mailMessage);

                MessageBox.Show("Email enviado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Não foi possível enviar o email" + ex);
            }



        }
       





    }
}


