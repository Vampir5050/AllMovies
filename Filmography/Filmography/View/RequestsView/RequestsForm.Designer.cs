namespace Filmography.View.Requests
{
    partial class RequestsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Req1tabPage = new System.Windows.Forms.TabPage();
            this.Request1comboBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Req2tabPage = new System.Windows.Forms.TabPage();
            this.SearchReq2button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CountrycomboBox = new System.Windows.Forms.ComboBox();
            this.FilmcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Req3tabPage = new System.Windows.Forms.TabPage();
            this.Req3MaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Req3MinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SearchReq3button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Req3YearComboBox = new System.Windows.Forms.ComboBox();
            this.Riq3CountryComboBox = new System.Windows.Forms.ComboBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.Req6tabPage = new System.Windows.Forms.TabPage();
            this.SearchReq6button = new System.Windows.Forms.Button();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.Req7tabPage = new System.Windows.Forms.TabPage();
            this.SearchReq7button = new System.Windows.Forms.Button();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.Req8tabPage = new System.Windows.Forms.TabPage();
            this.SearchReq8button = new System.Windows.Forms.Button();
            this.Req8FilmsComboBox = new System.Windows.Forms.ComboBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.Req9tabPage = new System.Windows.Forms.TabPage();
            this.listBox9 = new System.Windows.Forms.ListBox();
            this.Req9ActorComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Req9YearComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchReq9button = new System.Windows.Forms.Button();
            this.Req10tabPage = new System.Windows.Forms.TabPage();
            this.listBox10 = new System.Windows.Forms.ListBox();
            this.Req10HumansComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchReq10button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Req1tabPage.SuspendLayout();
            this.Req2tabPage.SuspendLayout();
            this.Req3tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Req3MaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Req3MinNumericUpDown)).BeginInit();
            this.Req6tabPage.SuspendLayout();
            this.Req7tabPage.SuspendLayout();
            this.Req8tabPage.SuspendLayout();
            this.Req9tabPage.SuspendLayout();
            this.Req10tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Req1tabPage);
            this.tabControl1.Controls.Add(this.Req2tabPage);
            this.tabControl1.Controls.Add(this.Req3tabPage);
            this.tabControl1.Controls.Add(this.Req6tabPage);
            this.tabControl1.Controls.Add(this.Req7tabPage);
            this.tabControl1.Controls.Add(this.Req8tabPage);
            this.tabControl1.Controls.Add(this.Req9tabPage);
            this.tabControl1.Controls.Add(this.Req10tabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1092, 503);
            this.tabControl1.TabIndex = 0;
            // 
            // Req1tabPage
            // 
            this.Req1tabPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Req1tabPage.Controls.Add(this.Request1comboBox);
            this.Req1tabPage.Controls.Add(this.listBox1);
            this.Req1tabPage.Location = new System.Drawing.Point(4, 25);
            this.Req1tabPage.Name = "Req1tabPage";
            this.Req1tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Req1tabPage.Size = new System.Drawing.Size(1084, 474);
            this.Req1tabPage.TabIndex = 0;
            this.Req1tabPage.Text = "запрос 1";
            // 
            // Request1comboBox
            // 
            this.Request1comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.Request1comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Request1comboBox.FormattingEnabled = true;
            this.Request1comboBox.Items.AddRange(new object[] {
            "найти самый дорогой фильм",
            "найти самый популярный фильм",
            "найти самый старый фильм по году"});
            this.Request1comboBox.Location = new System.Drawing.Point(3, 108);
            this.Request1comboBox.Name = "Request1comboBox";
            this.Request1comboBox.Size = new System.Drawing.Size(350, 24);
            this.Request1comboBox.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(370, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(708, 404);
            this.listBox1.TabIndex = 0;
            // 
            // Req2tabPage
            // 
            this.Req2tabPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Req2tabPage.Controls.Add(this.SearchReq2button);
            this.Req2tabPage.Controls.Add(this.label3);
            this.Req2tabPage.Controls.Add(this.label2);
            this.Req2tabPage.Controls.Add(this.CountrycomboBox);
            this.Req2tabPage.Controls.Add(this.FilmcomboBox);
            this.Req2tabPage.Controls.Add(this.label1);
            this.Req2tabPage.Controls.Add(this.GenreComboBox);
            this.Req2tabPage.Controls.Add(this.listBox2);
            this.Req2tabPage.Location = new System.Drawing.Point(4, 25);
            this.Req2tabPage.Name = "Req2tabPage";
            this.Req2tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Req2tabPage.Size = new System.Drawing.Size(1084, 474);
            this.Req2tabPage.TabIndex = 1;
            this.Req2tabPage.Text = "запрос 2";
            // 
            // SearchReq2button
            // 
            this.SearchReq2button.Location = new System.Drawing.Point(11, 360);
            this.SearchReq2button.Name = "SearchReq2button";
            this.SearchReq2button.Size = new System.Drawing.Size(125, 23);
            this.SearchReq2button.TabIndex = 7;
            this.SearchReq2button.Text = "поиск";
            this.SearchReq2button.UseVisualStyleBackColor = true;
            this.SearchReq2button.Click += new System.EventHandler(this.SearchReq2button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "выбор фильма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "выбор страны";
            // 
            // CountrycomboBox
            // 
            this.CountrycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountrycomboBox.FormattingEnabled = true;
            this.CountrycomboBox.Location = new System.Drawing.Point(5, 140);
            this.CountrycomboBox.Name = "CountrycomboBox";
            this.CountrycomboBox.Size = new System.Drawing.Size(224, 24);
            this.CountrycomboBox.TabIndex = 4;
            // 
            // FilmcomboBox
            // 
            this.FilmcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilmcomboBox.FormattingEnabled = true;
            this.FilmcomboBox.Location = new System.Drawing.Point(5, 231);
            this.FilmcomboBox.Name = "FilmcomboBox";
            this.FilmcomboBox.Size = new System.Drawing.Size(224, 24);
            this.FilmcomboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "выбор жанра";
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(5, 57);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(227, 24);
            this.GenreComboBox.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(304, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(762, 468);
            this.listBox2.TabIndex = 0;
            // 
            // Req3tabPage
            // 
            this.Req3tabPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Req3tabPage.Controls.Add(this.Req3MaxNumericUpDown);
            this.Req3tabPage.Controls.Add(this.Req3MinNumericUpDown);
            this.Req3tabPage.Controls.Add(this.SearchReq3button);
            this.Req3tabPage.Controls.Add(this.label6);
            this.Req3tabPage.Controls.Add(this.label5);
            this.Req3tabPage.Controls.Add(this.label4);
            this.Req3tabPage.Controls.Add(this.Req3YearComboBox);
            this.Req3tabPage.Controls.Add(this.Riq3CountryComboBox);
            this.Req3tabPage.Controls.Add(this.listBox3);
            this.Req3tabPage.Location = new System.Drawing.Point(4, 25);
            this.Req3tabPage.Name = "Req3tabPage";
            this.Req3tabPage.Size = new System.Drawing.Size(1084, 474);
            this.Req3tabPage.TabIndex = 2;
            this.Req3tabPage.Text = "запрос 3";
            // 
            // Req3MaxNumericUpDown
            // 
            this.Req3MaxNumericUpDown.Location = new System.Drawing.Point(204, 210);
            this.Req3MaxNumericUpDown.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.Req3MaxNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Req3MaxNumericUpDown.Name = "Req3MaxNumericUpDown";
            this.Req3MaxNumericUpDown.Size = new System.Drawing.Size(164, 22);
            this.Req3MaxNumericUpDown.TabIndex = 9;
            this.Req3MaxNumericUpDown.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // Req3MinNumericUpDown
            // 
            this.Req3MinNumericUpDown.Location = new System.Drawing.Point(11, 209);
            this.Req3MinNumericUpDown.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.Req3MinNumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Req3MinNumericUpDown.Name = "Req3MinNumericUpDown";
            this.Req3MinNumericUpDown.Size = new System.Drawing.Size(164, 22);
            this.Req3MinNumericUpDown.TabIndex = 8;
            this.Req3MinNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // SearchReq3button
            // 
            this.SearchReq3button.Location = new System.Drawing.Point(20, 303);
            this.SearchReq3button.Name = "SearchReq3button";
            this.SearchReq3button.Size = new System.Drawing.Size(75, 23);
            this.SearchReq3button.TabIndex = 7;
            this.SearchReq3button.Text = "поиск";
            this.SearchReq3button.UseVisualStyleBackColor = true;
            this.SearchReq3button.Click += new System.EventHandler(this.SearchReq3button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(116, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "выберите диапозон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "выберите страну";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "выберите год выпуска";
            // 
            // Req3YearComboBox
            // 
            this.Req3YearComboBox.FormattingEnabled = true;
            this.Req3YearComboBox.Location = new System.Drawing.Point(11, 54);
            this.Req3YearComboBox.Name = "Req3YearComboBox";
            this.Req3YearComboBox.Size = new System.Drawing.Size(211, 24);
            this.Req3YearComboBox.TabIndex = 3;
            // 
            // Riq3CountryComboBox
            // 
            this.Riq3CountryComboBox.FormattingEnabled = true;
            this.Riq3CountryComboBox.Location = new System.Drawing.Point(11, 132);
            this.Riq3CountryComboBox.Name = "Riq3CountryComboBox";
            this.Riq3CountryComboBox.Size = new System.Drawing.Size(211, 24);
            this.Riq3CountryComboBox.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(410, 0);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(656, 452);
            this.listBox3.TabIndex = 0;
            // 
            // Req6tabPage
            // 
            this.Req6tabPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Req6tabPage.Controls.Add(this.SearchReq6button);
            this.Req6tabPage.Controls.Add(this.listBox6);
            this.Req6tabPage.Location = new System.Drawing.Point(4, 25);
            this.Req6tabPage.Name = "Req6tabPage";
            this.Req6tabPage.Size = new System.Drawing.Size(1084, 474);
            this.Req6tabPage.TabIndex = 3;
            this.Req6tabPage.Text = "запрос 6";
            // 
            // SearchReq6button
            // 
            this.SearchReq6button.Location = new System.Drawing.Point(3, 75);
            this.SearchReq6button.Name = "SearchReq6button";
            this.SearchReq6button.Size = new System.Drawing.Size(289, 138);
            this.SearchReq6button.TabIndex = 1;
            this.SearchReq6button.Text = "поиск";
            this.SearchReq6button.UseVisualStyleBackColor = true;
            this.SearchReq6button.Click += new System.EventHandler(this.SearchReq6button_Click);
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 16;
            this.listBox6.Location = new System.Drawing.Point(355, 0);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(711, 452);
            this.listBox6.TabIndex = 0;
            // 
            // Req7tabPage
            // 
            this.Req7tabPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Req7tabPage.Controls.Add(this.SearchReq7button);
            this.Req7tabPage.Controls.Add(this.listBox7);
            this.Req7tabPage.Location = new System.Drawing.Point(4, 25);
            this.Req7tabPage.Name = "Req7tabPage";
            this.Req7tabPage.Size = new System.Drawing.Size(1084, 474);
            this.Req7tabPage.TabIndex = 4;
            this.Req7tabPage.Text = "запрос 7";
            // 
            // SearchReq7button
            // 
            this.SearchReq7button.Location = new System.Drawing.Point(3, 91);
            this.SearchReq7button.Name = "SearchReq7button";
            this.SearchReq7button.Size = new System.Drawing.Size(273, 152);
            this.SearchReq7button.TabIndex = 1;
            this.SearchReq7button.Text = "поиск";
            this.SearchReq7button.UseVisualStyleBackColor = true;
            this.SearchReq7button.Click += new System.EventHandler(this.SearchReq7button_Click);
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 16;
            this.listBox7.Location = new System.Drawing.Point(368, 3);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(698, 468);
            this.listBox7.TabIndex = 0;
            // 
            // Req8tabPage
            // 
            this.Req8tabPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Req8tabPage.Controls.Add(this.SearchReq8button);
            this.Req8tabPage.Controls.Add(this.Req8FilmsComboBox);
            this.Req8tabPage.Controls.Add(this.listBox8);
            this.Req8tabPage.Location = new System.Drawing.Point(4, 25);
            this.Req8tabPage.Name = "Req8tabPage";
            this.Req8tabPage.Size = new System.Drawing.Size(1084, 474);
            this.Req8tabPage.TabIndex = 5;
            this.Req8tabPage.Text = "запрос 8";
            // 
            // SearchReq8button
            // 
            this.SearchReq8button.Location = new System.Drawing.Point(51, 156);
            this.SearchReq8button.Name = "SearchReq8button";
            this.SearchReq8button.Size = new System.Drawing.Size(207, 54);
            this.SearchReq8button.TabIndex = 2;
            this.SearchReq8button.Text = "поиск";
            this.SearchReq8button.UseVisualStyleBackColor = true;
            this.SearchReq8button.Click += new System.EventHandler(this.SearchReq8button_Click);
            // 
            // Req8FilmsComboBox
            // 
            this.Req8FilmsComboBox.FormattingEnabled = true;
            this.Req8FilmsComboBox.Location = new System.Drawing.Point(28, 71);
            this.Req8FilmsComboBox.Name = "Req8FilmsComboBox";
            this.Req8FilmsComboBox.Size = new System.Drawing.Size(266, 24);
            this.Req8FilmsComboBox.TabIndex = 1;
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.ItemHeight = 16;
            this.listBox8.Location = new System.Drawing.Point(317, 3);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(749, 452);
            this.listBox8.TabIndex = 0;
            // 
            // Req9tabPage
            // 
            this.Req9tabPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Req9tabPage.Controls.Add(this.SearchReq9button);
            this.Req9tabPage.Controls.Add(this.label8);
            this.Req9tabPage.Controls.Add(this.Req9YearComboBox);
            this.Req9tabPage.Controls.Add(this.label7);
            this.Req9tabPage.Controls.Add(this.Req9ActorComboBox);
            this.Req9tabPage.Controls.Add(this.listBox9);
            this.Req9tabPage.Location = new System.Drawing.Point(4, 25);
            this.Req9tabPage.Name = "Req9tabPage";
            this.Req9tabPage.Size = new System.Drawing.Size(1084, 474);
            this.Req9tabPage.TabIndex = 6;
            this.Req9tabPage.Text = "запрос 9";
            // 
            // listBox9
            // 
            this.listBox9.FormattingEnabled = true;
            this.listBox9.ItemHeight = 16;
            this.listBox9.Location = new System.Drawing.Point(319, 3);
            this.listBox9.Name = "listBox9";
            this.listBox9.Size = new System.Drawing.Size(747, 452);
            this.listBox9.TabIndex = 0;
            // 
            // Req9ActorComboBox
            // 
            this.Req9ActorComboBox.FormattingEnabled = true;
            this.Req9ActorComboBox.Location = new System.Drawing.Point(3, 67);
            this.Req9ActorComboBox.Name = "Req9ActorComboBox";
            this.Req9ActorComboBox.Size = new System.Drawing.Size(285, 24);
            this.Req9ActorComboBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Выберите актера";
            // 
            // Req9YearComboBox
            // 
            this.Req9YearComboBox.FormattingEnabled = true;
            this.Req9YearComboBox.Location = new System.Drawing.Point(3, 150);
            this.Req9YearComboBox.Name = "Req9YearComboBox";
            this.Req9YearComboBox.Size = new System.Drawing.Size(245, 24);
            this.Req9YearComboBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Выберите год";
            // 
            // SearchReq9button
            // 
            this.SearchReq9button.Location = new System.Drawing.Point(7, 231);
            this.SearchReq9button.Name = "SearchReq9button";
            this.SearchReq9button.Size = new System.Drawing.Size(192, 63);
            this.SearchReq9button.TabIndex = 8;
            this.SearchReq9button.Text = "поиск";
            this.SearchReq9button.UseVisualStyleBackColor = true;
            this.SearchReq9button.Click += new System.EventHandler(this.SearchReq9button_Click);
            // 
            // Req10tabPage
            // 
            this.Req10tabPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Req10tabPage.Controls.Add(this.SearchReq10button);
            this.Req10tabPage.Controls.Add(this.label9);
            this.Req10tabPage.Controls.Add(this.Req10HumansComboBox);
            this.Req10tabPage.Controls.Add(this.listBox10);
            this.Req10tabPage.Location = new System.Drawing.Point(4, 25);
            this.Req10tabPage.Name = "Req10tabPage";
            this.Req10tabPage.Size = new System.Drawing.Size(1084, 474);
            this.Req10tabPage.TabIndex = 7;
            this.Req10tabPage.Text = "запрос 10";
            // 
            // listBox10
            // 
            this.listBox10.FormattingEnabled = true;
            this.listBox10.ItemHeight = 16;
            this.listBox10.Location = new System.Drawing.Point(387, 6);
            this.listBox10.Name = "listBox10";
            this.listBox10.Size = new System.Drawing.Size(679, 452);
            this.listBox10.TabIndex = 0;
            // 
            // Req10HumansComboBox
            // 
            this.Req10HumansComboBox.FormattingEnabled = true;
            this.Req10HumansComboBox.Location = new System.Drawing.Point(4, 53);
            this.Req10HumansComboBox.Name = "Req10HumansComboBox";
            this.Req10HumansComboBox.Size = new System.Drawing.Size(268, 24);
            this.Req10HumansComboBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Выберите президента";
            // 
            // SearchReq10button
            // 
            this.SearchReq10button.Location = new System.Drawing.Point(7, 155);
            this.SearchReq10button.Name = "SearchReq10button";
            this.SearchReq10button.Size = new System.Drawing.Size(191, 68);
            this.SearchReq10button.TabIndex = 7;
            this.SearchReq10button.Text = "поиск";
            this.SearchReq10button.UseVisualStyleBackColor = true;
            this.SearchReq10button.Click += new System.EventHandler(this.SearchReq10button_Click);
            // 
            // RequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1094, 506);
            this.Controls.Add(this.tabControl1);
            this.Name = "RequestsForm";
            this.Text = "RequestsForm";
            this.Load += new System.EventHandler(this.RequestsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Req1tabPage.ResumeLayout(false);
            this.Req2tabPage.ResumeLayout(false);
            this.Req2tabPage.PerformLayout();
            this.Req3tabPage.ResumeLayout(false);
            this.Req3tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Req3MaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Req3MinNumericUpDown)).EndInit();
            this.Req6tabPage.ResumeLayout(false);
            this.Req7tabPage.ResumeLayout(false);
            this.Req8tabPage.ResumeLayout(false);
            this.Req9tabPage.ResumeLayout(false);
            this.Req9tabPage.PerformLayout();
            this.Req10tabPage.ResumeLayout(false);
            this.Req10tabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Req1tabPage;
        private System.Windows.Forms.ComboBox Request1comboBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage Req2tabPage;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CountrycomboBox;
        private System.Windows.Forms.ComboBox FilmcomboBox;
        private System.Windows.Forms.Button SearchReq2button;
        private System.Windows.Forms.TabPage Req3tabPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Req3YearComboBox;
        private System.Windows.Forms.ComboBox Riq3CountryComboBox;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button SearchReq3button;
        private System.Windows.Forms.NumericUpDown Req3MaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown Req3MinNumericUpDown;
        private System.Windows.Forms.TabPage Req6tabPage;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Button SearchReq6button;
        private System.Windows.Forms.TabPage Req7tabPage;
        private System.Windows.Forms.Button SearchReq7button;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.TabPage Req8tabPage;
        private System.Windows.Forms.Button SearchReq8button;
        private System.Windows.Forms.ComboBox Req8FilmsComboBox;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.TabPage Req9tabPage;
        private System.Windows.Forms.Button SearchReq9button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Req9YearComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Req9ActorComboBox;
        private System.Windows.Forms.ListBox listBox9;
        private System.Windows.Forms.TabPage Req10tabPage;
        private System.Windows.Forms.Button SearchReq10button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Req10HumansComboBox;
        private System.Windows.Forms.ListBox listBox10;
    }
}