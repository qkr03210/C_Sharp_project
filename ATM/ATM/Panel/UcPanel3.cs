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


        Form1 parentForm;
        public UcPanel3(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
            temp();
        }
        public void temp()
        {
                
            while (true)
            {
                 using (WebClient wc = new WebClient())
                 {
                    var json = wc.DownloadString("https://www.koreaexim.go.kr/site/program/financial/exchangeJSON?authkey="+ mykey+"&searchdate=20210623&data=AP01");
                    //var jArray = JObject.Parse(json);

                    var objs = JArray.Parse(json).ToObject<List<JObject>>();
                    string name = objs[0]["cur_unit"].ToString().Trim().Replace(",", "");
                    string price = objs[0]["kftc_deal_bas_r"].ToString().Trim().Replace(",", "");

                    Console.WriteLine(name);
                    Console.WriteLine(price);
                    //if (jArray["returnValue"].ToString() == "fail")
                   
                            
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

                           
                            //jArray["drwtNo3"].ToString();
                            //jArray["drwtNo4"].ToString();
                            //jArray["drwtNo5"].ToString();
                            //jArray["drwtNo6"].ToString();
                            //jArray["bnusNo"].ToString();
                            //jArray["drwNo"].ToString();
                            //jArray["drwNoDate"].ToString();
                           

                 }
            }

        }
    
    
    }


}
