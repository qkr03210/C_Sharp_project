﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model
{
    public class checkAcc
    {
        string acc_num;
        string bank;
        string name;
        int balance;
        Boolean acc_check = false;

        public string Acc_num { get => acc_num; set => acc_num = value; }
        public string Bank { get => bank; set => bank = value; }
        public string Name { get => name; set => name = value; }
        public int Balance { get => balance; set => balance = value; }
        public bool Acc_check { get => acc_check; set => acc_check = value; }
    }
}
