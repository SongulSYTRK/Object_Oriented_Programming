using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Exception
{
    public class HasNumber : ApplicationException
    {
        public string Text { get; set; }
        public override string Message => "Metin içerisinde sayısal değer yer alamaz ...!";
        public HasNumber(string parametre) 
        {
            this.Text = parametre;
            GetException();
            GetSendMail();
        }
        private void GetException()
        {          
            string folderUrl = Application.StartupPath + @"\log.txt";
            DateTime ExceptionDate = DateTime.Now;
            string message = this.Message; 
            string text = this.Text; 

             
            StreamWriter streamwriter = new StreamWriter(folderUrl, true, Encoding.UTF8);
           
            StringBuilder sb = new StringBuilder();
            sb.Append(text);
            sb.Append("-");
            sb.Append(message);
            sb.Append("-");
            sb.Append(ExceptionDate);
            streamwriter.WriteLine(sb.ToString());
            streamwriter.Close(); 

        }
        public void GetSendMail()
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("songulsytrk@gmail.com");
            mail.Subject = "HasNumberException ";
            mail.Body = "exception hatası oluştu.Sayısal değer girişi yapıldı";
            mail.To.Add("songulsytrk@gmail.com");
            mail.Attachments.Clear();

            SmtpClient mailClient = new SmtpClient();
            mailClient.Credentials = new System.Net.NetworkCredential("songuslytrk@gmail.com", "şifre");
            mailClient.EnableSsl = true;
            mailClient.Host = "smpt.gmail.com";
            mailClient.Port = 587;
            mailClient.Send(mail);

        }


    }
}
