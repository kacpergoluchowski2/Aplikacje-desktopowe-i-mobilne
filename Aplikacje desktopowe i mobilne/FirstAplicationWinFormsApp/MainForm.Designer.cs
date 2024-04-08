namespace FirstAplicationWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonFirst = new Button();
            checkBoxMath = new CheckBox();
            checkBoxGerman = new CheckBox();
            FavLessonLabel = new Label();
            pizzaLabel = new Label();
            radioButtonPizzaYes = new RadioButton();
            radioButtonPizzaNo = new RadioButton();
            nameBoxLabel = new Label();
            textBoxName = new TextBox();
            favGameLabel = new Label();
            comboBoxFavGame = new ComboBox();
            SuspendLayout();
            // 
            // buttonFirst
            // 
            buttonFirst.BackColor = Color.Khaki;
            buttonFirst.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFirst.Cursor = Cursors.Hand;
            buttonFirst.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point);
            buttonFirst.Location = new Point(12, 12);
            buttonFirst.Name = "buttonFirst";
            buttonFirst.Size = new Size(311, 76);
            buttonFirst.TabIndex = 0;
            buttonFirst.Text = "Pierwszy przycisk";
            buttonFirst.UseVisualStyleBackColor = false;
            buttonFirst.Click += buttonFirst_Click;
            // 
            // checkBoxMath
            // 
            checkBoxMath.AutoSize = true;
            checkBoxMath.ForeColor = SystemColors.Control;
            checkBoxMath.Location = new Point(12, 155);
            checkBoxMath.Name = "checkBoxMath";
            checkBoxMath.Size = new Size(92, 19);
            checkBoxMath.TabIndex = 2;
            checkBoxMath.Text = "Matematyka";
            checkBoxMath.UseVisualStyleBackColor = true;
            checkBoxMath.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBoxGerman
            // 
            checkBoxGerman.AutoSize = true;
            checkBoxGerman.ForeColor = SystemColors.Control;
            checkBoxGerman.Location = new Point(12, 180);
            checkBoxGerman.Name = "checkBoxGerman";
            checkBoxGerman.Size = new Size(107, 19);
            checkBoxGerman.TabIndex = 3;
            checkBoxGerman.Text = "Język niemiecki";
            checkBoxGerman.UseVisualStyleBackColor = true;
            // 
            // FavLessonLabel
            // 
            FavLessonLabel.AutoSize = true;
            FavLessonLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            FavLessonLabel.ForeColor = SystemColors.Control;
            FavLessonLabel.Location = new Point(12, 111);
            FavLessonLabel.Name = "FavLessonLabel";
            FavLessonLabel.Size = new Size(370, 30);
            FavLessonLabel.TabIndex = 4;
            FavLessonLabel.Text = "Zaznacz ulubione przedmioty w szkole";
            // 
            // pizzaLabel
            // 
            pizzaLabel.AutoSize = true;
            pizzaLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            pizzaLabel.ForeColor = SystemColors.Control;
            pizzaLabel.Location = new Point(12, 214);
            pizzaLabel.Name = "pizzaLabel";
            pizzaLabel.Size = new Size(285, 30);
            pizzaLabel.TabIndex = 5;
            pizzaLabel.Text = "Czy lubisz pizze z ananasem?";
            pizzaLabel.Click += label1_Click;
            // 
            // radioButtonPizzaYes
            // 
            radioButtonPizzaYes.AutoSize = true;
            radioButtonPizzaYes.ForeColor = SystemColors.Control;
            radioButtonPizzaYes.Location = new Point(12, 248);
            radioButtonPizzaYes.Name = "radioButtonPizzaYes";
            radioButtonPizzaYes.Size = new Size(42, 19);
            radioButtonPizzaYes.TabIndex = 6;
            radioButtonPizzaYes.TabStop = true;
            radioButtonPizzaYes.Text = "Tak";
            radioButtonPizzaYes.UseVisualStyleBackColor = true;
            radioButtonPizzaYes.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonPizzaNo
            // 
            radioButtonPizzaNo.AutoSize = true;
            radioButtonPizzaNo.ForeColor = SystemColors.Control;
            radioButtonPizzaNo.Location = new Point(12, 273);
            radioButtonPizzaNo.Name = "radioButtonPizzaNo";
            radioButtonPizzaNo.Size = new Size(43, 19);
            radioButtonPizzaNo.TabIndex = 7;
            radioButtonPizzaNo.TabStop = true;
            radioButtonPizzaNo.Text = "Nie";
            radioButtonPizzaNo.UseVisualStyleBackColor = true;
            // 
            // nameBoxLabel
            // 
            nameBoxLabel.AutoSize = true;
            nameBoxLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameBoxLabel.ForeColor = SystemColors.Control;
            nameBoxLabel.Location = new Point(12, 311);
            nameBoxLabel.Name = "nameBoxLabel";
            nameBoxLabel.Size = new Size(167, 30);
            nameBoxLabel.TabIndex = 8;
            nameBoxLabel.Text = "Podaj swoje imię";
            nameBoxLabel.Click += label1_Click_1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(19, 344);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(160, 23);
            textBoxName.TabIndex = 9;
            // 
            // favGameLabel
            // 
            favGameLabel.AutoSize = true;
            favGameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            favGameLabel.ForeColor = SystemColors.Control;
            favGameLabel.Location = new Point(551, 26);
            favGameLabel.Name = "favGameLabel";
            favGameLabel.Size = new Size(194, 30);
            favGameLabel.TabIndex = 10;
            favGameLabel.Text = "Twoja ulubiona gra:";
            favGameLabel.Click += label1_Click_2;
            // 
            // comboBoxFavGame
            // 
            comboBoxFavGame.FormattingEnabled = true;
            comboBoxFavGame.Items.AddRange(new object[] { "Szachy", "Warcaby", "Memory" });
            comboBoxFavGame.Location = new Point(551, 65);
            comboBoxFavGame.Name = "comboBoxFavGame";
            comboBoxFavGame.Size = new Size(121, 23);
            comboBoxFavGame.TabIndex = 12;
            comboBoxFavGame.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(878, 429);
            Controls.Add(comboBoxFavGame);
            Controls.Add(favGameLabel);
            Controls.Add(textBoxName);
            Controls.Add(nameBoxLabel);
            Controls.Add(radioButtonPizzaNo);
            Controls.Add(radioButtonPizzaYes);
            Controls.Add(pizzaLabel);
            Controls.Add(FavLessonLabel);
            Controls.Add(checkBoxGerman);
            Controls.Add(checkBoxMath);
            Controls.Add(buttonFirst);
            Name = "MainForm";
            Text = "Pierwsza aplikacja";
            TransparencyKey = Color.Goldenrod;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFirst;
        private CheckBox checkBoxMath;
        private CheckBox checkBoxGerman;
        private Label FavLessonLabel;
        private Label pizzaLabel;
        private RadioButton radioButtonPizzaYes;
        private RadioButton radioButtonPizzaNo;
        private Label nameBoxLabel;
        private TextBox textBoxName;
        private Label favGameLabel;
        private ComboBox comboBoxFavGame;
    }
}
