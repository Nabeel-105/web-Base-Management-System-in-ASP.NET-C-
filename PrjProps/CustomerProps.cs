using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjProps
{
  public  class CustomerProps
    {
        private String cid;
        private String cname;
        private String cell;
        private String no_of_item;
        private String t_bill;

        public string Cid
        {
            get
            {
                return cid;
            }

            set
            {
                cid = value;
            }
        }

        public string Cname
        {
            get
            {
                return cname;
            }

            set
            {
                cname = value;
            }
        }

        public string Cell
        {
            get
            {
                return cell;
            }

            set
            {
                cell = value;
            }
        }

        public string No_of_item
        {
            get
            {
                return no_of_item;
            }

            set
            {
                no_of_item = value;
            }
        }

        public string T_bill
        {
            get
            {
                return t_bill;
            }

            set
            {
                t_bill = value;
            }
        }
    }
}
