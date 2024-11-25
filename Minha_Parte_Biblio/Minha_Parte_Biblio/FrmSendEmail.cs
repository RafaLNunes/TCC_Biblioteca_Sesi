using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Minha_Parte_Biblio
{
    public partial class FrmSendEmail : Form
    {
        public FrmSendEmail(string EmailBase)
        {
            InitializeComponent();

            txtIndexMail.Text = EmailBase;
        }


        private void SendEmail_Click(object sender, EventArgs e)
        {
            // Coletar as informações do formulário
            string nome = txtFirstName.Text.ToString() + " " + txtSecondName.Text.ToString();
            string emailindex = txtIndexMail.Text;
            string emailremetente = txtremetente.Text;
            string mensagem = txtMensagem.Text;
            string emailassunto = txtAssunto.Text;

            // Criar um objeto de e-mail
            //MailMessage emailMessage = new MailMessage();
            //emailMessage.To.Add(emailindex);
            //emailMessage.Subject = "Formulário de contato";
            //emailMessage.Body = $"Nome: {nome}\nEmail: {emailremetente}\nMensagem: {mensagem}";

            // Enviar o e-mail //INFELIZMENTE PRECISA DE UM LOG IN
            //SmtpClient smtpClient = new SmtpClient();
            //smtpClient.Host = "seuservidordeemail.com";
            //smtpClient.Port = 587;
            //smtpClient.Credentials = new NetworkCredential("seuemail@example.com", "suasenha");
            //smtpClient.Send(emailMessage);

            try
            {
                // Configurar o cliente SMTP
                SmtpClient client = new SmtpClient("smtp.mailersend.net", 587) // Use o servidor SMTP e a porta apropriados
                {
                    Credentials = new NetworkCredential("MS_c5qogf@trial-0p7kx4xjwv7l9yjr.mlsender.net", "AtUu9pTt9jhRYv9I"),
                    EnableSsl = true // Ative SSL se necessário
                };

                // Criar o objeto MailMessage
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(emailremetente),
                    Subject = emailassunto,
                    Body = $"Nome: {nome}\nMensagem: {mensagem}",
                    IsBodyHtml = false
                };

                mail.To.Add(emailindex); // Adiciona o destinatário

                // Enviar o e-mail
                client.Send(mail);
                MessageBox.Show("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar e-mail: {ex.Message}");
            }

            //Mail to

        }

        private void FrmSendEmail_Load(object sender, EventArgs e)
        {

        }
    }
}
