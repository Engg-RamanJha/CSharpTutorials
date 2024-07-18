using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP_V
{
    

    class Customer
    {
        public void SaveCustomer()
        {
            //Sql Connection

            //Create Instace of database connection

            //Log the process

            //Send Email
        }
        public void Add()
        {
            try
            {
                //Implement Code for save customer
            }
            catch (Exception ex)
            {

                File.WriteAllText(@"d:\ErrorLog.txt", ex.ToString());
            }

        }

    }

    
}
