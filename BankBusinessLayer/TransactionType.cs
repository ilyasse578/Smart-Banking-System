using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsTransactionType
    {
        public int TransactionTypeID { get; set; }
        public string TransactionType { get; set; }

        public clsTransactionType(int transactionTypeID, string transactionType)
        {
            this.TransactionTypeID = transactionTypeID;
            this.TransactionType = transactionType;
        }

        static public clsTransactionType Find(int TransactionTypeID)
        {
            string transactionType = "";

            if(clsTransactionTypeData.Find(TransactionTypeID, ref transactionType))
            {
                return new clsTransactionType(TransactionTypeID, transactionType);
            }

            else
            {
                return null;
            }
        }

    }

}
