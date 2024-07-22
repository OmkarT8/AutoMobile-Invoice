using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoManufacture
{
    class OrderClassMaster
    {
        TransactionLayer trns = new TransactionLayer();

        public DataTable GetPartList(string partn)
        {
            string query;
            query = "select hsncode from tbl_PartsMaster where partno like @partn + '%'";

            Dictionary<string, string> dictn = new Dictionary<string, string>();
            dictn.Add("@partn", partn);

            return trns.SpecificData(query, dictn);
        }

        public DataTable GetPrice(string sIndex)
        {
            string query;
            query = "select mrp from tbl_PartsMaster where partno=@sindex";

            Dictionary<string, string> dictn = new Dictionary<string, string>();
            dictn.Add("@sindex", sIndex);

            return trns.SpecificData(query, dictn);
        }

        public bool placeOrder(string name, string invoice, string partno, string qty, string dicsp, string dis, string total,string date)
        {
            string query;
            query = "Insert into tbl_orderDetails(name,invoice,partno,quantity,discp,disc,total,date) values(@name,@invoice,@partno,@qty,@discp,@dis,@total,@date)";

            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("@name", name);
            param.Add("@invoice", invoice);
            param.Add("@partno", partno);
            param.Add("@qty", qty);
            param.Add("@discp", dicsp);
            param.Add("@dis", dis);
            param.Add("@total", total);
            param.Add("@date", date);


            if (trns.InsertData(query, param) > 0)
                return true;
            else
                return false;
        }

        public DataTable GetAllOrders()
        {
            string query;
            query = "Select name,invoice,partno,quantity,discp,disc,total,date from tbl_orderDetails";
            return trns.GetData(query);
        }

        public DataTable GetOrderDetails(string Name)
        {
            string query;
            query = "select name,invoice,partno,quantity,discp,disc,total,date from tbl_orderDetails where name like @name + '%'";

            Dictionary<string, string> dictn = new Dictionary<string, string>();
            dictn.Add("@name", Name);

            return trns.SpecificData(query, dictn);
        }
    }
}
