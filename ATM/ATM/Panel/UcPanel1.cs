using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.Panel;
using MySql.Data.MySqlClient;

namespace ATM
{
    public partial class UcPanel1 : UserControl
    {
        Form1 parentForm;
        public UcPanel1(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
        }

        //이승직 20210627
        //계좌 로그인으로
        private void button_login_Click(object sender, EventArgs e)
        {
            UcPanel_login panel_login = new UcPanel_login(parentForm);
            parentForm.controllView(panel_login, "ucpanel_login");
        }

        //이승직 20210627
        //패널 2번으로
        private void button_switch_panel2_Click(object sender, EventArgs e)
        {
            UcPanel2 panel2 = new UcPanel2(parentForm);
            parentForm.controllView(panel2, "ucpanel2");
        }

        //이승직 20210627
        //환율버튼
        private void button_HwanYoul_Click(object sender, EventArgs e)
        {
            //로그인이 되어있으면
            if(parentForm.chkLogin())
            {
                UcPanel3 panel3 = new UcPanel3(parentForm);
                parentForm.controllView(panel3, "ucpanel3");
            }
            //로그인이 안되어있으면
            else
            {
                UcPanel_login uc_login = new UcPanel_login(parentForm);
                parentForm.controllView(uc_login, "UcPanel_login");
            }
        }

        //이승직 20210627
        // 패널 4번으로
        private void button_Panel4_Click(object sender, EventArgs e)
        {
            Panel.UcPanel4 panel4 = new Panel.UcPanel4(parentForm);
            parentForm.controllView(panel4, "ucpanel4");
        }

        //이승직 20210627
        //패널 5번으로
        private void button_panel5_Click(object sender, EventArgs e)
        {
            Panel.UcPanel5 panel5 = new Panel.UcPanel5(parentForm);
            parentForm.controllView(panel5, "ucpanel5");
        }

        //이승직 20210627
        //패널 6번으로
        private void button_panel6_Click(object sender, EventArgs e)
        {
            Panel.UcPanel6 panel6 = new Panel.UcPanel6(parentForm);
            parentForm.controllView(panel6, "ucpanel6");
        }

        //이승직 20210627
        //패널 7번으로
        private void button_panel7_Click(object sender, EventArgs e)
        {
            Panel.UcPanel7 panel7 = new Panel.UcPanel7(parentForm);
            parentForm.controllView(panel7, "ucpanel7");
        }

        //이승직 20210627
        //패널 8번으로
        private void button_panel8_Click(object sender, EventArgs e)
        {
            Panel.UcPanel8 panel8 = new Panel.UcPanel8(parentForm);
            parentForm.controllView(panel8, "ucpanel8");
        }

        //이승직 20210627
        //패널 9번으로
        private void button_panel9_Click(object sender, EventArgs e)
        {
            Panel.UcPanel9 panel9 = new Panel.UcPanel9(parentForm);
            parentForm.controllView(panel9, "ucpanel9");
        }

        //이승직 20210627
        //패널 10번으로
        private void button_panel10_Click(object sender, EventArgs e)
        {
            Panel.UcPanel10 panel10 = new Panel.UcPanel10(parentForm);
            parentForm.controllView(panel10, "ucpanel10");
        }

        //이승직 20210627
        //패널 11번으로
        private void button_panel11_Click(object sender, EventArgs e)
        {
            Panel.UcPanel11 panel11 = new Panel.UcPanel11(parentForm);
            parentForm.controllView(panel11, "ucpanel11");
        }

        //종료
        private void button_Exit_Click(object sender, EventArgs e)
        {
            parentForm.Close();
        }

        private static void SelectUsingReader()
        {
            string connStr = "Server=localhost;Database=atm;Uid=root;Pwd=1234;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM client";

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine("{0}: {1}", rdr["name"], rdr["money"]);
                }
                rdr.Close();
            }
        }

        //아직 안씀
        private static void SelectUsingAdapter()
        {
            DataSet ds = new DataSet();
            string connStr = "Server=localhost;Database=atm;Uid=root;Pwd=1234;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                //MySqlDataAdapter 클래스를 이용하여
                //비연결 모드로 데이타 가져오기
                string sql = "SELECT * FROM Tab1 WHERE Id>=2";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "Tab1");
            }

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                Console.WriteLine(r["Name"]);
            }
        }

        private void button_Test_Mysql_Click(object sender, EventArgs e)
        {
            SelectUsingReader();
        }


    }
}
