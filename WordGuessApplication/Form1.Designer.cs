namespace WordGuessApplication
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guessBox = new System.Windows.Forms.Button();
            this.secretWord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wrongAnswer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Brown;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(42, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 0;
            // 
            // guessBox
            // 
            this.guessBox.BackColor = System.Drawing.Color.ForestGreen;
            this.guessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBox.Location = new System.Drawing.Point(76, 143);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(131, 35);
            this.guessBox.TabIndex = 1;
            this.guessBox.Text = "Guess";
            this.guessBox.UseVisualStyleBackColor = false;
            this.guessBox.Click += new System.EventHandler(this.guessBox_Click);
            // 
            // secretWord
            // 
            this.secretWord.BackColor = System.Drawing.Color.ForestGreen;
            this.secretWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secretWord.Location = new System.Drawing.Point(12, 31);
            this.secretWord.Name = "secretWord";
            this.secretWord.Size = new System.Drawing.Size(264, 75);
            this.secretWord.TabIndex = 2;
            this.secretWord.Text = "c??????r";
            this.secretWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.ForestGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wrong Guess";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wrongAnswer
            // 
            this.wrongAnswer.BackColor = System.Drawing.Color.Brown;
            this.wrongAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongAnswer.FormattingEnabled = true;
            this.wrongAnswer.ItemHeight = 20;
            this.wrongAnswer.Items.AddRange(new object[] {
            "",
            ""});
            this.wrongAnswer.Location = new System.Drawing.Point(300, 54);
            this.wrongAnswer.Name = "wrongAnswer";
            this.wrongAnswer.Size = new System.Drawing.Size(172, 144);
            this.wrongAnswer.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 206);
            this.Controls.Add(this.wrongAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secretWord);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button guessBox;
        private System.Windows.Forms.Label secretWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox wrongAnswer;
    }
}

