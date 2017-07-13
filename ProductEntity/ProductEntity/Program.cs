using ProductEntity;
using ProductEntity.ProductDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEntity
{
    class Program
    {
        Dictionary<int, string> productDic;
        MyProducts myp;

        public void fillDataDictionary()
        {
            myp = new MyProducts();
            myp.produ();

            var result = (from r in myp.GetAllProduct()
                          select r).ToList();

            productDic = new Dictionary<int, string>();

            foreach (var r in result)
            {
                //fill dic
                productDic.Add(r.ProductCode, r.ProductName);
            }
        }
        //return 
        public string getDataDictionary()
        {
            var res = from r in productDic
                      select r;

            return res.ToString();
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.fillDataDictionary();
            p.getDataDictionary();
            Console.Read();
        }
    }
}
