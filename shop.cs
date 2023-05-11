using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semestrovaya
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }  

    public partial class shop : Form
    {
        DataBase db = new DataBase();

        int selectedRow;

        public shop()
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

            comboBox_publisher2.DataSource = table_publishers;
            comboBox_publisher2.DisplayMember = "name";
            comboBox_publisher2.ValueMember = "idpublishers";

            MySqlConnection connection_developers = new MySqlConnection(myConnectionString);
            {
                MySqlCommand command = new MySqlCommand("SELECT iddevelopers, name FROM developers", connection_developers);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table_developers);
            }

            comboBox_developer2.DataSource = table_developers;
            comboBox_developer2.DisplayMember = "name";
            comboBox_developer2.ValueMember = "iddevelopers";
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("title", "Название");
            dataGridView1.Columns.Add("reviews", "Отзывы");
            dataGridView1.Columns.Add("price", "Цена $");
            dataGridView1.Columns.Add("age_restriction", "Возрастное ограничение");
            dataGridView1.Columns.Add("date_of_creation", "Дата выпуска");
            dataGridView1.Columns.Add("id_developer", "Разработчик");
            dataGridView1.Columns.Add("id_publisher", "Издатель");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetInt32(4), record.GetDateTime(5), record.GetString(6), record.GetString(7), RowState.ModifiedNew);
             
        }

        private void RefreshDataGrid(DataGridView dwg)
        {
            dwg.Rows.Clear();
            MySqlCommand command = new MySqlCommand("select idgames, games.title, games.reviews, games.price, games.age_restriction, games.date_of_creation, developers.`name`, publishers.`name` from games\r\njoin publishers on games.id_publisher = publishers.idpublishers\r\njoin developers on games.id_developer = developers.iddevelopers\r\n order by idgames", db.getConnection());
            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }


        private void button4_Click(object sender, EventArgs e)
        {       
            
                textBox_publisher.Visible = true;
                textBox_developer.Visible = true;

                comboBox_developer2.Visible = false;
                comboBox_publisher2.Visible = false;

                Update();
                ClearFields();
            
        }

        private void shop_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            dataGridView1.Columns[8].Visible = false;

            comboBox_developer2.Visible = false;
            comboBox_publisher2.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_title.Text = row.Cells[1].Value.ToString();
                textBox_reviews.Text = row.Cells[2].Value.ToString();
                textBox_price.Text = row.Cells[3].Value.ToString();
                textBox_age.Text = row.Cells[4].Value.ToString();
                textBox_date_creat.Text = row.Cells[5].Value.ToString();
                textBox_developer.Text = row.Cells[6].Value.ToString();
                textBox_publisher.Text = row.Cells[7].Value.ToString();

            }
            string s = textBox_date_creat.Text;
            s = DateTime.Parse(s).ToShortDateString();
            DateTime date = DateTime.Parse(s);
            date.GetDateTimeFormats('u');
            s = date.ToString("yyyy-MM-dd");
            textBox_date_creat.Text = s;

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_game addfrm = new add_game();
            addfrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_publisher.Visible = false;
            textBox_developer.Visible = false;

            comboBox_developer2.Visible = true;
            comboBox_publisher2.Visible = true;

            comboBox_developer2.Text = "";
            comboBox_publisher2.Text = "";
            Change();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            advanced_search frm1 = new advanced_search();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
        }

        private void Search(DataGridView dgw)
        {

            dgw.Rows.Clear();
            MySqlCommand command = new MySqlCommand("select idgames, games.title, games.reviews, games.price, games.age_restriction, games.date_of_creation, developers.`name`, publishers.`name` from games\r\njoin publishers on games.id_publisher = publishers.idpublishers\r\njoin developers on games.id_developer = developers.iddevelopers\r\n where title like concat ('%', @title, '%')", db.getConnection());
            command.Parameters.Add("@title", MySqlDbType.VarChar).Value = textBox2.Text;

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Search(dataGridView1);
         
        }

        private void Update()
        {
            db.openConnection();

            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[8].Value;

                if (rowState == RowState.Existed)
                    continue;

                if(rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var title = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var reviews = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var price = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var age = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var date_creation = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var developer = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var publisher = dataGridView1.Rows[index].Cells[7].Value.ToString();


                    MySqlCommand command = new MySqlCommand("update games set title = @title, reviews = @reviews, price = @price, age_restriction = @age, date_of_creation = @date, id_developer = @developer, id_publisher = @publisher where idgames = @id", db.getConnection());
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                    command.Parameters.Add("@title", MySqlDbType.VarChar).Value = title;
                    command.Parameters.Add("@reviews", MySqlDbType.VarChar).Value = reviews;
                    command.Parameters.Add("@price", MySqlDbType.Int32).Value = price;
                    command.Parameters.Add("@age", MySqlDbType.Int32).Value = age;
                    command.Parameters.Add("@date", MySqlDbType.Date).Value = date_creation;
                    command.Parameters.Add("@developer", MySqlDbType.Int32).Value = developer;
                    command.Parameters.Add("@publisher", MySqlDbType.Int32).Value = publisher;

                    command.ExecuteNonQuery();
                    RefreshDataGrid(dataGridView1);
                }

            }
            db.closeConnection();

        }



        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_id.Text;
            var title = textBox_title.Text;
            var reviews = textBox_reviews.Text;
            var price = textBox_price.Text;
            var age = textBox_age.Text;
            var date_creation = textBox_date_creat.Text;
            var developer = comboBox_developer2.SelectedValue;
            var publisher = comboBox_publisher2.SelectedValue;

            dataGridView1.Rows[selectedRowIndex].SetValues(id, title, reviews, price, age, date_creation, developer, publisher);
            dataGridView1.Rows[selectedRowIndex].Cells[8].Value = RowState.Modified;
        }

        private void ClearFields()
        {
            textBox_id.Text = "";
            textBox_title.Text = "";
            textBox_age.Text = "";
            textBox_reviews.Text = "";
            textBox_price.Text = "";
            textBox_date_creat.Text = "";
            textBox_developer.Text = "";
            textBox_publisher.Text = "";
            comboBox_developer2.Text = "";
            comboBox_publisher2.Text = "";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();

            textBox_publisher.Visible = true;
            textBox_developer.Visible = true;

            comboBox_developer2.Visible = false;
            comboBox_publisher2.Visible = false;
        }
    }

}
