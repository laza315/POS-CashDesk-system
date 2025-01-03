namespace eKasa
{
    partial class AddArticle
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            categoryBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(213, 71);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 0;
            label1.Text = "Cenovnik Pica";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(173, 491);
            button1.Name = "button1";
            button1.Size = new Size(203, 92);
            button1.TabIndex = 1;
            button1.Text = "Sacuvaj izmene i dodaj novu stavku";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button2.ForeColor = Color.Green;
            button2.Location = new Point(299, 419);
            button2.Name = "button2";
            button2.Size = new Size(182, 66);
            button2.TabIndex = 2;
            button2.Text = "Sacuvaj Izmene!";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(516, 12);
            button3.Name = "button3";
            button3.Size = new Size(50, 48);
            button3.TabIndex = 3;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(223, 173);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 52);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(347, 248);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(347, 303);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 23);
            textBox3.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = categoryBindingSource;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(263, 354);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 23);
            comboBox1.TabIndex = 7;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Models.Category);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(57, 173);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 8;
            label2.Text = "Naziv stavke";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(57, 239);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 9;
            label3.Text = "Nabavna cena";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(57, 296);
            label4.Name = "label4";
            label4.Size = new Size(246, 25);
            label4.TabIndex = 10;
            label4.Text = "Prodajna cena (+PDV)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(57, 347);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 11;
            label5.Text = "Kategorija";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(67, 419);
            button4.Name = "button4";
            button4.Size = new Size(176, 66);
            button4.TabIndex = 12;
            button4.Text = "Odustani";
            button4.UseVisualStyleBackColor = true;
            // 
            // AddArticle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1;
            ClientSize = new Size(578, 595);
            ControlBox = false;
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddArticle";
            Text = "AddArticle";
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private BindingSource categoryBindingSource;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button4;
    }
}