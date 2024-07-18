using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    #region Communication
    interface iTextMessage
    {
        void TextMessaging(string content);
    }
    interface iWhatsAppText
    {
        void WhatsAppText(string content);
    }
    interface iVoiceMessage
    {
        void VoiceMessage(string content);
    }

    class Iphone6 : iTextMessage,iWhatsAppText,iVoiceMessage
    {
        public void TextMessaging(string content)
        {

        }

        public void VoiceMessage(string content)
        {

        }

        public void WhatsAppText(string content)
        {

        }
    }

    public class Nokia1100 : iTextMessage
    {
        public void TextMessaging(string content)
        {

        }        
    }
    #endregion

    ////Following LSP
    public interface IEnquiry
    {
        double CalculateDiscount();
    }
    public interface ICustomer : IEnquiry
    {
        void Add();
    }

    public interface IRead : ICustomer
    {
        void Read();
    }
    public class Customer : ICustomer,IRead
    {
        public virtual double CalculateDiscount()
        {
            return 0;
        }
        public virtual void Add()
        {
            try
            {
                //Implement Code for save customer
            }
            catch (Exception ex)
            {

                new FileErrorHandler().HandleError(ex.ToString());
            }
        }

        public void Read()
        {
            //Read customer details.
        }
    }

    public class GoldCustomerISP : Customer
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 10;
        }

    }

    public class SilverCustomerISP : Customer
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 5;
        }

    }
    public class EnquiryCustomerISP : IEnquiry
    {
        public double CalculateDiscount()
        {
            return 2;
        }
    }
}
