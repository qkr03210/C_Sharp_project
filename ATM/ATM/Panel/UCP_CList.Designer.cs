
namespace ATM.Panel
{
    partial class UCP_CList
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
            this.button_upbit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.거래 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.marketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koreannameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_name = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPriceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marketDataGridViewTextBoxColumn,
            this.koreannameDataGridViewTextBoxColumn,
            this.tradepriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cPriceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(374, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "이전화면";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_upbit
            // 
            this.button_upbit.Location = new System.Drawing.Point(409, 355);
            this.button_upbit.Name = "button_upbit";
            this.button_upbit.Size = new System.Drawing.Size(80, 51);
            this.button_upbit.TabIndex = 2;
            this.button_upbit.Text = "코인 차트";
            this.button_upbit.UseVisualStyleBackColor = true;
            this.button_upbit.Click += new System.EventHandler(this.button_upbit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 솔잎 M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(404, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "코인이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴 솔잎 M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(404, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "가격";
            // 
            // 거래
            // 
            this.거래.Location = new System.Drawing.Point(481, 201);
            this.거래.Name = "거래";
            this.거래.Size = new System.Drawing.Size(63, 37);
            this.거래.TabIndex = 6;
            this.거래.Text = "button3";
            this.거래.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(589, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 37);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("한컴 솔잎 M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(404, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "수량";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(506, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 21);
            this.textBox1.TabIndex = 9;
            // 
            // marketDataGridViewTextBoxColumn
            // 
            this.marketDataGridViewTextBoxColumn.DataPropertyName = "market";
            this.marketDataGridViewTextBoxColumn.HeaderText = "market";
            this.marketDataGridViewTextBoxColumn.Name = "marketDataGridViewTextBoxColumn";
            this.marketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // koreannameDataGridViewTextBoxColumn
            // 
            this.koreannameDataGridViewTextBoxColumn.DataPropertyName = "korean_name";
            this.koreannameDataGridViewTextBoxColumn.HeaderText = "코인이름";
            this.koreannameDataGridViewTextBoxColumn.Name = "koreannameDataGridViewTextBoxColumn";
            this.koreannameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tradepriceDataGridViewTextBoxColumn
            // 
            this.tradepriceDataGridViewTextBoxColumn.DataPropertyName = "trade_price";
            this.tradepriceDataGridViewTextBoxColumn.HeaderText = "가격";
            this.tradepriceDataGridViewTextBoxColumn.Name = "tradepriceDataGridViewTextBoxColumn";
            this.tradepriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPriceBindingSource
            // 
            this.cPriceBindingSource.DataSource = typeof(ATM.Model.CPrice);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(506, 54);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 12);
            this.label_name.TabIndex = 10;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(506, 95);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(9, 12);
            this.label_price.TabIndex = 11;
            this.label_price.Text = " ";
            // 
            // UCP_CList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.거래);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_upbit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCP_CList";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPriceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_upbit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koreannameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cPriceBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button 거래;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_price;
    }
}
