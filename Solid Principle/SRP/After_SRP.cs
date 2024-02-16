using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalsDemo.SRP
{
    public class Invoice
    {
        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }
        public void AddInvoice()
        {
            try
            {

                Console.WriteLine("Invoice Created");
                SendMail.SendInvoiceEmail();
                SendSMS.SendInvoiceMessage();
                 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        public void DeleteInvoice()
        {
            try
            {
                Console.WriteLine("Invoice Deleted!!");
                SendMail.SendInvoiceEmail();
                SendSMS.SendInvoiceMessage();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }


    public class SendMail
    {
        public static void SendInvoiceEmail()
        {
            try
            {
                Console.WriteLine("Mail Sended Succesfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!!");
            }

        }
    }

    public class SendSMS
    {
        public static void SendInvoiceMessage()
        {
            try
            {
                Console.WriteLine("SMS Sended Succesfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!!");
            }

        }
    }
}
