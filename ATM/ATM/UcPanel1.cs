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
    public partial class UcPanel1 : UserControl
    {
        Form2 parentForm;
        public UcPanel1(Form2 form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void button_switch_panel2_Click(object sender, EventArgs e)
        {
            UcPanel2 panel2 = new UcPanel2(parentForm);
            parentForm.controllView(panel2,"ucpanel2");
        }
    }
}
