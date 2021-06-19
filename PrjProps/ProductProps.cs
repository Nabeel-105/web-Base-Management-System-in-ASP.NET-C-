using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjProps
{
   public class ProductProps
    {
        private String pid;
        private String title;
        private String price;
        private String stock;
        private String expiry;
        private String manufacturor;

        public string Pid
        {
            get
            {
                return pid;
            }

            set
            {
                pid = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
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

        public string Expiry
        {
            get
            {
                return expiry;
            }

            set
            {
                expiry = value;
            }
        }

        public string Manufacturor
        {
            get
            {
                return manufacturor;
            }

            set
            {
                manufacturor = value;
            }
        }
    }
}
