namespace BMI_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Result = new Label();
            ResultButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ResetButton = new Button();
            SuspendLayout();
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(366, 266);
            Result.Name = "Result";
            Result.Size = new Size(0, 15);
            Result.TabIndex = 0;
            // 
            // ResultButton
            // 
            ResultButton.Location = new Point(338, 222);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(103, 28);
            ResultButton.TabIndex = 1;
            ResultButton.Text = "Bereken BMI";
            ResultButton.UseVisualStyleBackColor = true;
            ResultButton.Click += ResultButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(253, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += TextBoxChange;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(418, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += TextBoxChange;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 133);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 4;
            label2.Text = "Gewicht in KG";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 133);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 5;
            label3.Text = "Lengte in M";
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(348, 318);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(75, 23);
            ResetButton.TabIndex = 6;
            ResetButton.Text = "Herstel";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResetButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(ResultButton);
            Controls.Add(Result);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Result;
        private Button ResultButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button ResetButton;
    }
}
