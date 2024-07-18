using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP

{
    #region Employee

    public abstract class Bonus
    {
        public abstract double CalculateBonus(double salary);
    }
    public class CompanyEmployee : Bonus
    {
        public override double CalculateBonus( double salary)
        {
            return (salary * .10) / 100;
        }
    }
    public class ContractEmployee : Bonus
    {
        public override double CalculateBonus( double salary)
        {
            return 0;
        }
    }
    #endregion
    public class Customer
    {
        public virtual double CalculateDiscount()
        {
            return 0;
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


}
