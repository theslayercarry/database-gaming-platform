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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace semestrovaya
{
    public partial class advanced_search : Form
    {
        DataBase db = new DataBase();
        int i = 0;
        public advanced_search()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            string myConnectionString = "Database=games_v2;Data Source=127.0.0.1;User Id=root;Password=1337";

            DataTable table_genres = new DataTable();
            DataTable table_themes = new DataTable();
            DataTable table_types = new DataTable();

            MySqlConnection connection_genres = new MySqlConnection(myConnectionString);
            {
                MySqlCommand command = new MySqlCommand("SELECT idgenres, title FROM genres", connection_genres);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table_genres);
            }

            listBox_genres.DataSource = table_genres;
            listBox_genres.DisplayMember = "title";
            listBox_genres.ValueMember = "idgenres";

            MySqlConnection connection_themes = new MySqlConnection(myConnectionString);
            {
                MySqlCommand command = new MySqlCommand("SELECT idthemes, title FROM themes", connection_themes);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table_themes);
            }

            listBox_themes.DataSource = table_themes;
            listBox_themes.DisplayMember = "title";
            listBox_themes.ValueMember = "idthemes";


            MySqlConnection connection_types = new MySqlConnection(myConnectionString);
            {
                MySqlCommand command = new MySqlCommand("SELECT idtypes, title FROM types", connection_types);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table_types);
            }

            listBox_types.DataSource = table_types;
            listBox_types.DisplayMember = "title";
            listBox_types.ValueMember = "idtypes";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = listBox_genres.Text;
            if (i++ == 0)
            {
                CreateColumns();
            }    
            dataGridView1.Columns[2].HeaderText = "Жанр";
            RefreshDataGrid_genres(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = listBox_themes.Text;
            if (i++ == 0)
            {
                CreateColumns();
            }
            dataGridView1.Columns[2].HeaderText = "Тема";
            RefreshDataGrid_themes(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = listBox_types.Text;
            if (i++ == 0)
            {
                CreateColumns();
            }
            dataGridView1.Columns[2].HeaderText = "Тип";
            RefreshDataGrid_types(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("title", "Название");
            dataGridView1.Columns.Add("reviews", "Отзывы");
            dataGridView1.Columns.Add("id_genre","Жанр");
            dataGridView1.Columns.Add("price", "Цена $");
            dataGridView1.Columns.Add("date_of_creation", "Дата выпуска");
            dataGridView1.Columns.Add("id_developer", "Разработчик");
            dataGridView1.Columns.Add("id_publisher", "Издатель");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[7].Visible = false;
        }


        private void RefreshDataGrid_genres(DataGridView dwg)
        {
            dwg.Rows.Clear();
            MySqlCommand command = new MySqlCommand("select games.title, games.reviews, genres.title, games.price, games.date_of_creation, developers.`name`, publishers.`name` from games \r\njoin publishers on games.id_publisher = publishers.idpublishers\r\njoin developers on games.id_developer = developers.iddevelopers\r\njoin games_to_genres on games_to_genres.id_game = games.idgames\r\njoin genres on games_to_genres.id_genre = genres.idgenres where genres.idgenres = @genre order by games.title", db.getConnection());
            command.Parameters.Add("@genre", MySqlDbType.Int32).Value = listBox_genres.SelectedValue;
            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow_genres(dwg, reader);
            }
            reader.Close();
        }

        private void RefreshDataGrid_types(DataGridView dwg)
        {
            dwg.Rows.Clear();
            MySqlCommand command = new MySqlCommand("select games.title, games.reviews, types.title, games.price, games.date_of_creation, developers.`name`, publishers.`name` from games \r\njoin publishers on games.id_publisher = publishers.idpublishers\r\njoin developers on games.id_developer = developers.iddevelopers\r\njoin games_to_types on games_to_types.id_game = games.idgames\r\njoin types on games_to_types.id_type = types.idtypes where types.idtypes = @type order by games.title", db.getConnection());
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = listBox_types.SelectedValue;
            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow_types(dwg, reader);
            }
            reader.Close();
        }

        private void RefreshDataGrid_themes(DataGridView dwg)
        {
            dwg.Rows.Clear();
            MySqlCommand command = new MySqlCommand("select games.title, games.reviews, themes.title, games.price, games.date_of_creation, developers.`name`, publishers.`name` from games \r\njoin publishers on games.id_publisher = publishers.idpublishers\r\njoin developers on games.id_developer = developers.iddevelopers\r\njoin games_to_themes on games_to_themes.id_game = games.idgames\r\njoin themes on games_to_themes.id_theme = themes.idthemes where themes.idthemes = @theme order by games.title", db.getConnection());
            command.Parameters.Add("@theme", MySqlDbType.Int32).Value = listBox_themes.SelectedValue;
            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow_themes(dwg, reader);
            }
            reader.Close();
        }


        private void ReadSingleRow_genres(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetDateTime(4), record.GetString(5), record.GetString(6), RowState.ModifiedNew);

        }

        private void ReadSingleRow_types(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetDateTime(4), record.GetString(5), record.GetString(6), RowState.ModifiedNew);

        }


        private void ReadSingleRow_themes(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetDateTime(4), record.GetString(5), record.GetString(6), RowState.ModifiedNew);

        }

        private void advanced_search_Load(object sender, EventArgs e)
        {

        }
    }
}
