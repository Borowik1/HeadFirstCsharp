namespace _01___Clones
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
            this.clone1Button = new System.Windows.Forms.Button();
            this.clone2Button = new System.Windows.Forms.Button();
            this.gcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clone1Button
            // 
            this.clone1Button.Location = new System.Drawing.Point(13, 13);
            this.clone1Button.Name = "clone1Button";
            this.clone1Button.Size = new System.Drawing.Size(126, 23);
            this.clone1Button.TabIndex = 0;
            this.clone1Button.Text = "Clone #1";
            this.clone1Button.UseVisualStyleBackColor = true;
            this.clone1Button.Click += new System.EventHandler(this.clone1Button_Click);
            // 
            // clone2Button
            // 
            this.clone2Button.Location = new System.Drawing.Point(13, 43);
            this.clone2Button.Name = "clone2Button";
            this.clone2Button.Size = new System.Drawing.Size(126, 23);
            this.clone2Button.TabIndex = 1;
            this.clone2Button.Text = "Clone #2";
            this.clone2Button.UseVisualStyleBackColor = true;
            this.clone2Button.Click += new System.EventHandler(this.clone2Button_Click);
            // 
            // gcButton
            // 
            this.gcButton.Location = new System.Drawing.Point(13, 73);
            this.gcButton.Name = "gcButton";
            this.gcButton.Size = new System.Drawing.Size(126, 23);
            this.gcButton.TabIndex = 2;
            this.gcButton.Text = "GC";
            this.gcButton.UseVisualStyleBackColor = true;
            this.gcButton.Click += new System.EventHandler(this.gcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 117);
            this.Controls.Add(this.gcButton);
            this.Controls.Add(this.clone2Button);
            this.Controls.Add(this.clone1Button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Clones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clone1Button;
        private System.Windows.Forms.Button clone2Button;
        private System.Windows.Forms.Button gcButton;
    }
}

