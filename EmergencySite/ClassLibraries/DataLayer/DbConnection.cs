using EmergencySite.ClassLibraries.Exception;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EmergencySite.ClassLibraries.DataLayer
{
    class DbConnection
    {
        protected static string Constr = "";
        public static SqlConnection ConObj;

        #region Function used to get connection string
        public static SqlConnection GetDbConnection()
        {
            try
            {
                Constr = ConfigurationManager.ConnectionStrings["WesisDbContext"].ConnectionString;
                ConObj = new SqlConnection(Constr);
            }
            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DBConnection] " + "Methods[SqlConnection] " + ex.Message);
            }
            return ConObj;
        }
        #endregion 
 
        #region Function used to close connection
        public static void CloseConnection()
        {
            try
            {
                if (ConObj.State != ConnectionState.Closed)
                {
                    ConObj.Close();
                }
            }
            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DBConnection] " + "Methods[closeConnection] " + ex.Message);
            }
        }
        #endregion 
       
        #region Function used to open connetion
        public static void OpenConnection()
        {
            try
            {
                if (ConObj.State != ConnectionState.Open)
                {
                    ConObj.Open();
                }
            }
            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DBConnection] " + "Methods[openConnection] " + ex.Message);
            }
        }

        public static async Task OpenConnectionAsync()
        {
            try
            {
                if (ConObj.State != ConnectionState.Open)
                {
                    await ConObj.OpenAsync();
                }
            }
            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DBConnection] " + "Methods[openConnection] " + ex.Message);
            }
        }
        #endregion 
    }
}
