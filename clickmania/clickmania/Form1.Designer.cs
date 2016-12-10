namespace clickmania
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
            this.StartGame = new System.Windows.Forms.Button();
            this.RowCountsNumeric = new System.Windows.Forms.NumericUpDown();
            this.RowCountsLabel = new System.Windows.Forms.Label();
            this.ColumnCountsLabel = new System.Windows.Forms.Label();
            this.ColumnCountsNumeric = new System.Windows.Forms.NumericUpDown();
            this.ColorsLabel = new System.Windows.Forms.Label();
            this.ColorsCounts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RowCountsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnCountsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartGame.Font = new System.Drawing.Font("Niagara Solid", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StartGame.Location = new System.Drawing.Point(395, 5);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(75, 30);
            this.StartGame.TabIndex = 1;
            this.StartGame.Text = "Start";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // RowCountsNumeric
            // 
            this.RowCountsNumeric.Location = new System.Drawing.Point(395, 55);
            this.RowCountsNumeric.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.RowCountsNumeric.Name = "RowCountsNumeric";
            this.RowCountsNumeric.Size = new System.Drawing.Size(75, 20);
            this.RowCountsNumeric.TabIndex = 2;
            // 
            // RowCountsLabel
            // 
            this.RowCountsLabel.AutoSize = true;
            this.RowCountsLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RowCountsLabel.Location = new System.Drawing.Point(398, 39);
            this.RowCountsLabel.Name = "RowCountsLabel";
            this.RowCountsLabel.Size = new System.Drawing.Size(36, 14);
            this.RowCountsLabel.TabIndex = 3;
            this.RowCountsLabel.Text = "Rows";
            // 
            // ColumnCountsLabel
            // 
            this.ColumnCountsLabel.AutoSize = true;
            this.ColumnCountsLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnCountsLabel.Location = new System.Drawing.Point(395, 82);
            this.ColumnCountsLabel.Name = "ColumnCountsLabel";
            this.ColumnCountsLabel.Size = new System.Drawing.Size(48, 14);
            this.ColumnCountsLabel.TabIndex = 4;
            this.ColumnCountsLabel.Text = "Columns";
            // 
            // ColumnCountsNumeric
            // 
            this.ColumnCountsNumeric.Location = new System.Drawing.Point(395, 99);
            this.ColumnCountsNumeric.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ColumnCountsNumeric.Name = "ColumnCountsNumeric";
            this.ColumnCountsNumeric.Size = new System.Drawing.Size(75, 20);
            this.ColumnCountsNumeric.TabIndex = 5;
            // 
            // ColorsLabel
            // 
            this.ColorsLabel.AutoSize = true;
            this.ColorsLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorsLabel.Location = new System.Drawing.Point(398, 126);
            this.ColorsLabel.Name = "ColorsLabel";
            this.ColorsLabel.Size = new System.Drawing.Size(38, 14);
            this.ColorsLabel.TabIndex = 6;
            this.ColorsLabel.Text = "Colors";
            // 
            // ColorsCounts
            // 
            this.ColorsCounts.BackColor = System.Drawing.SystemColors.Window;
            this.ColorsCounts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColorsCounts.FormattingEnabled = true;
            this.ColorsCounts.Location = new System.Drawing.Point(395, 143);
            this.ColorsCounts.Name = "ColorsCounts";
            this.ColorsCounts.Size = new System.Drawing.Size(75, 21);
            this.ColorsCounts.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(487, 386);
            this.Controls.Add(this.ColorsCounts);
            this.Controls.Add(this.ColorsLabel);
            this.Controls.Add(this.ColumnCountsNumeric);
            this.Controls.Add(this.ColumnCountsLabel);
            this.Controls.Add(this.RowCountsLabel);
            this.Controls.Add(this.RowCountsNumeric);
            this.Controls.Add(this.StartGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.RowCountsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnCountsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.NumericUpDown RowCountsNumeric;
        private System.Windows.Forms.Label RowCountsLabel;
        private System.Windows.Forms.Label ColumnCountsLabel;
        private System.Windows.Forms.NumericUpDown ColumnCountsNumeric;
        private System.Windows.Forms.Label ColorsLabel;
        private System.Windows.Forms.ComboBox ColorsCounts;
    }
}

