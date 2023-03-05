namespace Filmography.View.AdminView.AddView
{
    partial class DisplayForm
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
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.AddDisplayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilmsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(432, 206);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(308, 85);
            this.RemoveButton.TabIndex = 12;
            this.RemoveButton.Text = "удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите страны показа, через запятую";
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Location = new System.Drawing.Point(15, 164);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(373, 22);
            this.DisplayTextBox.TabIndex = 10;
            // 
            // AddDisplayButton
            // 
            this.AddDisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDisplayButton.Location = new System.Drawing.Point(15, 206);
            this.AddDisplayButton.Name = "AddDisplayButton";
            this.AddDisplayButton.Size = new System.Drawing.Size(308, 85);
            this.AddDisplayButton.TabIndex = 9;
            this.AddDisplayButton.Text = "Добавить";
            this.AddDisplayButton.UseVisualStyleBackColor = true;
            this.AddDisplayButton.Click += new System.EventHandler(this.AddDisplayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(376, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите фильм";
            // 
            // FilmsComboBox
            // 
            this.FilmsComboBox.FormattingEnabled = true;
            this.FilmsComboBox.Location = new System.Drawing.Point(307, 56);
            this.FilmsComboBox.Name = "FilmsComboBox";
            this.FilmsComboBox.Size = new System.Drawing.Size(308, 24);
            this.FilmsComboBox.TabIndex = 7;
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.AddDisplayButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilmsComboBox);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Button AddDisplayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FilmsComboBox;
    }
}