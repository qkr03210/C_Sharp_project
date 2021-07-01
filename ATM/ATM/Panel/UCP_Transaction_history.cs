using System;
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

namespace ATM.Panel
{
    public partial class UCP_Transaction_history : UserControl
    {
        Transaction ts = new Transaction();
        List<TsHistory> list = new List<TsHistory>();
        string bank;
        string name;
        string acc_num;

        Form1 parentForm;
        public UCP_Transaction_history(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
            this.name = parentForm.getName();
            this.bank = parentForm.getBank();
            this.acc_num = parentForm.getUserAccount();
            list = ts.TsHistory(acc_num, bank);
            Name_label.Text = name+" 님의 거래 내역";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            parentForm.HomePanel();
        }
    }
}
