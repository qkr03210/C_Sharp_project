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

namespace ATM
{
    public partial class Form1 : Form
    {
        UcPanel1 panel;
        string UserAccount = "";
        public Form1()
        {
            InitializeComponent();
            panel = new UcPanel1(this);
            controllView(panel, "ucpanel1");
        }
        //박상준,20210627 주석 추가
        //패널전환,패널 객체+패널이름
        public void controllView(UserControl uc, string view)
        {
            if (!mainL.Controls.ContainsKey(view))
            {
                uc.Dock = DockStyle.Fill;
                mainL.Controls.Add(uc);
            }
            mainL.Controls[view].BringToFront();
        }
        //박상준,20210627 주석 추가
        //다른 패널에서 홈 패널로 이동
        public void HomePanel()
        {
            UcPanel1 panel = new UcPanel1(this);
            controllView(panel, "ucpanel1");
        }
        //박상준,20210627
        //게좌와 비밀번호로 로그인되면 form1에 정보 기록
        public void login(string account)
        {
            UserAccount = account;
        }
        public Boolean chkLogin()
        {
            if(UserAccount.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void logout()
        {
            UserAccount = null;
        }
    }
}
