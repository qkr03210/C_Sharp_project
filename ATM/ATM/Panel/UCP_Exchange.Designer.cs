
namespace ATM
{
    partial class UCP_Exchange
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button_mycurrency = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_country = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_totalPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_currency = new System.Windows.Forms.Label();
            this.label_curr = new System.Windows.Forms.Label();
            this.currnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangeRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeRateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currnameDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.exchangeRateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(243, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(540, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "시작 화면으로";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "환율";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "환율 api 읽어오기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_mycurrency
            // 
            this.button_mycurrency.Location = new System.Drawing.Point(417, 399);
            this.button_mycurrency.Name = "button_mycurrency";
            this.button_mycurrency.Size = new System.Drawing.Size(97, 34);
            this.button_mycurrency.TabIndex = 4;
            this.button_mycurrency.Text = "마이페이지";
            this.button_mycurrency.UseVisualStyleBackColor = true;
            this.button_mycurrency.Click += new System.EventHandler(this.button_mycurrency_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "국가";
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Location = new System.Drawing.Point(125, 95);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(0, 12);
            this.label_country.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "환율";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(125, 187);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(0, 12);
            this.label_price.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "KRW :";
            // 
            // label_totalPrice
            // 
            this.label_totalPrice.AutoSize = true;
            this.label_totalPrice.Location = new System.Drawing.Point(127, 242);
            this.label_totalPrice.Name = "label_totalPrice";
            this.label_totalPrice.Size = new System.Drawing.Size(0, 12);
            this.label_totalPrice.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "환전할 금액 : ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(110, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "환전하기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_amount
            // 
            this.textBox_amount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_amount.Location = new System.Drawing.Point(141, 287);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(54, 21);
            this.textBox_amount.TabIndex = 13;
            this.textBox_amount.TextChanged += new System.EventHandler(this.textBox_amount_TextChanged);
            this.textBox_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_amount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "통화";
            // 
            // label_currency
            // 
            this.label_currency.AutoSize = true;
            this.label_currency.Location = new System.Drawing.Point(125, 142);
            this.label_currency.Name = "label_currency";
            this.label_currency.Size = new System.Drawing.Size(0, 12);
            this.label_currency.TabIndex = 15;
            // 
            // label_curr
            // 
            this.label_curr.AutoSize = true;
            this.label_curr.Location = new System.Drawing.Point(108, 290);
            this.label_curr.Name = "label_curr";
            this.label_curr.Size = new System.Drawing.Size(0, 12);
            this.label_curr.TabIndex = 16;
            // 
            // currnameDataGridViewTextBoxColumn
            // 
            this.currnameDataGridViewTextBoxColumn.DataPropertyName = "curr_name";
            this.currnameDataGridViewTextBoxColumn.HeaderText = "국가명";
            this.currnameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.currnameDataGridViewTextBoxColumn.Name = "currnameDataGridViewTextBoxColumn";
            this.currnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.currnameDataGridViewTextBoxColumn.Width = 175;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "통화단위";
            this.currencyDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            this.currencyDataGridViewTextBoxColumn.ReadOnly = true;
            this.currencyDataGridViewTextBoxColumn.Width = 175;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "환율";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 175;
            // 
            // exchangeRateBindingSource
            // 
            this.exchangeRateBindingSource.DataSource = typeof(ATM.Model.ExchangeRate);
            // 
            // UCP_Exchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_curr);
            this.Controls.Add(this.label_currency);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_totalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_mycurrency);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCP_Exchange";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeRateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_mycurrency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_totalPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn currnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource exchangeRateBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_currency;
        private System.Windows.Forms.Label label_curr;
    }
}
