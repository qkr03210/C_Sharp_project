
namespace ATM.Panel
{
    partial class UCP_Mycurrency
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
            this.button_home = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.label_acctitle = new System.Windows.Forms.Label();
            this.label_account = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangeRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_bank = new System.Windows.Forms.Label();
            this.label_bank2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeRateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_home
            // 
            this.button_home.Location = new System.Drawing.Point(676, 378);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(102, 50);
            this.button_home.TabIndex = 0;
            this.button_home.Text = "시작화면으로";
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(542, 378);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(110, 50);
            this.button_back.TabIndex = 1;
            this.button_back.Text = "이전화면으로";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("배달의민족 도현", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_title.Location = new System.Drawing.Point(53, 33);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(209, 35);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "보유 외화 조회";
            // 
            // label_acctitle
            // 
            this.label_acctitle.AutoSize = true;
            this.label_acctitle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_acctitle.Location = new System.Drawing.Point(55, 93);
            this.label_acctitle.Name = "label_acctitle";
            this.label_acctitle.Size = new System.Drawing.Size(122, 21);
            this.label_acctitle.TabIndex = 3;
            this.label_acctitle.Text = "나의 계좌번호 :";
            // 
            // label_account
            // 
            this.label_account.AutoSize = true;
            this.label_account.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_account.Location = new System.Drawing.Point(178, 94);
            this.label_account.Name = "label_account";
            this.label_account.Size = new System.Drawing.Size(16, 21);
            this.label_account.TabIndex = 4;
            this.label_account.Text = " ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currencyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.currnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.exchangeRateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(675, 215);
            this.dataGridView1.TabIndex = 5;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "통화코드";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            this.currencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "보유 개수";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currnameDataGridViewTextBoxColumn
            // 
            this.currnameDataGridViewTextBoxColumn.DataPropertyName = "curr_name";
            this.currnameDataGridViewTextBoxColumn.HeaderText = "통화명";
            this.currnameDataGridViewTextBoxColumn.Name = "currnameDataGridViewTextBoxColumn";
            this.currnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exchangeRateBindingSource
            // 
            this.exchangeRateBindingSource.DataSource = typeof(ATM.Model.ExchangeRate);
            // 
            // label_bank
            // 
            this.label_bank.AutoSize = true;
            this.label_bank.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_bank.Location = new System.Drawing.Point(383, 93);
            this.label_bank.Name = "label_bank";
            this.label_bank.Size = new System.Drawing.Size(74, 21);
            this.label_bank.TabIndex = 3;
            this.label_bank.Text = "은행명 : ";
            // 
            // label_bank2
            // 
            this.label_bank2.AutoSize = true;
            this.label_bank2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_bank2.Location = new System.Drawing.Point(451, 94);
            this.label_bank2.Name = "label_bank2";
            this.label_bank2.Size = new System.Drawing.Size(16, 21);
            this.label_bank2.TabIndex = 4;
            this.label_bank2.Text = " ";
            // 
            // UCP_Mycurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_bank2);
            this.Controls.Add(this.label_account);
            this.Controls.Add(this.label_bank);
            this.Controls.Add(this.label_acctitle);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_home);
            this.Name = "UCP_Mycurrency";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeRateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource exchangeRateBindingSource;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_acctitle;
        private System.Windows.Forms.Label label_account;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label_bank;
        private System.Windows.Forms.Label label_bank2;
    }
}
