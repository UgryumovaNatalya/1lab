namespace WindowsFormsApplication2
{
    partial class Window
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Button();
            this.oklad = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "способы начисления зарплаты";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hours
            // 
            this.hours.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hours.Location = new System.Drawing.Point(12, 43);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(101, 66);
            this.hours.TabIndex = 1;
            this.hours.Text = "почасовая оплата";
            this.hours.UseVisualStyleBackColor = true;
            this.hours.Click += new System.EventHandler(this.button1_Click);
            // 
            // oklad
            // 
            this.oklad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oklad.Location = new System.Drawing.Point(119, 43);
            this.oklad.Name = "oklad";
            this.oklad.Size = new System.Drawing.Size(84, 67);
            this.oklad.TabIndex = 2;
            this.oklad.Text = "оклад";
            this.oklad.UseVisualStyleBackColor = true;
            this.oklad.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(209, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 66);
            this.button3.TabIndex = 3;
            this.button3.Text = "ставка";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 137);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.oklad);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.label1);
            this.Name = "Window";
            this.Text = "company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hours;
        private System.Windows.Forms.Button oklad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}

