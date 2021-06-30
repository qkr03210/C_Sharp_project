using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model
{
    class Coin
    {
        public string coin_name { get; set; }
        public int amount { get; set; }
        public int total_price { get; set; }

        public Coin(string coin_name, int amount, int total_price)
        {
            this.coin_name = coin_name;
            this.amount = amount;
            this.total_price = total_price;
        }
    }
}
