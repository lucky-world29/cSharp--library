namespace NIT_LAB
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            radioMale = new RadioButton();
            radioFemale = new RadioButton();
            button1 = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 24);
            label1.Name = "label1";
            label1.Size = new Size(277, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(57, 105);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 1;
            label2.Text = "Employee ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(57, 158);
            label3.Name = "label3";
            label3.Size = new Size(159, 23);
            label3.TabIndex = 2;
            label3.Text = "Employee Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(57, 211);
            label4.Name = "label4";
            label4.Size = new Size(160, 23);
            label4.TabIndex = 3;
            label4.Text = "Employee Salary :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(57, 260);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(230, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(230, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(230, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 27);
            textBox3.TabIndex = 7;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.BackColor = Color.Transparent;
            radioMale.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioMale.ForeColor = Color.FromArgb(255, 128, 255);
            radioMale.Location = new Point(230, 260);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(72, 24);
            radioMale.TabIndex = 8;
            radioMale.TabStop = true;
            radioMale.Text = "MALE";
            radioMale.UseVisualStyleBackColor = false;
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.BackColor = Color.Transparent;
            radioFemale.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioFemale.ForeColor = Color.FromArgb(255, 128, 255);
            radioFemale.Location = new Point(308, 259);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(84, 24);
            radioFemale.TabIndex = 9;
            radioFemale.TabStop = true;
            radioFemale.Text = "FeMale";
            radioFemale.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(131, 306);
            button1.Name = "button1";
            button1.Size = new Size(109, 30);
            button1.TabIndex = 10;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(131, 351);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 20);
            labelResult.TabIndex = 11;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.milky_way_6337038_640;
            ClientSize = new Size(644, 429);
            Controls.Add(labelResult);
            Controls.Add(button1);
            Controls.Add(radioFemale);
            Controls.Add(radioMale);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RadioButton radioMale;
        private RadioButton radioFemale;
        private Button button1;
        private Label labelResult;
    }
}