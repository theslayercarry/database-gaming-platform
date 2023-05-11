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
    public partial class games_to_types : Form
    {
        DataBase db = new DataBase();
        public games_to_types()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            string myConnectionString = "Database=games_v2;Data Source=127.0.0.1;User Id=root;Password=1337";

            DataTable table_games = new DataTable();
            DataTable table_types = new DataTable();

            MySqlConnection connection_games = new MySqlConnection(myConnectionString);
            {
                MySqlCommand command = new MySqlCommand("SELECT idgames, title FROM games", connection_games);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table_games);
            }

            comboBox_games.DataSource = table_games;
            comboBox_games.DisplayMember = "title";
            comboBox_games.ValueMember = "idgames";

            MySqlConnection connection_types = new MySqlConnection(myConnectionString);
            {
                MySqlCommand command = new MySqlCommand("SELECT idtypes, title FROM types", connection_types);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table_types);
            }

            comboBox_types.DataSource = table_types;
            comboBox_types.DisplayMember = "title";
            comboBox_types.ValueMember = "idtypes";

        }

        private void games_to_types_Load(object sender, EventArgs e)
        {

        }

        private Boolean check_records()
        {
            var id_type = comboBox_types.SelectedValue;
            var id_game = comboBox_games.SelectedValue;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from games_to_types where id_game = @id_game and id_type = @id_type", db.getConnection());
            command.Parameters.Add("@id_game", MySqlDbType.Int32).Value = id_game;
            command.Parameters.Add("@id_type", MySqlDbType.Int32).Value = id_type;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Запись с заданными параметрами уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check_records())
            {
                return;
            }
            var id_game = comboBox_games.SelectedValue;
            var id_type = comboBox_types.SelectedValue;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("insert into games_to_types (id_game, id_type) values (@id_game, @id_type)", db.getConnection());
            command.Parameters.Add("@id_game", MySqlDbType.Int32).Value = id_game;
            command.Parameters.Add("@id_type", MySqlDbType.Int32).Value = id_type;


            db.openConnection();
            if (comboBox_games.Text == "" || comboBox_types.Text == "")
            {
                MessageBox.Show("1. Выберите игру\r\n2. Выберите тип игры", "Несоответствие форме создания записи");
            }
            else if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Запись успешно создана.", "Добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.closeConnection();
                /*adapter.SelectCommand = command;
                adapter.Fill(table);*/
            }
            else
            {
                MessageBox.Show("Произошла ошибка при создании записи.", "Ошибка при добавлении записи", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
