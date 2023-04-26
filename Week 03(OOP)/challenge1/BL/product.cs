using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1.BL
{
   
    class product
    {
        public product()
        {
            product_name = "";
            product_categary = "";
            product_price = 0F;
            stock_quantity = 0F;
            Minimum_quantity = 0F;
        }
        public product(string product_name,string product_categary,float product_price,float stock_quantity,float Minimum_quantity)
        {
            this.product_name = product_name;
            this.product_categary = product_categary;
            this.product_price = product_price;
            this.stock_quantity = stock_quantity;
            this.Minimum_quantity = Minimum_quantity;
        }
        public product(product p)
        {
            this.product_name = p.product_name;
            this.product_categary = p.product_categary;
            this.product_price = p.product_price;
            this.stock_quantity = p.stock_quantity;
            this.Minimum_quantity = p.Minimum_quantity;
        }
        public string product_name;
        public string product_categary;
        public float product_price;
        public float stock_quantity;
        public float Minimum_quantity;
    }
}
