namespace MoneyApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SummLabel = new System.Windows.Forms.Label();
            this.FiveCount = new System.Windows.Forms.Label();
            this.TenCount = new System.Windows.Forms.Label();
            this.SummTextBox = new System.Windows.Forms.TextBox();
            this.CountFive = new System.Windows.Forms.TextBox();
            this.CountTen = new System.Windows.Forms.TextBox();
            this.AddFive = new System.Windows.Forms.Button();
            this.AddTen = new System.Windows.Forms.Button();
            this.AllCount = new System.Windows.Forms.Label();
            this.CountCoins = new System.Windows.Forms.TextBox();
            this.LessFive = new System.Windows.Forms.Button();
            this.LessTen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SummLabel
            // 
            this.SummLabel.AutoSize = true;
            this.SummLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummLabel.Location = new System.Drawing.Point(548, 214);
            this.SummLabel.Name = "SummLabel";
            this.SummLabel.Size = new System.Drawing.Size(121, 42);
            this.SummLabel.TabIndex = 0;
            this.SummLabel.Text = "Сума:";
            // 
            // FiveCount
            // 
            this.FiveCount.AutoSize = true;
            this.FiveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveCount.Location = new System.Drawing.Point(98, 59);
            this.FiveCount.Name = "FiveCount";
            this.FiveCount.Size = new System.Drawing.Size(214, 42);
            this.FiveCount.TabIndex = 1;
            this.FiveCount.Text = "Кількість 5:";
            // 
            // TenCount
            // 
            this.TenCount.AutoSize = true;
            this.TenCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenCount.Location = new System.Drawing.Point(77, 142);
            this.TenCount.Name = "TenCount";
            this.TenCount.Size = new System.Drawing.Size(235, 42);
            this.TenCount.TabIndex = 2;
            this.TenCount.Text = "Кількість 10:";
            // 
            // SummTextBox
            // 
            this.SummTextBox.Location = new System.Drawing.Point(698, 226);
            this.SummTextBox.Name = "SummTextBox";
            this.SummTextBox.ReadOnly = true;
            this.SummTextBox.Size = new System.Drawing.Size(100, 31);
            this.SummTextBox.TabIndex = 3;
            this.SummTextBox.Text = "0";
            // 
            // CountFive
            // 
            this.CountFive.Location = new System.Drawing.Point(369, 70);
            this.CountFive.Name = "CountFive";
            this.CountFive.ReadOnly = true;
            this.CountFive.Size = new System.Drawing.Size(100, 31);
            this.CountFive.TabIndex = 4;
            this.CountFive.Text = "0";
            // 
            // CountTen
            // 
            this.CountTen.Location = new System.Drawing.Point(369, 154);
            this.CountTen.Name = "CountTen";
            this.CountTen.ReadOnly = true;
            this.CountTen.Size = new System.Drawing.Size(100, 31);
            this.CountTen.TabIndex = 5;
            this.CountTen.Text = "0";
            // 
            // AddFive
            // 
            this.AddFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFive.Location = new System.Drawing.Point(555, 48);
            this.AddFive.Name = "AddFive";
            this.AddFive.Size = new System.Drawing.Size(243, 53);
            this.AddFive.TabIndex = 6;
            this.AddFive.Text = "Додати 5!";
            this.AddFive.UseVisualStyleBackColor = true;
            this.AddFive.Click += new System.EventHandler(this.AddFive_Click);
            // 
            // AddTen
            // 
            this.AddTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTen.Location = new System.Drawing.Point(555, 139);
            this.AddTen.Name = "AddTen";
            this.AddTen.Size = new System.Drawing.Size(243, 53);
            this.AddTen.TabIndex = 7;
            this.AddTen.Text = "Додати 10!";
            this.AddTen.UseVisualStyleBackColor = true;
            this.AddTen.Click += new System.EventHandler(this.AddTen_Click);
            // 
            // AllCount
            // 
            this.AllCount.AutoSize = true;
            this.AllCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCount.Location = new System.Drawing.Point(50, 214);
            this.AllCount.Name = "AllCount";
            this.AllCount.Size = new System.Drawing.Size(262, 42);
            this.AllCount.TabIndex = 8;
            this.AllCount.Text = "Усього монет:";
            // 
            // CountCoins
            // 
            this.CountCoins.Location = new System.Drawing.Point(369, 226);
            this.CountCoins.Name = "CountCoins";
            this.CountCoins.ReadOnly = true;
            this.CountCoins.Size = new System.Drawing.Size(100, 31);
            this.CountCoins.TabIndex = 9;
            this.CountCoins.Text = "0";
            // 
            // LessFive
            // 
            this.LessFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessFive.Location = new System.Drawing.Point(820, 48);
            this.LessFive.Name = "LessFive";
            this.LessFive.Size = new System.Drawing.Size(243, 53);
            this.LessFive.TabIndex = 10;
            this.LessFive.Text = "Прибрати 5";
            this.LessFive.UseVisualStyleBackColor = true;
            this.LessFive.Click += new System.EventHandler(this.LessFive_Click);
            // 
            // LessTen
            // 
            this.LessTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessTen.Location = new System.Drawing.Point(820, 140);
            this.LessTen.Name = "LessTen";
            this.LessTen.Size = new System.Drawing.Size(243, 53);
            this.LessTen.TabIndex = 11;
            this.LessTen.Text = "Прибрати 10";
            this.LessTen.UseVisualStyleBackColor = true;
            this.LessTen.Click += new System.EventHandler(this.LessTen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "шт.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "шт.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(813, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "грн.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "шт.";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(820, 289);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(243, 75);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "Вийти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1130, 396);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LessTen);
            this.Controls.Add(this.LessFive);
            this.Controls.Add(this.CountCoins);
            this.Controls.Add(this.AllCount);
            this.Controls.Add(this.AddTen);
            this.Controls.Add(this.AddFive);
            this.Controls.Add(this.CountTen);
            this.Controls.Add(this.CountFive);
            this.Controls.Add(this.SummTextBox);
            this.Controls.Add(this.TenCount);
            this.Controls.Add(this.FiveCount);
            this.Controls.Add(this.SummLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1156, 467);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1156, 467);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Счётчик монет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SummLabel;
        private System.Windows.Forms.Label FiveCount;
        private System.Windows.Forms.Label TenCount;
        private System.Windows.Forms.TextBox SummTextBox;
        private System.Windows.Forms.TextBox CountFive;
        private System.Windows.Forms.TextBox CountTen;
        private System.Windows.Forms.Button AddFive;
        private System.Windows.Forms.Button AddTen;
        private System.Windows.Forms.Label AllCount;
        private System.Windows.Forms.TextBox CountCoins;
        private System.Windows.Forms.Button LessFive;
        private System.Windows.Forms.Button LessTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExitButton;
    }
}

