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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RandToMarix = new System.Windows.Forms.Button();
            this.TwoMatrix = new System.Windows.Forms.Button();
            this.GetRow = new System.Windows.Forms.TextBox();
            this.GetColumn = new System.Windows.Forms.TextBox();
            this.Row = new System.Windows.Forms.Label();
            this.Column = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(728, 298);
            this.dataGridView1.TabIndex = 0;
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(44, 383);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(728, 262);
            this.dataGridView2.TabIndex = 5;
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
            this.TwoMatrix.Location = new System.Drawing.Point(222, 351);
            this.TwoMatrix.Name = "TwoMatrix";
            this.TwoMatrix.Size = new System.Drawing.Size(108, 23);
            this.TwoMatrix.TabIndex = 7;
            this.TwoMatrix.Text = "Заполнить 2";
            this.TwoMatrix.UseVisualStyleBackColor = true;
            this.TwoMatrix.Click += new System.EventHandler(this.TwoMatrix_Click);
            // 
            // GetRow
            // 
            this.GetRow.Location = new System.Drawing.Point(81, 353);
            this.GetRow.Name = "GetRow";
            this.GetRow.Size = new System.Drawing.Size(31, 20);
            this.GetRow.TabIndex = 8;
            // 
            // GetColumn
            // 
            this.GetColumn.Location = new System.Drawing.Point(166, 353);
            this.GetColumn.Name = "GetColumn";
            this.GetColumn.Size = new System.Drawing.Size(30, 20);
            this.GetColumn.TabIndex = 9;
            // 
            // Row
            // 
            this.Row.AutoSize = true;
            this.Row.Location = new System.Drawing.Point(46, 357);
            this.Row.Name = "Row";
            this.Row.Size = new System.Drawing.Size(29, 13);
            this.Row.TabIndex = 10;
            this.Row.Text = "Row";
            // 
            // Column
            // 
            this.Column.AutoSize = true;
            this.Column.Location = new System.Drawing.Point(118, 356);
            this.Column.Name = "Column";
            this.Column.Size = new System.Drawing.Size(42, 13);
            this.Column.TabIndex = 11;
            this.Column.Text = "Column";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 670);
            this.Controls.Add(this.Column);
            this.Controls.Add(this.Row);
            this.Controls.Add(this.GetColumn);
            this.Controls.Add(this.GetRow);
            this.Controls.Add(this.TwoMatrix);
            this.Controls.Add(this.RandToMarix);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.RowPlus);
            this.Controls.Add(this.RowMinus);
            this.Controls.Add(this.ColumnPlus);
            this.Controls.Add(this.ColumnMinus);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ColumnMinus;
        private System.Windows.Forms.Button ColumnPlus;
        private System.Windows.Forms.Button RowMinus;
        private System.Windows.Forms.Button RowPlus;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button RandToMarix;
        private System.Windows.Forms.Button TwoMatrix;
        private System.Windows.Forms.TextBox GetRow;
        private System.Windows.Forms.TextBox GetColumn;
        private System.Windows.Forms.Label Row;
        private System.Windows.Forms.Label Column;
    }
}

