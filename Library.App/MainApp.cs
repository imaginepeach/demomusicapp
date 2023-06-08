using Library.IF;
using Library.Settings;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;
using System.Windows.Forms;
using Library.Bll;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library.App
{
    public partial class MainApp : Form
    {
        #region DI - внедрение зависимости
        // Устанавливаем зависимость от контейнера
        private static Configuration _configuration = Registration._configuration;
        private static ISong CreateBook(string name, string author, int indexGenre)
        {
            Genre genre = (Genre)indexGenre;

            var book = _configuration.Container.GetInstance<ISong>();
            book.Name = name;
            book.Author = author;
            book.Genre = genre;

            var library = _configuration.Container.GetInstance<IMusicApp>();

            library.AddBook(book);
            return book;
        }
        private static IFav CreateCheck(ISong book, IUser user)
        {
            var check = _configuration.Container.GetInstance<IFav>();
            check.User = user;
            check.Book = book;
            check.DateTime = DateTime.Now;

            var library = _configuration.Container.GetInstance<IMusicApp>();
            check.Library = library;
            library.TakeBook(check);

            return check;
        }
        private static IEnumerable<ISong> GetAllBooks()
        {
            var library = _configuration.Container.GetInstance<IMusicApp>();
            var books = library.GetAllBooks();

            return books;
        }
        private static IEnumerable<IFav> GetChecks()
        {
            var library = _configuration.Container.GetInstance<IMusicApp>();
            var checks = library.GetChecks(user);

            return checks;
        }
        private static IEnumerable<ISong> FindBooksGenre(Genre genre)
        {
            var library = _configuration.Container.GetInstance<IMusicApp>();
            var books = library.FindBooksGenre(genre);

            return books;
        }
        private static IEnumerable<ISong> FindBooksAuthor(string author)
        {
            var library = _configuration.Container.GetInstance<IMusicApp>();
            var books = library.FindBooksAuthor(author);

            return books;
        }
        private static ISong GetBook(string name, string author)
        {
            var library = _configuration.Container.GetInstance<IMusicApp>();
            var book = library.GetBook(name, author);

            return book;
        }
        private void ReturnBook(IFav check)
        {
            var library = _configuration.Container.GetInstance<IMusicApp>();
            library.ReturnBook(check);
        }
        #endregion
        private void UpdateLists()
        {
            listView1.View = View.Details;
            listUserBooks.Items.Clear();
            var checks = GetChecks();
            foreach (var _check in checks)
            {
                listUserBooks.Items.Add(_check);
            }

            listView1.Items.Clear();
            var books = GetAllBooks();
            foreach (var b in books)
            {
                ListViewItem listitem = new ListViewItem(b.Name);
                listitem.SubItems.Add(b.Author);
                listitem.SubItems.Add(b.Genre.ToString());
                listitem.SubItems.Add(b.isTaken ? "unavaible" : "avaible");
                listView1.Items.Add(listitem);
            }
        }
        private void ChangeSelectionColor(ListBox listBox, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.NavajoWhite);//Choose the color

            e.DrawBackground();
            e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
        static IUser user;

        public MainApp()
        {
            InitializeComponent();
            user = Registration.currentUser;
            var library = _configuration.Container.GetInstance<IMusicApp>();
            listGenre.DataSource = Enum.GetValues(typeof(Genre));
            //addGenre.DataSource = Enum.GetValues(typeof(Genre));
            label1.Text = $"{library}, {user.Name}!";
        }

        private void getAllBooks_Click(object sender, EventArgs e)
        {
            UpdateLists();
        }

        /*private void addBook_Click(object sender, EventArgs e)
         {
             var name = addName.Text;
             var author = addAuthor.Text;
             var genreIndex = addGenre.SelectedIndex;
             var genre = addGenre.SelectedItem;
             var confirmResult = MessageBox.Show($"Вы хотите добавить {name} - {author}, жанр {genre}. Верно?",
                                      "Подтверждение",
                                      MessageBoxButtons.YesNo);
             if (confirmResult == DialogResult.Yes) { }
             else { return; }
             ISong book = CreateBook(name, author, genreIndex);

             label2.Text = $"Книга {book}\nуспешно добавлена.";

             UpdateLists();
         }*/

        private void findBooksGenre_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Genre genre = (Genre)listGenre.SelectedItem;
            var books = FindBooksGenre(genre);
            foreach (var b in books)
            {
                ListViewItem listitem = new ListViewItem(b.Name);
                listitem.SubItems.Add(b.Author);
                listitem.SubItems.Add(b.Genre.ToString());
                listitem.SubItems.Add(b.isTaken ? "unavaible" : "avaible");
                listView1.Items.Add(listitem);
            }
            if (listView1.Items == null)
            {
                label2.Text = "Can't find anything lol!";
            }
            else
            {
                label2.Text = $"There's {listView1.Items.Count} songs\n in {genre}";
            }
        }

        private void findBooksAuthor_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string author = textAuthor.Text;
            var books = FindBooksAuthor(author);
            foreach (var b in books)
            {
                ListViewItem listitem = new ListViewItem(b.Name);
                listitem.SubItems.Add(b.Author);
                listitem.SubItems.Add(b.Genre.ToString());
                listitem.SubItems.Add(b.isTaken ? "unavaible" : "avaible");
                listView1.Items.Add(listitem);
            }
            if (listView1.Items == null)
            {
                label2.Text = "Literally no results bro!";
            }
            else
            {
                label2.Text = $"There's {listView1.Items.Count} songs \n from {author}";
            }

        }

        private void takeBook_Click(object sender, EventArgs e)
        {
            string name;
            string author;
            try
            {
                name = listView1.SelectedItems[0].SubItems[0].Text;
                author = listView1.SelectedItems[0].SubItems[1].Text;
            }
            catch
            {
                label2.Text = "Select a song!";
                return;
            }

            ISong book = GetBook(name, author);
            if (book == null)
            {
                label2.Text = "Select a song!";
                return;
            }
            if (book.isTaken)
            {
                label2.Text = $"Sorry, but song {book}\n is unavaible rn.";
                return;
            }

            /*int time;
            try
            {
                time = int.Parse(textTime.Text);
            }
            catch (Exception ex)
            {
                label2.Text = "Введите количество дней, на которое\nхотите взять книгу!";
                return;
            }
            if (time > 31)
            {
                label2.Text = $"Книгу можно взять не более чем на 31 день!";
                return;
            }
            var confirmResult = MessageBox.Show($"Вы хотите взять книгу {book}. Верно?",
                                     "Подтверждение",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) { }
            else { return; }*/

            var check = CreateCheck(book, user);

            label2.Text = check.ToString();

            UpdateLists();
        }

        private void returnBook_Click(object sender, EventArgs e)
        {
            IFav check = (IFav)listUserBooks.SelectedItem;
            if (check == null)
            {
                label2.Text = "Select a song to remove!";
                return;
            }

            ISong book = GetBook(check.BookName, check.BookAuthor);


            ReturnBook(check);


            UpdateLists();
        }

        private void listUserBooks_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listUserBooks.Items[e.Index].ToString(), listUserBooks.Font, listUserBooks.Width).Height;
        }
        private void listUserBooks_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listUserBooks.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(listUserBooks.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
            ChangeSelectionColor(listUserBooks, e);
        }

        private void booksUser_Click(object sender, EventArgs e)
        {
            UpdateLists();
        }

        private void listGenre_DrawItem(object sender, DrawItemEventArgs e)
        {
            ChangeSelectionColor(listGenre, e);
        }


        private void reviews_Click(object sender, EventArgs e)
        {
            string name;
            string author;
            try
            {
                name = listView1.SelectedItems[0].SubItems[0].Text;
                author = listView1.SelectedItems[0].SubItems[1].Text;
            }
            catch
            {
                label2.Text = "Select a song!";
                return;
            }

            ISong book = GetBook(name, author);
            if (book == null)
            {
                label2.Text = "Select a song!";
                return;
            }
            Genius form = new Genius(user, book);
            form.ShowDialog();
        }

        private void textTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}