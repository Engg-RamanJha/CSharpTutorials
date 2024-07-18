using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{

    #region Employee

    public interface Salary
    {
        double Salary();

    }
    public interface Bonus
    {       
         double Bonus(double salary);

    }

    public class CompanyEmployee : Salary,Bonus
    {
        public  double Bonus(double salary)
        {
            return (salary * .10) / 100;
        }

        public  double Salary()
        {
            return 10000;
        }
    }

    public class ContractEmployee : Salary, Bonus
    {
        public  double Bonus(double salary)
        {
            return (salary * .05) / 100;
        }

        public  double Salary()
        {
            return 5000;
        }
    }

    public class ThirdPartyEmployee : Salary
    {
        public  double Salary()
        {
            return 2000;
        }
    }
    #endregion

    //Following LSP
    public interface IEnquiry
    {
        double CalculateDiscount();
    }
    public interface ICustomer:IEnquiry
    {
        void Add();
    }
    public class Customer:ICustomer
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
    public class EnquiryCustomer : IEnquiry
    {
        public double CalculateDiscount()
        {
            return 2;
        }
    }
}
