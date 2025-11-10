namespace Windows_Programming
{
    partial class Form2
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
            button11 = new Button();
            button22 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button11
            // 
            button11.Location = new Point(124, 12);
            button11.Name = "button11";
            button11.Size = new Size(521, 58);
            button11.TabIndex = 0;
            button11.Text = "button1";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button1_Click;
            // 
            // button22
            // 
            button22.Location = new Point(124, 111);
            button22.Name = "button22";
            button22.Size = new Size(521, 58);
            button22.TabIndex = 1;
            button22.Text = "button2";
            button22.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 203);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(521, 58);
            textBox1.TabIndex = 2;
            textBox1.Text = "Text Box 1";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 299);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(521, 65);
            textBox2.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button22);
            Controls.Add(button11);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button11;
        private Button button22;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}