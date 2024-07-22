using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AutoManufacture
{
    class AddPartClassMaster
    {
        TransactionLayer transac = new TransactionLayer();

        public DataTable GetParts()
        {
            string query;
            query = "Select partno,partdes,hsncode,cgst,sgst,mrp from tbl_PartsMaster";
            return transac.GetData(query);
        }

        public bool AddPart(string partno, string partdes, string hsncode,string cgst,string sgst, string mrp)
        {
            string query;
            query = "Insert into tbl_PartsMaster values(@partno,@partdes,@hsncode,@cgst,@sgst,@mrp)";

            Dictionary<string, string> param = new Dictionary<string, string>();
            
            param.Add("@partno", partno);
            param.Add("@partdes", partdes);
            param.Add("@hsncode", hsncode);
            param.Add("@cgst", cgst);
            param.Add("@sgst", sgst);
            param.Add("@mrp", mrp);

            if (transac.InsertData(query, param) > 0)
                return true;
            else
                return false;
        }
        public bool RemovePart(string partno)
        {
            string query;
            query = "Delete From tbl_PartsMaster where partno=@partno";

            Dictionary<string, string> dctn = new Dictionary<string, string>();
            dctn.Add("@partno", partno);

            if (transac.RemoveData(query, dctn) > 0)
                return true;
            else
                return false;
        }

        public bool UpdatePart(string partdes,string hsncode,string cgst,string sgst, string mrp, string partno)
        {
            string query;
            query = "Update tbl_PartsMaster SET partdes=@partdes,hsncode=@hsncode,cgst=@cgst,sgst=@sgst,mrp=@mrp where partno=@partno";

            Dictionary<string, string> dctnr = new Dictionary<string, string>();

            dctnr.Add("@partdes", partdes);
            dctnr.Add("@hsncode", hsncode);
            dctnr.Add("@cgst", cgst);
            dctnr.Add("@sgst", sgst);
            dctnr.Add("@mrp", mrp);
            dctnr.Add("@partno", partno);

            if (transac.UpdateData(query, dctnr) > 0)
                return true;
            else
                return false;
        }

        public bool TruncateAllRecords()
        {
            string query;
            query = "TRUNCATE TABLE tbl_PartsMaster";
            if (transac.TruncateData(query) > 0)
                return true;
            else
                return false;
        }

        public DataTable GetPartNo(string partn)
        {
            string query;
            query = "select partno from tbl_PartsMaster where partno like @partn + '%'";

            Dictionary<string, string> dictn = new Dictionary<string, string>();
            dictn.Add("@partn", partn);

            return transac.SpecificData(query, dictn);
        }
    }
}
