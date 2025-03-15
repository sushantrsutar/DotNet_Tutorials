using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsDemoTQ
{
    internal class Product
    {
        private int productid;
        private string productname;
        private double productprice;

        public int ProductId {
            set { productid = value; }
            get { return productid; }
        }

        public string ProductName
        {
            set { productname = value; }
            get { return productname; }
        }

        public double ProductPrice
        {
            set { productprice = value; }
            get { return productprice; }
        }

        public string show() {
            return $"product id : {productid},product name : {productname},product price : {productprice}";
        }
    }
}
