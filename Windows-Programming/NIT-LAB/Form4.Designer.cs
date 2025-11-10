namespace NIT_LAB
{
    partial class Form4
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Add = new Button();
            listBox1 = new ListBox();
            Remove = new Button();
            Clear = new Button();
            Insert = new Button();
            RemoveAt = new Button();
            Close = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(113, 112);
            label1.Name = "label1";
            label1.Size = new Size(210, 41);
            label1.TabIndex = 0;
            label1.Text = "Selected Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(113, 194);
            label2.Name = "label2";
            label2.Size = new Size(225, 41);
            label2.TabIndex = 1;
            label2.Text = "Selected Index";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(175, 30);
            label3.Name = "label3";
            label3.Size = new Size(464, 50);
            label3.TabIndex = 2;
            label3.Text = "ListBox in Windows Form";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(423, 112);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 41);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Location = new Point(423, 194);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(257, 41);
            textBox2.TabIndex = 4;
            // 
            // Add
            // 
            Add.BackColor = Color.LightGray;
            Add.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.ForeColor = Color.Red;
            Add.Location = new Point(301, 313);
            Add.Name = "Add";
            Add.Size = new Size(154, 69);
            Add.TabIndex = 6;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Gold;
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(46, 330);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(163, 200);
            listBox1.TabIndex = 7;
            // 
            // Remove
            // 
            Remove.BackColor = Color.LightGray;
            Remove.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Remove.ForeColor = Color.Red;
            Remove.Location = new Point(301, 388);
            Remove.Name = "Remove";
            Remove.Size = new Size(154, 69);
            Remove.TabIndex = 8;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += Remove_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.LightGray;
            Clear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear.ForeColor = Color.Red;
            Clear.Location = new Point(301, 463);
            Clear.Name = "Clear";
            Clear.Size = new Size(154, 69);
            Clear.TabIndex = 9;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Insert
            // 
            Insert.BackColor = Color.LightGray;
            Insert.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insert.ForeColor = Color.Red;
            Insert.Location = new Point(580, 307);
            Insert.Name = "Insert";
            Insert.Size = new Size(154, 69);
            Insert.TabIndex = 10;
            Insert.Text = "Insert";
            Insert.UseVisualStyleBackColor = false;
            Insert.Click += Insert_Click;
            // 
            // RemoveAt
            // 
            RemoveAt.BackColor = Color.LightGray;
            RemoveAt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveAt.ForeColor = Color.Red;
            RemoveAt.Location = new Point(580, 388);
            RemoveAt.Name = "RemoveAt";
            RemoveAt.Size = new Size(154, 69);
            RemoveAt.TabIndex = 11;
            RemoveAt.Text = "RemoveAt";
            RemoveAt.UseVisualStyleBackColor = false;
            RemoveAt.Click += RemoveAt_Click;
            // 
            // Close
            // 
            Close.BackColor = Color.LightGray;
            Close.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close.ForeColor = Color.Red;
            Close.Location = new Point(580, 465);
            Close.Name = "Close";
            Close.Size = new Size(154, 69);
            Close.TabIndex = 12;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.erik_mclean_ZRns2R5azu0_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(855, 601);
            Controls.Add(Close);
            Controls.Add(RemoveAt);
            Controls.Add(Insert);
            Controls.Add(Clear);
            Controls.Add(Remove);
            Controls.Add(listBox1);
            Controls.Add(Add);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Add;
        private ListBox listBox1;
        private Button Remove;
        private Button Clear;
        private Button Insert;
        private Button RemoveAt;
        private Button Close;
    }
}