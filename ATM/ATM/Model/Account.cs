using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model
{
    //이승직 20210628
    //계좌 조회용
    class Account
    {
        public Account(string bank, string acc_num, string name, string phone, int balance)
        {
            this.bank = bank;
            this.acc_num = acc_num;
            this.name = name;
            this.phone = phone;
            this.balance = balance;
        }

        public string bank { get; set; }

        public string acc_num { get; set; }

        public string name { get; set; }

        public string phone { get; set; }

        public int balance { get; set; }
    }
}
