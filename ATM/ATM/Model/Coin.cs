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
        public int total_amount { get; set; }
        public int AvgPrice { get; set; }
        public double earning_rate { get; set; }

        public Coin(string coin_name, int total_amount, int AvgPrice, double earning_rate)
        {
            this.coin_name = coin_name;
            this.total_amount = total_amount;
            this.AvgPrice = AvgPrice;
            this.earning_rate = earning_rate;
        }
    }
}
