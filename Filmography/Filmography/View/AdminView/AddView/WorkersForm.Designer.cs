namespace Filmography.View.AdminView.AddView
{
    partial class WorkersForm
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
            this.AddWorkersButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PostComboBox = new System.Windows.Forms.ComboBox();
            this.HumansComboBox = new System.Windows.Forms.ComboBox();
            this.FilmsComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddPrezidentButton = new System.Windows.Forms.Button();
            this.FilmsStudiosComboBox = new System.Windows.Forms.ComboBox();
            this.RemotePrezidentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddWorkersButton
            // 
            this.AddWorkersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWorkersButton.Location = new System.Drawing.Point(3, 290);
            this.AddWorkersButton.Name = "AddWorkersButton";
            this.AddWorkersButton.Size = new System.Drawing.Size(191, 56);
            this.AddWorkersButton.TabIndex = 20;
            this.AddWorkersButton.Text = "добавить сотрудников";
            this.AddWorkersButton.UseVisualStyleBackColor = true;
            this.AddWorkersButton.Click += new System.EventHandler(this.AddWorkersButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(401, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Выберите человека";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Выберите должность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Выберите фильм";
            // 
            // PostComboBox
            // 
            this.PostComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostComboBox.FormattingEnabled = true;
            this.PostComboBox.Items.AddRange(new object[] {
            "Актер",
            "Продюсер",
            "Режиссер"});
            this.PostComboBox.Location = new System.Drawing.Point(3, 239);
            this.PostComboBox.Name = "PostComboBox";
            this.PostComboBox.Size = new System.Drawing.Size(289, 24);
            this.PostComboBox.TabIndex = 16;
            // 
            // HumansComboBox
            // 
            this.HumansComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HumansComboBox.FormattingEnabled = true;
            this.HumansComboBox.Location = new System.Drawing.Point(235, 26);
            this.HumansComboBox.Name = "HumansComboBox";
            this.HumansComboBox.Size = new System.Drawing.Size(606, 24);
            this.HumansComboBox.TabIndex = 15;
            // 
            // FilmsComboBox
            // 
            this.FilmsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilmsComboBox.FormattingEnabled = true;
            this.FilmsComboBox.Location = new System.Drawing.Point(3, 179);
            this.FilmsComboBox.Name = "FilmsComboBox";
            this.FilmsComboBox.Size = new System.Drawing.Size(293, 24);
            this.FilmsComboBox.TabIndex = 14;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(226, 290);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(191, 56);
            this.RemoveButton.TabIndex = 21;
            this.RemoveButton.Text = "удалить сотрудников";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddPrezidentButton
            // 
            this.AddPrezidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPrezidentButton.Location = new System.Drawing.Point(604, 283);
            this.AddPrezidentButton.Name = "AddPrezidentButton";
            this.AddPrezidentButton.Size = new System.Drawing.Size(181, 71);
            this.AddPrezidentButton.TabIndex = 22;
            this.AddPrezidentButton.Text = "добавить президента киностудии";
            this.AddPrezidentButton.UseVisualStyleBackColor = true;
            this.AddPrezidentButton.Click += new System.EventHandler(this.AddPrezidentButton_Click);
            // 
            // FilmsStudiosComboBox
            // 
            this.FilmsStudiosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilmsStudiosComboBox.FormattingEnabled = true;
            this.FilmsStudiosComboBox.Location = new System.Drawing.Point(656, 216);
            this.FilmsStudiosComboBox.Name = "FilmsStudiosComboBox";
            this.FilmsStudiosComboBox.Size = new System.Drawing.Size(288, 24);
            this.FilmsStudiosComboBox.TabIndex = 23;
            // 
            // RemotePrezidentButton
            // 
            this.RemotePrezidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemotePrezidentButton.Location = new System.Drawing.Point(812, 283);
            this.RemotePrezidentButton.Name = "RemotePrezidentButton";
            this.RemotePrezidentButton.Size = new System.Drawing.Size(181, 71);
            this.RemotePrezidentButton.TabIndex = 24;
            this.RemotePrezidentButton.Text = "удалить президента киностудии";
            this.RemotePrezidentButton.UseVisualStyleBackColor = true;
            this.RemotePrezidentButton.Click += new System.EventHandler(this.RemotePrezidentButton_Click);
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(993, 484);
            this.Controls.Add(this.RemotePrezidentButton);
            this.Controls.Add(this.FilmsStudiosComboBox);
            this.Controls.Add(this.AddPrezidentButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddWorkersButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PostComboBox);
            this.Controls.Add(this.HumansComboBox);
            this.Controls.Add(this.FilmsComboBox);
            this.Name = "WorkersForm";
            this.Text = "WorkersForm";
            this.Load += new System.EventHandler(this.WorkersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddWorkersButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PostComboBox;
        private System.Windows.Forms.ComboBox HumansComboBox;
        private System.Windows.Forms.ComboBox FilmsComboBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddPrezidentButton;
        private System.Windows.Forms.ComboBox FilmsStudiosComboBox;
        private System.Windows.Forms.Button RemotePrezidentButton;
    }
}