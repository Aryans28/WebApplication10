using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;

namespace WebApplication10
{
    public partial class replyfeedback : System.Web.UI.Page
    {
        concls co = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            string se = "select useremail from utab where userid=" + Session["uid"] + "";
            string s = co.Fun_scalar(se);
            TextBox1.Text = s;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string txt1 = TextBox1.Text;
            string txt2 = TextBox2.Text;
            string txt3 = TextBox3.Text;
            SendEmail("cloths", "aryanellikkal03@gmail.com", "hyre nddj mslk kvzp", "diya", txt1, txt2, txt3);
            string upd = "update feedbk set replymsg='" + TextBox3.Text + "',fstatus=1 where userid=" + Session["uid"] + "";
            int i = co.Fun_Non_Query(upd);
            if(i==1)
            {
                Label1.Visible = true;
                Label1.Text = "succesfuly sent";
            }
        }
        public static void SendEmail(string yourName, string yourGmailUserName, string yourGmailPassword, string toName, string toEmail, string subject, string body)

        {
            string to = toEmail; //To address    
            string from = yourGmailUserName; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = body;
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(yourGmailUserName, yourGmailPassword);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
    