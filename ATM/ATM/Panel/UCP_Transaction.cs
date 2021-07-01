using ATM.Common;
using ATM.Model;
using System;
using System.Windows.Forms;

namespace ATM.Panel
{
    public partial class UCP_Transaction : UserControl
    {
        CheckAcc ca;
        Transaction ts = new Transaction();
        Form1 parentForm;
        string bank;
        double bal;
        string acc_num;
        string name;
        public UCP_Transaction(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
            this.bank = parentForm.getBank();
            this.bal = parentForm.getBalance();
            this.acc_num = parentForm.getUserAccount();
            this.name = parentForm.getName();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            parentForm.logout();
        }

        private void transaction_Click(object sender, EventArgs e)
        {
            if (bal < double.Parse(money_text.Text))
            {
                MessageBox.Show("잔액 부족");
            }
            else
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
                        ts.transaction(acc_num, bank, name, bal, ca.Acc_num, ca.Bank, ca.Name, ca.Balance, int.Parse(money_text.Text));
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
}
