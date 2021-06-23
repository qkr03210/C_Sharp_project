﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ATM
{
    public partial class UcPanel1 : UserControl
    {
        Form1 parentForm;
        public UcPanel1(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void button_switch_panel2_Click(object sender, EventArgs e)
        {
            UcPanel2 panel2 = new UcPanel2(parentForm);
            parentForm.controllView(panel2,"ucpanel2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.Close();
        }
        private static void SelectUsingReader()
        {
            string connStr = "Server=localhost;Database=atm;Uid=root;Pwd=1234;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM client";

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine("{0}: {1}", rdr["name"], rdr["money"]);
                }
                rdr.Close();
            }
        }

        //아직 안씀
        private static void SelectUsingAdapter()
        {
            DataSet ds = new DataSet();
            string connStr = "Server=localhost;Database=atm;Uid=root;Pwd=1234;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                //MySqlDataAdapter 클래스를 이용하여
                //비연결 모드로 데이타 가져오기
                string sql = "SELECT * FROM Tab1 WHERE Id>=2";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "Tab1");
            }

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                Console.WriteLine(r["Name"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectUsingReader();
        }
    }
}