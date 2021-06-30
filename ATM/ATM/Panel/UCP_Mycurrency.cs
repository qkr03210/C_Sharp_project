using ATM.Model;
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
    public partial class UCP_Mycurrency : UserControl
    {
        List<ExchangeRate> exchanges = new List<ExchangeRate>();

        Form1 parentForm;
        public UCP_Mycurrency(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
            label_account.Text = parentForm.getUserAccount();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            parentForm.HomePanel();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            
        }


    }
}
