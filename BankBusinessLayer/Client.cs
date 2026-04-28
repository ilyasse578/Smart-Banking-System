using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsClient
    {
        public int ClientID { get; set; }
        public string AccountNumber { get; set; }
        public string PinCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }

        public enum enMode {AddNew, Update}

        public enMode Mode { get; set; }

        public clsClient()
        {
            this.ClientID = -1;
            this.AccountNumber = "";
            this.PinCode = "";
            this.FirstName = "";
            this.LastName = "";
            this.Phone = "";
            this.Email = "";
            this.Balance = 0;
            this.Mode = enMode.AddNew;
        }

        public clsClient(int ClientID, string accountNumber, string pinCode, string firstName,string lastName, string phone, string email, decimal balance)
        {
            this.ClientID = ClientID;
            this.AccountNumber = accountNumber;
            this.PinCode = pinCode;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
            this.Balance = balance;
            this.Mode = enMode.Update;
        }

        static public DataTable ClientsList()
        {
            return clsClientData.ClientsList();
        }

        static public clsClient FindByID(int ClientID)
        {
            string AccountNumber = "", PinCode = "", FirstName = "",LastName="", Phone = "", Email = "";
            decimal Balance = 0;

            if (clsClientData.FindByID(ClientID, ref AccountNumber, ref PinCode, ref FirstName, ref LastName, ref Phone, ref Email, ref Balance))
            {
                return new clsClient(ClientID, AccountNumber, PinCode, FirstName, LastName, Phone, Email, Balance);
            }

            else
            {
                return null;
            }
        }

        static public clsClient FindByAccountNumber(string AccountNumber)
        {
            int ClientID = -1;
            string PinCode = "", FirstName = "", LastName = "", Phone = "", Email = "";
            decimal Balance = 0;

            if (clsClientData.FindByAccountNumber(AccountNumber, ref ClientID, ref PinCode, ref FirstName, ref LastName, ref Phone, ref Email, ref Balance))
            {
                return new clsClient(ClientID, AccountNumber, PinCode, FirstName, LastName, Phone, Email, Balance);
            }

            else
            {
                return null;
            }
        }

        static public bool isClientExist(string AccountNumber)
        {
            return clsClientData.IsClientExist(AccountNumber);
        }

        private bool _AddNewClient()
        {
            this.ClientID = clsClientData.AddNewClient(this.AccountNumber, this.PinCode, this.FirstName,this.LastName, this.Phone, this.Email, this.Balance);
            return this.ClientID != -1;
        }

        private bool _UpdateClient()
        {
            return clsClientData.UpdateClient(this.ClientID, this.AccountNumber, this.PinCode, this.FirstName, this.LastName, this.Phone, this.Email, this.Balance);
        }

        public bool Save()
        {
            switch(this.Mode)
            {
                case enMode.AddNew:
                    if(_AddNewClient())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                        return _UpdateClient();
            }

            return false;

        }

        static public bool Delete(int ClientID)
        {
            return clsClientData.DeleteClient(ClientID);
        }

        static public DataTable BalancesList()
        {
            return clsClientData.BalancesList();
        }

        static public decimal TotalBalances()
        {
            return clsClientData.TotalBalances();
        }

    }
}
