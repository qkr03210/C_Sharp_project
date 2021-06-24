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
        public Form1()
        {
            InitializeComponent();
            panel = new UcPanel1(this);
            controllView(panel, "ucpanel1");
        }

        public void controllView(UserControl uc, string view)
        {
            if (!mainL.Controls.ContainsKey(view))
            {
                uc.Dock = DockStyle.Fill;
                mainL.Controls.Add(uc);
            }
            mainL.Controls[view].BringToFront();
        }
        public void HomePanel()
        {
            UcPanel1 panel = new UcPanel1(this);
            controllView(panel, "ucpanel1");
        }
    }
}
