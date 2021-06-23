
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_switch_panel1
            // 
            this.button_switch_panel1.Location = new System.Drawing.Point(94, 107);
            this.button_switch_panel1.Name = "button_switch_panel1";
            this.button_switch_panel1.Size = new System.Drawing.Size(116, 53);
            this.button_switch_panel1.TabIndex = 0;
            this.button_switch_panel1.Text = "패널1로";
            this.button_switch_panel1.UseVisualStyleBackColor = true;
            this.button_switch_panel1.Click += new System.EventHandler(this.button_switch_panel1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "패널3으로";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UcPanel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_switch_panel1);
            this.Name = "UcPanel2";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_switch_panel1;
        private System.Windows.Forms.Button button1;
    }
}
