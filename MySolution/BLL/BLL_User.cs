using DAL;
using System.Data;
using ML;

namespace BLL
{
    public class BLL_User
    {
        public User loadInfo(string strUserName)
        {
            User user = new User();
            DAL_User objDAL_User = new DAL_User();
            DataTable dt = objDAL_User.LoadInfo(strUserName);
            if(dt != null)
            {
                user = new User(dt.Rows[0]);
            }
            return user;
        }
    }
}
