namespace egzamin
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            header = new Label();
            bindingSource1 = new BindingSource(components);
            e_mail_label = new Label();
            e_mail_input = new TextBox();
            password_label = new Label();
            password_input = new TextBox();
            password_label_again = new Label();
            password_input_again = new TextBox();
            confirm_button = new Button();
            result_label = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.AutoSize = true;
            header.BackColor = Color.Teal;
            header.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            header.ForeColor = SystemColors.ControlLight;
            header.Location = new Point(1, 0);
            header.Name = "header";
            header.Padding = new Padding(0, 0, 220, 0);
            header.Size = new Size(414, 37);
            header.TabIndex = 0;
            header.Text = "Rejestruj konto";
            header.Click += label1_Click;
            // 
            // e_mail_label
            // 
            e_mail_label.AutoSize = true;
            e_mail_label.Location = new Point(8, 43);
            e_mail_label.Name = "e_mail_label";
            e_mail_label.Size = new Size(74, 15);
            e_mail_label.TabIndex = 1;
            e_mail_label.Text = "Podaj e-mail";
            e_mail_label.Click += label2_Click;
            // 
            // e_mail_input
            // 
            e_mail_input.Location = new Point(12, 61);
            e_mail_input.Name = "e_mail_input";
            e_mail_input.Size = new Size(85, 23);
            e_mail_input.TabIndex = 2;
            e_mail_input.TextChanged += textBox1_TextChanged;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(8, 104);
            password_label.Name = "password_label";
            password_label.Size = new Size(68, 15);
            password_label.TabIndex = 3;
            password_label.Text = "Podaj hasło";
            password_label.Click += label3_Click;
            // 
            // password_input
            // 
            password_input.Location = new Point(12, 122);
            password_input.Name = "password_input";
            password_input.PasswordChar = '*';
            password_input.Size = new Size(85, 23);
            password_input.TabIndex = 4;
            password_input.Text = "email";
            // 
            // password_label_again
            // 
            password_label_again.AutoSize = true;
            password_label_again.Location = new Point(8, 161);
            password_label_again.Name = "password_label_again";
            password_label_again.Size = new Size(81, 15);
            password_label_again.TabIndex = 5;
            password_label_again.Text = "Powtórz hasło";
            password_label_again.Click += label4_Click;
            // 
            // password_input_again
            // 
            password_input_again.Location = new Point(12, 179);
            password_input_again.Name = "password_input_again";
            password_input_again.PasswordChar = '*';
            password_input_again.Size = new Size(85, 23);
            password_input_again.TabIndex = 6;
            password_input_again.Text = "email";
            password_input_again.TextChanged += password_input_again_TextChanged;
            // 
            // confirm_button
            // 
            confirm_button.Location = new Point(127, 227);
            confirm_button.Name = "confirm_button";
            confirm_button.Size = new Size(88, 30);
            confirm_button.TabIndex = 7;
            confirm_button.Text = "ZATWIERDŹ";
            confirm_button.UseVisualStyleBackColor = true;
            confirm_button.Click += confirm_button_Click;
            // 
            // result_label
            // 
            result_label.AutoSize = true;
            result_label.Location = new Point(148, 271);
            result_label.Name = "result_label";
            result_label.Size = new Size(0, 15);
            result_label.TabIndex = 8;
            result_label.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 450);
            Controls.Add(result_label);
            Controls.Add(confirm_button);
            Controls.Add(password_input_again);
            Controls.Add(password_label_again);
            Controls.Add(password_input);
            Controls.Add(password_label);
            Controls.Add(e_mail_input);
            Controls.Add(e_mail_label);
            Controls.Add(header);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label header;
        private BindingSource bindingSource1;
        private Label e_mail_label;
        private TextBox e_mail_input;
        private Label password_label;
        private TextBox password_input;
        private Label password_label_again;
        private TextBox password_input_again;
        private Button confirm_button;
        private Label result_label;
    }
}