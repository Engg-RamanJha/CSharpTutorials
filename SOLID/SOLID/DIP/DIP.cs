using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    #region Employee
    public interface iSaveEmployee
    {
        void SaveEmployee();
    }

    public class CompanyEmployee : iSaveEmployee
    {
        public void SaveEmployee()
        {
            Console.WriteLine("Saving Company Employee");
        }
    }
    public class ContractEmployee : iSaveEmployee
    {
        public void SaveEmployee()
        {
            Console.WriteLine("Saving Company Employee");
        }
    }

    public class Employee
    {
        
        iSaveEmployee saveEmployee = null;
        public Employee(iSaveEmployee iSaveEmployee)
        {
            saveEmployee = iSaveEmployee;
        }

        //public Employee(string empType)
        //{
        //    if(empType=="comp")
        //    {
        //        saveEmployee = new CompanyEmployee();
        //    }
        //    else
        //    {
        //        saveEmployee = new ContractEmployee();
        //    }
        //}

        public void SaveEmployee()
        {
            saveEmployee.SaveEmployee();
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
    public class Customer : ICustomer, IRead
    {
        IErrorHandler IErrorHandlerObj;
        //Violating DIP
        public Customer(string type)
        {
            if (type.ToLower() == "file")
            {
                IErrorHandlerObj = new FileErrorHandler();
            }
            else
            {
                IErrorHandlerObj = new XmlErrorHandler();
            }
        }

        //Following DIP
        public Customer(IErrorHandler obj)
        {
            IErrorHandlerObj = obj;
        }
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

                IErrorHandlerObj.HandleError(ex.ToString());
            }
        }

        public void Read()
        {
            //Read customer details.
        }
    }


}
