namespace _28022023
{
    partial class Form_Login
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.Login_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Top_panel = new System.Windows.Forms.Panel();
            this.Bot_panel = new System.Windows.Forms.Panel();
            this.label_name = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.Login_textbox = new System.Windows.Forms.TextBox();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.Top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Login_button.Location = new System.Drawing.Point(203, 504);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(124, 59);
            this.Login_button.TabIndex = 0;
            this.Login_button.Text = "Войти.";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Exit_button.Location = new System.Drawing.Point(203, 590);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(124, 59);
            this.Exit_button.TabIndex = 1;
            this.Exit_button.Text = "Выйти из программы.";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.Top_panel.Controls.Add(this.icon);
            this.Top_panel.Controls.Add(this.label_name);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(521, 100);
            this.Top_panel.TabIndex = 2;
            // 
            // Bot_panel
            // 
            this.Bot_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.Bot_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bot_panel.Location = new System.Drawing.Point(0, 741);
            this.Bot_panel.Name = "Bot_panel";
            this.Bot_panel.Size = new System.Drawing.Size(521, 100);
            this.Bot_panel.TabIndex = 3;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(155, 35);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(151, 25);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "ООО «Рыбалка»";
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(0, -1);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(101, 101);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 4;
            this.icon.TabStop = false;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(155, 146);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(149, 25);
            this.label_login.TabIndex = 4;
            this.label_login.Text = "Введиите логин";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(155, 269);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(146, 25);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "Введите пароль";
            // 
            // Login_textbox
            // 
            this.Login_textbox.Location = new System.Drawing.Point(160, 190);
            this.Login_textbox.Name = "Login_textbox";
            this.Login_textbox.Size = new System.Drawing.Size(219, 31);
            this.Login_textbox.TabIndex = 6;
            // 
            // Password_textbox
            // 
            this.Password_textbox.Location = new System.Drawing.Point(160, 332);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Size = new System.Drawing.Size(219, 31);
            this.Password_textbox.TabIndex = 7;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 841);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.Login_textbox);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.Bot_panel);
            this.Controls.Add(this.Top_panel);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Login_button);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Login";
            this.Text = "Вход в программу.";
            this.Top_panel.ResumeLayout(false);
            this.Top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Panel Bot_panel;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox Login_textbox;
        private System.Windows.Forms.TextBox Password_textbox;
    }
}

