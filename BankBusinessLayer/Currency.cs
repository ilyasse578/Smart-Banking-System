using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsCurrency
    {
        public int CurrencyID { get; set; }
        public string Country { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Rate { get; set; }

        public clsCurrency()
        {
            this.CurrencyID = -1;
            this.Country = "";
            this.CurrencyName = "";
            this.CurrencyCode = "";
            this.Rate= 0;
        }

        public clsCurrency(int currencyID, string country, string currencyName, string currencyCode, decimal rate)
        {
            this.CurrencyID = currencyID;
            this.Country = country;
            this.CurrencyName = currencyName;
            this.CurrencyCode = currencyCode;
            this.Rate = rate;
        }

        public DataTable CurrenciesList()
        {
            return clsCurrencyData.CurrenciesList();
        }

        public clsCurrency Find(string CurrencyCode)
        {
            int currencyID = -1;
            string country = "", currencyName = "", currencyCode = "";
            decimal rate = 0;

            if(clsCurrencyData.Find(CurrencyCode, ref currencyID, ref country, ref currencyName, ref rate))
            {
                return new clsCurrency(currencyID, country, currencyName, currencyCode, rate);
            }

            else
            {
                return null;
            }
        }
    }
}
