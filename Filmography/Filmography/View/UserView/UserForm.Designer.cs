namespace Filmography.View.UserView
{
    partial class UserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SortGroupBox = new System.Windows.Forms.GroupBox();
            this.MetodComboBox = new System.Windows.Forms.ComboBox();
            this.CountryRadioButton = new System.Windows.Forms.RadioButton();
            this.PriceRadioButton = new System.Windows.Forms.RadioButton();
            this.AbcRadioButton = new System.Windows.Forms.RadioButton();
            this.YearRadioButton = new System.Windows.Forms.RadioButton();
            this.SortCheckBox = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RequestsButton = new System.Windows.Forms.Button();
            this.SortGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Коллекция фильмов";
            // 
            // SortGroupBox
            // 
            this.SortGroupBox.Controls.Add(this.MetodComboBox);
            this.SortGroupBox.Controls.Add(this.CountryRadioButton);
            this.SortGroupBox.Controls.Add(this.PriceRadioButton);
            this.SortGroupBox.Controls.Add(this.AbcRadioButton);
            this.SortGroupBox.Controls.Add(this.YearRadioButton);
            this.SortGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortGroupBox.Location = new System.Drawing.Point(817, 107);
            this.SortGroupBox.Name = "SortGroupBox";
            this.SortGroupBox.Size = new System.Drawing.Size(402, 355);
            this.SortGroupBox.TabIndex = 2;
            this.SortGroupBox.TabStop = false;
            // 
            // MetodComboBox
            // 
            this.MetodComboBox.FormattingEnabled = true;
            this.MetodComboBox.Items.AddRange(new object[] {
            "по убыванию",
            "по возрастанию"});
            this.MetodComboBox.Location = new System.Drawing.Point(6, 26);
            this.MetodComboBox.Name = "MetodComboBox";
            this.MetodComboBox.Size = new System.Drawing.Size(194, 28);
            this.MetodComboBox.TabIndex = 9;
            this.MetodComboBox.SelectionChangeCommitted += new System.EventHandler(this.MetodComboBox_SelectionChangeCommitted);
            // 
            // CountryRadioButton
            // 
            this.CountryRadioButton.AutoSize = true;
            this.CountryRadioButton.Location = new System.Drawing.Point(6, 242);
            this.CountryRadioButton.Name = "CountryRadioButton";
            this.CountryRadioButton.Size = new System.Drawing.Size(136, 24);
            this.CountryRadioButton.TabIndex = 8;
            this.CountryRadioButton.TabStop = true;
            this.CountryRadioButton.Text = "по странам";
            this.CountryRadioButton.UseVisualStyleBackColor = true;
            // 
            // PriceRadioButton
            // 
            this.PriceRadioButton.AutoSize = true;
            this.PriceRadioButton.Location = new System.Drawing.Point(6, 195);
            this.PriceRadioButton.Name = "PriceRadioButton";
            this.PriceRadioButton.Size = new System.Drawing.Size(157, 24);
            this.PriceRadioButton.TabIndex = 7;
            this.PriceRadioButton.TabStop = true;
            this.PriceRadioButton.Text = "по стоимости";
            this.PriceRadioButton.UseVisualStyleBackColor = true;
            // 
            // AbcRadioButton
            // 
            this.AbcRadioButton.AutoSize = true;
            this.AbcRadioButton.Location = new System.Drawing.Point(6, 149);
            this.AbcRadioButton.Name = "AbcRadioButton";
            this.AbcRadioButton.Size = new System.Drawing.Size(249, 24);
            this.AbcRadioButton.TabIndex = 6;
            this.AbcRadioButton.TabStop = true;
            this.AbcRadioButton.Text = "в алфавитном порядке";
            this.AbcRadioButton.UseVisualStyleBackColor = true;
            // 
            // YearRadioButton
            // 
            this.YearRadioButton.AutoSize = true;
            this.YearRadioButton.Location = new System.Drawing.Point(6, 101);
            this.YearRadioButton.Name = "YearRadioButton";
            this.YearRadioButton.Size = new System.Drawing.Size(181, 24);
            this.YearRadioButton.TabIndex = 5;
            this.YearRadioButton.TabStop = true;
            this.YearRadioButton.Text = "по году выпуска";
            this.YearRadioButton.UseVisualStyleBackColor = true;
            // 
            // SortCheckBox
            // 
            this.SortCheckBox.AutoSize = true;
            this.SortCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortCheckBox.Location = new System.Drawing.Point(817, 60);
            this.SortCheckBox.Name = "SortCheckBox";
            this.SortCheckBox.Size = new System.Drawing.Size(187, 20);
            this.SortCheckBox.TabIndex = 3;
            this.SortCheckBox.Text = "вкл/выкл сортировку";
            this.SortCheckBox.UseVisualStyleBackColor = true;
            this.SortCheckBox.CheckedChanged += new System.EventHandler(this.SortCheckBox_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(799, 468);
            this.listBox1.TabIndex = 0;
            // 
            // RequestsButton
            // 
            this.RequestsButton.Location = new System.Drawing.Point(1043, 9);
            this.RequestsButton.Name = "RequestsButton";
            this.RequestsButton.Size = new System.Drawing.Size(184, 23);
            this.RequestsButton.TabIndex = 4;
            this.RequestsButton.Text = "форма запросов";
            this.RequestsButton.UseVisualStyleBackColor = true;
            this.RequestsButton.Click += new System.EventHandler(this.RequestsButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1260, 514);
            this.Controls.Add(this.RequestsButton);
            this.Controls.Add(this.SortCheckBox);
            this.Controls.Add(this.SortGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.SortGroupBox.ResumeLayout(false);
            this.SortGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SortGroupBox;
        private System.Windows.Forms.RadioButton CountryRadioButton;
        private System.Windows.Forms.RadioButton PriceRadioButton;
        private System.Windows.Forms.RadioButton AbcRadioButton;
        private System.Windows.Forms.RadioButton YearRadioButton;
        private System.Windows.Forms.CheckBox SortCheckBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox MetodComboBox;
        private System.Windows.Forms.Button RequestsButton;
    }
}