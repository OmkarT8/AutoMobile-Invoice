using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoManufacture
{
    public class OrderDetailsClass
    {
        public string partno { get; set; }

        public string hsncode { get; set; }

        public float mrp { get; set; }

        public float qnty { get; set; }

        public float netmrp { get; set; }

        public float discPercnt { get; set; }

        public float discount { get; set; }

        public float taxAmt { get; set; }

        public float cgstPercnt { get; set; }

        public float cgst { get; set; }

        public float sgstPercnt { get; set; }

        public float sgst { get; set; }

        public float total { get; set; }
    }
}
