namespace FrmBasicThread
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
            thread_label = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // thread_label
            // 
            thread_label.AutoSize = true;
            thread_label.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thread_label.Location = new Point(82, 130);
            thread_label.Name = "thread_label";
            thread_label.Size = new Size(652, 65);
            thread_label.TabIndex = 0;
            thread_label.Text = "BEFORE STARTING THREAD";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(167, 223);
            button1.Name = "button1";
            button1.Size = new Size(481, 98);
            button1.TabIndex = 1;
            button1.Text = "RUN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(thread_label);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label thread_label;
        private Button button1;
    }
}
