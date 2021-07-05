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
    public partial class UCP_Homepanel : UserControl
    {
        Form1 parentForm;
        public UCP_Homepanel(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
        }

        //이승직 20210627
        //계좌 로그인으로
        private void button_login_Click(object sender, EventArgs e)
        {
            UCP_Login panel_login = new UCP_Login(parentForm,5);
            parentForm.controllView(panel_login);
        }

        //이승직 20210627
        //패널 2번으로
        private void button_switch_panel2_Click(object sender, EventArgs e)
        {
            UCP_noaccount noacc = new UCP_noaccount(parentForm);
            parentForm.controllView(noacc);
        }

        //이승직 20210627
        //환율버튼
        private void button_HwanYoul_Click(object sender, EventArgs e)
        {
            //로그인이 되어있으면
            if(parentForm.chkLogin())
            {
                UCP_Exchange exchange = new UCP_Exchange(parentForm);
                parentForm.controllView(exchange);
            }
            //로그인이 안되어있으면
            else
            {
                UCP_Login uc_login = new UCP_Login(parentForm,0);
                parentForm.controllView(uc_login);
            }
        }

        //이승직 20210627
        // 패널 4번으로
        private void button_Panel4_Click(object sender, EventArgs e)
        {
            //로그인이 되어있으면
            if (parentForm.chkLogin())
            {
                UCP_Transaction trans = new UCP_Transaction(parentForm);
                parentForm.controllView(trans);
            }
            //로그인이 안되어있으면
            else
            {
                UCP_Login uc_login = new UCP_Login(parentForm, 1);
                parentForm.controllView(uc_login);
            }

        }
        //이승직 20210627
        //패널 6번으로
        private void button_panel6_Click(object sender, EventArgs e)
        {
            if (parentForm.chkLogin())
            {
                Panel.UCP_Account_check panel6 = new Panel.UCP_Account_check(parentForm, parentForm.getName(), parentForm.getPN());
                parentForm.controllView(panel6);
            }
            else
            {
                UCP_Login uc_login = new UCP_Login(parentForm, 6);
                parentForm.controllView(uc_login);
            }
        }

        //이승직 20210627
        //패널 7번으로
        private void button_panel7_Click(object sender, EventArgs e)
        {
            if (parentForm.chkLogin())
            {
                UCP_CList clist = new UCP_CList(parentForm);
                parentForm.controllView(clist);
            }
            //로그인이 안되어있으면
            else
            {
                UCP_Login uc_login = new UCP_Login(parentForm, 2);
                parentForm.controllView(uc_login);
            }            
        }

        //이승직 20210627
        //패널 9번으로
        private void button_panel9_Click(object sender, EventArgs e)
        {
            //로그인이 되어있으면
            if (parentForm.chkLogin())
            {
                Panel.UCP_MyCoin mycoin = new Panel.UCP_MyCoin(parentForm);
                parentForm.controllView(mycoin);
            }
            //로그인이 안되어있으면
            else
            {
                UCP_Login uc_login = new UCP_Login(parentForm, 3);
                parentForm.controllView(uc_login);
            }
            
        }

        //이승직 20210627
        //패널 UCP_Transaction_history으로
        private void button_panel10_Click(object sender, EventArgs e)
        {
            if (parentForm.chkLogin())
            {
                Panel.UCP_Transaction_history panel10 = new Panel.UCP_Transaction_history(parentForm);
                parentForm.controllView(panel10);
            }
            //로그인이 안되어있으면
            else
            {
                UCP_Login uc_login = new UCP_Login(parentForm, 4);
                parentForm.controllView(uc_login);
            }
        }

        //박상준,20210703
        //form1 종료
        private void button_Exit_Click(object sender, EventArgs e)
        {
            parentForm.Close();
        }

    }
}
