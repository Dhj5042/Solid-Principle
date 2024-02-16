using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalsDemo.SRP
{
    public class InvoiceBeforeSRP
    {
        public int InvoiceAmount { get; set; }
        public DateTime InvoiceDate { get; set; }

        public void AddInvoice()
        {
            try
            {

                Console.WriteLine("Invoice Created");
                this.SendInvoiceEmail();
                this.SendInvoiceMessage();
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
                this.SendInvoiceEmail();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void SendInvoiceEmail()
        {
            try
            {
                Console.WriteLine("Mail Sended Succesfully");
            }
            catch(Exception ex)  
            {
                Console.WriteLine("Something went wrong!!");
            }

        }
        public void SendInvoiceMessage()
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
