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
    public partial class UcPanel_login : UserControl
    {
        Form1 parentForm;
        public UcPanel_login(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            parentForm.HomePanel();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string connStr = "Server=192.168.0.104;Database=atm;Uid=root;Pwd=1234;";
            int result = 0;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT count(*) as cnt FROM account where acc_num = '" + textBox_account.Text + "' and pwd = '" + textBox_pwd.Text + "';";

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result=Convert.ToInt32(rdr["cnt"]);
                    Console.WriteLine("{0}", result);
                }
                rdr.Close();
            }

            if(result==0)
            {
                textBox_account = null;
                textBox_pwd = null;
                MessageBox.Show("일치하는 정보가 없습니다");
            }
            else if(result ==1)
            {
                parentForm.login(textBox_account.Text);
                UcPanel3 panel3 = new UcPanel3(parentForm);
                parentForm.controllView(panel3, "ucpanel3");
            }
        }
    }
}
