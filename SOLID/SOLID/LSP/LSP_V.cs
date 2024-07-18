using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP_V
{
    #region Employee

    public abstract class Employee
    {
        public abstract double Salary();
        public abstract double Bonus(double salary);

    }

    public class CompanyEmployee : Employee
    {
        public override double Bonus(double salary)
        {
            return (salary * .10) / 100;
        }

        public override double Salary()
        {
            return 10000;
        }
    }

    public class ContractEmployee : Employee
    {
        public override double Bonus(double salary)
        {
            return (salary * .05) / 100;
        }

        public override double Salary()
        {
            return 5000;
        }
    }

    public class ThirdPartyEmployee : Employee
    {
        public override double Bonus(double salary)
        {
            throw new NotImplementedException("No bonus for ThirdPartyEmployee");
        }

        public override double Salary()
        {
            return 2000;
        }
    }
    #endregion
    #region Customer
    public class Customer
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
    public class EnquiryCustomer : Customer
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 5;
        }

        public override void Add()
        {
            throw new NotImplementedException("Enquirey customer can not be saved.");
        }
    }

    #endregion
}
