namespace NIT_LAB
{
    partial class Form10_9
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
            lblCategory = new Label();
            lblSubcategory = new Label();
            lblProduct = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("SimSun-ExtB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.Maroon;
            lblCategory.Location = new Point(69, 114);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(372, 28);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Selected Product Details";
            // 
            // lblSubcategory
            // 
            lblSubcategory.AutoSize = true;
            lblSubcategory.BackColor = Color.Transparent;
            lblSubcategory.Font = new Font("SimSun-ExtB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubcategory.ForeColor = Color.Maroon;
            lblSubcategory.Location = new Point(69, 232);
            lblSubcategory.Margin = new Padding(4, 0, 4, 0);
            lblSubcategory.Name = "lblSubcategory";
            lblSubcategory.Size = new Size(372, 28);
            lblSubcategory.TabIndex = 1;
            lblSubcategory.Text = "Selected Product Details";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.BackColor = Color.Transparent;
            lblProduct.Font = new Font("SimSun-ExtB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProduct.ForeColor = Color.Maroon;
            lblProduct.Location = new Point(69, 349);
            lblProduct.Margin = new Padding(4, 0, 4, 0);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(372, 28);
            lblProduct.TabIndex = 2;
            lblProduct.Text = "Selected Product Details";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 64, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(404, 435);
            btnClose.Margin = new Padding(4, 4, 4, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(255, 86);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form10_9
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnClose);
            Controls.Add(lblProduct);
            Controls.Add(lblSubcategory);
            Controls.Add(lblCategory);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form10_9";
            Text = "Form10_9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategory;
        private Label lblSubcategory;
        private Label lblProduct;
        private Button btnClose;
    }
}