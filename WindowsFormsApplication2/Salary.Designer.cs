namespace WindowsFormsApplication2
{
    partial class SalaryForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMoneyMounth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInMonth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHoursOne = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHoursTwo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "оклад";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "з/п в месяц";
            // 
            // textBoxMoneyMounth
            // 
            this.textBoxMoneyMounth.Location = new System.Drawing.Point(12, 188);
            this.textBoxMoneyMounth.Name = "textBoxMoneyMounth";
            this.textBoxMoneyMounth.ReadOnly = true;
            this.textBoxMoneyMounth.Size = new System.Drawing.Size(100, 20);
            this.textBoxMoneyMounth.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "з/п в месяц";
            // 
            // textBoxInMonth
            // 
            this.textBoxInMonth.Location = new System.Drawing.Point(12, 46);
            this.textBoxInMonth.Name = "textBoxInMonth";
            this.textBoxInMonth.Size = new System.Drawing.Size(100, 20);
            this.textBoxInMonth.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "часы, которые нужно отработать";
            // 
            // textBoxHoursOne
            // 
            this.textBoxHoursOne.Location = new System.Drawing.Point(12, 85);
            this.textBoxHoursOne.Name = "textBoxHoursOne";
            this.textBoxHoursOne.Size = new System.Drawing.Size(100, 20);
            this.textBoxHoursOne.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "отработанные часы";
            // 
            // textBoxHoursTwo
            // 
            this.textBoxHoursTwo.Location = new System.Drawing.Point(12, 124);
            this.textBoxHoursTwo.Name = "textBoxHoursTwo";
            this.textBoxHoursTwo.Size = new System.Drawing.Size(100, 20);
            this.textBoxHoursTwo.TabIndex = 9;
            // 
            // salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 216);
            this.Controls.Add(this.textBoxHoursTwo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxHoursOne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxInMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMoneyMounth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "salary";
            this.Text = "oklad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMoneyMounth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHoursOne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHoursTwo;
    }
}