using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Web;
using System.Net.Mail;
using System.IO;
using System.Text.RegularExpressions;

namespace ExceptionHandler
{
   public class ExceptionManager
    {
        /// <summary>
        /// Returns the default log device which will be mentioned in the configuration file.
        /// The value in the config file should have following values for devices:
        /// 1. TextFile
        /// 2. Database
        /// </summary>
        public static string SmtpServer = "smtp.gmail.com";

        public static string adminEmail = "secureserveithome@gmail.com";
        private static LogDevice DefaultErrorDevice
        {
            get
            {
                //Returns the value for log device from configuration file.
                string defaultDevice = "TextFile";// ConfigurationManager.AppSettings["DefaultErrorDevice"];
                try
                {
                    //Parses the device string value and returns the associated enum.
                    return (LogDevice)Enum.Parse(typeof(LogDevice), defaultDevice, true);
                }
                catch
                {
                    //Throws an exception if the invalid device text is specified.
                    throw new ArgumentException(string.Format("The device {0} is not valid. Use \"TextFile\" or \"Database\" instead.", defaultDevice));
                }
            }
        }
        //to get ApplicationPath
        public static string GetApplicationRoot()
        {
            var exePath = Path.GetDirectoryName(System.Reflection
                              .Assembly.GetExecutingAssembly().CodeBase);
            //Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:/+[\S\s]*?(?=/+bin)");
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(exePath).Value;
            return appRoot;
        }
        /// <summary>
        /// Returns the error log file name from the config file which is stored in appsettings section
        /// with ErrorLogFileName key name.
        /// </summary>
        private static string ErrorLogFileName
        {
            get
            {
                var buildDir = GetApplicationRoot();
              return  System.IO.Path.GetFullPath(buildDir + "/logs/err_log_" + System.DateTime.Now.ToString("ddMMyyyy") + ".txt");
                //return System.Web.HttpContext.Current.Server.MapPath("~/") + "logs/err_log_"+System.DateTime.Now.ToString("ddMMyyyy")+".txt";
            }
        }
        /// <summary>
        /// Appends the error details log into default device
        /// </summary>
        /// <param name="ex">Exception object which is thrown by the application</param>
        public static void AppendLog(Exception ex)
        {
            try
            {
                using (ExceptionProvider provider = new ExceptionProvider())
                {
                    string Message = ex.ToString();
                    provider.LogFileName = ErrorLogFileName;
                   
                    provider.AppendLog(DefaultErrorDevice, ex);
                    //EmailSend(Message);
                }
            }
            catch(Exception ex1)
            {

            }
        }

        public static void AppendLog(Exception ex, out string err)
        {
            err = string.Empty;
            try
            {
                using (ExceptionProvider provider = new ExceptionProvider())
                {
                    provider.LogFileName = ErrorLogFileName;
                    provider.AppendLog(DefaultErrorDevice, ex);
                }
            }
            catch (Exception inEx)
            {
                err = inEx.Message;
            }
        }
        public static bool EmailSend(string Ex)
        {
            bool chkSend = false;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer1 = new SmtpClient(SmtpServer);
                mail.From = new MailAddress(adminEmail);
                mail.To.Add("secureserveithome@gmail.com");
                mail.Subject = "Issue in EHRP Project";
                mail.Body = Ex.ToString();

                //System.Net.Mail.Attachment attachment;
                //string Location = System.Web.HttpContext.Current.Server.MapPath("~/") + "logs/err_log_" + System.DateTime.Now.ToString("ddMMyyyy") + ".txt"; ;
                //attachment = new System.Net.Mail.Attachment(Location);
                //mail.Attachments.Add(attachment);

                SmtpServer1.Port = 587;
                SmtpServer1.Credentials = new System.Net.NetworkCredential("secureserveithome@gmail.com", "SSITH@2016");
                SmtpServer1.EnableSsl = true;

                SmtpServer1.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return chkSend;
        }

    }
}
