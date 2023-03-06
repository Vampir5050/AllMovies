namespace Filmography.View.AdminView.AddView
{
    partial class FilmsStudiosForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddNameTextBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.StudiosComboBox = new System.Windows.Forms.ComboBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(51, 251);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(124, 64);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название новой студии";
            // 
            // AddNameTextBox
            // 
            this.AddNameTextBox.Location = new System.Drawing.Point(5, 185);
            this.AddNameTextBox.Name = "AddNameTextBox";
            this.AddNameTextBox.Size = new System.Drawing.Size(312, 22);
            this.AddNameTextBox.TabIndex = 2;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(782, 251);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(124, 64);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // StudiosComboBox
            // 
            this.StudiosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudiosComboBox.FormattingEnabled = true;
            this.StudiosComboBox.Location = new System.Drawing.Point(346, 61);
            this.StudiosComboBox.Name = "StudiosComboBox";
            this.StudiosComboBox.Size = new System.Drawing.Size(410, 24);
            this.StudiosComboBox.TabIndex = 4;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.Location = new System.Drawing.Point(457, 251);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(124, 64);
            this.ChangeButton.TabIndex = 5;
            this.ChangeButton.Text = "изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(342, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите студию для удаления или изменения";
            // 
            // ChangeNameTextBox
            // 
            this.ChangeNameTextBox.Location = new System.Drawing.Point(388, 185);
            this.ChangeNameTextBox.Name = "ChangeNameTextBox";
            this.ChangeNameTextBox.Size = new System.Drawing.Size(312, 22);
            this.ChangeNameTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(385, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите новое название";
            // 
            // FilmsStudiosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1012, 446);
            this.Controls.Add(this.ChangeNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.StudiosComboBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Name = "FilmsStudiosForm";
            this.Text = "FilmsStudiosForm";
            this.Load += new System.EventHandler(this.FilmsStudiosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddNameTextBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ComboBox StudiosComboBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ChangeNameTextBox;
        private System.Windows.Forms.Label label3;
    }
}