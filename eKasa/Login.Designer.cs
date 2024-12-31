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
            button1 = new Button();
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
            txt_username.Location = new Point(313, 215);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(222, 23);
            txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(313, 301);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(222, 23);
            txt_password.TabIndex = 3;
            txt_password.KeyDown += txt_password_KeyDown;
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
            //button1_login.KeyDown += button1_login_KeyDown;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(823, 8);
            button1.Name = "button1";
            button1.Size = new Size(45, 34);
            button1.TabIndex = 6;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._1;
            ClientSize = new Size(882, 686);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(button1_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            ShowIcon = false;
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
        private Button button1;
    }
}