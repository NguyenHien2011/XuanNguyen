using DataAccessLayer;
using System.Data;

namespace DAL
{
    public partial class DAL_User
    {
        public DataTable? LoadInfo(String strUserName)
        {
            DBManager dBManager = new DBManager(DataProvider.SqlServer, "");
            try
            {
                dBManager.Open();
                dBManager.CreateParameters(2);
                dBManager.AddParameters(0, "@", "");
                dBManager.AddParameters(1, "@", "");
                return dBManager.ExecuteDataTable(System.Data.CommandType.StoredProcedure, "storeProcName");
            }
            catch (Exception) 
            { 
                return null;
            }
            finally
            {
                dBManager.Close();
            }
        }    
    }
}
