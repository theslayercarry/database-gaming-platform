using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace semestrovaya
{
    public partial class add_game : Form
    {
        DataBase db = new DataBase();

        public add_game()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            string myConnectionString = "Database=games_v2;Data Source=127.0.0.1;User Id=root;Password=1337";

            DataTable table_publishers = new DataTable();
            DataTable table_developers = new DataTable();

            MySqlConnection connection_publishers = new MySqlConnection(myConnectionString);
            {
                MySqlCommand command = new MySqlCommand("SELECT idpublishers, name FROM publishers", connection_publishers);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table_publishers);
            }

            comboBox_publisher.DataSource = table_publishers;
            comboBox_publisher.DisplayMember = "name";
            comboBox_publisher.ValueMember = "idpublishers";

            MySqlConnection connection_developers = new MySqlConnection(myConnectionString);
            {
                MySqlCommand command = new MySqlCommand("SELECT iddevelopers, name FROM developers", connection_developers);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table_developers);
            }

            comboBox_developer.DataSource = table_developers;
            comboBox_developer.DisplayMember = "name";
            comboBox_developer.ValueMember = "iddevelopers";
        }

        private void add_game_Load(object sender, EventArgs e)
        {
            textBox_title.MaxLength = 100;
            textBox_price.MaxLength = 2;
            textBox_age.MaxLength = 2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox_publisher.SelectedValue.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var title = textBox_title.Text;
            var reviews = maskedTextBox_reviews.Text;
            var price = textBox_price.Text;
            var age = textBox_age.Text;
            var date_creation = maskedTextBox_date_creat.Text;
            var developer = comboBox_developer.SelectedValue;
            var publisher = comboBox_publisher.SelectedValue;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command_new = new MySqlCommand("insert into games (`title`, `reviews`, `price`, `age_restriction`, `date_of_creation`, `id_developer`, `id_publisher`) values (@title, @reviews, @price, @age_restriction, @date_of_creation, @id_developer, @id_publisher)", db.getConnection());
            command_new.Parameters.Add("@title", MySqlDbType.VarChar).Value = title;
            command_new.Parameters.Add("@reviews", MySqlDbType.VarChar).Value = reviews;
            command_new.Parameters.Add("@price", MySqlDbType.Int32).Value = price;
            command_new.Parameters.Add("@age_restriction", MySqlDbType.Int32).Value = age;
            command_new.Parameters.Add("@date_of_creation", MySqlDbType.VarChar).Value = date_creation;
            command_new.Parameters.Add("@id_developer", MySqlDbType.Int32).Value = developer;
            command_new.Parameters.Add("@id_publisher", MySqlDbType.Int32).Value = publisher;

            if (textBox_title.TextLength < 1 || maskedTextBox_reviews.Text == "   % of  ,   ,    reviews аre positive" || textBox_price.TextLength < 1 || textBox_age.TextLength < 1 || maskedTextBox_date_creat.Text == "    -  -" || comboBox_developer.Text == "" || comboBox_publisher.Text == "")
            {
                MessageBox.Show("1.Введите название игры, состоящее как минимум из 1 символа, используя только буквы, цифры и знаки «:», «!», «|», «.», «'».\r\n" +
                    "2.Выберите Издателя.\r\n" +
                    "3.Выберите Разработчика.\r\nДругие ошибки выделены ниже:\r\n\n" +
                    "4.Введите дату выпуска игры в формате \"____-__-__\"\r\n" +
                    "5.Введите рецензию на игру в формате \"% of _,___,___ reviews аre positive\"\r\n" +
                    "6.Введите возрастное ограничение игры\r\n" +
                    "7.Введите цену игры", "Несоответствие форме создания записи");
            }
            else if (command_new.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Запись успешно создана.", "Добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.closeConnection();
            }
            else
            {
                MessageBox.Show("Произошла ошибка при создании записи.", "Ошибка при добавлении записи", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox_developer_SelectedIndexChanged(object sender, EventArgs e)
        {
           //MessageBox.Show(comboBox_developer.SelectedValue.ToString());
        }

        private void textBox_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox_date_creat_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip t = new System.Windows.Forms.ToolTip();
            t.SetToolTip(maskedTextBox_date_creat, "yyyy-mm-dd");
        }

        private void textBox_title_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && !Char.IsLetter(number) && number != 32 && number != 58 && number != 33 && number != '|' && number != 46 && number != '\'')
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            games_to_types addfrm = new games_to_types();
            addfrm.Show();
        }

        private void linkLabel_games_to_genres_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            games_to_genres addfrm = new games_to_genres();
            addfrm.Show();
        }
    }
        
        
}



    


