using Library.Bll;
using Library.IF;
using Library.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.App
{
    public partial class Genius : Form
    {
        #region DI - внедрение зависимости
        // Устанавливаем зависимость от контейнера
        private static Configuration _configuration = Registration._configuration;
        private static ISong GetBook(string name, string author)
        {
            var library = _configuration.Container.GetInstance<IMusicApp>();
            var book = library.GetBook(name, author);

            return book;
        }
        private static void AddReview((int, string, string) review, string name, string author)
        {
            var library = _configuration.Container.GetInstance<IMusicApp>();

            library.AddReview(review, name, author);
        }
        #endregion
        IUser currentUser;
        ISong currentBook;
        private void UpdateLists()
        {
            listBox1.Items.Clear();
            currentBook = GetBook(currentBook.Name, currentBook.Author);
            List<(int, string, string)> list = JsonConvert.DeserializeObject<List<(int, string, string)>>(currentBook.ReviewsJson);
            if (list != null)
            {
                float sum = 0;
                foreach (var review in list)
                {
                    //listBox1.Items.Add($"{review.Item3}: {review.Item2} - Оценка: {review.Item1}");
                    sum += review.Item1;
                }
            }
            else
            {
                listBox1.Items.Add("No interesting info yet;(!");
            }
        }
        public Genius(IUser user, ISong book)
        {
            InitializeComponent();
            currentUser = user;
            currentBook = book;
            UpdateLists();
            label2.Text += $" {currentBook}";
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }

        private void addReview_Click(object sender, EventArgs e)
        {
            var review = (rating.SelectedIndex + 1, userReview.Text, currentUser.Name);
            /*var confirmResult = MessageBox.Show($"{review.Item3}: {review.Item2}\nОценка: {review.Item1}",
                                     "Подтверждение",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) { }
            else { return; }*/

            AddReview(review, currentBook.Name, currentBook.Author);
            UpdateLists();
        }
    }
}
