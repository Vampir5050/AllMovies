namespace Filmography.View.AdminView.AddView
{
    partial class TranslationsForm
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
            this.FilmsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTranslationsButton = new System.Windows.Forms.Button();
            this.TransleytTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilmsComboBox
            // 
            this.FilmsComboBox.FormattingEnabled = true;
            this.FilmsComboBox.Location = new System.Drawing.Point(304, 32);
            this.FilmsComboBox.Name = "FilmsComboBox";
            this.FilmsComboBox.Size = new System.Drawing.Size(308, 24);
            this.FilmsComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите фильм";
            // 
            // AddTranslationsButton
            // 
            this.AddTranslationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTranslationsButton.Location = new System.Drawing.Point(12, 182);
            this.AddTranslationsButton.Name = "AddTranslationsButton";
            this.AddTranslationsButton.Size = new System.Drawing.Size(308, 85);
            this.AddTranslationsButton.TabIndex = 2;
            this.AddTranslationsButton.Text = "Добавить";
            this.AddTranslationsButton.UseVisualStyleBackColor = true;
            this.AddTranslationsButton.Click += new System.EventHandler(this.AddTranslationsButton_Click);
            // 
            // TransleytTextBox
            // 
            this.TransleytTextBox.Location = new System.Drawing.Point(12, 140);
            this.TransleytTextBox.Name = "TransleytTextBox";
            this.TransleytTextBox.Size = new System.Drawing.Size(308, 22);
            this.TransleytTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите перевод через запятую";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(429, 182);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(308, 85);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // TranslationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(779, 443);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransleytTextBox);
            this.Controls.Add(this.AddTranslationsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilmsComboBox);
            this.Name = "TranslationsForm";
            this.Text = "AddTranslationsForm";
            this.Load += new System.EventHandler(this.AddTranslationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FilmsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddTranslationsButton;
        private System.Windows.Forms.TextBox TransleytTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveButton;
    }
}