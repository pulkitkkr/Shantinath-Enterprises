using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
          {

              MailMessage message = new MailMessage();
              message.From = new MailAddress(TextBox2.Text);
              message.To.Add(new MailAddress(("shantinathpvc@gmail.com")));
              message.Subject = TextBox4.Text;
              message.IsBodyHtml = true;
              string a = "Sender Name:-" + TextBox1.Text + " Mobile:-" + TextBox3.Text + " enquiry :-" + TextBox5.Text;

              message.Body = a;
              SmtpClient smtp = new SmtpClient();    
             smtp.Host = "smtp.gmail.com";
              smtp.EnableSsl = true;
              System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
              NetworkCred.UserName = "shantinathpvc@gmail.com";
              NetworkCred.Password = "mcbbox123";
              smtp.UseDefaultCredentials = true;
              smtp.Credentials = NetworkCred;
              smtp.Port = 587;      
       
             
             smtp.Send(message);
             Label1.Text = "message sent";
             Label1.Visible = true;
             TextBox1.Text = null;
             TextBox2.Text = null;
             TextBox3.Text = null;
             TextBox4.Text = null;
             TextBox5.Text = null;
             
          }
}