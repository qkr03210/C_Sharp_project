using ATM.Common;
using ATM.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Panel
{
    public partial class UCP_account_check : UserControl
    {
        Form1 parentForm;
        public UCP_account_check(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            parentForm.HomePanel();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            string connStr = "Server=192.168.0.104;Database=atm;Uid=root;Pwd=1234;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT acc_num, bank, name, balance FROM account WHERE name= '" + textBox_name.Text + "' and phone= '" + textBox_num.Text + "';";

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                //foreach (DataRow item in MySQL_Helper.ds.Tables[0].Rows)
                while(rdr.Read())
                {
                    string bank = rdr["bank"].ToString();
                    string acc_num = rdr["acc_num"].ToString();
                    string name = rdr["name"].ToString();
                    int balance = int.Parse(rdr["balance"].ToString());
                    Account temp = new Account(bank, acc_num, name, balance);
                    MySQL_Manager.accounts.Add(temp);
                }
                rdr.Close();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = MySQL_Manager.accounts;
            }
        }
    }
}
