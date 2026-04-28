using DataAccessLAyer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class clsUser
    {
        //URGENT IMPORTANT INFO :  after Save method Excuted , the last identity(the ID For the user just added ) given to userID . You can use it withoout problem  
        //Presentation layer script for Permissions : 
         
        public enum enPermissions { AllPermissions = -1, ManageClient = 1, ManageUser = 2, Transactions = 4, LoginRegister = 8 }
        public bool CheckUserPermissions(enPermissions enPermissions)
        {
            if(Convert.ToInt32(enPermissions.AllPermissions) == this.permissions)
                return true;
            else if((Convert.ToInt32(enPermissions)&this.permissions)== Convert.ToInt32(enPermissions))
                return true;
            else
                return false;
        }

        enum EnMode { Addnew , Update}
        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int permissions { get; set; }
        EnMode mode { get; set; }
        bool _AddNew()
        {
            userID = clsUserData.AddNewUser(username, password, permissions);
            return  userID!= -1;
        }
        bool _Update()
        {
            return clsUserData.UpdateUser(userID, username, password, permissions);
        }
       
       
        public clsUser()  
        { 
            userID = -1;
            username = string.Empty;
            password = string.Empty;
            permissions = -100;
            mode = EnMode.Addnew;
        }
       
        clsUser(int userid,string username,string password,int permissions)
        {
            this.userID = userid;
            this.username = username;
            this.password = password;
            this.permissions = permissions;
            mode = EnMode.Update;
        }
        public static DataTable GetAllUsers()
        {
            return clsUserData.UsersList();
        }
       
        static public bool Delete(string Username)
        {
            return clsUserData.DeleteUser(Username);
        }
       
        static public clsUser Find(string userName)
        {
            int userID = 0;
            string password = "";
            int permissions = 0;
       
            if (clsUserData.FindByUserName(userName,ref userID, ref password, ref permissions))
                return new clsUser(userID, userName, password, permissions);
            else
               return  null;
       
        }
       
        static public clsUser Find(string username, string password)
        {
            int userID = 0;
            //string username = "";
            int permissions = 0;
       
            if (clsUserData.FindByUserNameAndPassword(username,password, ref userID, ref permissions))
                return new clsUser(userID, username, password, permissions);
            else
                return null;
       
        }

        static public bool isExist(string username, string password)
        {
            return clsUserData.isExist(username, password);
        }
        static public bool isExist(string username)
        {
            return clsUserData.isExist(username);
        }

        public bool Save()
        {
            switch(mode)
            {
                case EnMode.Update:return _Update();
                case EnMode.Addnew: mode = EnMode.Update;return _AddNew();
                default: return false;
            }
        }
       
    }
}
