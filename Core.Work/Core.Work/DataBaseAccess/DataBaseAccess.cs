using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Core.Work.DataBaseAccess
{
    public class DataAccessBase
    {
        private Database database;
        private DbCommand dbCommand;



        private static string connString = ConfigurationManager.ConnectionStrings["DBConn"].ToString();

        public string GetMyName()
        {
            String strName = "";

            Database NamedDB = ConnectToDataBase();

            using (DbCommand dbCmd = NamedDB.GetStoredProcCommand("SP_NAME_TO_GET_DETAILS"))
            {
                strName = (string)NamedDB.ExecuteScalar(dbCmd);
            }
                return "";

        }

        private Database ConnectToDataBase()
        { 
            try
            {
                Database db = DatabaseFactory.CreateDatabase(connString);

                return db;
            }
            catch (Exception ex)
            {

                //Handle DB connection failures and log the errors to file using NLog.
                throw ex;
            }

        }


    }
}
