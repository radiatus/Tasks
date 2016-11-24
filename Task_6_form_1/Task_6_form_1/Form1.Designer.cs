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
            this.matrixOne = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMinus = new System.Windows.Forms.Button();
            this.ColumnPlus = new System.Windows.Forms.Button();
            this.RowMinus = new System.Windows.Forms.Button();
            this.RowPlus = new System.Windows.Forms.Button();
            this.matrixTwo = new System.Windows.Forms.DataGridView();
            this.RandToMarix = new System.Windows.Forms.Button();
            this.TwoMatrix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrixOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixOne
            // 
            this.matrixOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixOne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.matrixOne.EnableHeadersVisualStyles = false;
            this.matrixOne.Location = new System.Drawing.Point(44, 49);
            this.matrixOne.Name = "matrixOne";
            this.matrixOne.RowHeadersWidth = 50;
            this.matrixOne.Size = new System.Drawing.Size(728, 298);
            this.matrixOne.TabIndex = 0;
            this.matrixOne.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            this.matrixOne.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // ColumnMinus
            // 
            this.ColumnMinus.Location = new System.Drawing.Point(48, 20);
            this.ColumnMinus.Name = "ColumnMinus";
            this.ColumnMinus.Size = new System.Drawing.Size(27, 23);
            this.ColumnMinus.TabIndex = 1;
            this.ColumnMinus.Text = "-";
            this.ColumnMinus.UseVisualStyleBackColor = true;
            this.ColumnMinus.Click += new System.EventHandler(this.ColumnMinus_Click);
            // 
            // ColumnPlus
            // 
            this.ColumnPlus.Location = new System.Drawing.Point(81, 20);
            this.ColumnPlus.Name = "ColumnPlus";
            this.ColumnPlus.Size = new System.Drawing.Size(27, 23);
            this.ColumnPlus.TabIndex = 2;
            this.ColumnPlus.Text = "+";
            this.ColumnPlus.UseVisualStyleBackColor = true;
            this.ColumnPlus.Click += new System.EventHandler(this.ColumnPlus_Click);
            // 
            // RowMinus
            // 
            this.RowMinus.Location = new System.Drawing.Point(12, 49);
            this.RowMinus.Name = "RowMinus";
            this.RowMinus.Size = new System.Drawing.Size(26, 23);
            this.RowMinus.TabIndex = 3;
            this.RowMinus.Text = "-";
            this.RowMinus.UseVisualStyleBackColor = true;
            this.RowMinus.Click += new System.EventHandler(this.RowMinus_Click);
            // 
            // RowPlus
            // 
            this.RowPlus.Location = new System.Drawing.Point(12, 78);
            this.RowPlus.Name = "RowPlus";
            this.RowPlus.Size = new System.Drawing.Size(25, 23);
            this.RowPlus.TabIndex = 4;
            this.RowPlus.Text = "+";
            this.RowPlus.UseVisualStyleBackColor = true;
            this.RowPlus.Click += new System.EventHandler(this.RowPlus_Click);
            // 
            // matrixTwo
            // 
            this.matrixTwo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixTwo.Location = new System.Drawing.Point(44, 383);
            this.matrixTwo.Name = "matrixTwo";
            this.matrixTwo.RowHeadersWidth = 50;
            this.matrixTwo.Size = new System.Drawing.Size(728, 262);
            this.matrixTwo.TabIndex = 5;
            this.matrixTwo.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView2_ColumnAdded);
            this.matrixTwo.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView2_RowPrePaint);
            // 
            // RandToMarix
            // 
            this.RandToMarix.Location = new System.Drawing.Point(130, 20);
            this.RandToMarix.Name = "RandToMarix";
            this.RandToMarix.Size = new System.Drawing.Size(106, 23);
            this.RandToMarix.TabIndex = 6;
            this.RandToMarix.Text = "Заполнить 1";
            this.RandToMarix.UseVisualStyleBackColor = true;
            this.RandToMarix.Click += new System.EventHandler(this.RandToMarix_Click);
            // 
            // TwoMatrix
            // 
            this.TwoMatrix.Location = new System.Drawing.Point(48, 353);
            this.TwoMatrix.Name = "TwoMatrix";
            this.TwoMatrix.Size = new System.Drawing.Size(108, 23);
            this.TwoMatrix.TabIndex = 7;
            this.TwoMatrix.Text = "Заполнить 2";
            this.TwoMatrix.UseVisualStyleBackColor = true;
            this.TwoMatrix.Click += new System.EventHandler(this.TwoMatrix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 670);
            this.Controls.Add(this.TwoMatrix);
            this.Controls.Add(this.RandToMarix);
            this.Controls.Add(this.matrixTwo);
            this.Controls.Add(this.RowPlus);
            this.Controls.Add(this.RowMinus);
            this.Controls.Add(this.ColumnPlus);
            this.Controls.Add(this.ColumnMinus);
            this.Controls.Add(this.matrixOne);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.matrixOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixTwo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView matrixOne;
        private System.Windows.Forms.Button ColumnMinus;
        private System.Windows.Forms.Button ColumnPlus;
        private System.Windows.Forms.Button RowMinus;
        private System.Windows.Forms.Button RowPlus;
        private System.Windows.Forms.DataGridView matrixTwo;
        private System.Windows.Forms.Button RandToMarix;
        private System.Windows.Forms.Button TwoMatrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

