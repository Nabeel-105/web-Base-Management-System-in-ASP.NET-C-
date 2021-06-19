using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjProps
{
    public class SupplierProps
    {
        private String sid;
        private String sname;
        private String cell;
        private String itemsupply;
        private String name_of_reciver;
        private String amount;

        public string Sid
        {
            get
            {
                return sid;
            }

            set
            {
                sid = value;
            }
        }

        public string Sname
        {
            get
            {
                return sname;
            }

            set
            {
                sname = value;
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

        public string Itemsupply
        {
            get
            {
                return itemsupply;
            }

            set
            {
                itemsupply = value;
            }
        }

        public string Name_of_reciver
        {
            get
            {
                return name_of_reciver;
            }

            set
            {
                name_of_reciver = value;
            }
        }

        public string Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }
    }
}
