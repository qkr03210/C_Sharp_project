using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model
{
    class ExchangeRate
    {
        public ExchangeRate(string currency, string price)
        {
            this.currency = currency;
            this.price = price;
        }
        public string currency { get; set; }
        public string price { get; set; }
    }
}
