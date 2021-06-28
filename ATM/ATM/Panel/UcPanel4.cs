using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Panel
{
    public partial class UcPanel4 : UserControl
    {
        MySqlConnection Myconn = new MySqlConnection();
        MySqlDataAdapter da;
        DataSet ds;
        Form1 parentForm;
        public UcPanel4(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            parentForm.HomePanel();
        }

        private void transaction_Click(object sender, EventArgs e)
        {

            if (checkBank(bankName.Text, accNum_text.Text))
            {
                MessageBox.Show("있다");
                Query_Transaction(accNum_text.Text, bankName.Text, int.Parse(money_text.Text));
                Qurey_Update_inBank(bankName.Text, accNum_text.Text, int.Parse(money_text.Text));
                /*Qurey_Update_outBank();
                Qurey_Update_inBank(); */
            }
            else
            {
                MessageBox.Show("없다");
            }
            /* Query_Transaction(accNum_text.Text, bankName_text.Text, int.Parse(money_text.Text));
             Qurey_Update_outBank();
             Qurey_Update_inBank();*/
        }

        private void Qurey_Update_inBank(string in_bank, string acc_num, int money)
        {
            ConnectDB();
            MySqlCommand cmd = new MySqlCommand("", Myconn);
            string sqlcommand = $"Update atm.account set balance= balance + {money} where bank = '{in_bank}' and acc_num = '{acc_num}'";
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();

            Myconn.Close();
        }

        private void Qurey_Update_outBank()
        {
            throw new NotImplementedException();
        }
        public Boolean checkBank(string in_bank, string in_acc)
        {
            Boolean check = false;
            ConnectDB();
            string sql = $"SELECT * FROM atm.account where bank = '{in_bank}' and acc_num = '{in_acc}'";
            da = new MySqlDataAdapter();
            MySqlCommand cmd = Myconn.CreateCommand();
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            ds = new DataSet();
            //da.Fill(ds, "tb_cust");
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr["acc_num"].Equals(in_acc) && rdr["bank"].Equals(in_bank))
                {
                    check = true;
                }
            }
            Myconn.Close();
            return check;
        }
        public void ConnectDB()
        {
            try
            {
                string pwd = "1234";
                string strConn = "Server=192.168.0.104; Port=3306; Database=atm;Uid=root;Pwd=" + pwd + ";Charset=utf8";
                Myconn = new MySqlConnection(strConn);
                Myconn.Open();
            }
            catch (Exception e)
            {
            }
        }
        public void Query_Transaction(string in_acc, string in_bank, int trans_amount)
        {
            ConnectDB();
            MySqlCommand cmd = new MySqlCommand("", Myconn);
            string sqlcommand = $"Insert Into transaction(trans_date, out_acc,out_bank,in_acc,in_bank,trans_amount,trans_type) " +
                $"values (now(), '1234','대구','{in_acc}','{in_bank}','{trans_amount}','1234')";
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();

            Myconn.Close();
        }

        private void accNum_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
