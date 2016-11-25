namespace Task7
{
    partial class Form1
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
            this.Number = new System.Windows.Forms.TextBox();
            this.ConvertToText = new System.Windows.Forms.Button();
            this.NumberText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(13, 13);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(171, 20);
            this.Number.TabIndex = 0;
            // 
            // ConvertToText
            // 
            this.ConvertToText.Location = new System.Drawing.Point(190, 10);
            this.ConvertToText.Name = "ConvertToText";
            this.ConvertToText.Size = new System.Drawing.Size(75, 23);
            this.ConvertToText.TabIndex = 1;
            this.ConvertToText.Text = "Convert";
            this.ConvertToText.UseVisualStyleBackColor = true;
            this.ConvertToText.Click += new System.EventHandler(this.ConvertToText_Click);
            // 
            // NumberText
            // 
            this.NumberText.Location = new System.Drawing.Point(12, 39);
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(566, 20);
            this.NumberText.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 69);
            this.Controls.Add(this.NumberText);
            this.Controls.Add(this.ConvertToText);
            this.Controls.Add(this.Number);
            this.Name = "Form1";
            this.Text = "Task 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Button ConvertToText;
        private System.Windows.Forms.TextBox NumberText;
    }
}

