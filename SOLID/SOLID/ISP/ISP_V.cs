using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP_V
{
    #region Communication

    public interface ICommunication
    {
        void TextMessaging(string content);
        void WhatsAppText(string content);
        void VoiceMessage(string content);
    }

    class Iphone6 : ICommunication
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

    public class Nokia1100 : ICommunication
    {
        public void TextMessaging(string content)
        {
            
        }

        public void VoiceMessage(string content)
        {
            throw new NotImplementedException("Nokia 1100 does not have VoiceMessage ");
        }

        public void WhatsAppText(string content)
        {
            throw new NotImplementedException("Nokia 1100 does not have Whatsapp");
        }
    }

    #endregion
    public interface IEnquiry
    {
        double CalculateDiscount();
    }
    public interface ICustomer : IEnquiry
    {
        void Add();
        void Read();//Some clients want to read the customer information and if we implement this it will affect all the existing user.
    }
    public class Customer : ICustomer
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

    public class GoldCustomer : Customer
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 10;
        }

    }

    public class SilverCustomer : Customer
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 5;
        }

    }
    public class EnquiryCustomer : IEnquiry
    {
        public double CalculateDiscount()
        {
            return 2;
        }
    }

    
}
