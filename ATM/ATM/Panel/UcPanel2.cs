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
    public partial class UcPanel2 : UserControl
    {
        Form1 parentForm;
        public UcPanel2(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void button_switch_panel1_Click(object sender, EventArgs e)
        {
            UcPanel1 panel1 = new UcPanel1(parentForm);
            parentForm.controllView(panel1,"ucpanel1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcPanel3 panel3 = new UcPanel3(parentForm);
            parentForm.controllView(panel3, "ucpanel3");
        }
    }
}
