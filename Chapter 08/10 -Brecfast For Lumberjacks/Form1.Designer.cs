namespace _10__Brecfast_For_Lumberjacks
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
            this.label1 = new System.Windows.Forms.Label();
            this.lumberjackName = new System.Windows.Forms.TextBox();
            this.addLumberjack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.breakfastLine = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.banana = new System.Windows.Forms.RadioButton();
            this.addFlapjack = new System.Windows.Forms.Button();
            this.lumberjackHave = new System.Windows.Forms.TextBox();
            this.nextLumberjack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lumberjack name";
            // 
            // lumberjackName
            // 
            this.lumberjackName.Location = new System.Drawing.Point(111, 13);
            this.lumberjackName.Name = "lumberjackName";
            this.lumberjackName.Size = new System.Drawing.Size(180, 20);
            this.lumberjackName.TabIndex = 1;
            // 
            // addLumberjack
            // 
            this.addLumberjack.Location = new System.Drawing.Point(16, 40);
            this.addLumberjack.Name = "addLumberjack";
            this.addLumberjack.Size = new System.Drawing.Size(275, 23);
            this.addLumberjack.TabIndex = 2;
            this.addLumberjack.Text = "Add Lumberjack";
            this.addLumberjack.UseVisualStyleBackColor = true;
            this.addLumberjack.Click += new System.EventHandler(this.addLumberjack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Breakfast line";
            // 
            // breakfastLine
            // 
            this.breakfastLine.Location = new System.Drawing.Point(19, 87);
            this.breakfastLine.Multiline = true;
            this.breakfastLine.Name = "breakfastLine";
            this.breakfastLine.Size = new System.Drawing.Size(123, 241);
            this.breakfastLine.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nextLumberjack);
            this.groupBox1.Controls.Add(this.lumberjackHave);
            this.groupBox1.Controls.Add(this.addFlapjack);
            this.groupBox1.Controls.Add(this.banana);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.crispy);
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Location = new System.Drawing.Point(149, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 258);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed a Lumberjack";
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(6, 20);
            this.howMany.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(130, 20);
            this.howMany.TabIndex = 0;
            this.howMany.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(7, 47);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(53, 17);
            this.crispy.TabIndex = 1;
            this.crispy.TabStop = true;
            this.crispy.Text = "Crispy";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(7, 71);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(55, 17);
            this.soggy.TabIndex = 2;
            this.soggy.TabStop = true;
            this.soggy.Text = "Soggy";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(7, 95);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(67, 17);
            this.browned.TabIndex = 3;
            this.browned.TabStop = true;
            this.browned.Text = "Browned";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Location = new System.Drawing.Point(7, 119);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(62, 17);
            this.banana.TabIndex = 4;
            this.banana.TabStop = true;
            this.banana.Text = "Banana";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // addFlapjack
            // 
            this.addFlapjack.Location = new System.Drawing.Point(6, 143);
            this.addFlapjack.Name = "addFlapjack";
            this.addFlapjack.Size = new System.Drawing.Size(130, 23);
            this.addFlapjack.TabIndex = 5;
            this.addFlapjack.Text = "Add Flapjack";
            this.addFlapjack.UseVisualStyleBackColor = true;
            this.addFlapjack.Click += new System.EventHandler(this.addFlapjack_Click);
            // 
            // lumberjackHave
            // 
            this.lumberjackHave.Location = new System.Drawing.Point(6, 173);
            this.lumberjackHave.Multiline = true;
            this.lumberjackHave.Name = "lumberjackHave";
            this.lumberjackHave.ReadOnly = true;
            this.lumberjackHave.Size = new System.Drawing.Size(130, 45);
            this.lumberjackHave.TabIndex = 6;
            // 
            // nextLumberjack
            // 
            this.nextLumberjack.Location = new System.Drawing.Point(6, 225);
            this.nextLumberjack.Name = "nextLumberjack";
            this.nextLumberjack.Size = new System.Drawing.Size(130, 23);
            this.nextLumberjack.TabIndex = 7;
            this.nextLumberjack.Text = "Next Lumbrjack";
            this.nextLumberjack.UseVisualStyleBackColor = true;
            this.nextLumberjack.Click += new System.EventHandler(this.nextLumberjack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 333);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.breakfastLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addLumberjack);
            this.Controls.Add(this.lumberjackName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Breakcfast for Lumberjacks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lumberjackName;
        private System.Windows.Forms.Button addLumberjack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox breakfastLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.NumericUpDown howMany;
        private System.Windows.Forms.Button nextLumberjack;
        private System.Windows.Forms.TextBox lumberjackHave;
        private System.Windows.Forms.Button addFlapjack;
    }
}

