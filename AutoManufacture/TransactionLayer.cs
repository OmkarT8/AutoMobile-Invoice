using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutoManufacture
{
     public class TransactionLayer
    {
        SqlConnection con;
        DataLayer sqlcon;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        DataTable dt;

        public TransactionLayer()
        {
            con = new SqlConnection();
            sqlcon = new DataLayer();
            con = sqlcon.createConn();
            checkConnection();
        }

        public bool checkConnection()
        {
            try
            {
                con = new SqlConnection();
                con = sqlcon.createConn();
                con.Open();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable GetData(string query)
        {
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public int InsertData(string query, Dictionary<string, string> param)
        {
            cmd = new SqlCommand(query, con);
            foreach (var item in param)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }
            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return recordsAffected;
        }

        public int RemoveData(string query, Dictionary<string, string> rdict)
        {
            cmd = new SqlCommand(query, con);
            foreach (var item in rdict)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }
            con.Open();
            int RecordDelete = cmd.ExecuteNonQuery();
            con.Close();
            return RecordDelete;
        }

        public int UpdateData(string query, Dictionary<string, string> udict)
        {
            cmd = new SqlCommand(query, con);
            foreach (var item in udict)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }
            con.Open();
            int recordupdate = cmd.ExecuteNonQuery();
            con.Close();
            return recordupdate;
        }


        public DataTable SpecificData(string query, Dictionary<string, string> param)
        {
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            foreach (var item in param)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public int TruncateData(string query)
        {
            cmd = new SqlCommand(query, con);
            con.Open();
            int recordstruncated=cmd.ExecuteNonQuery();
            con.Close();
            return recordstruncated;
        }
    }
}
