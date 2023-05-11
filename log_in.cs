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
    public partial class log_in : Form
    {
        DataBase db = new DataBase();
        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            textBox_password1.PasswordChar = '●';
            pictureBox3.Visible = false;
            textBox_login1.MaxLength = 50;
            textBox_password1.MaxLength = 50;   
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String loginUser = textBox_login1.Text;
            String passUser = textBox_password1.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select `login`, `password` from accounts where `login` = @uL and `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Загрузка данных пользователя...", "Успешная авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                shop frm1 = new shop();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Пожалуйста, проверьте свой пароль и имя аккаунта и попробуйте снова.", "Ошибка при входе", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) 
        {
            sign_up frm1 = new sign_up();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void textBox_login1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox_password1.UseSystemPasswordChar = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_password1.UseSystemPasswordChar = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_remember_me_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox_remember_me_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(checkBox_remember_me, "При следующем запуске приложения вам не нужно будет вводить пароль или подтверждать вход в аккаунт");
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

        private void log_in_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
