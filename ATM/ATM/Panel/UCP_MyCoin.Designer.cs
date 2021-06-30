namespace ATM.Panel
{
    partial class UCP_MyCoin
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
            this.button_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.coinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coinnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earningrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(1102, 721);
            this.button_back.Margin = new System.Windows.Forms.Padding(5);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(151, 61);
            this.button_back.TabIndex = 6;
            this.button_back.Text = "돌아가기";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coinnameDataGridViewTextBoxColumn,
            this.totalamountDataGridViewTextBoxColumn,
            this.avgPriceDataGridViewTextBoxColumn,
            this.earningrateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coinBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(911, 551);
            this.dataGridView1.TabIndex = 7;
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
            this.label1.Location = new System.Drawing.Point(1009, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(997, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(999, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // coinBindingSource
            // 
            this.coinBindingSource.DataSource = typeof(ATM.Model.Coin);
            // 
            // coinnameDataGridViewTextBoxColumn
            // 
            this.coinnameDataGridViewTextBoxColumn.DataPropertyName = "coin_name";
            this.coinnameDataGridViewTextBoxColumn.HeaderText = "코인명";
            this.coinnameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.coinnameDataGridViewTextBoxColumn.Name = "coinnameDataGridViewTextBoxColumn";
            this.coinnameDataGridViewTextBoxColumn.Width = 175;
            // 
            // totalamountDataGridViewTextBoxColumn
            // 
            this.totalamountDataGridViewTextBoxColumn.DataPropertyName = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.HeaderText = "수량";
            this.totalamountDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.totalamountDataGridViewTextBoxColumn.Name = "totalamountDataGridViewTextBoxColumn";
            this.totalamountDataGridViewTextBoxColumn.Width = 175;
            // 
            // avgPriceDataGridViewTextBoxColumn
            // 
            this.avgPriceDataGridViewTextBoxColumn.DataPropertyName = "AvgPrice";
            this.avgPriceDataGridViewTextBoxColumn.HeaderText = "구매 평균가";
            this.avgPriceDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.avgPriceDataGridViewTextBoxColumn.Name = "avgPriceDataGridViewTextBoxColumn";
            this.avgPriceDataGridViewTextBoxColumn.Width = 175;
            // 
            // earningrateDataGridViewTextBoxColumn
            // 
            this.earningrateDataGridViewTextBoxColumn.DataPropertyName = "earning_rate";
            this.earningrateDataGridViewTextBoxColumn.HeaderText = "수익률";
            this.earningrateDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.earningrateDataGridViewTextBoxColumn.Name = "earningrateDataGridViewTextBoxColumn";
            this.earningrateDataGridViewTextBoxColumn.Width = 175;
            // 
            // UCP_MyCoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_back);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCP_MyCoin";
            this.Size = new System.Drawing.Size(1257, 788);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource coinBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn coinnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn earningrateDataGridViewTextBoxColumn;
    }
}
