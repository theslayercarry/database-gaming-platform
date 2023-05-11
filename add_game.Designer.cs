namespace semestrovaya
{
    partial class add_game
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
            this.comboBox_publisher = new System.Windows.Forms.ComboBox();
            this.comboBox_developer = new System.Windows.Forms.ComboBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_games_to_genres = new System.Windows.Forms.LinkLabel();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBox_date_creat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_reviews = new System.Windows.Forms.MaskedTextBox();
            this.linkLabel_games_to_types = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_publisher
            // 
            this.comboBox_publisher.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_publisher.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_publisher.FormattingEnabled = true;
            this.comboBox_publisher.Location = new System.Drawing.Point(290, 396);
            this.comboBox_publisher.Name = "comboBox_publisher";
            this.comboBox_publisher.Size = new System.Drawing.Size(324, 31);
            this.comboBox_publisher.TabIndex = 0;
            this.comboBox_publisher.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox_developer
            // 
            this.comboBox_developer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_developer.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_developer.FormattingEnabled = true;
            this.comboBox_developer.Location = new System.Drawing.Point(290, 354);
            this.comboBox_developer.Name = "comboBox_developer";
            this.comboBox_developer.Size = new System.Drawing.Size(324, 31);
            this.comboBox_developer.TabIndex = 1;
            this.comboBox_developer.SelectedIndexChanged += new System.EventHandler(this.comboBox_developer_SelectedIndexChanged);
            // 
            // textBox_title
            // 
            this.textBox_title.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_title.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_title.Location = new System.Drawing.Point(290, 147);
            this.textBox_title.Multiline = true;
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(324, 29);
            this.textBox_title.TabIndex = 2;
            this.textBox_title.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_title_KeyPress);
            // 
            // textBox_age
            // 
            this.textBox_age.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_age.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_age.Location = new System.Drawing.Point(290, 269);
            this.textBox_age.Multiline = true;
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(324, 29);
            this.textBox_age.TabIndex = 4;
            this.textBox_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_age_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Image = global::semestrovaya.Properties.Resources.button_color4;
            this.button1.Location = new System.Drawing.Point(337, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(43, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 31);
            this.label9.TabIndex = 20;
            this.label9.Text = "Издатель:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(43, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "Разработчик:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(43, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "Дата выпуска:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(43, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Возрастное ограничение:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(43, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Отзывы:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(43, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Название:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::semestrovaya.Properties.Resources.button_color4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 102);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Игры (games)";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание записи:";
            // 
            // linkLabel_games_to_genres
            // 
            this.linkLabel_games_to_genres.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel_games_to_genres.AutoSize = true;
            this.linkLabel_games_to_genres.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_games_to_genres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_games_to_genres.ForeColor = System.Drawing.Color.Transparent;
            this.linkLabel_games_to_genres.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel_games_to_genres.Location = new System.Drawing.Point(3, 34);
            this.linkLabel_games_to_genres.Name = "linkLabel_games_to_genres";
            this.linkLabel_games_to_genres.Size = new System.Drawing.Size(334, 16);
            this.linkLabel_games_to_genres.TabIndex = 22;
            this.linkLabel_games_to_genres.TabStop = true;
            this.linkLabel_games_to_genres.Text = "Создание записи: игры к жанрам (games to genres)";
            this.linkLabel_games_to_genres.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_games_to_genres_LinkClicked);
            // 
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_price.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_price.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox_price.Location = new System.Drawing.Point(290, 228);
            this.textBox_price.Multiline = true;
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(324, 29);
            this.textBox_price.TabIndex = 23;
            this.textBox_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_price_KeyPress);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(43, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 31);
            this.label10.TabIndex = 24;
            this.label10.Text = "Цена $:";
            // 
            // maskedTextBox_date_creat
            // 
            this.maskedTextBox_date_creat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBox_date_creat.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_date_creat.Location = new System.Drawing.Point(290, 313);
            this.maskedTextBox_date_creat.Mask = "0000-00-00";
            this.maskedTextBox_date_creat.Name = "maskedTextBox_date_creat";
            this.maskedTextBox_date_creat.Size = new System.Drawing.Size(324, 29);
            this.maskedTextBox_date_creat.TabIndex = 25;
            this.maskedTextBox_date_creat.MouseHover += new System.EventHandler(this.maskedTextBox_date_creat_MouseHover);
            // 
            // maskedTextBox_reviews
            // 
            this.maskedTextBox_reviews.BackColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBox_reviews.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_reviews.Location = new System.Drawing.Point(290, 189);
            this.maskedTextBox_reviews.Mask = "00 % of 0.000.000 reviews аre positive";
            this.maskedTextBox_reviews.Name = "maskedTextBox_reviews";
            this.maskedTextBox_reviews.Size = new System.Drawing.Size(324, 29);
            this.maskedTextBox_reviews.TabIndex = 26;
            // 
            // linkLabel_games_to_types
            // 
            this.linkLabel_games_to_types.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel_games_to_types.AutoSize = true;
            this.linkLabel_games_to_types.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_games_to_types.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_games_to_types.ForeColor = System.Drawing.Color.Transparent;
            this.linkLabel_games_to_types.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel_games_to_types.Location = new System.Drawing.Point(3, 13);
            this.linkLabel_games_to_types.Name = "linkLabel_games_to_types";
            this.linkLabel_games_to_types.Size = new System.Drawing.Size(315, 16);
            this.linkLabel_games_to_types.TabIndex = 27;
            this.linkLabel_games_to_types.TabStop = true;
            this.linkLabel_games_to_types.Text = "Создание записи: игры к типам (games to types)\r\n";
            this.linkLabel_games_to_types.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::semestrovaya.Properties.Resources.button_color4;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.linkLabel_games_to_types);
            this.panel2.Controls.Add(this.linkLabel_games_to_genres);
            this.panel2.Location = new System.Drawing.Point(582, 589);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 63);
            this.panel2.TabIndex = 28;
            // 
            // add_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::semestrovaya.Properties.Resources.fotor_2023_5_9_22_17_20;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 664);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.maskedTextBox_reviews);
            this.Controls.Add(this.maskedTextBox_date_creat);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.comboBox_developer);
            this.Controls.Add(this.comboBox_publisher);
            this.Name = "add_game";
            this.Text = "add_game";
            this.Load += new System.EventHandler(this.add_game_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_publisher;
        private System.Windows.Forms.ComboBox comboBox_developer;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel_games_to_genres;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_date_creat;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_reviews;
        private System.Windows.Forms.LinkLabel linkLabel_games_to_types;
        private System.Windows.Forms.Panel panel2;
    }
}