namespace semestrovaya
{
    partial class shop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_publisher2 = new System.Windows.Forms.ComboBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.comboBox_developer2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_reviews = new System.Windows.Forms.TextBox();
            this.textBox_publisher = new System.Windows.Forms.TextBox();
            this.textBox_developer = new System.Windows.Forms.TextBox();
            this.textBox_date_creat = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_search = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Управление записями:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button_cancel);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(824, 485);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 389);
            this.panel3.TabIndex = 9;
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_cancel.Image = global::semestrovaya.Properties.Resources.button_color4;
            this.button_cancel.Location = new System.Drawing.Point(42, 301);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(140, 60);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "Отменить";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Image = global::semestrovaya.Properties.Resources.button_color4;
            this.button4.Location = new System.Drawing.Point(42, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Image = global::semestrovaya.Properties.Resources.button_color4;
            this.button3.Location = new System.Drawing.Point(42, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::semestrovaya.Properties.Resources.linklabel2;
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Image = global::semestrovaya.Properties.Resources.button_color4;
            this.button1.Location = new System.Drawing.Point(42, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Новая запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.comboBox_publisher2);
            this.panel2.Controls.Add(this.textBox_price);
            this.panel2.Controls.Add(this.comboBox_developer2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox_age);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_title);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_id);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_reviews);
            this.panel2.Controls.Add(this.textBox_publisher);
            this.panel2.Controls.Add(this.textBox_developer);
            this.panel2.Controls.Add(this.textBox_date_creat);
            this.panel2.Location = new System.Drawing.Point(66, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 389);
            this.panel2.TabIndex = 8;
            // 
            // comboBox_publisher2
            // 
            this.comboBox_publisher2.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox_publisher2.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_publisher2.FormattingEnabled = true;
            this.comboBox_publisher2.Location = new System.Drawing.Point(156, 341);
            this.comboBox_publisher2.Name = "comboBox_publisher2";
            this.comboBox_publisher2.Size = new System.Drawing.Size(355, 28);
            this.comboBox_publisher2.TabIndex = 13;
            // 
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_price.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_price.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox_price.Location = new System.Drawing.Point(161, 172);
            this.textBox_price.Multiline = true;
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(350, 27);
            this.textBox_price.TabIndex = 10;
            // 
            // comboBox_developer2
            // 
            this.comboBox_developer2.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox_developer2.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_developer2.FormattingEnabled = true;
            this.comboBox_developer2.Location = new System.Drawing.Point(156, 298);
            this.comboBox_developer2.Name = "comboBox_developer2";
            this.comboBox_developer2.Size = new System.Drawing.Size(355, 28);
            this.comboBox_developer2.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(4, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 31);
            this.label10.TabIndex = 11;
            this.label10.Text = "Цена $:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(3, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 31);
            this.label9.TabIndex = 14;
            this.label9.Text = "Издатель:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(4, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Разработчик:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(4, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Дата выпуска:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(4, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Возрастное ограничение:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(4, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Отзывы:";
            // 
            // textBox_age
            // 
            this.textBox_age.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_age.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_age.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox_age.Location = new System.Drawing.Point(260, 214);
            this.textBox_age.Multiline = true;
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(251, 27);
            this.textBox_age.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(4, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Название:";
            // 
            // textBox_title
            // 
            this.textBox_title.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_title.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_title.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox_title.Location = new System.Drawing.Point(161, 94);
            this.textBox_title.Multiline = true;
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(350, 27);
            this.textBox_title.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(4, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID:";
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_id.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_id.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox_id.Location = new System.Drawing.Point(161, 53);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(350, 27);
            this.textBox_id.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Запись:";
            // 
            // textBox_reviews
            // 
            this.textBox_reviews.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_reviews.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_reviews.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox_reviews.Location = new System.Drawing.Point(161, 132);
            this.textBox_reviews.Multiline = true;
            this.textBox_reviews.Name = "textBox_reviews";
            this.textBox_reviews.Size = new System.Drawing.Size(350, 27);
            this.textBox_reviews.TabIndex = 2;
            // 
            // textBox_publisher
            // 
            this.textBox_publisher.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_publisher.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_publisher.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox_publisher.Location = new System.Drawing.Point(156, 341);
            this.textBox_publisher.Multiline = true;
            this.textBox_publisher.Name = "textBox_publisher";
            this.textBox_publisher.Size = new System.Drawing.Size(355, 27);
            this.textBox_publisher.TabIndex = 6;
            // 
            // textBox_developer
            // 
            this.textBox_developer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_developer.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_developer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox_developer.Location = new System.Drawing.Point(156, 299);
            this.textBox_developer.Multiline = true;
            this.textBox_developer.Name = "textBox_developer";
            this.textBox_developer.Size = new System.Drawing.Size(355, 27);
            this.textBox_developer.TabIndex = 5;
            this.textBox_developer.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox_date_creat
            // 
            this.textBox_date_creat.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_date_creat.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_date_creat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox_date_creat.Location = new System.Drawing.Point(156, 258);
            this.textBox_date_creat.Multiline = true;
            this.textBox_date_creat.Name = "textBox_date_creat";
            this.textBox_date_creat.Size = new System.Drawing.Size(355, 27);
            this.textBox_date_creat.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(66, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(980, 389);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::semestrovaya.Properties.Resources.button_color4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.linkLabel10);
            this.panel1.Controls.Add(this.linkLabel9);
            this.panel1.Controls.Add(this.linkLabel8);
            this.panel1.Controls.Add(this.linkLabel7);
            this.panel1.Controls.Add(this.linkLabel6);
            this.panel1.Location = new System.Drawing.Point(66, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 60);
            this.panel1.TabIndex = 6;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.Transparent;
            this.button_search.BackgroundImage = global::semestrovaya.Properties.Resources.search;
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_search.Location = new System.Drawing.Point(935, 12);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(32, 32);
            this.button_search.TabIndex = 2;
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.Transparent;
            this.button_refresh.BackgroundImage = global::semestrovaya.Properties.Resources.reload;
            this.button_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_refresh.Location = new System.Drawing.Point(745, 13);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(32, 32);
            this.button_refresh.TabIndex = 1;
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox2.Location = new System.Drawing.Point(782, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 32);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // linkLabel10
            // 
            this.linkLabel10.ActiveLinkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel10.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel10.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel10.Location = new System.Drawing.Point(662, 16);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(73, 21);
            this.linkLabel10.TabIndex = 4;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "Новости";
            this.linkLabel10.VisitedLinkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // linkLabel9
            // 
            this.linkLabel9.ActiveLinkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel9.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel9.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel9.Location = new System.Drawing.Point(495, 16);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(145, 21);
            this.linkLabel9.TabIndex = 3;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "Предметы за очки";
            this.linkLabel9.VisitedLinkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // linkLabel8
            // 
            this.linkLabel8.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel8.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel8.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel8.Location = new System.Drawing.Point(387, 16);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(86, 21);
            this.linkLabel8.TabIndex = 2;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Категории";
            this.linkLabel8.VisitedLinkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.ActiveLinkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel7.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel7.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel7.Location = new System.Drawing.Point(156, 16);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(200, 21);
            this.linkLabel7.TabIndex = 1;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Новое и примечательное";
            this.linkLabel7.VisitedLinkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // linkLabel6
            // 
            this.linkLabel6.ActiveLinkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel6.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel6.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel6.Location = new System.Drawing.Point(21, 16);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(107, 21);
            this.linkLabel6.TabIndex = 0;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Ваш магазин";
            this.linkLabel6.VisitedLinkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::semestrovaya.Properties.Resources.ocean_lightning_black_and_white_connor_sipe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 906);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "shop";
            this.Text = "shop";
            this.Load += new System.EventHandler(this.shop_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_reviews;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.TextBox textBox_publisher;
        private System.Windows.Forms.TextBox textBox_developer;
        private System.Windows.Forms.TextBox textBox_date_creat;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_developer2;
        private System.Windows.Forms.ComboBox comboBox_publisher2;
        private System.Windows.Forms.Button button_cancel;
    }
}