namespace _07___Two_Decks
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
            this.resetDeck1 = new System.Windows.Forms.Button();
            this.shuffleDeck1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resetDeck2 = new System.Windows.Forms.Button();
            this.shuffleDeck2 = new System.Windows.Forms.Button();
            this.moveToDeck2 = new System.Windows.Forms.Button();
            this.moveToDeck1 = new System.Windows.Forms.Button();
            this.deck1ListBox = new System.Windows.Forms.ListBox();
            this.deck2ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deck#1";
            // 
            // resetDeck1
            // 
            this.resetDeck1.Location = new System.Drawing.Point(12, 263);
            this.resetDeck1.Name = "resetDeck1";
            this.resetDeck1.Size = new System.Drawing.Size(100, 23);
            this.resetDeck1.TabIndex = 2;
            this.resetDeck1.Text = "Reset deck#1";
            this.resetDeck1.UseVisualStyleBackColor = true;
            this.resetDeck1.Click += new System.EventHandler(this.resetDeck1_Click);
            // 
            // shuffleDeck1
            // 
            this.shuffleDeck1.Location = new System.Drawing.Point(12, 292);
            this.shuffleDeck1.Name = "shuffleDeck1";
            this.shuffleDeck1.Size = new System.Drawing.Size(100, 23);
            this.shuffleDeck1.TabIndex = 3;
            this.shuffleDeck1.Text = "Shuffle deck#1";
            this.shuffleDeck1.UseVisualStyleBackColor = true;
            this.shuffleDeck1.Click += new System.EventHandler(this.shuffleDeck1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Deck#2";
            // 
            // resetDeck2
            // 
            this.resetDeck2.Location = new System.Drawing.Point(193, 263);
            this.resetDeck2.Name = "resetDeck2";
            this.resetDeck2.Size = new System.Drawing.Size(100, 23);
            this.resetDeck2.TabIndex = 2;
            this.resetDeck2.Text = "Reset deck#2";
            this.resetDeck2.UseVisualStyleBackColor = true;
            this.resetDeck2.Click += new System.EventHandler(this.resetDeck2_Click);
            // 
            // shuffleDeck2
            // 
            this.shuffleDeck2.Location = new System.Drawing.Point(193, 292);
            this.shuffleDeck2.Name = "shuffleDeck2";
            this.shuffleDeck2.Size = new System.Drawing.Size(100, 23);
            this.shuffleDeck2.TabIndex = 3;
            this.shuffleDeck2.Text = "Shuffle deck#2";
            this.shuffleDeck2.UseVisualStyleBackColor = true;
            this.shuffleDeck2.Click += new System.EventHandler(this.shuffleDeck2_Click);
            // 
            // moveToDeck2
            // 
            this.moveToDeck2.Location = new System.Drawing.Point(119, 69);
            this.moveToDeck2.Name = "moveToDeck2";
            this.moveToDeck2.Size = new System.Drawing.Size(68, 23);
            this.moveToDeck2.TabIndex = 4;
            this.moveToDeck2.Text = ">>";
            this.moveToDeck2.UseVisualStyleBackColor = true;
            this.moveToDeck2.Click += new System.EventHandler(this.moveToDeck2_Click);
            // 
            // moveToDeck1
            // 
            this.moveToDeck1.Location = new System.Drawing.Point(118, 98);
            this.moveToDeck1.Name = "moveToDeck1";
            this.moveToDeck1.Size = new System.Drawing.Size(68, 23);
            this.moveToDeck1.TabIndex = 4;
            this.moveToDeck1.Text = "<<";
            this.moveToDeck1.UseVisualStyleBackColor = true;
            this.moveToDeck1.Click += new System.EventHandler(this.moveToDeck1_Click);
            // 
            // deck1ListBox
            // 
            this.deck1ListBox.FormattingEnabled = true;
            this.deck1ListBox.Location = new System.Drawing.Point(12, 30);
            this.deck1ListBox.Name = "deck1ListBox";
            this.deck1ListBox.Size = new System.Drawing.Size(101, 225);
            this.deck1ListBox.TabIndex = 5;
            // 
            // deck2ListBox
            // 
            this.deck2ListBox.FormattingEnabled = true;
            this.deck2ListBox.Location = new System.Drawing.Point(193, 30);
            this.deck2ListBox.Name = "deck2ListBox";
            this.deck2ListBox.Size = new System.Drawing.Size(101, 225);
            this.deck2ListBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 324);
            this.Controls.Add(this.deck2ListBox);
            this.Controls.Add(this.deck1ListBox);
            this.Controls.Add(this.moveToDeck1);
            this.Controls.Add(this.moveToDeck2);
            this.Controls.Add(this.shuffleDeck2);
            this.Controls.Add(this.shuffleDeck1);
            this.Controls.Add(this.resetDeck2);
            this.Controls.Add(this.resetDeck1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetDeck1;
        private System.Windows.Forms.Button shuffleDeck1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetDeck2;
        private System.Windows.Forms.Button shuffleDeck2;
        private System.Windows.Forms.Button moveToDeck2;
        private System.Windows.Forms.Button moveToDeck1;
        private System.Windows.Forms.ListBox deck1ListBox;
        private System.Windows.Forms.ListBox deck2ListBox;
    }
}

