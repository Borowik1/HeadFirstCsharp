namespace _01___Beehive_Management_Interfaces
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
            this.nextShiftButton = new System.Windows.Forms.Button();
            this.workerBeeJob = new System.Windows.Forms.GroupBox();
            this.assignJobButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.workerBeeJobBox = new System.Windows.Forms.ComboBox();
            this.reportTextBox = new System.Windows.Forms.TextBox();
            this.workerBeeJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // nextShiftButton
            // 
            this.nextShiftButton.Location = new System.Drawing.Point(350, 13);
            this.nextShiftButton.Name = "nextShiftButton";
            this.nextShiftButton.Size = new System.Drawing.Size(99, 100);
            this.nextShiftButton.TabIndex = 0;
            this.nextShiftButton.Text = "Work the next shift";
            this.nextShiftButton.UseVisualStyleBackColor = true;
            this.nextShiftButton.Click += new System.EventHandler(this.nextShiftButton_Click);
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.Controls.Add(this.assignJobButton);
            this.workerBeeJob.Controls.Add(this.label2);
            this.workerBeeJob.Controls.Add(this.label1);
            this.workerBeeJob.Controls.Add(this.shifts);
            this.workerBeeJob.Controls.Add(this.workerBeeJobBox);
            this.workerBeeJob.Location = new System.Drawing.Point(13, 13);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(308, 100);
            this.workerBeeJob.TabIndex = 1;
            this.workerBeeJob.TabStop = false;
            this.workerBeeJob.Text = "Worker bee assignments";
            // 
            // assignJobButton
            // 
            this.assignJobButton.Location = new System.Drawing.Point(7, 71);
            this.assignJobButton.Name = "assignJobButton";
            this.assignJobButton.Size = new System.Drawing.Size(291, 23);
            this.assignJobButton.TabIndex = 4;
            this.assignJobButton.Text = "Assign this job to a bee";
            this.assignJobButton.UseVisualStyleBackColor = true;
            this.assignJobButton.Click += new System.EventHandler(this.assignJobButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shifts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Job";
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(178, 37);
            this.shifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(120, 20);
            this.shifts.TabIndex = 1;
            this.shifts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // workerBeeJobBox
            // 
            this.workerBeeJobBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJobBox.FormattingEnabled = true;
            this.workerBeeJobBox.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.workerBeeJobBox.Location = new System.Drawing.Point(7, 37);
            this.workerBeeJobBox.Name = "workerBeeJobBox";
            this.workerBeeJobBox.Size = new System.Drawing.Size(153, 21);
            this.workerBeeJobBox.TabIndex = 0;
            // 
            // reportTextBox
            // 
            this.reportTextBox.Location = new System.Drawing.Point(13, 119);
            this.reportTextBox.Multiline = true;
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.Size = new System.Drawing.Size(436, 110);
            this.reportTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 241);
            this.Controls.Add(this.reportTextBox);
            this.Controls.Add(this.workerBeeJob);
            this.Controls.Add(this.nextShiftButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Beehive Management";
            this.workerBeeJob.ResumeLayout(false);
            this.workerBeeJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextShiftButton;
        private System.Windows.Forms.GroupBox workerBeeJob;
        private System.Windows.Forms.Button assignJobButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.ComboBox workerBeeJobBox;
        private System.Windows.Forms.TextBox reportTextBox;
    }
}

