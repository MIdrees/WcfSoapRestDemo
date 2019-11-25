using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRestDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Product> GetProductListJ()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product { ID = "1", Name = "Product 1" });
            list.Add(new Product { ID = "2", Name = "Product 2" });
            list.Add(new Product { ID = "3", Name = "Product 3" });
            return list;
        }

        public List<Product> GetProductListX()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product { ID = "4", Name = "test4" });
            list.Add(new Product { ID = "5", Name = "test5" });
            list.Add(new Product { ID = "6", Name = "test6" });
            return list;
        }
    }
}
