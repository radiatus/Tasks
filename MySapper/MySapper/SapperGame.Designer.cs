namespace MySapper
{
    partial class SapperGame
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
            this.fuckingPanel = new System.Windows.Forms.Panel();
            this.startGame = new System.Windows.Forms.Button();
            this.length = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfMine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fuckingPanel
            // 
            this.fuckingPanel.Location = new System.Drawing.Point(13, 92);
            this.fuckingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.fuckingPanel.Name = "fuckingPanel";
            this.fuckingPanel.Size = new System.Drawing.Size(856, 748);
            this.fuckingPanel.TabIndex = 2;
            this.fuckingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fuckingPanel_MouseClick);
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(13, 12);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(118, 36);
            this.startGame.TabIndex = 3;
            this.startGame.Text = "Старт игры";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(318, 34);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(101, 22);
            this.length.TabIndex = 4;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(318, 62);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(101, 22);
            this.width.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Размеры поля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Длинна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ширина";
            // 
            // numberOfMine
            // 
            this.numberOfMine.Location = new System.Drawing.Point(137, 62);
            this.numberOfMine.Name = "numberOfMine";
            this.numberOfMine.Size = new System.Drawing.Size(100, 22);
            this.numberOfMine.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Кол-во мин";
            // 
            // SapperGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 853);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberOfMine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.width);
            this.Controls.Add(this.length);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.fuckingPanel);
            this.Name = "SapperGame";
            this.Text = "Сапёр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel fuckingPanel;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberOfMine;
        private System.Windows.Forms.Label label4;
    }
}

