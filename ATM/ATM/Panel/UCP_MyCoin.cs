using ATM.Model;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Panel
{   
    public partial class UCP_MyCoin : UserControl
    {
        //박상준,20210629
        //내가 가진 코인에 대한 정보 확인
        Form1 parentForm;
        private List<Coin> coins = new List<Coin>();
        public UCP_MyCoin(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
            MyCoin();
        }
        private void MyCoin()
        {
            coins.Clear();
            string connStr = "Server=192.168.0.104;Database=atm;Uid=root;Pwd=1234;";
            dataGridView1.DataSource = null;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM coin where acc_num = '" + parentForm.getUserAccount() + "';";
                string coin_name;
                int amount;
                int total_price;
                
                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    coin_name = rdr["coin_name"].ToString();
                    amount = Convert.ToInt32(rdr["amount"]);
                    total_price = amount * Convert.ToInt32(rdr["price"]);
                    Coin temp = new Coin(coin_name,amount,total_price);
                    coins.Add(temp);
                }
                rdr.Close();
            }
            dataGridView1.DataSource = coins;
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            parentForm.HomePanel();
        }

        private async void temp()
        {
            Console.WriteLine(timer1.Interval);
            Console.WriteLine("temp실행중");
            string requestUrl;
            int intCheck;
            string coin = "CRIX.UPBIT.KRW-BTC";
            string time = "1";

            if (int.TryParse(time, out intCheck))
                requestUrl = $"https://crix-api-endpoint.upbit.com/v1/crix/candles/minutes/{time}?code=CRIX.UPBIT.KRW-{coin}&count=200";
            else
                requestUrl = $"https://crix-api-endpoint.upbit.com/v1/crix/candles/{time}?code=CRIX.UPBIT.KRW-{coin}&count=200";
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(requestUrl);
                var responseString = await response.Content.ReadAsStringAsync();
                //Console.WriteLine("responseString"+responseString.ToString());
                var json = JArray.Parse(responseString);
                Console.WriteLine("json[0]" + json[0].ToString());//가장 최근꺼
                Console.WriteLine("json[0]의 코드" + json[0]["code"].ToString());
                Console.WriteLine("json[0]의 가격" + json[0]["tradePrice"].ToString());
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            temp();
        }
    }
}
