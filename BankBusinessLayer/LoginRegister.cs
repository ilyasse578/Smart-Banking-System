using BankDataAccessLayer;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsLoginRegister
    {
        public int LoginRegisterID { get; set; }
        public DateTime Date { get; set; }
        public clsUser User { get; set; }

        public clsLoginRegister()
        {
            this.LoginRegisterID = -1;
            this.Date = DateTime.Now;
            this.User = null;
        }

        public clsLoginRegister(int loginRegisterID, DateTime date, clsUser user)
        {
            this.LoginRegisterID=loginRegisterID;
            this.Date = date;
            this.User = user;

        }

        static public DataTable LoginRegistersList()
        {
            return clsLoginRegisterData.LoginRegistersList();
        }

        public bool AddNewLoginRegister()
        {
            int loginRegisterID = clsLoginRegisterData.AddLoginRegister(this.Date, this.User.userID);

            return loginRegisterID != -1;
        }


    }
}
