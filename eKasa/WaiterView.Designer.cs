namespace eKasa
{
    partial class WaiterView
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
            X_and_loguserout = new Button();
            SuspendLayout();
            // 
            // X_and_loguserout
            // 
            X_and_loguserout.BackColor = Color.Transparent;
            X_and_loguserout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X_and_loguserout.ForeColor = Color.Red;
            X_and_loguserout.Location = new Point(743, 12);
            X_and_loguserout.Name = "X_and_loguserout";
            X_and_loguserout.Size = new Size(45, 34);
            X_and_loguserout.TabIndex = 7;
            X_and_loguserout.Text = "x";
            X_and_loguserout.UseVisualStyleBackColor = false;
            X_and_loguserout.Click += X_and_loguserout_Click;
            // 
            // WaiterView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(X_and_loguserout);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WaiterView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WaiterView";
            ResumeLayout(false);
        }

        #endregion

        private Button X_and_loguserout;
    }
}