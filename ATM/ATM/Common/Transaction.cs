﻿using ATM.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Common
{
    public class Transaction
    {
        string connStr = "Server=192.168.0.104;Database=atm;Uid=root;Pwd=1234;";
        // 계좌 잔액 확인
        public double checkBal(string acc_num, string bank)
        {
            double bal = 0;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT balance FROM account where acc_num = '"
                    + acc_num + "' and bank = '" + bank + "';";
                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    bal = Convert.ToDouble(rdr["balance"]);
                }
                rdr.Close();
            }
            return bal;
        }
        //송금할 계좌 정보 확인
        public CheckAcc checkAcc(string acc_num, string bank)
        {
            CheckAcc ca = new CheckAcc();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT name,balance,acc_num,bank  FROM account where acc_num = '"
                    + acc_num + "' and bank = '" + bank + "';";
                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ca.Acc_num = rdr["acc_num"].ToString();
                    ca.Bank = rdr["bank"].ToString();
                    ca.Name = rdr["name"].ToString();
                    ca.Balance = Convert.ToDouble(rdr["balance"].ToString());
                    ca.Acc_check = true;
                }
                rdr.Close();
            }
            return ca;
        }
        //송금
        public void transaction(string out_acc, string out_bank, string out_name, double out_balance,
            string in_acc, string in_bank, string in_name, double in_balance, int trans_amount)
        {
            string sql = "Insert Into transaction (trans_date," +
                "out_acc,out_bank,out_name,out_balance," +
                "in_acc,in_bank,in_name,in_balance," +
                "trans_price,trans_type)" +
                "value(now(), '" + out_acc + "', '" + out_bank + "', '" + out_name + "'," + (out_balance - trans_amount) + "," +
                "'" + in_acc + "', '" + in_bank + "', '" + in_name + "'," + (in_balance + trans_amount) + "," + trans_amount + ", 'money'); ";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
        }
        //무통장 입금
        public void gdgdzz(string out_acc, string out_bank, string out_name,
            string in_acc, string in_bank, string in_name, double in_balance, int trans_amount)
        {
            string sql = "Insert Into transaction (trans_date," +
                "out_acc,out_bank,out_name,out_balance," +
                "in_acc,in_bank,in_name,in_balance," +
                "trans_price,trans_type)" +
                "value(now(), '" + out_acc + "', '" + out_bank + "', '" + out_name + "', 0 ," +
                "'" + in_acc + "', '" + in_bank + "', '" + in_name + "'," + (in_balance + trans_amount) + "," + trans_amount + ", 'money'); ";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
        }
        public List<TsHistory> TsHistory(string acc_num, string bank)
        {
            List<TsHistory> list = new List<TsHistory>();
            TsHistory th;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = $"select * from ("
                               + $" SELECT trans_date as trans_date, out_name as name , trans_price as price , in_balance as balance, '입금' as type"
                               + $" FROM atm.transaction where in_acc = '{acc_num}' and in_bank = '{bank}'"
                               + $" Union"
                               + $" SELECT trans_date as trans_date, in_name as name, trans_price as price , out_balance as balance, '출금' as type"
                               + $" FROM atm.transaction where out_acc = '{acc_num}' and out_bank = '{bank}') a"
                               + $" order by trans_date desc; ";
                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    th = new TsHistory();
                    th.trans_date = rdr["trans_date"].ToString();
                    th.name = rdr["name"].ToString();
                    th.amount = rdr["price"].ToString();
                    th.balance = double.Parse(rdr["balance"].ToString());
                    th.type = rdr["type"].ToString();
                    list.Add(th);
                }
                rdr.Close();
            }
            return list;
        }
    }
}
