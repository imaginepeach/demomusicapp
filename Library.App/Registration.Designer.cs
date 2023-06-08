namespace Library.App
{
    partial class Registration
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
            emailLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            passwordLogin = new TextBox();
            label5 = new Label();
            label6 = new Label();
            passwordReg = new TextBox();
            label7 = new Label();
            emailReg = new TextBox();
            label8 = new Label();
            nameReg = new TextBox();
            label9 = new Label();
            passwordRegRetry = new TextBox();
            agreement = new CheckBox();
            login = new Button();
            registration = new Button();
            checkPasswordReg = new CheckBox();
            checkPassword = new CheckBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // emailLogin
            // 
            emailLogin.BackColor = Color.Ivory;
            emailLogin.Location = new Point(56, 141);
            emailLogin.Margin = new Padding(3, 2, 3, 2);
            emailLogin.Name = "emailLogin";
            emailLogin.Size = new Size(145, 23);
            emailLogin.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.NavajoWhite;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 19);
            label1.Name = "label1";
            label1.Size = new Size(331, 23);
            label1.TabIndex = 20;
            label1.Text = "Добро пожаловать в библиотеку!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 59);
            label2.Name = "label2";
            label2.Size = new Size(131, 19);
            label2.TabIndex = 21;
            label2.Text = "Вход в аккаунт";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 124);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 22;
            label3.Text = "Логин:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 165);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 24;
            label4.Text = "Пароль:";
            // 
            // passwordLogin
            // 
            passwordLogin.BackColor = Color.Ivory;
            passwordLogin.Location = new Point(56, 182);
            passwordLogin.Margin = new Padding(3, 2, 3, 2);
            passwordLogin.Name = "passwordLogin";
            passwordLogin.Size = new Size(145, 23);
            passwordLogin.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(469, 59);
            label5.Name = "label5";
            label5.Size = new Size(113, 19);
            label5.TabIndex = 25;
            label5.Text = "Регистрация";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(458, 217);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 29;
            label6.Text = "Пароль:";
            // 
            // passwordReg
            // 
            passwordReg.BackColor = Color.Ivory;
            passwordReg.Location = new Point(458, 234);
            passwordReg.Margin = new Padding(3, 2, 3, 2);
            passwordReg.Name = "passwordReg";
            passwordReg.Size = new Size(145, 23);
            passwordReg.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(457, 160);
            label7.Name = "label7";
            label7.Size = new Size(158, 20);
            label7.TabIndex = 27;
            label7.Text = "Электронная почта:";
            // 
            // emailReg
            // 
            emailReg.BackColor = Color.Ivory;
            emailReg.Location = new Point(458, 177);
            emailReg.Margin = new Padding(3, 2, 3, 2);
            emailReg.Name = "emailReg";
            emailReg.Size = new Size(145, 23);
            emailReg.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(458, 119);
            label8.Name = "label8";
            label8.Size = new Size(121, 20);
            label8.TabIndex = 31;
            label8.Text = "Фамилия, Имя:";
            // 
            // nameReg
            // 
            nameReg.BackColor = Color.Ivory;
            nameReg.Location = new Point(458, 137);
            nameReg.Margin = new Padding(3, 2, 3, 2);
            nameReg.Name = "nameReg";
            nameReg.Size = new Size(145, 23);
            nameReg.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(458, 258);
            label9.Name = "label9";
            label9.Size = new Size(149, 20);
            label9.TabIndex = 33;
            label9.Text = "Повторите пароль:";
            // 
            // passwordRegRetry
            // 
            passwordRegRetry.BackColor = Color.Ivory;
            passwordRegRetry.Location = new Point(458, 275);
            passwordRegRetry.Margin = new Padding(3, 2, 3, 2);
            passwordRegRetry.Name = "passwordRegRetry";
            passwordRegRetry.Size = new Size(145, 23);
            passwordRegRetry.TabIndex = 32;
            // 
            // agreement
            // 
            agreement.AutoSize = true;
            agreement.Font = new Font("Century Gothic", 9.8F, FontStyle.Regular, GraphicsUnit.Point);
            agreement.Location = new Point(365, 356);
            agreement.Margin = new Padding(3, 2, 3, 2);
            agreement.Name = "agreement";
            agreement.Size = new Size(362, 23);
            agreement.TabIndex = 34;
            agreement.Text = "Согласие на обработку Персональных данных";
            agreement.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            login.BackColor = Color.Tan;
            login.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(54, 396);
            login.Margin = new Padding(3, 2, 3, 2);
            login.Name = "login";
            login.Size = new Size(144, 36);
            login.TabIndex = 35;
            login.Text = "Войти";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // registration
            // 
            registration.BackColor = Color.Tan;
            registration.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            registration.Location = new Point(389, 396);
            registration.Margin = new Padding(3, 2, 3, 2);
            registration.Name = "registration";
            registration.Size = new Size(312, 36);
            registration.TabIndex = 36;
            registration.Text = "Зарегистрироваться";
            registration.UseVisualStyleBackColor = false;
            registration.Click += registration_Click;
            // 
            // checkPasswordReg
            // 
            checkPasswordReg.AutoSize = true;
            checkPasswordReg.Font = new Font("Century Gothic", 9.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkPasswordReg.Location = new Point(469, 320);
            checkPasswordReg.Margin = new Padding(3, 2, 3, 2);
            checkPasswordReg.Name = "checkPasswordReg";
            checkPasswordReg.Size = new Size(159, 23);
            checkPasswordReg.TabIndex = 37;
            checkPasswordReg.Text = "Видимость пароля";
            checkPasswordReg.UseVisualStyleBackColor = true;
            checkPasswordReg.CheckedChanged += checkPasswordReg_CheckedChanged;
            // 
            // checkPassword
            // 
            checkPassword.AutoSize = true;
            checkPassword.Font = new Font("Century Gothic", 9.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkPassword.Location = new Point(54, 356);
            checkPassword.Margin = new Padding(3, 2, 3, 2);
            checkPassword.Name = "checkPassword";
            checkPassword.Size = new Size(159, 23);
            checkPassword.TabIndex = 38;
            checkPassword.Text = "Видимость пароля";
            checkPassword.UseVisualStyleBackColor = true;
            checkPassword.CheckedChanged += checkPassword_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.SaddleBrown;
            label10.Location = new Point(54, 251);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 39;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(878, 505);
            Controls.Add(label10);
            Controls.Add(checkPassword);
            Controls.Add(checkPasswordReg);
            Controls.Add(registration);
            Controls.Add(login);
            Controls.Add(agreement);
            Controls.Add(label9);
            Controls.Add(passwordRegRetry);
            Controls.Add(label8);
            Controls.Add(nameReg);
            Controls.Add(label6);
            Controls.Add(passwordReg);
            Controls.Add(label7);
            Controls.Add(emailReg);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(passwordLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emailLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Вход в учетную запись";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox passwordLogin;
        private Label label5;
        private Label label6;
        private TextBox passwordReg;
        private Label label7;
        private TextBox emailReg;
        private Label label8;
        private TextBox nameReg;
        private Label label9;
        private TextBox passwordRegRetry;
        private CheckBox agreement;
        private Button login;
        private Button registration;
        private CheckBox checkPasswordReg;
        private CheckBox checkPassword;
        private Label label10;
    }
}