﻿namespace _05___Guys_Serializable
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
            this.joeCashLabel = new System.Windows.Forms.Label();
            this.bobCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.saveJoeButton = new System.Windows.Forms.Button();
            this.loadJoeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joeCashLabel
            // 
            this.joeCashLabel.AutoSize = true;
            this.joeCashLabel.Location = new System.Drawing.Point(13, 9);
            this.joeCashLabel.Name = "joeCashLabel";
            this.joeCashLabel.Size = new System.Drawing.Size(35, 13);
            this.joeCashLabel.TabIndex = 0;
            this.joeCashLabel.Text = "label1";
            // 
            // bobCashLabel
            // 
            this.bobCashLabel.AutoSize = true;
            this.bobCashLabel.Location = new System.Drawing.Point(13, 40);
            this.bobCashLabel.Name = "bobCashLabel";
            this.bobCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bobCashLabel.TabIndex = 1;
            this.bobCashLabel.Text = "label2";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(13, 72);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bankCashLabel.TabIndex = 2;
            this.bankCashLabel.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Give $10\r\nto Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Recive $5\r\nfrom Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(15, 191);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(87, 36);
            this.joeGivesToBob.TabIndex = 5;
            this.joeGivesToBob.Text = "Joe gives $10\r\nto Bob";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(149, 191);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(85, 36);
            this.bobGivesToJoe.TabIndex = 6;
            this.bobGivesToJoe.Text = "Bob gives $5\r\nto Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // saveJoeButton
            // 
            this.saveJoeButton.Location = new System.Drawing.Point(16, 253);
            this.saveJoeButton.Name = "saveJoeButton";
            this.saveJoeButton.Size = new System.Drawing.Size(86, 23);
            this.saveJoeButton.TabIndex = 7;
            this.saveJoeButton.Text = "Save Joe";
            this.saveJoeButton.UseVisualStyleBackColor = true;
            this.saveJoeButton.Click += new System.EventHandler(this.saveJoeButton_Click);
            // 
            // loadJoeButton
            // 
            this.loadJoeButton.Location = new System.Drawing.Point(149, 253);
            this.loadJoeButton.Name = "loadJoeButton";
            this.loadJoeButton.Size = new System.Drawing.Size(85, 23);
            this.loadJoeButton.TabIndex = 8;
            this.loadJoeButton.Text = "Load Joe";
            this.loadJoeButton.UseVisualStyleBackColor = true;
            this.loadJoeButton.Click += new System.EventHandler(this.loadJoeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 288);
            this.Controls.Add(this.loadJoeButton);
            this.Controls.Add(this.saveJoeButton);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobCashLabel);
            this.Controls.Add(this.joeCashLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joeCashLabel;
        private System.Windows.Forms.Label bobCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
        private System.Windows.Forms.Button saveJoeButton;
        private System.Windows.Forms.Button loadJoeButton;
    }
}

