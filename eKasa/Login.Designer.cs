namespace eKasa
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            button1_login = new Button();
            button2_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(377, 165);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(377, 263);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(313, 207);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(222, 32);
            txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(313, 301);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(222, 40);
            txt_password.TabIndex = 3;
            // 
            // button1_login
            // 
            button1_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1_login.Location = new Point(380, 391);
            button1_login.Name = "button1_login";
            button1_login.Size = new Size(98, 34);
            button1_login.TabIndex = 4;
            button1_login.Text = "Login";
            button1_login.UseVisualStyleBackColor = true;
            button1_login.Click += button1_login_Click;
            // 
            // button2_exit
            // 
            button2_exit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2_exit.Location = new Point(50, 602);
            button2_exit.Name = "button2_exit";
            button2_exit.Size = new Size(98, 34);
            button2_exit.TabIndex = 5;
            button2_exit.Text = "Exit";
            button2_exit.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1;
            ClientSize = new Size(882, 686);
            Controls.Add(button2_exit);
            Controls.Add(button1_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button button1_login;
        private Button button2_exit;
    }
}