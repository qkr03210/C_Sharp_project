using ATM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Common
{
    class MySQL_Manager
    {
        public static List<Account> accounts = new List<Account>();

        public static void Load()
        {
            MySQL_Helper.Query_Select();
            accounts.Clear();
            string bank = "";
            string acc_num = "";
            string name = "";
            string phone = "";
            int balance = 0;

            foreach (DataRow item in MySQL_Helper.ds.Tables[0].Rows)
            {
                Account temp = new Account(bank,acc_num,name,phone,balance);
                bank = item["bank"].ToString();
                acc_num = item["acc_num"].ToString();
                //pwd = item["pwd"].ToString();
                name = item["name"].ToString();
                phone = item["phone"].ToString();
                balance = int.Parse(item["balance"].ToString());
                accounts.Add(temp);
            }
        }
    }
}
