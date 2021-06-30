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
    public partial class UCP_Mycurrency : UserControl
    {
        Form1 parentForm;
        public UCP_Mycurrency(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
            label_account.Text = parentForm.getUserAccount();
            dataGridView1.DataSource = Mycurr();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            parentForm.HomePanel();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            UCP_Exchange panel3 = new UCP_Exchange(parentForm);
            parentForm.controllView(panel3);
        }
        public List<ExchangeRate> Mycurr()
        {
            string curr_name = "";
            string currency = "";
            string price = "";
            string connStr = "Server=192.168.0.104;Database=atm;Uid=root;Pwd=1234;";
            List<ExchangeRate> list = new List<ExchangeRate>();
            ExchangeRate er;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT country, currency, amount FROM exchange where acc_num = '" + parentForm.getUserAccount() + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    er = new ExchangeRate(curr_name, currency, price);
                    er.curr_name = rdr["country"].ToString();
                    er.currency = rdr["currency"].ToString();
                    er.price = rdr["amount"].ToString();
                    Console.WriteLine(er.curr_name);
                    list.Add(er);
                }
                rdr.Close();
            }
            return list;
        }
    }
}
