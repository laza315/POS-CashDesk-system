namespace eKasa
{
    partial class Starting
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
            Iamwaiter_btn = new Button();
            Iammanager_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(278, 200);
            label1.Name = "label1";
            label1.Size = new Size(460, 25);
            label1.TabIndex = 0;
            label1.Text = "Molimo Vas odaberite koja je Vasa uloga u sistemu";
            // 
            // Iamwaiter_btn
            // 
            Iamwaiter_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Iamwaiter_btn.Location = new Point(350, 259);
            Iamwaiter_btn.Name = "Iamwaiter_btn";
            Iamwaiter_btn.Size = new Size(255, 53);
            Iamwaiter_btn.TabIndex = 1;
            Iamwaiter_btn.Text = "Konobar";
            Iamwaiter_btn.UseVisualStyleBackColor = true;
            Iamwaiter_btn.Click += Iamwaiter_btn_Click;
            // 
            // Iammanager_btn
            // 
            Iammanager_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            Iammanager_btn.Location = new Point(351, 340);
            Iammanager_btn.Name = "Iammanager_btn";
            Iammanager_btn.Size = new Size(256, 54);
            Iammanager_btn.TabIndex = 2;
            Iammanager_btn.Text = "Menadzer";
            Iammanager_btn.UseVisualStyleBackColor = true;
            Iammanager_btn.Click += Iammanager_btn_Click;
            // 
            // Starting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1;
            ClientSize = new Size(990, 713);
            Controls.Add(Iammanager_btn);
            Controls.Add(Iamwaiter_btn);
            Controls.Add(label1);
            Name = "Starting";
            Text = "Starting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Iamwaiter_btn;
        private Button Iammanager_btn;
    }
}