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
    public partial class Account_Check : UserControl
    {
        Form1 parentForm;
        public Account_Check(Form1 form)
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
            //버튼
        }
    }
}
