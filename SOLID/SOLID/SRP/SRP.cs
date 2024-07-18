using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    
    class Customer
    {
        public void SaveCustomer()
        {
            MangeConnection connection = new MangeConnection();

            IErrorHandler errorHandler = new FileErrorHandler();
            errorHandler.HandleError("Data Saved");

            SendEmail send = new SendEmail();
        }
        public void Add()
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

    }

    public class MangeConnection
    {

    }

    public class SendEmail
    {

    }


}
