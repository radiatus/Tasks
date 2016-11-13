namespace Task_6_form_1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnMinus = new System.Windows.Forms.Button();
            this.ColumnPlus = new System.Windows.Forms.Button();
            this.RowMinus = new System.Windows.Forms.Button();
            this.RowPlus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(499, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnMinus
            // 
            this.ColumnMinus.Location = new System.Drawing.Point(44, 3);
            this.ColumnMinus.Name = "ColumnMinus";
            this.ColumnMinus.Size = new System.Drawing.Size(27, 23);
            this.ColumnMinus.TabIndex = 1;
            this.ColumnMinus.Text = "-";
            this.ColumnMinus.UseVisualStyleBackColor = true;
            this.ColumnMinus.Click += new System.EventHandler(this.ColumnMinus_Click);
            // 
            // ColumnPlus
            // 
            this.ColumnPlus.Location = new System.Drawing.Point(81, 3);
            this.ColumnPlus.Name = "ColumnPlus";
            this.ColumnPlus.Size = new System.Drawing.Size(27, 23);
            this.ColumnPlus.TabIndex = 2;
            this.ColumnPlus.Text = "+";
            this.ColumnPlus.UseVisualStyleBackColor = true;
            this.ColumnPlus.Click += new System.EventHandler(this.ColumnPlus_Click);
            // 
            // RowMinus
            // 
            this.RowMinus.Location = new System.Drawing.Point(12, 32);
            this.RowMinus.Name = "RowMinus";
            this.RowMinus.Size = new System.Drawing.Size(26, 23);
            this.RowMinus.TabIndex = 3;
            this.RowMinus.Text = "-";
            this.RowMinus.UseVisualStyleBackColor = true;
            this.RowMinus.Click += new System.EventHandler(this.RowMinus_Click);
            // 
            // RowPlus
            // 
            this.RowPlus.Location = new System.Drawing.Point(12, 61);
            this.RowPlus.Name = "RowPlus";
            this.RowPlus.Size = new System.Drawing.Size(25, 23);
            this.RowPlus.TabIndex = 4;
            this.RowPlus.Text = "+";
            this.RowPlus.UseVisualStyleBackColor = true;
            this.RowPlus.Click += new System.EventHandler(this.RowPlus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 451);
            this.Controls.Add(this.RowPlus);
            this.Controls.Add(this.RowMinus);
            this.Controls.Add(this.ColumnPlus);
            this.Controls.Add(this.ColumnMinus);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ColumnMinus;
        private System.Windows.Forms.Button ColumnPlus;
        private System.Windows.Forms.Button RowMinus;
        private System.Windows.Forms.Button RowPlus;
    }
}

