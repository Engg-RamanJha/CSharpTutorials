using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IErrorHandler
    {
        void HandleError(string err);
    }
    public class FileErrorHandler:IErrorHandler
    {
        public void HandleError(string err)
        {
            File.WriteAllText(@"d:\ErrorLog.txt", err);
        }
    }
    public class XmlErrorHandler : IErrorHandler
    {
        public void HandleError(string err)
        {
            //Write error in Xml 
        }
    }
}
