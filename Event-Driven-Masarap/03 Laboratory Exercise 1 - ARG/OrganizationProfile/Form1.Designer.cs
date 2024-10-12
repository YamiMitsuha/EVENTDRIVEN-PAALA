namespace OrganizationProfile
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            datePickerBirthday = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cbPrograms = new ComboBox();
            txtFirstName = new TextBox();
            label9 = new Label();
            txtMiddleInitial = new TextBox();
            cbGender = new ComboBox();
            label10 = new Label();
            txtContactNo = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 37);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 69);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 102);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(75, 134);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(129, 69);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(148, 23);
            txtStudentNo.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(129, 104);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(148, 23);
            txtLastName.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(129, 136);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(107, 23);
            txtAge.TabIndex = 6;
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(129, 172);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(266, 23);
            datePickerBirthday.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 174);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 8;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(324, 69);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 9;
            label6.Text = "Program";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(309, 104);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 10;
            label7.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(334, 138);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 11;
            label8.Text = "Gender";
            // 
            // cbPrograms
            // 
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(414, 71);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(252, 23);
            cbPrograms.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(414, 106);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(148, 23);
            txtFirstName.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(580, 108);
            label9.Name = "label9";
            label9.Size = new Size(31, 21);
            label9.TabIndex = 14;
            label9.Text = "M.I";
            label9.Click += label9_Click;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(617, 106);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(49, 23);
            txtMiddleInitial.TabIndex = 15;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(414, 140);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(252, 23);
            cbGender.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(414, 172);
            label10.Name = "label10";
            label10.Size = new Size(91, 21);
            label10.TabIndex = 17;
            label10.Text = "Contact No.";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(511, 172);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(155, 23);
            txtContactNo.TabIndex = 18;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.IndianRed;
            btnRegister.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(179, 222);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(335, 38);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(709, 272);
            Controls.Add(btnRegister);
            Controls.Add(txtContactNo);
            Controls.Add(label10);
            Controls.Add(cbGender);
            Controls.Add(txtMiddleInitial);
            Controls.Add(label9);
            Controls.Add(txtFirstName);
            Controls.Add(cbPrograms);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(datePickerBirthday);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private DateTimePicker datePickerBirthday;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cbPrograms;
        private TextBox txtFirstName;
        private Label label9;
        private TextBox txtMiddleInitial;
        private ComboBox cbGender;
        private Label label10;
        private TextBox txtContactNo;
        private Button btnRegister;
    }
}
