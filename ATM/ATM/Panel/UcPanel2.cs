﻿using System;
using ATM.Common;
using ATM.Model;

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
    public partial class UcPanel2 : UserControl
    {
        CheckAcc ca;
        Transaction ts = new Transaction();
        Form1 parentForm;
        string bank = "GDGDG 은행";
        string acc_num = "ATM";
        string name = "무통장 입금";
        public UcPanel2(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void button_switch_panel1_Click(object sender, EventArgs e)
        {
            UCP_Homepanel panel1 = new UCP_Homepanel(parentForm);
            parentForm.controllView(panel1);
        }

        private void transaction_Click(object sender, EventArgs e)
        {
            ca = ts.checkAcc(accNum_text.Text, bankName.Text);
            if (ca.Acc_check)
            {
                DialogResult dr = MessageBox.Show("예금주 : " + ca.Name +
                                "\n은행 : " + ca.Bank + "\n계좌번호 : " + ca.Acc_num +
                                "\n보낼 금액 : " + money_text.Text + "원" +
                                "\n이 계좌로 송금 하시겠습니까?"
                                , "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.OK)
                {
                    ts.gdgdzz(acc_num, bank, name, ca.Acc_num, ca.Bank, ca.Name, ca.Balance, int.Parse(money_text.Text));
                    //잔액 조회후 세션 저장 or 로그아웃 -> 메인
                    MessageBox.Show("정상적으로 송금 되었습니다.");
                }
                else
                {
                    MessageBox.Show("취소 하였습니다");
                }
            }
            else
            {
                MessageBox.Show("없다");
            }
        }
    }
}