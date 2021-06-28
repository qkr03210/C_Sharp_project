
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
            this.exchangeRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            // exchangeRateBindingSource
            // 
            this.exchangeRateBindingSource.DataSource = typeof(ATM.Model.ExchangeRate);
            // 
            // UcPanel_MyCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_home);
            this.Name = "UcPanel_MyCurrency";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.exchangeRateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource exchangeRateBindingSource;
        private System.Windows.Forms.Button button_home;
    }
}
