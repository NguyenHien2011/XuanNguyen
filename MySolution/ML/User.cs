using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class User
    {
        private String strUserName = "";
        private String strFullName = "";
        private String strAddress = "";
        private String strPassWord = "";

        public string UserName { get => strUserName; set => strUserName = value; }
        public string FullName { get => strFullName; set => strFullName = value; }
        public string Address { get => strAddress; set => strAddress = value; }
        public string PassWord { get => strPassWord; set => strPassWord = value; }

        public User() { }
        public User(DataRow objRow) 
        {
            this.UserName = Convert.ToString(objRow["USERNAME"]);
            this.FullName = Convert.ToString(objRow["FULLNAME"]);
            this.Address = Convert.ToString(objRow["ADDRESS"]);
            this.PassWord = Convert.ToString(objRow["PASSWORD"]);
        }
    }
}
