using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADRASHA_Main
{
    internal class DatabaseClass
    {
        SqlConnection conn; //connection object

        public DatabaseClass() 
        {
            //connecting to database and opening connection.
            conn = new SqlConnection(@"");
            conn.Open();
        }

        public void connect_database()
        {
            
        }

        public DataTable GetTableData(string sql)
        {
            //method to get data from table
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int GetAutoID(string sql)
        {
            //method to get next id from table
            int i = 1;
            try
            {
                DataTable dt = GetTableData(sql);
                if (dt.Rows.Count >= 1)
                {
                    i = (int.Parse(dt.Rows[0][0].ToString()) + 1);
                }
                else
                    i = 1;
            }
            catch (Exception)
            {

                i = 1;
            }
            return i;
        }

        public void ExecuteSqlquery(string sql)
        {
            //method to run sql query which return nothing
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public void FillGridData(DataGridView dv, string sql)
        {
            //to fill tables with datatable
            DataTable dt = GetTableData(sql);
            dv.DataSource = dt;
        }

        public void FillCombo(ComboBox cb, string sql, string dismemb, string val)
        {
            //to fill combobox from database
            DataTable dt = GetTableData(sql);

            cb.ValueMember = val;
            cb.DataSource = dt;
            cb.DisplayMember = dismemb;

        }
    }
}
