using ATM.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Panel
{
    public partial class UCP_CList : UserControl
    {
        List<CPrice> cprice = new List<CPrice>();
        Form1 parentForm;
        public UCP_CList(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
            dataGridView1.DataSource = null;
            dataGridView1.DoubleBuffered(true);
        }
        void coins()
        {

            using (WebClient wc = new WebClient())
            {

                wc.Encoding = System.Text.Encoding.UTF8;

                var json1 = wc.DownloadString("https://api.upbit.com/v1/market/all");
                var objs1 = JArray.Parse(json1).ToObject<List<JObject>>();

                /* var coin = objs["market"];*/


                string market = "";
                string korean_name = "";
                string trade_price = "";

        
                cprice.Clear();

                /*korean_name = objs1[0]["korean_name"].ToString().Trim().Replace(",", "");
                market = objs1[0]["market"].ToString().Trim().Replace(",", "");*/
                for (int i = 0; i < objs1.Count; i++)
                {
                    if (objs1[i]["market"].ToString().Substring(0, 3) == "KRW")

                    //if (objs1[i]["market"].ToString().Contains("KRW"))
                    {
                        korean_name += objs1[i]["korean_name"].ToString().Trim().Replace(",", "") + ",";
                        market += objs1[i]["market"].ToString().Trim().Replace(",", "") + ",";
                    }
                    Console.WriteLine(i);
                }
                korean_name = korean_name.Substring(0, korean_name.Length - 1);
                market = market.Substring(0, market.Length - 1);
                var json2 = wc.DownloadString("https://api.upbit.com/v1/ticker?markets=" + market);
                var objs2 = JArray.Parse(json2).ToObject<List<JObject>>();
                trade_price = objs2[0]["trade_price"].ToString().Trim().Replace(",", "");

                for (int i = 1; i < objs2.Count; i++)
                {
                    trade_price += "," + objs2[i]["trade_price"].ToString().Trim().Replace(",", "");
                }
                string[] temp1 = korean_name.Split(',');
                string[] temp2 = market.Split(',');
                string[] temp3 = trade_price.Split(',');
                /*   double changeRate = Math.Round(objs1[int.Parse("signed_change_rate")].Value<double>() * 100, 2);
                   string changeRateText = $"{changeRate}%";
                   Console.WriteLine(changeRate);*/

                for (int i = 0; i < temp1.Length; i++)
                {
                    Console.WriteLine(i);
                    cprice.Add(new CPrice(temp2[i], temp1[i], temp3[i]));
                }


            }
            dataGridView1.DataSource = cprice;
            dataGridView1.Refresh();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.HomePanel();
        }

        private void button_upbit_Click(object sender, EventArgs e)
        {
            UCP_Upbit ub = new UCP_Upbit(parentForm);
            parentForm.controllView(ub);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            coins();
        }

        
      





        /*    public static class ExtensionMethods
            {
                public static void DoubleBuffered(this DataGridView dgv, bool setting)
                {
                    Type dgvType = dgv.GetType();
                    PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty);
                    pi.SetValue(dgv, setting, null);
                }
            }*/
    }
}
