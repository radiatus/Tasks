namespace Task6Forms
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
            this.FirstMatrix = new System.Windows.Forms.DataGridView();
            this.ColumnMinus = new System.Windows.Forms.Button();
            this.ColumnPlus = new System.Windows.Forms.Button();
            this.RowMinus = new System.Windows.Forms.Button();
            this.RowPlus = new System.Windows.Forms.Button();
            this.RandomMatrix = new System.Windows.Forms.Button();
            this.LoadMatrix = new System.Windows.Forms.Button();
            this.FillingSecondMatrix = new System.Windows.Forms.Button();
            this.SecondMatrix = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.FirstMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstMatrix
            // 
            this.FirstMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirstMatrix.Location = new System.Drawing.Point(48, 48);
            this.FirstMatrix.Name = "FirstMatrix";
            this.FirstMatrix.Size = new System.Drawing.Size(600, 200);
            this.FirstMatrix.TabIndex = 0;
            // 
            // ColumnMinus
            // 
            this.ColumnMinus.Location = new System.Drawing.Point(48, 12);
            this.ColumnMinus.Name = "ColumnMinus";
            this.ColumnMinus.Size = new System.Drawing.Size(30, 30);
            this.ColumnMinus.TabIndex = 1;
            this.ColumnMinus.Text = "-";
            this.ColumnMinus.UseVisualStyleBackColor = true;
            this.ColumnMinus.Click += new System.EventHandler(this.ColumnMinus_Click);
            // 
            // ColumnPlus
            // 
            this.ColumnPlus.Location = new System.Drawing.Point(84, 12);
            this.ColumnPlus.Name = "ColumnPlus";
            this.ColumnPlus.Size = new System.Drawing.Size(30, 30);
            this.ColumnPlus.TabIndex = 2;
            this.ColumnPlus.Text = "+";
            this.ColumnPlus.UseVisualStyleBackColor = true;
            this.ColumnPlus.Click += new System.EventHandler(this.ColumnPlus_Click);
            // 
            // RowMinus
            // 
            this.RowMinus.Location = new System.Drawing.Point(12, 48);
            this.RowMinus.Name = "RowMinus";
            this.RowMinus.Size = new System.Drawing.Size(30, 30);
            this.RowMinus.TabIndex = 3;
            this.RowMinus.Text = "-";
            this.RowMinus.UseVisualStyleBackColor = true;
            this.RowMinus.Click += new System.EventHandler(this.RowMinus_Click);
            // 
            // RowPlus
            // 
            this.RowPlus.Location = new System.Drawing.Point(12, 84);
            this.RowPlus.Name = "RowPlus";
            this.RowPlus.Size = new System.Drawing.Size(30, 30);
            this.RowPlus.TabIndex = 4;
            this.RowPlus.Text = "+";
            this.RowPlus.UseVisualStyleBackColor = true;
            this.RowPlus.Click += new System.EventHandler(this.RowPlus_Click);
            // 
            // RandomMatrix
            // 
            this.RandomMatrix.Location = new System.Drawing.Point(173, 12);
            this.RandomMatrix.Name = "RandomMatrix";
            this.RandomMatrix.Size = new System.Drawing.Size(100, 30);
            this.RandomMatrix.TabIndex = 5;
            this.RandomMatrix.Text = "Random";
            this.RandomMatrix.UseVisualStyleBackColor = true;
            this.RandomMatrix.Click += new System.EventHandler(this.RandomMatrix_Click);
            // 
            // LoadMatrix
            // 
            this.LoadMatrix.Location = new System.Drawing.Point(279, 12);
            this.LoadMatrix.Name = "LoadMatrix";
            this.LoadMatrix.Size = new System.Drawing.Size(100, 30);
            this.LoadMatrix.TabIndex = 6;
            this.LoadMatrix.Text = "Load";
            this.LoadMatrix.UseVisualStyleBackColor = true;
            this.LoadMatrix.Click += new System.EventHandler(this.LoadMatrix_Click);
            // 
            // FillingSecondMatrix
            // 
            this.FillingSecondMatrix.Location = new System.Drawing.Point(548, 12);
            this.FillingSecondMatrix.Name = "FillingSecondMatrix";
            this.FillingSecondMatrix.Size = new System.Drawing.Size(100, 30);
            this.FillingSecondMatrix.TabIndex = 7;
            this.FillingSecondMatrix.Text = "Second matrix";
            this.FillingSecondMatrix.UseVisualStyleBackColor = true;
            this.FillingSecondMatrix.Click += new System.EventHandler(this.FillingSecondMatrix_Click);
            // 
            // SecondMatrix
            // 
            this.SecondMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondMatrix.Location = new System.Drawing.Point(48, 255);
            this.SecondMatrix.Name = "SecondMatrix";
            this.SecondMatrix.Size = new System.Drawing.Size(600, 200);
            this.SecondMatrix.TabIndex = 8;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 492);
            this.Controls.Add(this.SecondMatrix);
            this.Controls.Add(this.FillingSecondMatrix);
            this.Controls.Add(this.LoadMatrix);
            this.Controls.Add(this.RandomMatrix);
            this.Controls.Add(this.RowPlus);
            this.Controls.Add(this.RowMinus);
            this.Controls.Add(this.ColumnPlus);
            this.Controls.Add(this.ColumnMinus);
            this.Controls.Add(this.FirstMatrix);
            this.Name = "Form1";
            this.Text = "Task 6";
            ((System.ComponentModel.ISupportInitialize)(this.FirstMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FirstMatrix;
        private System.Windows.Forms.Button ColumnMinus;
        private System.Windows.Forms.Button ColumnPlus;
        private System.Windows.Forms.Button RowMinus;
        private System.Windows.Forms.Button RowPlus;
        private System.Windows.Forms.Button RandomMatrix;
        private System.Windows.Forms.Button LoadMatrix;
        private System.Windows.Forms.Button FillingSecondMatrix;
        private System.Windows.Forms.DataGridView SecondMatrix;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

