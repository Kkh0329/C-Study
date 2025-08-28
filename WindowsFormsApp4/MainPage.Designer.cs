namespace WindowsFormsApp4
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Menu1 = new System.Windows.Forms.Button();
            this.Menu2 = new System.Windows.Forms.Button();
            this.Menu3 = new System.Windows.Forms.Button();
            this.Menu4 = new System.Windows.Forms.Button();
            this.Menu5 = new System.Windows.Forms.Button();
            this.Menu6 = new System.Windows.Forms.Button();
            this.Menu7 = new System.Windows.Forms.Button();
            this.managerPageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "게시판";
            // 
            // Menu1
            // 
            this.Menu1.Location = new System.Drawing.Point(27, 82);
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(565, 52);
            this.Menu1.TabIndex = 1;
            this.Menu1.Text = "그룹웨어 인사총무팀 수신 각종양식 제목 작성기준";
            this.Menu1.UseVisualStyleBackColor = true;
            this.Menu1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu2
            // 
            this.Menu2.Location = new System.Drawing.Point(27, 157);
            this.Menu2.Name = "Menu2";
            this.Menu2.Size = new System.Drawing.Size(565, 52);
            this.Menu2.TabIndex = 2;
            this.Menu2.Text = "임직원 법인카드 운영 공지";
            this.Menu2.UseVisualStyleBackColor = true;
            // 
            // Menu3
            // 
            this.Menu3.Location = new System.Drawing.Point(27, 233);
            this.Menu3.Name = "Menu3";
            this.Menu3.Size = new System.Drawing.Size(565, 52);
            this.Menu3.TabIndex = 3;
            this.Menu3.Text = "25년 6월 결산 마감 공지";
            this.Menu3.UseVisualStyleBackColor = true;
            this.Menu3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Menu4
            // 
            this.Menu4.Location = new System.Drawing.Point(27, 308);
            this.Menu4.Name = "Menu4";
            this.Menu4.Size = new System.Drawing.Size(565, 52);
            this.Menu4.TabIndex = 4;
            this.Menu4.Text = "2025년 8월 유가 공지";
            this.Menu4.UseVisualStyleBackColor = true;
            this.Menu4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Menu5
            // 
            this.Menu5.Location = new System.Drawing.Point(27, 384);
            this.Menu5.Name = "Menu5";
            this.Menu5.Size = new System.Drawing.Size(565, 52);
            this.Menu5.TabIndex = 5;
            this.Menu5.Text = "흥국에프엔비 드레스코드 (사내복장기준)";
            this.Menu5.UseVisualStyleBackColor = true;
            this.Menu5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Menu6
            // 
            this.Menu6.Location = new System.Drawing.Point(27, 462);
            this.Menu6.Name = "Menu6";
            this.Menu6.Size = new System.Drawing.Size(565, 52);
            this.Menu6.TabIndex = 6;
            this.Menu6.Text = "윤리규정 준수의";
            this.Menu6.UseVisualStyleBackColor = true;
            // 
            // Menu7
            // 
            this.Menu7.Location = new System.Drawing.Point(28, 542);
            this.Menu7.Name = "Menu7";
            this.Menu7.Size = new System.Drawing.Size(565, 52);
            this.Menu7.TabIndex = 7;
            this.Menu7.Text = "ChatGPT 결제 시 부가가치세(VAT) 관련 안내";
            this.Menu7.UseVisualStyleBackColor = true;
            // 
            // managerPageButton
            // 
            this.managerPageButton.Location = new System.Drawing.Point(503, 20);
            this.managerPageButton.Name = "managerPageButton";
            this.managerPageButton.Size = new System.Drawing.Size(117, 23);
            this.managerPageButton.TabIndex = 8;
            this.managerPageButton.Text = "관리자페이지";
            this.managerPageButton.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 633);
            this.Controls.Add(this.managerPageButton);
            this.Controls.Add(this.Menu7);
            this.Controls.Add(this.Menu6);
            this.Controls.Add(this.Menu5);
            this.Controls.Add(this.Menu4);
            this.Controls.Add(this.Menu3);
            this.Controls.Add(this.Menu2);
            this.Controls.Add(this.Menu1);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Menu1;
        private System.Windows.Forms.Button Menu2;
        private System.Windows.Forms.Button Menu3;
        private System.Windows.Forms.Button Menu4;
        private System.Windows.Forms.Button Menu5;
        private System.Windows.Forms.Button Menu6;
        private System.Windows.Forms.Button Menu7;
        private System.Windows.Forms.Button managerPageButton;
    }
}