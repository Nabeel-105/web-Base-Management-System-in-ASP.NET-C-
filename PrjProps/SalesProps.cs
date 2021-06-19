using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjProps
{
  public class SalesProps
    {
        private String reciept;
        private String product_name;
        private String price;
        private String stock;
        private String quantity;
        private String date;
        private String soldby;

        public string Reciept
        {
            get
            {
                return reciept;
            }

            set
            {
                reciept = value;
            }
        }

        public string Product_name
        {
            get
            {
                return product_name;
            }

            set
            {
                product_name = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        public string Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Soldby
        {
            get
            {
                return soldby;
            }

            set
            {
                soldby = value;
            }
        }
    }
}
