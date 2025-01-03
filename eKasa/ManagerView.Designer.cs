namespace eKasa
{
    partial class ManagerView
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            display_name_lbl = new Label();
            dodaj_artikal_btn = new Button();
            pazar_btn = new Button();
            signout_btn = new Button();
            x_btn = new Button();
            managerName = new Label();
            lblDateTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(318, 172);
            label1.Name = "label1";
            label1.Size = new Size(161, 37);
            label1.TabIndex = 0;
            label1.Text = "Dobrodosli";
            // 
            // display_name_lbl
            // 
            display_name_lbl.AutoSize = true;
            display_name_lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            display_name_lbl.Location = new Point(521, 174);
            display_name_lbl.Name = "display_name_lbl";
            display_name_lbl.Size = new Size(0, 25);
            display_name_lbl.TabIndex = 1;
            // 
            // dodaj_artikal_btn
            // 
            dodaj_artikal_btn.BackColor = Color.Transparent;
            dodaj_artikal_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            dodaj_artikal_btn.ForeColor = SystemColors.ActiveCaptionText;
            dodaj_artikal_btn.Location = new Point(362, 228);
            dodaj_artikal_btn.Name = "dodaj_artikal_btn";
            dodaj_artikal_btn.Size = new Size(282, 54);
            dodaj_artikal_btn.TabIndex = 2;
            dodaj_artikal_btn.Text = "Dodaj nov artikal u cenovnik";
            dodaj_artikal_btn.UseVisualStyleBackColor = false;
            dodaj_artikal_btn.Click += dodaj_artikal_btn_Click;
            // 
            // pazar_btn
            // 
            pazar_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            pazar_btn.ForeColor = SystemColors.ActiveCaptionText;
            pazar_btn.Location = new Point(362, 299);
            pazar_btn.Name = "pazar_btn";
            pazar_btn.Size = new Size(285, 57);
            pazar_btn.TabIndex = 3;
            pazar_btn.Text = "Pregled danasnjeg pazara";
            pazar_btn.UseVisualStyleBackColor = true;
            // 
            // signout_btn
            // 
            signout_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signout_btn.ForeColor = Color.DarkGoldenrod;
            signout_btn.Location = new Point(24, 583);
            signout_btn.Name = "signout_btn";
            signout_btn.Size = new Size(126, 37);
            signout_btn.TabIndex = 4;
            signout_btn.Text = "Odjavi se";
            signout_btn.UseVisualStyleBackColor = true;
            signout_btn.Click += XandSignout;
            // 
            // x_btn
            // 
            x_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            x_btn.ForeColor = Color.Red;
            x_btn.Location = new Point(967, 26);
            x_btn.Name = "x_btn";
            x_btn.Size = new Size(51, 42);
            x_btn.TabIndex = 5;
            x_btn.Text = "X";
            x_btn.UseVisualStyleBackColor = true;
            x_btn.Click += XandSignout;
            // 
            // managerName
            // 
            managerName.AutoSize = true;
            managerName.BackColor = Color.Transparent;
            managerName.Font = new Font("SimSun-ExtB", 26.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            managerName.ForeColor = Color.Yellow;
            managerName.Location = new Point(496, 174);
            managerName.Name = "managerName";
            managerName.Size = new Size(231, 35);
            managerName.TabIndex = 7;
            managerName.Text = "Manager_name";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.BackColor = Color.Transparent;
            lblDateTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = Color.Yellow;
            lblDateTime.Location = new Point(796, 583);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(68, 30);
            lblDateTime.TabIndex = 8;
            lblDateTime.Text = "label2";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ManagerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1;
            ClientSize = new Size(1040, 654);
            ControlBox = false;
            Controls.Add(lblDateTime);
            Controls.Add(managerName);
            Controls.Add(x_btn);
            Controls.Add(signout_btn);
            Controls.Add(pazar_btn);
            Controls.Add(dodaj_artikal_btn);
            Controls.Add(display_name_lbl);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManagerView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerView";
            Load += ManagerView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label display_name_lbl;
        private Button dodaj_artikal_btn;
        private Button pazar_btn;
        private Button signout_btn;
        private Button x_btn;
        private Label managerName;
        private Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}