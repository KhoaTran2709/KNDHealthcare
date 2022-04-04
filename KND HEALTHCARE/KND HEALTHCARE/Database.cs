using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace KND_HEALTHCARE
{
    class Database
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds;
        private static Database singleton = null;

        public static Database Singleton
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new Database();
                }
                return singleton;
            }
        }
        public Database()
        {
            string strCnn = "Data Source = KHOATRAN\\SQLEXPRESS; Initial Catalog = KNDHEALTHCARE; User = sa; Password = 123456; Integrated Security = True";
            sqlConn = new SqlConnection(strCnn);

        }
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        //Phuong thuc de thuc hien cac lenh Them, Xoa, Sua
        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open(); //Mo ket noi
            sqlcmd.ExecuteNonQuery();//Lenh hien lenh Them/Xoa/Sua
            sqlConn.Close();//Dong ket noi
        }
    }
}
