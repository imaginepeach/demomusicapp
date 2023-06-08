using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Bll;
using Library.IF;
using Library.Settings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Library.App
{
    public partial class Registration : Form
    {
        #region DI - внедрение зависимости
        // Устанавливаем зависимость от контейнера
        public static Configuration? _configuration;
        private static IMusicApp CreateLibrary(string address)
        {
            var library = _configuration.Container.GetInstance<IMusicApp>();
            library.Address = address;

            return library;
        }
        private static IUser CreateUser(string name, string email, string password)
        {
            var user = _configuration.Container.GetInstance<IUser>();
            user.Name = name;
            user.Email = email;
            user.Password = password;

            var library = _configuration.Container.GetInstance<IMusicApp>();
            library.Registration(user);

            return user;
        }
        public bool Login(IUser user)
        {
            var library = _configuration.Container.GetInstance<IMusicApp>();
            return library.Login(user);
        }
        public IUser GetUser(IUser user)
        {
            var library = _configuration.Container.GetInstance<IMusicApp>();
            return library.GetUser(user);
        }
        #endregion
        public static IUser? currentUser;
        public Registration()
        {
            _configuration = new Configuration();
            InitializeComponent();
            passwordReg.UseSystemPasswordChar = true;
            passwordRegRetry.UseSystemPasswordChar = true;
            passwordLogin.UseSystemPasswordChar = true;
            var library = CreateLibrary("<3");
            label1.Text = $"{library}!";
        }

        private void checkPasswordReg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPasswordReg.Checked)
            {
                passwordReg.UseSystemPasswordChar = false;
            }
            else
            {
                passwordReg.UseSystemPasswordChar = true;
            }
        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked)
            {
                passwordLogin.UseSystemPasswordChar = false;
            }
            else
            {
                passwordLogin.UseSystemPasswordChar = true;
            }
        }

        private void registration_Click(object sender, EventArgs e)
        {
            /*if (!agreement.Checked)
            {
                label10.Text = "Примите Согласие на обработку Персональных данных!";
                return;
            }*/
            if (passwordReg.Text != passwordRegRetry.Text)
            {
                label10.Text = "Пароли не совпадают, попробуйте еще раз!";
                return;
            }
            else if (passwordReg.Text.Length < 1 || passwordReg.Text.Length > 13)
            {
                label10.Text = "Imagine smth more interesting";
                return;
            }
            string name = nameReg.Text;
            string email = emailReg.Text;
            string password = passwordReg.Text;
            IUser user;
            try
            {
                user = CreateUser(name, email, password);
            }
            catch (Exception ex)
            {
                label10.Text = ex.Message;
                return;
            }
            currentUser = user;
            MainApp form = new MainApp();
            form.ShowDialog();
        }

        private void login_Click(object sender, EventArgs e)
        {
            IUser user = new User
            {
                Email = emailLogin.Text,
                Password = passwordLogin.Text
            };
            if (Login(user))
            {
                currentUser = GetUser(user);
                MainApp form = new MainApp();
                form.ShowDialog();
            }
            else
            {
                label10.Text = "Неправильный логин или пароль!";
            }
        }
    }
}
