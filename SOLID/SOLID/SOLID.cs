using SOLID.ISP;
using SOLID.LSP;
using SOLID.OCP;
using SOLID.SRP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLID
{
    public partial class SOLID_Principals : Form
    {
        public SOLID_Principals()
        {
            InitializeComponent();
        }

        private void SOLID_Principals_Load(object sender, EventArgs e)
        {

        }

        #region SRP
        private void m_buttonViolatingSRP_Click(object sender, EventArgs e)
        {
            try
            {

                SRP_V.Customer customer = new SRP_V.Customer();
                customer.SaveCustomer();
                customer.Add();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void m_buttonFollowingSRP_Click(object sender, EventArgs e)
        {
            try
            {
                SRP.Customer customer = new SRP.Customer();
                customer.SaveCustomer();
                customer.Add();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion

        #region OCP
        private void m_buttonViolatingOCP_Click(object sender, EventArgs e)
        {
            try
            {
                OCP_V.Employee employee = new OCP_V.Employee();
                double bonus = employee.CalculateBonus("CompanyEmployee", 100000);

                OCP_V.Customer customer = new OCP_V.Customer();
                customer.CustomerType = 1;
                customer.CalculateDiscount();
                customer.Add();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void m_buttonFollowingOCP_Click(object sender, EventArgs e)
        {
            try
            {
                OCP.Bonus companyEmp = new OCP.CompanyEmployee();
                double bonus = companyEmp.CalculateBonus(100000);


                OCP.Customer customer = new OCP.Customer();
                customer.CalculateDiscount();

                customer = new OCP.GoldCustomer();
                customer.CalculateDiscount();

                customer = new OCP.SilverCustomer();
                customer.CalculateDiscount();

            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region LSP
        private void m_buttonViolatingLSP_Click(object sender, EventArgs e)
        {
            try
            {
                LSP_V.Employee employee = new LSP_V.CompanyEmployee();
                employee.Salary();
                employee.Bonus(10000);

                 employee = new LSP_V.ThirdPartyEmployee();
                employee.Salary();
                employee.Bonus(10000);

                List<LSP_V.Customer> customers = new List<LSP_V.Customer>();
                customers.Add(new LSP_V.GoldCustomer());
                customers.Add(new LSP_V.SilverCustomer());
                customers.Add(new LSP_V.EnquiryCustomer());

                foreach (LSP_V.Customer o in customers)
                {
                    o.CalculateDiscount();
                    o.Add();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void m_buttonFollowingLSP_Click(object sender, EventArgs e)
        {
            try
            {
                List<LSP.Customer> customers = new List<LSP.Customer>();
                customers.Add(new LSP.GoldCustomer());
                customers.Add(new LSP.SilverCustomer());
                //customers.Add(new LSP.EnquiryCustomer());

                foreach (LSP.Customer o in customers)
                {
                    o.CalculateDiscount();
                    o.Add();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region ISP
        private void m_buttonViolatingISP_Click(object sender, EventArgs e)
        {
            try
            {
                ISP_V.ICustomer customer = new ISP_V.Customer();
                customer.Add();
                customer.Read();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void m_buttonFollowingISP_Click(object sender, EventArgs e)
        {
            ISP.ICustomer oldCustomer = new ISP.Customer();
            oldCustomer.Add();

            ISP.IRead newCustomer = new ISP.Customer();
            newCustomer.Add();
            newCustomer.Read();

        }
        #endregion

        #region DIP
        private void m_buttonViolatingDIP_Click(object sender, EventArgs e)
        {

            DIP.ICustomer customer = new DIP.Customer("file");
            customer.Add();
        }

        private void m_buttonFollowingDIP_Click(object sender, EventArgs e)
        {
            DIP.Employee emp = new DIP.Employee(new DIP.CompanyEmployee());
            emp.SaveEmployee();

            emp = new DIP.Employee(new DIP.ContractEmployee());
            emp.SaveEmployee();

            DIP.ICustomer customer = new DIP.Customer(new FileErrorHandler());
            customer.Add();
        }
        #endregion

        #region Label 
        private void m_labelSOLID_Click(object sender, EventArgs e)
        {
            string val = $"The SOLID principles were introduced by Robert C. Martin in his 2000 paper “Design Principles and Design Patterns”. " +
                $"{Environment.NewLine}These concepts were later built upon by Michael Feathers, who introduced us to the SOLID acronym." +
                $"{Environment.NewLine}{Environment.NewLine}Maintainability: Code that adheres to SOLID principles is easier to maintain and modify over time, as it is structured in a clear and organized way." +
                $"{Environment.NewLine}{Environment.NewLine}Flexibility: SOLID code is also more flexible, as changes to one part of the system are less likely to have unintended consequences in other parts of the codebase." +
                $"{Environment.NewLine}{Environment.NewLine}Testability: SOLID code is easier to test, as it is designed with the principles of separation of concerns and dependency inversion in mind.";

            MessageBox.Show(val);
        }

        private void m_labelSRP_Click(object sender, EventArgs e)
        {
            string val = $"SRP says that each class, module or function in the program should only do one job." +
                $"These principles enable for easy testing, Parallel development due to loose coupling." +
                $"{Environment.NewLine}{Environment.NewLine}Each class should have only one responsibility." +
                $"{Environment.NewLine}{Environment.NewLine}The class should have only one reason to change." +
                $"{Environment.NewLine}{Environment.NewLine}The class should do one thing, and do it well.";
            MessageBox.Show(val);
        }

        private void m_labelOCP_Click(object sender, EventArgs e)
        {
            string val = $"OCP says that the classes,methods and modules etc are open for extension but close for modification." +
                $"{Environment.NewLine}{Environment.NewLine}Design classes to be easily extended." +
                $"{Environment.NewLine}{Environment.NewLine}Use abstractions such as abstract classes or interfaces to define extension points." +
                $"{Environment.NewLine}{Environment.NewLine}Avoid making changes to existing code when adding new functionality.";
            MessageBox.Show(val);
        }

        private void m_labelLSP_Click(object sender, EventArgs e)
        {
            string val = $"If we can successfully replace the object.instance of a parent class with the object/instance of the " +
                $"child class without affecting the behavior of the base class then it is said to be in Liskov Substitution Principle." +
                $"{Environment.NewLine}{Environment.NewLine}Ensure that subtypes can be substituted for their base types without affecting the correctness of the program." +
                $"{Environment.NewLine}{Environment.NewLine}Subtypes should not change the preconditions or postconditions of the methods of their base types." +
                $"{Environment.NewLine}{Environment.NewLine}should not introduce new exceptions that are not part of the exception hierarchy of their base types." +
                $"{Environment.NewLine}{Environment.NewLine}The Liskov substitution principle (LSP) is a particular definition of a subtyping relation, called " +
                $"strong behavioral subtyping, that was initially introduced by Barbara Liskov in a 1987 conference keynote address titled Data abstraction and hierarchy. " +
                $"It is based on the concept of 'substitutability' – a principle in object-oriented programming stating that an object (such as a class) " +
                $"may be replaced by a sub-object (such as a class that extends the first class) without breaking the program.";
            MessageBox.Show(val);
        }

        private void m_labelISP_Click(object sender, EventArgs e)
        {
            string val = $"ISP says clients should not be forced to implement interfaces they don’t use." +
                $"So instead of huge interfaces, it is better to create multiple small ones so that they are utilized in the best possible way." +
                $"{Environment.NewLine}{Environment.NewLine}Define small, focused interfaces that are specific to the needs of the clients that use them."+
                $"{Environment.NewLine}{Environment.NewLine}Avoid creating large, monolithic interfaces that force clients to implement methods they don't need."+
                $"{Environment.NewLine}{Environment.NewLine}Prefer multiple, specialized interfaces over a single, general-purpose interface.";
            MessageBox.Show(val);
        }

        private void m_labelDIP_Click(object sender, EventArgs e)
        {
            string val = $"DIP says that High Level modules should not depend on the low level modules. " +
                $"Instead both should depends on abstraction(interface)" +
                $"{Environment.NewLine}{Environment.NewLine}Define high-level modules that depend on abstractions, not on concrete implementations."+
                $"{Environment.NewLine}{Environment.NewLine}Define low-level modules that provide concrete implementations for the abstractions used by high - level modules."+
                $"{Environment.NewLine}{Environment.NewLine}Use dependency injection to provide the concrete implementations to the high - level modules.";
            MessageBox.Show(val);
        }
        #endregion
    }

}




