namespace Library.App
{
    partial class Genius
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
            listBox1 = new ListBox();
            rating = new ComboBox();
            userReview = new TextBox();
            addReview = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(32, 62);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.None;
            listBox1.Size = new Size(694, 184);
            listBox1.TabIndex = 0;
            listBox1.DrawItem += listBox1_DrawItem;
            // 
            // rating
            // 
            rating.DropDownStyle = ComboBoxStyle.DropDownList;
            rating.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            rating.FormattingEnabled = true;
            rating.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            rating.Location = new Point(32, 307);
            rating.Margin = new Padding(3, 2, 3, 2);
            rating.Name = "rating";
            rating.Size = new Size(155, 30);
            rating.TabIndex = 1;
            // 
            // userReview
            // 
            userReview.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            userReview.Location = new Point(32, 307);
            userReview.Margin = new Padding(3, 2, 3, 2);
            userReview.Multiline = true;
            userReview.Name = "userReview";
            userReview.Size = new Size(694, 194);
            userReview.TabIndex = 2;
            // 
            // addReview
            // 
            addReview.BackColor = Color.Tan;
            addReview.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            addReview.Location = new Point(571, 534);
            addReview.Margin = new Padding(3, 2, 3, 2);
            addReview.Name = "addReview";
            addReview.Size = new Size(155, 46);
            addReview.TabIndex = 3;
            addReview.Text = "Оставить отзыв";
            addReview.UseVisualStyleBackColor = false;
            addReview.Click += addReview_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 259);
            label1.Name = "label1";
            label1.Size = new Size(204, 23);
            label1.TabIndex = 4;
            label1.Text = "Write smth interesting";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 18);
            label2.Name = "label2";
            label2.Size = new Size(157, 23);
            label2.TabIndex = 5;
            label2.Text = "Some cool facts";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(777, 622);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addReview);
            Controls.Add(userReview);
            Controls.Add(rating);
            Controls.Add(listBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Отзывы о книге";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ComboBox rating;
        private TextBox userReview;
        private Button addReview;
        private Label label1;
        private Label label2;
    }
}