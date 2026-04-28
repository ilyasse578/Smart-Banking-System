using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsTransaction
    {
        public int TransactionID { get; set; }
        public int ClientID { get; set; }
        public int UserID { get; set; }
        public int TransactionTypeID { get; set; }
        public decimal Amount { get; set; }

        public enum enMode { AddNew, Update}
        public enMode Mode { get; set; }


        public clsTransaction()
        {
            this.TransactionID = -1;
            this.ClientID = -1;
            this.UserID = -1;
            this.TransactionTypeID = -1;
            this.Amount = 0;
            this.Mode = enMode.AddNew;
        }

        public clsTransaction(int transactionID, int clientID, int userID, int transactionTypeID, decimal amount)
        {
            this.TransactionID = transactionID;
            this.ClientID = clientID;
            this.UserID = userID;
            this.TransactionTypeID = transactionTypeID;
            this.Amount = amount;
            this.Mode = enMode.Update;
        }

        static public DataTable TransactionsList()
        {
            return clsTransactionData.TransactionsList();
        }

        static public clsTransaction FindByTransactionID(int TransactionID)
        {
            int clientID = -1, userID = -1, transactionTypeID = -1;
            decimal amount = 0;

            if(clsTransactionData.FindByTransactionID(TransactionID, ref clientID, ref userID, ref transactionTypeID, ref amount))
            {
                return new clsTransaction(TransactionID, clientID, userID, transactionTypeID, amount);
            }

            else
            {
                return null;
            }

        }

        static public clsTransaction FindByClientID(int ClientID)
        {
            int transactionID = -1, userID = -1, transactionTypeID = -1;
            decimal amount = 0;

            if (clsTransactionData.FindByClientID(ClientID, ref transactionID, ref userID, ref transactionTypeID, ref amount))
            {
                return new clsTransaction(transactionID, ClientID, userID, transactionTypeID, amount);
            }

            else
            {
                return null;
            }

        }

        static public clsTransaction FindByUserID(int UserID)
        {
            int transactionID = -1, clientID = -1, transactionTypeID = -1;
            decimal amount = 0;

            if (clsTransactionData.FindByUserID(UserID, ref transactionID, ref clientID, ref transactionTypeID, ref amount))
            {
                return new clsTransaction(transactionID, clientID, UserID, transactionTypeID, amount);
            }

            else
            {
                return null;
            }

        }

        public bool _AddNewTransaction()
        {
            int NewTransactionID = clsTransactionData.AddNewTransaction(this.ClientID, this.UserID, this.TransactionTypeID, this.Amount);
            return NewTransactionID != -1;
        }

        public bool _Update()
        {
            return clsTransactionData.UpdateTransaction(this.ClientID, this.UserID, this.TransactionTypeID, this.Amount);
        }

        public bool Save()
        {
            switch(this.Mode)
            {
                case enMode.AddNew:
                    if(_AddNewTransaction())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _Update();
            }

            return false;
        }

        static public bool Delete(int TransactionID)
        {
            return clsTransactionData.Delete(TransactionID);
        }

    }

}
