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
            this.SearchReq3button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Req3YearComboBox = new System.Windows.Forms.ComboBox();
            this.Riq3CountryComboBox = new System.Windows.Forms.ComboBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.Req3MinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Req3MaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Req4tabPage = new System.Windows.Forms.TabPage();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.Req1tabPage.SuspendLayout();
            this.Req2tabPage.SuspendLayout();
            this.Req3tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Req3MinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Req3MaxNumericUpDown)).BeginInit();
            this.Req4tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Req1tabPage);
            this.tabControl1.Controls.Add(this.Req2tabPage);
            this.tabControl1.Controls.Add(this.Req3tabPage);
            this.tabControl1.Controls.Add(this.Req4tabPage);
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
            this.listBox1.Location = new System.Drawing.Point(386, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(696, 404);
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
            this.listBox2.Location = new System.Drawing.Point(490, -1);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(594, 468);
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
            this.listBox3.Location = new System.Drawing.Point(536, 9);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(541, 452);
            this.listBox3.TabIndex = 0;
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
            // Req4tabPage
            // 
            this.Req4tabPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Req4tabPage.Controls.Add(this.listBox4);
            this.Req4tabPage.Location = new System.Drawing.Point(4, 25);
            this.Req4tabPage.Name = "Req4tabPage";
            this.Req4tabPage.Size = new System.Drawing.Size(1084, 474);
            this.Req4tabPage.TabIndex = 3;
            this.Req4tabPage.Text = "запрос 4";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(509, 3);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(557, 452);
            this.listBox4.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.Req3MinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Req3MaxNumericUpDown)).EndInit();
            this.Req4tabPage.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage Req4tabPage;
        private System.Windows.Forms.ListBox listBox4;
    }
}