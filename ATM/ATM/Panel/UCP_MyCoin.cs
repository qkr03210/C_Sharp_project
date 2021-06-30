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
using System.Reflection;
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
            dataGridView1.DoubleBuffered(true);
        }
        private void MyCoin()
        {
            coins.Clear();
            string connStr = "Server=192.168.0.104;Database=atm;Uid=root;Pwd=1234;";
            dataGridView1.DataSource = null;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "select coin_name, sum(amount) as total_amount,sum(amount * price) / sum(amount) as AvgPrice from coin where acc_num = '" + parentForm.getUserAccount() + "';";
                string coin_name;
                int total_amount;
                int AvgPrice;

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    coin_name = rdr["coin_name"].ToString();
                    total_amount = Convert.ToInt32(rdr["total_amount"]);
                    AvgPrice = Convert.ToInt32(rdr["AvgPrice"]);
                    label1.Text = coin_name;
                    label2.Text = total_amount.ToString();

                    Coin temp = new Coin(coin_name, total_amount, AvgPrice, 0);
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
            //TODO datasource가 null에서 coins으로 바뀌면서 깜박이는거 수정해야함
            //dataGridView1.DataSource = null;
            Console.WriteLine(timer1.Interval);
            Console.WriteLine("temp실행중");
            string requestUrl;
            int intCheck;
            string coin = "BTC";
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
                coins[0].earning_rate = Math.Truncate((((coins[0].AvgPrice / Convert.ToDouble(json[0]["tradePrice"])) * 100) - 100) * 100) / 100;
                label3.Text = "" + (((coins[0].AvgPrice / Convert.ToDouble(json[0]["tradePrice"])) * 100) - 100) * 100;
                Console.WriteLine(coins[0].earning_rate);
                //coins.Add(new Coin("a", 3, 3, 3));
            }
            //박상준,20210639
            //데이터 그리드뷰 새로고침
            dataGridView1.Refresh();

            //if (dataGridView1.DataSource == null)
            //{
            //    dataGridView1.DataSource = coins;
            //}
            //else
            //{

            //}

        }

        public static DataTable GetDataGridViewAsDataTable(DataGridView _DataGridView)
        {
            try
            {
                if (_DataGridView.ColumnCount == 0)
                    return null;
                DataTable dtSource = new DataTable();
                //////create columns
                foreach (DataGridViewColumn col in _DataGridView.Columns)
                {
                    if (col.ValueType == null)
                        dtSource.Columns.Add(col.Name, typeof(string));
                    else
                        dtSource.Columns.Add(col.Name, col.ValueType);
                    dtSource.Columns[col.Name].Caption = col.HeaderText;
                }
                ///////insert row data
                foreach (DataGridViewRow row in _DataGridView.Rows)
                {
                    DataRow drNewRow = dtSource.NewRow();
                    foreach (DataColumn col in dtSource.Columns)
                    {
                        drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                    }
                    dtSource.Rows.Add(drNewRow);
                }
                return dtSource;
            }
            catch
            {
                return null;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            temp();
        }
    }
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty);
            pi.SetValue(dgv, setting, null);
        }
    }
}
