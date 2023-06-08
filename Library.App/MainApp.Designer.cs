namespace Library.App
{
    partial class MainApp
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
            takeBook = new Button();
            findBooksGenre = new Button();
            findBooksAuthor = new Button();
            returnBook = new Button();
            getAllBooks = new Button();
            listGenre = new ListBox();
            textAuthor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            listUserBooks = new ListBox();
            booksUser = new Button();
            label8 = new Label();
            label9 = new Label();
            listView1 = new ListView();
            bookName = new ColumnHeader();
            bookAuthor = new ColumnHeader();
            genre = new ColumnHeader();
            reviews = new Button();
            SuspendLayout();
            // 
            // takeBook
            // 
            takeBook.BackColor = Color.Tan;
            takeBook.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            takeBook.Location = new Point(602, 181);
            takeBook.Margin = new Padding(3, 2, 3, 2);
            takeBook.Name = "takeBook";
            takeBook.Size = new Size(144, 43);
            takeBook.TabIndex = 0;
            takeBook.Text = "Взять книгу";
            takeBook.UseVisualStyleBackColor = false;
            takeBook.Click += takeBook_Click;
            // 
            // findBooksGenre
            // 
            findBooksGenre.BackColor = SystemColors.AppWorkspace;
            findBooksGenre.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            findBooksGenre.Location = new Point(253, 117);
            findBooksGenre.Margin = new Padding(3, 2, 3, 2);
            findBooksGenre.Name = "findBooksGenre";
            findBooksGenre.Size = new Size(134, 43);
            findBooksGenre.TabIndex = 1;
            findBooksGenre.Text = "Найти книгу по жанру";
            findBooksGenre.UseVisualStyleBackColor = false;
            findBooksGenre.Click += findBooksGenre_Click;
            // 
            // findBooksAuthor
            // 
            findBooksAuthor.BackColor = SystemColors.AppWorkspace;
            findBooksAuthor.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            findBooksAuthor.Location = new Point(401, 117);
            findBooksAuthor.Margin = new Padding(3, 2, 3, 2);
            findBooksAuthor.Name = "findBooksAuthor";
            findBooksAuthor.Size = new Size(140, 43);
            findBooksAuthor.TabIndex = 2;
            findBooksAuthor.Text = "Найти книгу по автору";
            findBooksAuthor.UseVisualStyleBackColor = false;
            findBooksAuthor.Click += findBooksAuthor_Click;
            // 
            // returnBook
            // 
            returnBook.BackColor = Color.Tan;
            returnBook.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            returnBook.Location = new Point(1165, 181);
            returnBook.Margin = new Padding(3, 2, 3, 2);
            returnBook.Name = "returnBook";
            returnBook.Size = new Size(144, 43);
            returnBook.TabIndex = 3;
            returnBook.Text = "Вернуть книгу";
            returnBook.UseVisualStyleBackColor = false;
            returnBook.Click += returnBook_Click;
            // 
            // getAllBooks
            // 
            getAllBooks.BackColor = SystemColors.AppWorkspace;
            getAllBooks.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            getAllBooks.Location = new Point(22, 121);
            getAllBooks.Margin = new Padding(3, 2, 3, 2);
            getAllBooks.Name = "getAllBooks";
            getAllBooks.Size = new Size(177, 43);
            getAllBooks.TabIndex = 4;
            getAllBooks.Text = "Посмотреть список \r\nвсех книг";
            getAllBooks.UseVisualStyleBackColor = false;
            getAllBooks.Click += getAllBooks_Click;
            // 
            // listGenre
            // 
            listGenre.BackColor = Color.Ivory;
            listGenre.DrawMode = DrawMode.OwnerDrawFixed;
            listGenre.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            listGenre.FormattingEnabled = true;
            listGenre.ItemHeight = 21;
            listGenre.Location = new Point(254, 86);
            listGenre.Margin = new Padding(3, 2, 3, 2);
            listGenre.Name = "listGenre";
            listGenre.Size = new Size(134, 25);
            listGenre.TabIndex = 7;
            listGenre.DrawItem += listGenre_DrawItem;
            // 
            // textAuthor
            // 
            textAuthor.BackColor = Color.Ivory;
            textAuthor.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textAuthor.Location = new Point(402, 86);
            textAuthor.Margin = new Padding(3, 2, 3, 2);
            textAuthor.Name = "textAuthor";
            textAuthor.Size = new Size(140, 24);
            textAuthor.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.NavajoWhite;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 26);
            label1.Name = "label1";
            label1.Size = new Size(331, 23);
            label1.TabIndex = 12;
            label1.Text = "Добро пожаловать в библиотеку!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Linen;
            label2.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(746, 32);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Tan;
            label5.Font = new Font("Century Gothic", 11.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(886, 96);
            label5.Name = "label5";
            label5.Size = new Size(168, 19);
            label5.TabIndex = 19;
            label5.Text = "Книги, взятые Вами:";
            // 
            // listUserBooks
            // 
            listUserBooks.BackColor = Color.Ivory;
            listUserBooks.DrawMode = DrawMode.OwnerDrawVariable;
            listUserBooks.Font = new Font("Century Gothic", 11.8F, FontStyle.Bold, GraphicsUnit.Point);
            listUserBooks.FormattingEnabled = true;
            listUserBooks.ItemHeight = 20;
            listUserBooks.Location = new Point(762, 181);
            listUserBooks.Margin = new Padding(3, 2, 3, 2);
            listUserBooks.Name = "listUserBooks";
            listUserBooks.Size = new Size(388, 469);
            listUserBooks.TabIndex = 20;
            listUserBooks.DrawItem += listUserBooks_DrawItem;
            listUserBooks.MeasureItem += listUserBooks_MeasureItem;
            // 
            // booksUser
            // 
            booksUser.BackColor = SystemColors.AppWorkspace;
            booksUser.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            booksUser.Location = new Point(1060, 86);
            booksUser.Margin = new Padding(3, 2, 3, 2);
            booksUser.Name = "booksUser";
            booksUser.Size = new Size(189, 43);
            booksUser.TabIndex = 21;
            booksUser.Text = "Посмотреть список \r\nвзятых книг";
            booksUser.UseVisualStyleBackColor = false;
            booksUser.Click += booksUser_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(296, 61);
            label8.Name = "label8";
            label8.Size = new Size(54, 19);
            label8.TabIndex = 25;
            label8.Text = "Жанр:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(442, 61);
            label9.Name = "label9";
            label9.Size = new Size(53, 19);
            label9.TabIndex = 26;
            label9.Text = "Автор:";
            // 
            // listView1
            // 
            listView1.AllowColumnReorder = true;
            listView1.BackColor = Color.Ivory;
            listView1.Columns.AddRange(new ColumnHeader[] { bookName, bookAuthor, genre });
            listView1.Font = new Font("Century Gothic", 11.8F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.LabelEdit = true;
            listView1.Location = new Point(32, 179);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(564, 471);
            listView1.TabIndex = 29;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // bookName
            // 
            bookName.Text = "Название";
            bookName.Width = 200;
            // 
            // bookAuthor
            // 
            bookAuthor.Text = "Автор";
            bookAuthor.Width = 200;
            // 
            // genre
            // 
            genre.Text = "Жанр";
            genre.Width = 160;
            // 
            // reviews
            // 
            reviews.BackColor = Color.Tan;
            reviews.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            reviews.Location = new Point(410, 667);
            reviews.Margin = new Padding(3, 2, 3, 2);
            reviews.Name = "reviews";
            reviews.Size = new Size(186, 43);
            reviews.TabIndex = 30;
            reviews.Text = "Отзывы о книге";
            reviews.UseVisualStyleBackColor = false;
            reviews.Click += reviews_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1321, 743);
            Controls.Add(reviews);
            Controls.Add(listView1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(booksUser);
            Controls.Add(listUserBooks);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textAuthor);
            Controls.Add(listGenre);
            Controls.Add(getAllBooks);
            Controls.Add(returnBook);
            Controls.Add(findBooksAuthor);
            Controls.Add(findBooksGenre);
            Controls.Add(takeBook);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Библиотека";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button takeBook;
        private Button findBooksGenre;
        private Button findBooksAuthor;
        private Button returnBook;
        private Button getAllBooks;
        private ListBox listGenre;
        private TextBox textAuthor;
        private Label label1;
        private Label label2;
        private Label label5;
        private ListBox listUserBooks;
        private Button booksUser;
        private Label label8;
        private Label label9;
        private ListView listView1;
        private ColumnHeader bookName;
        private ColumnHeader bookAuthor;
        private ColumnHeader genre;
        private Button reviews;
    }
}