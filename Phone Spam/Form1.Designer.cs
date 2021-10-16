namespace Phone_Spam
{
    partial class PhoneSpam
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartDate = new System.Windows.Forms.TextBox();
            this.EndDate = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(39, 59);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(113, 20);
            this.StartDate.TabIndex = 0;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(203, 59);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(107, 20);
            this.EndDate.TabIndex = 1;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(39, 139);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(279, 122);
            this.Input.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата начала периода:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата окончания периода:";
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(403, 55);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(75, 23);
            this.report.TabIndex = 5;
            this.report.Text = "Отчет";
            this.report.UseVisualStyleBackColor = true;
            // 
            // PhoneSpam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 314);
            this.Controls.Add(this.report);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Name = "PhoneSpam";
            this.Text = "Phone Spam";
            this.Load += new System.EventHandler(this.PhoneSpam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StartDate;
        private System.Windows.Forms.TextBox EndDate;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button report;
    }
}

