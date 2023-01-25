namespace DivisionDecVSMod_MunaShabab
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
            this.DividendDesLabel = new System.Windows.Forms.Label();
            this.dividendTextBox = new System.Windows.Forms.TextBox();
            this.dividedByLabel = new System.Windows.Forms.Label();
            this.divisorDesLabel = new System.Windows.Forms.Label();
            this.divisorTextBox = new System.Windows.Forms.TextBox();
            this.clacButton = new System.Windows.Forms.Button();
            this.modDesLabel = new System.Windows.Forms.Label();
            this.quotientDesLabel = new System.Windows.Forms.Label();
            this.quotientLabel = new System.Windows.Forms.Label();
            this.remainderDesLabel = new System.Windows.Forms.Label();
            this.remainderLabel = new System.Windows.Forms.Label();
            this.decimalDivDesLabel = new System.Windows.Forms.Label();
            this.decimalDivLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DividendDesLabel
            // 
            this.DividendDesLabel.AutoSize = true;
            this.DividendDesLabel.Location = new System.Drawing.Point(66, 24);
            this.DividendDesLabel.Name = "DividendDesLabel";
            this.DividendDesLabel.Size = new System.Drawing.Size(52, 13);
            this.DividendDesLabel.TabIndex = 0;
            this.DividendDesLabel.Text = "Dividend:";
            // 
            // dividendTextBox
            // 
            this.dividendTextBox.Location = new System.Drawing.Point(58, 40);
            this.dividendTextBox.Name = "dividendTextBox";
            this.dividendTextBox.Size = new System.Drawing.Size(60, 20);
            this.dividendTextBox.TabIndex = 1;
            // 
            // dividedByLabel
            // 
            this.dividedByLabel.AutoSize = true;
            this.dividedByLabel.Location = new System.Drawing.Point(124, 43);
            this.dividedByLabel.Name = "dividedByLabel";
            this.dividedByLabel.Size = new System.Drawing.Size(64, 13);
            this.dividedByLabel.TabIndex = 2;
            this.dividedByLabel.Text = "Divided By :";
            // 
            // divisorDesLabel
            // 
            this.divisorDesLabel.AutoSize = true;
            this.divisorDesLabel.Location = new System.Drawing.Point(194, 24);
            this.divisorDesLabel.Name = "divisorDesLabel";
            this.divisorDesLabel.Size = new System.Drawing.Size(45, 13);
            this.divisorDesLabel.TabIndex = 3;
            this.divisorDesLabel.Text = "Divisor :";
            // 
            // divisorTextBox
            // 
            this.divisorTextBox.Location = new System.Drawing.Point(187, 40);
            this.divisorTextBox.Name = "divisorTextBox";
            this.divisorTextBox.Size = new System.Drawing.Size(67, 20);
            this.divisorTextBox.TabIndex = 4;
            // 
            // clacButton
            // 
            this.clacButton.Location = new System.Drawing.Point(90, 93);
            this.clacButton.Name = "clacButton";
            this.clacButton.Size = new System.Drawing.Size(126, 23);
            this.clacButton.TabIndex = 5;
            this.clacButton.Text = "Calculate";
            this.clacButton.UseVisualStyleBackColor = true;
            this.clacButton.Click += new System.EventHandler(this.clacButton_Click);
            // 
            // modDesLabel
            // 
            this.modDesLabel.AutoSize = true;
            this.modDesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modDesLabel.Location = new System.Drawing.Point(55, 138);
            this.modDesLabel.Name = "modDesLabel";
            this.modDesLabel.Size = new System.Drawing.Size(199, 13);
            this.modDesLabel.TabIndex = 6;
            this.modDesLabel.Text = "Answer Via Integer Division (Mod)";
            // 
            // quotientDesLabel
            // 
            this.quotientDesLabel.AutoSize = true;
            this.quotientDesLabel.Location = new System.Drawing.Point(7, 182);
            this.quotientDesLabel.Name = "quotientDesLabel";
            this.quotientDesLabel.Size = new System.Drawing.Size(56, 13);
            this.quotientDesLabel.TabIndex = 7;
            this.quotientDesLabel.Text = "Quotient : ";
            // 
            // quotientLabel
            // 
            this.quotientLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quotientLabel.Location = new System.Drawing.Point(69, 180);
            this.quotientLabel.Name = "quotientLabel";
            this.quotientLabel.Size = new System.Drawing.Size(53, 19);
            this.quotientLabel.TabIndex = 8;
            // 
            // remainderDesLabel
            // 
            this.remainderDesLabel.AutoSize = true;
            this.remainderDesLabel.Location = new System.Drawing.Point(175, 181);
            this.remainderDesLabel.Name = "remainderDesLabel";
            this.remainderDesLabel.Size = new System.Drawing.Size(64, 13);
            this.remainderDesLabel.TabIndex = 9;
            this.remainderDesLabel.Text = "Remainder :";
            // 
            // remainderLabel
            // 
            this.remainderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remainderLabel.Location = new System.Drawing.Point(245, 181);
            this.remainderLabel.Name = "remainderLabel";
            this.remainderLabel.Size = new System.Drawing.Size(52, 18);
            this.remainderLabel.TabIndex = 10;
            // 
            // decimalDivDesLabel
            // 
            this.decimalDivDesLabel.AutoSize = true;
            this.decimalDivDesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalDivDesLabel.Location = new System.Drawing.Point(71, 223);
            this.decimalDivDesLabel.Name = "decimalDivDesLabel";
            this.decimalDivDesLabel.Size = new System.Drawing.Size(168, 13);
            this.decimalDivDesLabel.TabIndex = 11;
            this.decimalDivDesLabel.Text = "Answer Via Decimal Division";
            // 
            // decimalDivLabel
            // 
            this.decimalDivLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decimalDivLabel.Location = new System.Drawing.Point(101, 252);
            this.decimalDivLabel.Name = "decimalDivLabel";
            this.decimalDivLabel.Size = new System.Drawing.Size(100, 23);
            this.decimalDivLabel.TabIndex = 12;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(90, 301);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(126, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 357);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.decimalDivLabel);
            this.Controls.Add(this.decimalDivDesLabel);
            this.Controls.Add(this.remainderLabel);
            this.Controls.Add(this.remainderDesLabel);
            this.Controls.Add(this.quotientLabel);
            this.Controls.Add(this.quotientDesLabel);
            this.Controls.Add(this.modDesLabel);
            this.Controls.Add(this.clacButton);
            this.Controls.Add(this.divisorTextBox);
            this.Controls.Add(this.divisorDesLabel);
            this.Controls.Add(this.dividedByLabel);
            this.Controls.Add(this.dividendTextBox);
            this.Controls.Add(this.DividendDesLabel);
            this.Name = "Form1";
            this.Text = "Division in C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DividendDesLabel;
        private System.Windows.Forms.TextBox dividendTextBox;
        private System.Windows.Forms.Label dividedByLabel;
        private System.Windows.Forms.Label divisorDesLabel;
        private System.Windows.Forms.TextBox divisorTextBox;
        private System.Windows.Forms.Button clacButton;
        private System.Windows.Forms.Label modDesLabel;
        private System.Windows.Forms.Label quotientDesLabel;
        private System.Windows.Forms.Label quotientLabel;
        private System.Windows.Forms.Label remainderDesLabel;
        private System.Windows.Forms.Label remainderLabel;
        private System.Windows.Forms.Label decimalDivDesLabel;
        private System.Windows.Forms.Label decimalDivLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

