using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace MVCModelApp.Models.DAL
{
    public static class HelperFuctions
    {

        
        //Start SP Related Methods TblLogin

        public static bool IsLoginValid(string loginname, string pwd)
        {

            DbModel context = new DbModel();
           var lst = context.LoginAllList(loginname, pwd).First() ;
           if (lst == 1)
           {
               return true;
           }

           return false;
        }

        public static bool IsLoginExsist(string loginname)
        {

            DbModel context = new DbModel();
            var lst = context.IsLoginExsist(loginname).First();
            if (lst >= 1)
            {
                return true;
            }

            return false;
        }

        public static IEnumerable<EmpDeptReport_Result> EmpDeptReport (string srh)
        {

            DbModel context = new DbModel();
            var lst = context.EmpDeptReport(srh).ToList().OrderBy(x => x.Name);
            

            if (lst.Count() >= 1)
            {
                return lst;
            }

            return lst;
        }

        public static void ResetPassword(int id, string pwd)
        {
            DbModel context = new DbModel();
            var lst = context.ResetPasssword(id, pwd);
          
        }

        public static int ResetPassswordByEmail(string loginname, string pwd)
        {
            DbModel context = new DbModel();
            var lst = context.ResetPassswordByEmail(loginname, pwd);
            return lst;
        }
        

        public static string ComputeHash(string text)
        {

            string hash = null;
            UTF8Encoding encoder = new UTF8Encoding();
            // Dim sha As SHA256 = SHA256.Create()
            MD5 sha = MD5.Create();
            byte[] source = encoder.GetBytes(text);
            byte[] hashedSource = sha.ComputeHash(source);

            hash = BitConverter.ToString(hashedSource);
            return hash;

        }
        //End SP Related Methods TblLogin


      

        public static void AppSettings(out string UserID, out string Password, out string SMTPPort, out string Host)
        {
            UserID = ConfigurationManager.AppSettings.Get("UserID");
            Password = ConfigurationManager.AppSettings.Get("Password");
            SMTPPort = ConfigurationManager.AppSettings.Get("SMTPPort");
            Host = ConfigurationManager.AppSettings.Get("Host");
        }
        public static void SendEmail(string From, string Subject, string Body, string To, string UserID, string Password, string SMTPPort, string Host)
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add(To);
            mail.From = new MailAddress(From);
            mail.Subject = Subject;
            mail.Body = Body;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = Host;
            smtp.Port = Convert.ToInt16(SMTPPort);
            smtp.Credentials = new NetworkCredential(UserID, Password);
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }  


    }
}