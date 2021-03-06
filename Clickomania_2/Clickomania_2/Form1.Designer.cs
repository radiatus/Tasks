﻿namespace clickmania
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelGame = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.RowCountsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnCountsNumeric)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartGame.Font = new System.Drawing.Font("Niagara Solid", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StartGame.Location = new System.Drawing.Point(13, 7);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(75, 30);
            this.StartGame.TabIndex = 1;
            this.StartGame.Text = "Start";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // RowCountsNumeric
            // 
            this.RowCountsNumeric.Location = new System.Drawing.Point(13, 57);
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
            this.RowCountsLabel.Location = new System.Drawing.Point(10, 40);
            this.RowCountsLabel.Name = "RowCountsLabel";
            this.RowCountsLabel.Size = new System.Drawing.Size(36, 14);
            this.RowCountsLabel.TabIndex = 3;
            this.RowCountsLabel.Text = "Rows";
            // 
            // ColumnCountsLabel
            // 
            this.ColumnCountsLabel.AutoSize = true;
            this.ColumnCountsLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnCountsLabel.Location = new System.Drawing.Point(10, 80);
            this.ColumnCountsLabel.Name = "ColumnCountsLabel";
            this.ColumnCountsLabel.Size = new System.Drawing.Size(48, 14);
            this.ColumnCountsLabel.TabIndex = 4;
            this.ColumnCountsLabel.Text = "Columns";
            // 
            // ColumnCountsNumeric
            // 
            this.ColumnCountsNumeric.Location = new System.Drawing.Point(13, 97);
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
            this.ColorsLabel.Location = new System.Drawing.Point(10, 120);
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
            this.ColorsCounts.Location = new System.Drawing.Point(13, 137);
            this.ColorsCounts.Name = "ColorsCounts";
            this.ColorsCounts.Size = new System.Drawing.Size(75, 21);
            this.ColorsCounts.TabIndex = 7;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelMenu.Controls.Add(this.StartGame);
            this.panelMenu.Controls.Add(this.ColorsCounts);
            this.panelMenu.Controls.Add(this.RowCountsLabel);
            this.panelMenu.Controls.Add(this.ColorsLabel);
            this.panelMenu.Controls.Add(this.RowCountsNumeric);
            this.panelMenu.Controls.Add(this.ColumnCountsNumeric);
            this.panelMenu.Controls.Add(this.ColumnCountsLabel);
            this.panelMenu.Location = new System.Drawing.Point(383, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(100, 168);
            this.panelMenu.TabIndex = 8;
            // 
            // panelGame
            // 
            this.panelGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelGame.BackColor = System.Drawing.Color.LightGray;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(377, 377);
            this.panelGame.TabIndex = 9;
            this.panelGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(485, 378);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RowCountsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnCountsNumeric)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.NumericUpDown RowCountsNumeric;
        private System.Windows.Forms.Label RowCountsLabel;
        private System.Windows.Forms.Label ColumnCountsLabel;
        private System.Windows.Forms.NumericUpDown ColumnCountsNumeric;
        private System.Windows.Forms.Label ColorsLabel;
        private System.Windows.Forms.ComboBox ColorsCounts;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelGame;
    }
}

