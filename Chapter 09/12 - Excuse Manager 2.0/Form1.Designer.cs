namespace _12___Excuse_Manager_2._0
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
            this.randomButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lastUsed = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // randomButton
            // 
            this.randomButton.Enabled = false;
            this.randomButton.Location = new System.Drawing.Point(246, 107);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(75, 23);
            this.randomButton.TabIndex = 11;
            this.randomButton.Text = "Random";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Enabled = false;
            this.openFileButton.Location = new System.Drawing.Point(165, 107);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 10;
            this.openFileButton.Text = "Open";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Enabled = false;
            this.saveFileButton.Location = new System.Drawing.Point(84, 107);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(75, 23);
            this.saveFileButton.TabIndex = 9;
            this.saveFileButton.Text = "Save";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // openFolderButton
            // 
            this.openFolderButton.Location = new System.Drawing.Point(3, 107);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(75, 23);
            this.openFolderButton.TabIndex = 8;
            this.openFolderButton.Text = "Folder";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "  File date";
            // 
            // lastUsed
            // 
            this.lastUsed.Location = new System.Drawing.Point(62, 55);
            this.lastUsed.Name = "lastUsed";
            this.lastUsed.Size = new System.Drawing.Size(259, 20);
            this.lastUsed.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last used";
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(61, 29);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(260, 20);
            this.results.TabIndex = 3;
            this.results.TextChanged += new System.EventHandler(this.results_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "     Result";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(60, 3);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(261, 20);
            this.description.TabIndex = 1;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "   Excuse";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.description);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.results);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.lastUsed);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.textBox3);
            this.flowLayoutPanel1.Controls.Add(this.openFolderButton);
            this.flowLayoutPanel1.Controls.Add(this.saveFileButton);
            this.flowLayoutPanel1.Controls.Add(this.openFileButton);
            this.flowLayoutPanel1.Controls.Add(this.randomButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(329, 142);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(62, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(259, 20);
            this.textBox3.TabIndex = 12;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 142);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excuse Manager";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button openFolderButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker lastUsed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

