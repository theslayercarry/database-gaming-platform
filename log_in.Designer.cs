namespace semestrovaya
{
    partial class log_in
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
            this.textBox_login1 = new System.Windows.Forms.TextBox();
            this.textBox_password1 = new System.Windows.Forms.TextBox();
            this.checkBox_remember_me = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_login1
            // 
            this.textBox_login1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_login1.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox_login1.Location = new System.Drawing.Point(145, 180);
            this.textBox_login1.Multiline = true;
            this.textBox_login1.Name = "textBox_login1";
            this.textBox_login1.Size = new System.Drawing.Size(368, 38);
            this.textBox_login1.TabIndex = 3;
            this.textBox_login1.TextChanged += new System.EventHandler(this.textBox_login1_TextChanged);
            // 
            // textBox_password1
            // 
            this.textBox_password1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_password1.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox_password1.Location = new System.Drawing.Point(145, 249);
            this.textBox_password1.Multiline = true;
            this.textBox_password1.Name = "textBox_password1";
            this.textBox_password1.ShortcutsEnabled = false;
            this.textBox_password1.Size = new System.Drawing.Size(368, 38);
            this.textBox_password1.TabIndex = 4;
            this.textBox_password1.TextChanged += new System.EventHandler(this.textBox_password1_TextChanged);
            // 
            // checkBox_remember_me
            // 
            this.checkBox_remember_me.AutoSize = true;
            this.checkBox_remember_me.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_remember_me.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_remember_me.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_remember_me.ForeColor = System.Drawing.Color.Ivory;
            this.checkBox_remember_me.Location = new System.Drawing.Point(145, 293);
            this.checkBox_remember_me.Name = "checkBox_remember_me";
            this.checkBox_remember_me.Size = new System.Drawing.Size(126, 22);
            this.checkBox_remember_me.TabIndex = 12;
            this.checkBox_remember_me.Text = "Запомнить меня";
            this.checkBox_remember_me.UseVisualStyleBackColor = false;
            this.checkBox_remember_me.CheckedChanged += new System.EventHandler(this.checkBox_remember_me_CheckedChanged);
            this.checkBox_remember_me.MouseHover += new System.EventHandler(this.checkBox_remember_me_MouseHover);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Ivory;
            this.linkLabel1.Location = new System.Drawing.Point(581, 471);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(299, 34);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ещё нет аккаунта? Создайте бесплатный аккаунт";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::semestrovaya.Properties.Resources.hide_new;
            this.pictureBox4.Location = new System.Drawing.Point(473, 258);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::semestrovaya.Properties.Resources.show_new;
            this.pictureBox3.Location = new System.Drawing.Point(473, 258);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreate.Image = global::semestrovaya.Properties.Resources.button_color4;
            this.btnCreate.Location = new System.Drawing.Point(227, 321);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(200, 58);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Войти";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(142, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "ПАРОЛЬ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(141, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ВОЙТИ, ИСПОЛЬЗУЯ ИМЯ АККАУНТА";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::semestrovaya.Properties.Resources.theboys;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 514);
            this.Controls.Add(this.checkBox_remember_me);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_password1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_login1);
            this.DoubleBuffered = true;
            this.Name = "log_in";
            this.Text = "log_in";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.log_in_FormClosed);
            this.Load += new System.EventHandler(this.log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_login1;
        private System.Windows.Forms.TextBox textBox_password1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox_remember_me;
    }
}