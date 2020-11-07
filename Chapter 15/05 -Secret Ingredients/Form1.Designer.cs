namespace _05__Secret_Ingredients
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
            this.getIngredientButton = new System.Windows.Forms.Button();
            this.getSuzanneDelegateButton = new System.Windows.Forms.Button();
            this.getAmyDelegateButton = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // getIngredientButton
            // 
            this.getIngredientButton.Location = new System.Drawing.Point(13, 13);
            this.getIngredientButton.Name = "getIngredientButton";
            this.getIngredientButton.Size = new System.Drawing.Size(111, 23);
            this.getIngredientButton.TabIndex = 0;
            this.getIngredientButton.Text = "Get The Ingredient";
            this.getIngredientButton.UseVisualStyleBackColor = true;
            this.getIngredientButton.Click += new System.EventHandler(this.getIngredientButton_Click);
            // 
            // getSuzanneDelegateButton
            // 
            this.getSuzanneDelegateButton.Location = new System.Drawing.Point(13, 43);
            this.getSuzanneDelegateButton.Name = "getSuzanneDelegateButton";
            this.getSuzanneDelegateButton.Size = new System.Drawing.Size(165, 23);
            this.getSuzanneDelegateButton.TabIndex = 1;
            this.getSuzanneDelegateButton.Text = "Get Suzanne\'s Delegate";
            this.getSuzanneDelegateButton.UseVisualStyleBackColor = true;
            this.getSuzanneDelegateButton.Click += new System.EventHandler(this.getSuzanneDelegateButton_Click);
            // 
            // getAmyDelegateButton
            // 
            this.getAmyDelegateButton.Location = new System.Drawing.Point(13, 73);
            this.getAmyDelegateButton.Name = "getAmyDelegateButton";
            this.getAmyDelegateButton.Size = new System.Drawing.Size(165, 23);
            this.getAmyDelegateButton.TabIndex = 2;
            this.getAmyDelegateButton.Text = "Get Amy\'s Delegate";
            this.getAmyDelegateButton.UseVisualStyleBackColor = true;
            this.getAmyDelegateButton.Click += new System.EventHandler(this.getAmyDelegateButton_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(130, 15);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(48, 20);
            this.amount.TabIndex = 3;
            this.amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 109);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.getAmyDelegateButton);
            this.Controls.Add(this.getSuzanneDelegateButton);
            this.Controls.Add(this.getIngredientButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Secret Ingredient";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getIngredientButton;
        private System.Windows.Forms.Button getSuzanneDelegateButton;
        private System.Windows.Forms.Button getAmyDelegateButton;
        private System.Windows.Forms.NumericUpDown amount;
    }
}