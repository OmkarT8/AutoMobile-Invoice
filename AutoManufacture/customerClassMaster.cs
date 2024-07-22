using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AutoManufacture
{
    public class customerClassMaster
    {
        TransactionLayer trns = new TransactionLayer();

        public DataTable getCustomers()
        {
            string query;
            query = "Select custname,address,gstpan,date from tbl_customerMaster";
            return trns.GetData(query);
        }

        public bool AddCustomer(string name, string address,string gstpan)
        {
            string query;
            query = "Insert into tbl_customerMaster(custname,address,gstpan,date) values(@cname,@address,@gstpn,'"+DateTime.Now.ToString("dd/MM/yyyy")+"')";

            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("@cname", name);
            param.Add("@address", address);
            param.Add("@gstpn", gstpan);

            if (trns.InsertData(query, param) > 0)
                return true;
            else
                return false;
        }

        public bool RemoveCustomer(string name)
        {
            string query;
            query = "Delete From tbl_customerMaster where custname=@cname";

            Dictionary<string, string> dctn = new Dictionary<string, string>();
            dctn.Add("@cname", name);

            if (trns.RemoveData(query, dctn) > 0)
                return true;
            else
                return false;
        }

        public bool UpdateCustomer(string address,string gstpan,string name)
        {
            string query;
            query = "Update tbl_customerMaster SET address=@address,gstpan=@gstpn where custname=@cname";

            Dictionary<string, string> dctnr = new Dictionary<string, string>();
            dctnr.Add("@address", address);
            dctnr.Add("@gstpn",gstpan);
            dctnr.Add("@cname", name);

            if (trns.UpdateData(query, dctnr) > 0)
                return true;
            else
                return false;
        }
    }
}
