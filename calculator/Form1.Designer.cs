﻿namespace calculator
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NumBtn7 = new System.Windows.Forms.Button();
            this.NumBtn8 = new System.Windows.Forms.Button();
            this.NumBtn9 = new System.Windows.Forms.Button();
            this.DivBtn = new System.Windows.Forms.Button();
            this.MultiBtn = new System.Windows.Forms.Button();
            this.NumBtn6 = new System.Windows.Forms.Button();
            this.NumBtn5 = new System.Windows.Forms.Button();
            this.NumBtn4 = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.NumBtn3 = new System.Windows.Forms.Button();
            this.NumBtn2 = new System.Windows.Forms.Button();
            this.NumBtn1 = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.CalBtn = new System.Windows.Forms.Button();
            this.DotBtn = new System.Windows.Forms.Button();
            this.NumBtn0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 0;
            // 
            // ClrBtn
            // 
            this.ClrBtn.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ClrBtn.Location = new System.Drawing.Point(14, 49);
            this.ClrBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(61, 52);
            this.ClrBtn.TabIndex = 1;
            this.ClrBtn.Text = "C";
            this.ClrBtn.UseVisualStyleBackColor = true;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(86, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 42);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumBtn7
            // 
            this.NumBtn7.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumBtn7.Location = new System.Drawing.Point(14, 109);
            this.NumBtn7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumBtn7.Name = "NumBtn7";
            this.NumBtn7.Size = new System.Drawing.Size(61, 52);
            this.NumBtn7.TabIndex = 3;
            this.NumBtn7.Text = "7";
            this.NumBtn7.UseVisualStyleBackColor = true;
            this.NumBtn7.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // NumBtn8
            // 
            this.NumBtn8.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumBtn8.Location = new System.Drawing.Point(81, 109);
            this.NumBtn8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumBtn8.Name = "NumBtn8";
            this.NumBtn8.Size = new System.Drawing.Size(61, 52);
            this.NumBtn8.TabIndex = 4;
            this.NumBtn8.Text = "8";
            this.NumBtn8.UseVisualStyleBackColor = true;
            this.NumBtn8.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // NumBtn9
            // 
            this.NumBtn9.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumBtn9.Location = new System.Drawing.Point(149, 109);
            this.NumBtn9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumBtn9.Name = "NumBtn9";
            this.NumBtn9.Size = new System.Drawing.Size(61, 52);
            this.NumBtn9.TabIndex = 5;
            this.NumBtn9.Text = "9";
            this.NumBtn9.UseVisualStyleBackColor = true;
            this.NumBtn9.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // DivBtn
            // 
            this.DivBtn.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DivBtn.Location = new System.Drawing.Point(216, 109);
            this.DivBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DivBtn.Name = "DivBtn";
            this.DivBtn.Size = new System.Drawing.Size(61, 52);
            this.DivBtn.TabIndex = 6;
            this.DivBtn.Text = "/";
            this.DivBtn.UseVisualStyleBackColor = true;
            this.DivBtn.Click += new System.EventHandler(this.DivBtn_Click);
            // 
            // MultiBtn
            // 
            this.MultiBtn.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MultiBtn.Location = new System.Drawing.Point(216, 169);
            this.MultiBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MultiBtn.Name = "MultiBtn";
            this.MultiBtn.Size = new System.Drawing.Size(61, 52);
            this.MultiBtn.TabIndex = 10;
            this.MultiBtn.Text = "*";
            this.MultiBtn.UseVisualStyleBackColor = true;
            this.MultiBtn.Click += new System.EventHandler(this.MultiBtn_Click);
            // 
            // NumBtn6
            // 
            this.NumBtn6.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumBtn6.Location = new System.Drawing.Point(149, 169);
            this.NumBtn6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumBtn6.Name = "NumBtn6";
            this.NumBtn6.Size = new System.Drawing.Size(61, 52);
            this.NumBtn6.TabIndex = 9;
            this.NumBtn6.Text = "6";
            this.NumBtn6.UseVisualStyleBackColor = true;
            this.NumBtn6.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // NumBtn5
            // 
            this.NumBtn5.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumBtn5.Location = new System.Drawing.Point(81, 169);
            this.NumBtn5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumBtn5.Name = "NumBtn5";
            this.NumBtn5.Size = new System.Drawing.Size(61, 52);
            this.NumBtn5.TabIndex = 8;
            this.NumBtn5.Text = "5";
            this.NumBtn5.UseVisualStyleBackColor = true;
            this.NumBtn5.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // NumBtn4
            // 
            this.NumBtn4.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumBtn4.Location = new System.Drawing.Point(14, 169);
            this.NumBtn4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumBtn4.Name = "NumBtn4";
            this.NumBtn4.Size = new System.Drawing.Size(61, 52);
            this.NumBtn4.TabIndex = 7;
            this.NumBtn4.Text = "4";
            this.NumBtn4.UseVisualStyleBackColor = true;
            this.NumBtn4.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MinusBtn.Location = new System.Drawing.Point(216, 229);
            this.MinusBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(61, 52);
            this.MinusBtn.TabIndex = 14;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // NumBtn3
            // 
            this.NumBtn3.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumBtn3.Location = new System.Drawing.Point(149, 229);
            this.NumBtn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumBtn3.Name = "NumBtn3";
            this.NumBtn3.Size = new System.Drawing.Size(61, 52);
            this.NumBtn3.TabIndex = 13;
            this.NumBtn3.Text = "3";
            this.NumBtn3.UseVisualStyleBackColor = true;
            this.NumBtn3.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // NumBtn2
            // 
            this.NumBtn2.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumBtn2.Location = new System.Drawing.Point(81, 229);
            this.NumBtn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumBtn2.Name = "NumBtn2";
            this.NumBtn2.Size = new System.Drawing.Size(61, 52);
            this.NumBtn2.TabIndex = 12;
            this.NumBtn2.Text = "2";
            this.NumBtn2.UseVisualStyleBackColor = true;
            this.NumBtn2.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // NumBtn1
            // 
            this.NumBtn1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumBtn1.Location = new System.Drawing.Point(14, 229);
            this.NumBtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumBtn1.Name = "NumBtn1";
            this.NumBtn1.Size = new System.Drawing.Size(61, 52);
            this.NumBtn1.TabIndex = 11;
            this.NumBtn1.Text = "1";
            this.NumBtn1.UseVisualStyleBackColor = true;
            this.NumBtn1.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlusBtn.Location = new System.Drawing.Point(216, 289);
            this.PlusBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(61, 52);
            this.PlusBtn.TabIndex = 18;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // CalBtn
            // 
            this.CalBtn.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CalBtn.Location = new System.Drawing.Point(149, 289);
            this.CalBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CalBtn.Name = "CalBtn";
            this.CalBtn.Size = new System.Drawing.Size(61, 52);
            this.CalBtn.TabIndex = 17;
            this.CalBtn.Text = "=";
            this.CalBtn.UseVisualStyleBackColor = true;
            this.CalBtn.Click += new System.EventHandler(this.CalBtn_Click);
            // 
            // DotBtn
            // 
            this.DotBtn.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DotBtn.Location = new System.Drawing.Point(81, 289);
            this.DotBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DotBtn.Name = "DotBtn";
            this.DotBtn.Size = new System.Drawing.Size(61, 52);
            this.DotBtn.TabIndex = 16;
            this.DotBtn.Text = ".";
            this.DotBtn.UseVisualStyleBackColor = true;
            this.DotBtn.Click += new System.EventHandler(this.DotBtn_Click);
            // 
            // NumBtn0
            // 
            this.NumBtn0.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumBtn0.Location = new System.Drawing.Point(14, 289);
            this.NumBtn0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumBtn0.Name = "NumBtn0";
            this.NumBtn0.Size = new System.Drawing.Size(61, 52);
            this.NumBtn0.TabIndex = 15;
            this.NumBtn0.Text = "0";
            this.NumBtn0.UseVisualStyleBackColor = true;
            this.NumBtn0.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 360);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.CalBtn);
            this.Controls.Add(this.DotBtn);
            this.Controls.Add(this.NumBtn0);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.NumBtn3);
            this.Controls.Add(this.NumBtn2);
            this.Controls.Add(this.NumBtn1);
            this.Controls.Add(this.MultiBtn);
            this.Controls.Add(this.NumBtn6);
            this.Controls.Add(this.NumBtn5);
            this.Controls.Add(this.NumBtn4);
            this.Controls.Add(this.DivBtn);
            this.Controls.Add(this.NumBtn9);
            this.Controls.Add(this.NumBtn8);
            this.Controls.Add(this.NumBtn7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClrBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NumBtn7;
        private System.Windows.Forms.Button NumBtn8;
        private System.Windows.Forms.Button NumBtn9;
        private System.Windows.Forms.Button DivBtn;
        private System.Windows.Forms.Button MultiBtn;
        private System.Windows.Forms.Button NumBtn6;
        private System.Windows.Forms.Button NumBtn5;
        private System.Windows.Forms.Button NumBtn4;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button NumBtn3;
        private System.Windows.Forms.Button NumBtn2;
        private System.Windows.Forms.Button NumBtn1;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button CalBtn;
        private System.Windows.Forms.Button DotBtn;
        private System.Windows.Forms.Button NumBtn0;
    }
}

