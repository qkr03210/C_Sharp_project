
namespace ATM
{
    partial class UcPanel2
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_switch_panel1 = new System.Windows.Forms.Button();
            this.bankName = new System.Windows.Forms.ComboBox();
            this.transaction = new System.Windows.Forms.Button();
            this.money_text = new System.Windows.Forms.TextBox();
            this.accNum_text = new System.Windows.Forms.TextBox();
            this.money = new System.Windows.Forms.Label();
            this.accNum = new System.Windows.Forms.Label();
            this.bank_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_switch_panel1
            // 
            this.button_switch_panel1.Location = new System.Drawing.Point(681, 394);
            this.button_switch_panel1.Name = "button_switch_panel1";
            this.button_switch_panel1.Size = new System.Drawing.Size(116, 53);
            this.button_switch_panel1.TabIndex = 0;
            this.button_switch_panel1.Text = "메인으로";
            this.button_switch_panel1.UseVisualStyleBackColor = true;
            this.button_switch_panel1.Click += new System.EventHandler(this.button_switch_panel1_Click);
            // 
            // bankName
            // 
            this.bankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankName.FormattingEnabled = true;
            this.bankName.Items.AddRange(new object[] {
            "국민",
            "농협",
            "신한",
            "우리",
            "카카오",
            "하나"});
            this.bankName.Location = new System.Drawing.Point(112, 30);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(131, 20);
            this.bankName.TabIndex = 17;
            // 
            // transaction
            // 
            this.transaction.Location = new System.Drawing.Point(34, 110);
            this.transaction.Name = "transaction";
            this.transaction.Size = new System.Drawing.Size(101, 43);
            this.transaction.TabIndex = 16;
            this.transaction.Text = "송금";
            this.transaction.UseVisualStyleBackColor = true;
            this.transaction.Click += new System.EventHandler(this.transaction_Click);
            // 
            // money_text
            // 
            this.money_text.Location = new System.Drawing.Point(112, 83);
            this.money_text.Name = "money_text";
            this.money_text.Size = new System.Drawing.Size(131, 21);
            this.money_text.TabIndex = 15;
            // 
            // accNum_text
            // 
            this.accNum_text.Location = new System.Drawing.Point(112, 56);
            this.accNum_text.Name = "accNum_text";
            this.accNum_text.Size = new System.Drawing.Size(131, 21);
            this.accNum_text.TabIndex = 14;
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Location = new System.Drawing.Point(32, 83);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(29, 12);
            this.money.TabIndex = 13;
            this.money.Text = "금액";
            // 
            // accNum
            // 
            this.accNum.AutoSize = true;
            this.accNum.Location = new System.Drawing.Point(32, 56);
            this.accNum.Name = "accNum";
            this.accNum.Size = new System.Drawing.Size(53, 12);
            this.accNum.TabIndex = 12;
            this.accNum.Text = "계좌번호";
            // 
            // bank_name
            // 
            this.bank_name.AutoSize = true;
            this.bank_name.Location = new System.Drawing.Point(32, 29);
            this.bank_name.Name = "bank_name";
            this.bank_name.Size = new System.Drawing.Size(29, 12);
            this.bank_name.TabIndex = 11;
            this.bank_name.Text = "은행";
            // 
            // UcPanel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bankName);
            this.Controls.Add(this.transaction);
            this.Controls.Add(this.money_text);
            this.Controls.Add(this.accNum_text);
            this.Controls.Add(this.money);
            this.Controls.Add(this.accNum);
            this.Controls.Add(this.bank_name);
            this.Controls.Add(this.button_switch_panel1);
            this.Name = "UcPanel2";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_switch_panel1;
        private System.Windows.Forms.ComboBox bankName;
        private System.Windows.Forms.Button transaction;
        private System.Windows.Forms.TextBox money_text;
        private System.Windows.Forms.TextBox accNum_text;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label accNum;
        private System.Windows.Forms.Label bank_name;
    }
}
