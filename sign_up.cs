using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semestrovaya
{
    public partial class sign_up : Form
    {
        DataBase db = new DataBase();
        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBox_telephone.Text = "+7 XXX XXX XX XX";
            textBox_telephone.ForeColor = Color.DimGray;
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            textBox_login2.MaxLength = 50;
            textBox_password2.MaxLength = 50;
            textBox_telephone.MaxLength = 17;
            textBox_nickname.MaxLength = 100;
            textBox_email.MaxLength = 100;
            comboBox_country.MaxLength = 100;
            textBox_password2.PasswordChar = '●';
            textBox_password2_repeat.PasswordChar = '●';
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
        }

        private void button_create_account_Click(object sender, EventArgs e)
        {
            if (checkuser())
            {
                return;
            }

            if (checkpasswords())
            {
                return;
            }
            String loginUser = textBox_login2.Text;
            String passUser = textBox_password2.Text;
            String email = textBox_email.Text;
            String country = comboBox_country.Text;
            String phone = textBox_telephone.Text;
            String nickname = textBox_nickname.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("insert into accounts (`login`, `password`, `nickname`, `email`, `phone`, `account_creation_date`, `country`) values (@uL, @uP, @uN, @uE, @uPhone, @uA_C_D, @uC)", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = nickname;
            command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@uA_C_D", MySqlDbType.DateTime).Value = DateTime.Now;
            command.Parameters.Add("@uPhone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@uC", MySqlDbType.VarChar).Value = country;

            db.openConnection();
            if (textBox_login2.TextLength < 3 || textBox_password2.TextLength < 8 || textBox_email.TextLength < 9 || comboBox_country.Text == "" || textBox_telephone.TextLength < 7 || textBox_telephone.Text == "+7 XXX XXX XX XX" || textBox_nickname.TextLength < 1)
            {
                MessageBox.Show("1.Введите имя аккаунта, состоящее как минимум из 3 символов, используя только буквы, цифры и знак «_».\r\n" +
                    "2.Введенный вами пароль недопустим. Пожалуйста, выберите другой, длиной минимум в 8 символов.\r\nДругие ошибки выделены ниже:\r\n\n" +
                    "3.Введите существующий адрес эл. почты\r\n" +
                    "4.Выберите страну проживания\r\n" +
                    "5.Введите номер телефона\r\n" + 
                    "6.Введите имя профиля", "Несоответствие форме регистрации");
            }
            else if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно зарегистрирован.", "Регистрация завершена");
                log_in frm_login = new log_in();
                this.Hide();
                frm_login.ShowDialog();

                db.closeConnection();
                /*adapter.SelectCommand = command;
                adapter.Fill(table);*/
            }
            else
            {
                MessageBox.Show("Произошла ошибка при создании аккаунта.", "Ошибка при регистрации");
            }

        }

        private Boolean checkuser()
        {
            var loginUser = textBox_login2.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select `login` from accounts where `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Выбранное имя аккаунта недоступно. Пожалуйста, выберите другое.", "Ошибка при регистрации");
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean checkpasswords()
        {
            var password1 = textBox_password2.Text;
            var password2 = textBox_password2_repeat.Text;

            if(password1 != password2)
            {
                MessageBox.Show("Пароли не совпадают\nПароль в обоих полях должен совпадать.", "Ошибка при создании аккаунта");
                return true;
            }
            else
            {
                return false;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_password2_repeat.UseSystemPasswordChar = false;
            pictureBox2.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox_password2_repeat.UseSystemPasswordChar = true;
            pictureBox2.Visible = true;
            pictureBox5.Visible = false;
        }

        private void comboBox_country_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_telephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_telephone_Enter(object sender, EventArgs e)
        {
            if(textBox_telephone.Text == "+7 XXX XXX XX XX")
            textBox_telephone.Text = "";
        }

        private void textBox_telephone_Leave(object sender, EventArgs e)
        {
            if (textBox_telephone.Text == "")
            {
                textBox_telephone.Text = "+7 XXX XXX XX XX";
                textBox_telephone.ForeColor = Color.DimGray;
            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox4, "Показать пароль");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox3, "Скрыть пароль");
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox5, "Показать пароль");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox2, "Скрыть пароль");
        }

        private void textBox_telephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; 
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_login2_Leave(object sender, EventArgs e)
        {
          //
        }

        private void textBox_password2_Leave(object sender, EventArgs e)
        {
            //
        }

        private void textBox_password2_repeat_Leave(object sender, EventArgs e)
        {
            //
        }

        private void textBox_login2_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox_login2, "Введите имя аккаунта, состоящее как минимум из 3 символов, используя только буквы, цифры и знак «_».");
        }

        private void textBox_password2_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox_password2, "Пароль должен содержать от 8 символов.");
        }

        private void textBox_password2_repeat_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox_password2_repeat, "Пароли должны совпадать.");
        }

        private void textBox_login2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && !Char.IsLetter(number) && number != 95)
            {
                e.Handled = true;
            }
        }

        private void textBox_telephone_MouseEnter(object sender, EventArgs e)
        {
            textBox_telephone.ForeColor = Color.DarkSlateGray;
        }

        private void textBox_telephone_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_telephone.Text == "" || textBox_telephone.Text == "+7 XXX XXX XX XX")
            textBox_telephone.ForeColor = Color.Gray;
        }

        private void textBox_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && !Char.IsLetter(number) && number != 45 && number != 46 && number != 64)
            {
                e.Handled = true;
            }
        }

        private void textBox_telephone_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox_telephone, "Минимальная длина номера телефона 7 цифр");
        }

        private void sign_up_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
    
}
