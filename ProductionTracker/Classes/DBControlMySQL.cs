using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Linq;
using System.Text;
using System;

namespace ProductionTracker
{
    class DBControlMySQL
    {
        //private OleDbConnection dbconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data " +
        //    "Source=Production.mdb");
        private MySqlConnection mysqlconn = new MySqlConnection("server=192.168.1.100;user=patritti;database=Patritti;port=3306;password=Welcome258!");

        //private OleDbCommand dbcmd; //cmd inputs
        private MySqlCommand dbcmd;

        /* data usage */
        //public OleDbDataAdapter dbda;
        public MySqlDataAdapter dbda;
        public DataTable dbdt;

        //query parameters
        public List<MySqlParameter> listParams = new List<MySqlParameter>();

        public int recordCount; //query stats
        public string exceptions; //when things break, they are listed here

        public async void ExecQuery(string Query)
        {
            //reset vars for each query
            recordCount = 0;
            exceptions = "";

            //do this async to wait for the db
            try
            {
                //open connection to db
                mysqlconn.Open();

                //use connection
                dbcmd = new MySqlCommand(Query, mysqlconn);

                //load params
                foreach (MySqlParameter p in listParams)
                    dbcmd.Parameters.Add(p);

                //clear params
                listParams.Clear();

                //execute
                dbdt = new DataTable();
                dbda = new MySqlDataAdapter(dbcmd);

                recordCount = dbda.Fill(dbdt);
            }
            catch (Exception err)
            {
                //exception handling for when queries go wrong
                exceptions = err.Message;
            }

            //close connection
            if (mysqlconn.State == ConnectionState.Open)
            {
                mysqlconn.Close();
            }
        }

        //query and command parameters
        public void AddParam(string name, object value)
        {
            var newParam = new MySqlParameter(name, value);

            listParams.Add(newParam);
        }
    }
}
