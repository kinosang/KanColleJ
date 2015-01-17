namespace KanColleJehad
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ckb_agreement = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cookie = new System.Windows.Forms.TextBox();
            this.txt_scd = new System.Windows.Forms.TextBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.tmr_send = new System.Windows.Forms.Timer(this.components);
            this.lbl_num = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ckb_agreement
            // 
            this.ckb_agreement.AutoSize = true;
            this.ckb_agreement.Location = new System.Drawing.Point(12, 21);
            this.ckb_agreement.Name = "ckb_agreement";
            this.ckb_agreement.Size = new System.Drawing.Size(1038, 29);
            this.ckb_agreement.TabIndex = 0;
            this.ckb_agreement.Text = "我同意我仅将本软件用于实验用途，作者不承担任何由于直接或间接造成的危害的法律责任";
            this.ckb_agreement.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "发送间距(单位为ms)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(244, 85);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(594, 297);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(198, 58);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cookie：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "验证码：";
            // 
            // txt_cookie
            // 
            this.txt_cookie.Location = new System.Drawing.Point(128, 184);
            this.txt_cookie.Name = "txt_cookie";
            this.txt_cookie.Size = new System.Drawing.Size(862, 35);
            this.txt_cookie.TabIndex = 6;
            // 
            // txt_scd
            // 
            this.txt_scd.Location = new System.Drawing.Point(128, 241);
            this.txt_scd.Name = "txt_scd";
            this.txt_scd.Size = new System.Drawing.Size(862, 35);
            this.txt_scd.TabIndex = 7;
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(798, 297);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(192, 58);
            this.btn_stop.TabIndex = 8;
            this.btn_stop.Text = "停止";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // tmr_send
            // 
            this.tmr_send.Tick += new System.EventHandler(this.tmr_send_Tick);
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(16, 314);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(150, 25);
            this.lbl_num.TabIndex = 9;
            this.lbl_num.Text = "已发送：0次";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(128, 135);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(862, 35);
            this.txt_url.TabIndex = 11;
            this.txt_url.Text = "http://gc.moejn.cn/login.html";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Url：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 367);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.txt_scd);
            this.Controls.Add(this.txt_cookie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckb_agreement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "舰娘国服数据库压力测试";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckb_agreement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cookie;
        private System.Windows.Forms.TextBox txt_scd;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Timer tmr_send;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label label4;
    }
}

