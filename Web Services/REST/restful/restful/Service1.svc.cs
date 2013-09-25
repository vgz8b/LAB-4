using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace restful
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "add/{a}/{b}")]
        public person Add(string a,string b)
        {
            double c;
            int v1 = Convert.ToInt32(a);
            int v2 = Convert.ToInt32(b);
            c = v1 + v2;
            return new person()
            {
                Operation = "Addition",
                Output =  Convert.ToDouble(c)
            };
        }
         [WebInvoke(Method ="GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "sub/{a}/{b}")]
        public person Sub(string a,string b)
        {
            double c;
            int v1 = Convert.ToInt32(a);
            int v2 = Convert.ToInt32(b);
            c = v1 - v2;
            return new person()
            {
                Operation = "Subtraction",
                Output = Convert.ToDouble(c)
            };
        }
         [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "mul/{a}/{b}")]
        public person Mul(string a,string b)
        {
            double c;
            int v1 = Convert.ToInt32(a);
            int v2 = Convert.ToInt32(b);
            c = v1 * v2;
            return new person()
            {
                Operation = "Multiplication",
                Output = Convert.ToDouble(c)
            };
        }
         [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "div/{a}/{b}")]
        public person Div(string a,string b)
        {
            double c;
            int v1 = Convert.ToInt32(a);
            int v2 = Convert.ToInt32(b);
            c = v1 / v2;
            return new person()
            {
                Operation = "Division",
                Output = Convert.ToDouble(c)
            };
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
    }
   
    public class person
    {
        public string Operation { get; set; }
        public double Output { get; set; }
    }
}
