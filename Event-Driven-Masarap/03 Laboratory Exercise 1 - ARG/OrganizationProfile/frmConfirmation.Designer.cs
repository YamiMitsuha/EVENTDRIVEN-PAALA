namespace OrganizationProfile
{
    partial class frmConfirmation
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblStudentNo = new Label();
            label8 = new Label();
            lblName = new Label();
            lblProgram = new Label();
            lblAge = new Label();
            lblBirthday = new Label();
            lblGender = new Label();
            lblContactNo = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 0;
            label1.Text = "Student No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 53);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 83);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 2;
            label3.Text = "Program :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 116);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 3;
            label4.Text = "Age :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 151);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 4;
            label5.Text = "Birthday :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 183);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 5;
            label6.Text = "Gender :";
            label6.Click += label6_Click;
            // 
            // lblStudentNo
            // 
            lblStudentNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentNo.Location = new Point(135, 22);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(208, 21);
            lblStudentNo.TabIndex = 6;
            lblStudentNo.Text = "-";
            lblStudentNo.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 213);
            label8.Name = "label8";
            label8.Size = new Size(94, 21);
            label8.TabIndex = 7;
            label8.Text = "Contact No.:";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(135, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(208, 21);
            lblName.TabIndex = 8;
            lblName.Text = "-";
            // 
            // lblProgram
            // 
            lblProgram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgram.Location = new Point(135, 83);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(208, 21);
            lblProgram.TabIndex = 9;
            lblProgram.Text = "-";
            // 
            // lblAge
            // 
            lblAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(135, 116);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(208, 21);
            lblAge.TabIndex = 10;
            lblAge.Text = "-";
            // 
            // lblBirthday
            // 
            lblBirthday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthday.Location = new Point(135, 151);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(208, 21);
            lblBirthday.TabIndex = 11;
            lblBirthday.Text = "-";
            // 
            // lblGender
            // 
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(135, 183);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(208, 21);
            lblGender.TabIndex = 12;
            lblGender.Text = "-";
            // 
            // lblContactNo
            // 
            lblContactNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactNo.Location = new Point(135, 213);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(208, 21);
            lblContactNo.TabIndex = 13;
            lblContactNo.Text = "-";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.IndianRed;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(71, 327);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(219, 38);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "SUBMIT";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // frmConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(367, 377);
            Controls.Add(btnRegister);
            Controls.Add(lblContactNo);
            Controls.Add(lblGender);
            Controls.Add(lblBirthday);
            Controls.Add(lblAge);
            Controls.Add(lblProgram);
            Controls.Add(lblName);
            Controls.Add(label8);
            Controls.Add(lblStudentNo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmConfirmation";
            Text = "frmConfirmation";
            Load += frmConfirmation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblStudentNo;
        private Label label8;
        private Label lblName;
        private Label lblProgram;
        private Label lblAge;
        private Label lblBirthday;
        private Label lblGender;
        private Label lblContactNo;
        private Button btnRegister;
    }
}