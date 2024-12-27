namespace MVCLab6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.movieComboBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.movieInfoTextBox = new System.Windows.Forms.TextBox();
            this.subtitlesTextBox = new System.Windows.Forms.TextBox();
            this.englishRadioButton = new System.Windows.Forms.RadioButton();
            this.russianRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // movieComboBox
            // 
            this.movieComboBox.FormattingEnabled = true;
            this.movieComboBox.Location = new System.Drawing.Point(13, 13);
            this.movieComboBox.Name = "movieComboBox";
            this.movieComboBox.Size = new System.Drawing.Size(121, 24);
            this.movieComboBox.TabIndex = 0;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(13, 41);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(121, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Показать информацию";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // movieInfoTextBox
            // 
            this.movieInfoTextBox.Location = new System.Drawing.Point(13, 70);
            this.movieInfoTextBox.Multiline = true;
            this.movieInfoTextBox.Name = "movieInfoTextBox";
            this.movieInfoTextBox.Size = new System.Drawing.Size(255, 60);
            this.movieInfoTextBox.TabIndex = 2;
            // 
            // subtitlesTextBox
            // 
            this.subtitlesTextBox.Location = new System.Drawing.Point(13, 136);
            this.subtitlesTextBox.Multiline = true;
            this.subtitlesTextBox.Name = "subtitlesTextBox";
            this.subtitlesTextBox.Size = new System.Drawing.Size(255, 60);
            this.subtitlesTextBox.TabIndex = 3;
            // 
            // englishRadioButton
            // 
            this.englishRadioButton.AutoSize = true;
            this.englishRadioButton.Location = new System.Drawing.Point(141, 13);
            this.englishRadioButton.Name = "englishRadioButton";
            this.englishRadioButton.Size = new System.Drawing.Size(72, 20);
            this.englishRadioButton.TabIndex = 4;
            this.englishRadioButton.TabStop = true;
            this.englishRadioButton.Text = "English";
            this.englishRadioButton.UseVisualStyleBackColor = true;
            // 
            // russianRadioButton
            // 
            this.russianRadioButton.AutoSize = true;
            this.russianRadioButton.Location = new System.Drawing.Point(141, 36);
            this.russianRadioButton.Name = "russianRadioButton";
            this.russianRadioButton.Size = new System.Drawing.Size(77, 20);
            this.russianRadioButton.TabIndex = 5;
            this.russianRadioButton.TabStop = true;
            this.russianRadioButton.Text = "Russian";
            this.russianRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.russianRadioButton);
            this.Controls.Add(this.englishRadioButton);
            this.Controls.Add(this.subtitlesTextBox);
            this.Controls.Add(this.movieInfoTextBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.movieComboBox);
            this.Name = "Form1";
            this.Text = "Movie Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox movieComboBox;
        private System.Windows.Forms.RadioButton englishRadioButton;
        private System.Windows.Forms.RadioButton russianRadioButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox movieInfoTextBox;
        private System.Windows.Forms.TextBox subtitlesTextBox;
    }
}

