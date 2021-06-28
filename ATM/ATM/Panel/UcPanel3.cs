using ATM.Model;
using ATM.Panel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class UcPanel3 : UserControl
    {
        //(타입) AP01 : 환율, AP02 : 대출금리, AP03 : 국제금리
        //(요청) https://www.koreaexim.go.kr/site/program/financial/exchangeJSON?authkey=AUTHKEY1234567890&searchdate=20180102&data=AP01
        //주소+인증키+날짜+타입
        //(반환값 확인용 사이트)https://www.koreaexim.go.kr/site/program/openapi/openApiView?menuid=001003002002001&apino=2&viewtype=C
        string url = "https://www.koreaexim.go.kr/site/program/financial/exchangeJSON";
        string mykey = "hKSdbCbx9x9G7ynyLP8yxL7z0t9Gwl2c";

        List<ExchangeRate> exchanges = new List<ExchangeRate>();
        Form1 parentForm;
        public UcPanel3(Form1 form)
        {

            InitializeComponent();
            parentForm = form;
            
        }
        //박상준,20210624
        //당일 환율 api정보를 가져와서 데이터 그리드뷰에 출력(버튼)
        //박상준,20210627
        //환율api 정보를 당일 날짜를 기준으로 불러오는것으로 만들었으나, 주말에는 값을 null로 가져오는것을 확인
        public void temp()
        {

            using (WebClient wc = new WebClient())
            {
                //박상준,20210624
                //가끔 api로 json읽어올때 한글 깨지는 경우가 있어서 Encoding 문제 발생->해결
                wc.Encoding = System.Text.Encoding.UTF8;
                //var json = wc.DownloadString("https://www.koreaexim.go.kr/site/program/financial/exchangeJSON?authkey=" + mykey + "&searchdate="+"20210625"+"&data=AP01");
                var json = wc.DownloadString("https://www.koreaexim.go.kr/site/program/financial/exchangeJSON?authkey=" + mykey + "&searchdate=" + DateTime.Now.ToString("yyyyMMdd") + "&data=AP01");
                var objs = JArray.Parse(json).ToObject<List<JObject>>();
                string price = "";
                string name = "";
                string country = "";
                dataGridView1.DataSource = null;
                exchanges.Clear();
                for (int i = 0; i < objs.Count; i++)
                {
                    country = objs[i]["cur_nm"].ToString().Trim().Replace(",", "").Split(' ')[0];
                    name = objs[i]["cur_unit"].ToString().Trim().Replace(",", "");
                    price = objs[i]["kftc_deal_bas_r"].ToString().Trim().Replace(",", "");
                    ExchangeRate temp = new ExchangeRate(country,name,price);
                    exchanges.Add(temp);
                }

                //"result":1,
                //"cur_unit":"AED",
                //"ttb":"288.78",
                //"tts":"294.61",
                //"deal_bas_r":"291.7",
                //"bkpr":"291",
                //"yy_efee_r":"0",
                //"ten_dd_efee_r":"0",
                //"kftc_bkpr":"291",
                //"kftc_deal_bas_r":"291.7",
                //"cur_nm":"아랍에미리트 디르함"

                dataGridView1.DataSource = exchanges;
            }


        }
        //박상준,20210624
        //UcPanel1로 이동
        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.HomePanel();
        }
        //박상준,20210627
        //api로 환율 정보 읽어오는 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            temp();
        }

        private void button_mycurrency_Click(object sender, EventArgs e)
        {
            UcPanel_MyCurrency ucpanel_mycurrency = new UcPanel_MyCurrency(parentForm);
            parentForm.controllView(ucpanel_mycurrency, "ucpanel_mycurrency");
        }

        private void textBox_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }

            if (textBox_amount.TextLength == 0 && e.KeyChar == Convert.ToChar(Keys.D0))
            {
                e.Handled = true;
            }
        }

        private void textBox_amount_TextChanged(object sender, EventArgs e)
        {
            label_totalPrice.Text = textBox_amount.Text;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 데이터가 없는 경우 return
            if (this.dataGridView1.RowCount == 0)
                return;

            // 현재 Row를 가져온다.
            DataGridViewRow dgvr = dataGridView1.CurrentRow;

            // 선택한 Row의 데이터를 가져온다.
            DataRow row = (dgvr.DataBoundItem as DataRowView).Row;

            // TextBox에 그리드 데이터를 넣는다.
            label_currency.Text = row["currency"].ToString();
            label_price.Text = row["price"].ToString();
        }

        private void UcPanel3_Load(object sender, EventArgs e)
        {

        }


        //TODO 당일 api읽어와서 파일로 저장하는 기능 해야함
    }


}
