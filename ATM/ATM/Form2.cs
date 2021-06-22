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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void controllView(UserControl uc, string view)
        {
            if (!mainL.Controls.ContainsKey(view))
            {
                uc.Dock = DockStyle.Fill;
                mainL.Controls.Add(uc);
            }
            mainL.Controls[view].BringToFront();
        }
    }
}
