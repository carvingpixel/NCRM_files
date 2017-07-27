using System;
using System.Net;
using System.Net.Mail;

// Base Class Used in Registrar Request View and Curriculum Request Views //

namespace NCRM
{
    //Ash nazg durbatulûk
    public class EmailNotify
    {
        //PROPERTIES-----------------------------------------------//
        private const string SysClient = "HIDDENRESOURCE";
        private const string SysEmail = "HIDDENRESOURCE";
        private const string EmTech = "HIDDENRESOURCE";

        private const string SendSignature =
            " \r\n  \r\n Sincerely,  \r\n  Department - NCRM System  \r\n **SMTP System Email - This Email is Not Monitored, Please Do Not Reply**";

        private const string EmSubject = "HIDDENRESOURCE";
        private const string SysPassword = "HIDDENRESOURCE";
        //sendTo - Method Parameter
        //sendBody - Method Parameter


        public void SchoolNotification(string sendBody)
        {
        }


        //METHOD: SMTP EMAIL TO REGISTRATION COURSE APPROVED ----------------------------------------------//
        public void EmailNotification(string sendTo, string sendBody)
        {
            try
            {
                using (var client = new SmtpClient(SysClient))
                {
                    var message = new MailMessage {From = new MailAddress(SysEmail)};

                    message.To.Add(sendTo);
                    message.CC.Add(EmTech);
                    message.Body = sendBody + SendSignature;
                    message.Subject = EmSubject;
                    client.UseDefaultCredentials = false;
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(SysEmail, SysPassword);
                    client.Send(message);
                }
            }
            catch (SmtpFailedRecipientsException sfrEx)
            {
                // TODO: Handle exception
                // When email could not be delivered to all receipients.
                throw sfrEx;
            }
            catch (SmtpException sEx)
            {
                // TODO: Handle exception
                // When SMTP Client cannot complete Send operation.
                throw sEx;
            }
            catch (Exception ex)
            {
                // TODO: Handle exception
                // Any exception that may occur during the send process.
                throw ex;
            }
        }


//ENDOFLINE
    }
}