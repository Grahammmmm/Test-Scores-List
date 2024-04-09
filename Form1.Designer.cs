namespace Test_Score_List
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label9 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 43);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter the test number...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 74);
            label2.Name = "label2";
            label2.Size = new Size(257, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter your grade you got on the test...";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(421, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(421, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(581, 41);
            button1.Name = "button1";
            button1.Size = new Size(198, 86);
            button1.TabIndex = 16;
            button1.Text = "Press to enter your next score...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(473, 385);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 17;
            // 
            // button2
            // 
            button2.Location = new Point(151, 297);
            button2.Name = "button2";
            button2.Size = new Size(186, 108);
            button2.TabIndex = 18;
            button2.Text = "Press to reveal how far your tests are from the average!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label9;
        private Button button2;
    }
}
