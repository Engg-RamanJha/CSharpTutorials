using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP_V

{

    #region Employee
    public class Employee
    {
        public double CalculateBonus(string employeeType, double salary)
        {
            double bonus = 0;
            if (employeeType == "CompanyEmployee")
            {
                bonus = (salary * .10) / 100;
            }
            else if (employeeType == "ContractEmployee")
            {
                bonus = 0;
            }
            return bonus;
        }
    }
    #endregion

    class Customer
    {
        private int _customerType;
        public int CustomerType
        {
            get { return _customerType; }
            set { _customerType = value; }
        }

        public double CalculateDiscount()
        {
            if(_customerType==1)
            {
                return 10;
            }
            else
            {
                return 5;
            }
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
