namespace CEIT310_Final2_OzanAksoy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_createStudent = new System.Windows.Forms.Button();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lst_students = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBox_student = new System.Windows.Forms.ComboBox();
            this.btn_createEngagement = new System.Windows.Forms.Button();
            this.btn_engagementRecords = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_createEngagement = new System.Windows.Forms.TabPage();
            this.lbl_engagementWarning = new System.Windows.Forms.Label();
            this.btn_createTabEng = new System.Windows.Forms.Button();
            this.txt_pageViews = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_videoViews = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_engagementName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage_viewRecords = new System.Windows.Forms.TabPage();
            this.lbl_engScore = new System.Windows.Forms.Label();
            this.lst_engRecords = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_createEngagement.SuspendLayout();
            this.tabPage_viewRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_createStudent);
            this.groupBox1.Controls.Add(this.lbl_warning);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_surname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Student";
            // 
            // btn_createStudent
            // 
            this.btn_createStudent.Location = new System.Drawing.Point(222, 165);
            this.btn_createStudent.Name = "btn_createStudent";
            this.btn_createStudent.Size = new System.Drawing.Size(94, 29);
            this.btn_createStudent.TabIndex = 7;
            this.btn_createStudent.Text = "Create";
            this.btn_createStudent.UseVisualStyleBackColor = true;
            this.btn_createStudent.Click += new System.EventHandler(this.btn_createStudent_Click_1);
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Location = new System.Drawing.Point(19, 212);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(145, 20);
            this.lbl_warning.TabIndex = 6;
            this.lbl_warning.Text = "Please enter a name.";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(122, 117);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(194, 27);
            this.txt_email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email: ";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(122, 68);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(194, 27);
            this.txt_surname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname: ";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(122, 23);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(194, 27);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Students";
            // 
            // lst_students
            // 
            this.lst_students.FormattingEnabled = true;
            this.lst_students.ItemHeight = 20;
            this.lst_students.Location = new System.Drawing.Point(12, 301);
            this.lst_students.Name = "lst_students";
            this.lst_students.Size = new System.Drawing.Size(359, 184);
            this.lst_students.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Select Student: ";
            // 
            // cBox_student
            // 
            this.cBox_student.FormattingEnabled = true;
            this.cBox_student.Location = new System.Drawing.Point(571, 33);
            this.cBox_student.Name = "cBox_student";
            this.cBox_student.Size = new System.Drawing.Size(151, 28);
            this.cBox_student.TabIndex = 11;
            // 
            // btn_createEngagement
            // 
            this.btn_createEngagement.Location = new System.Drawing.Point(422, 81);
            this.btn_createEngagement.Name = "btn_createEngagement";
            this.btn_createEngagement.Size = new System.Drawing.Size(180, 29);
            this.btn_createEngagement.TabIndex = 8;
            this.btn_createEngagement.Text = "Create Engagement";
            this.btn_createEngagement.UseVisualStyleBackColor = true;
            this.btn_createEngagement.Click += new System.EventHandler(this.btn_createEngagement_Click_1);
            // 
            // btn_engagementRecords
            // 
            this.btn_engagementRecords.Location = new System.Drawing.Point(608, 81);
            this.btn_engagementRecords.Name = "btn_engagementRecords";
            this.btn_engagementRecords.Size = new System.Drawing.Size(180, 29);
            this.btn_engagementRecords.TabIndex = 12;
            this.btn_engagementRecords.Text = "Engagement Records";
            this.btn_engagementRecords.UseVisualStyleBackColor = true;
            this.btn_engagementRecords.Click += new System.EventHandler(this.btn_engagementRecords_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_createEngagement);
            this.tabControl1.Controls.Add(this.tabPage_viewRecords);
            this.tabControl1.Location = new System.Drawing.Point(422, 133);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(366, 352);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage_createEngagement
            // 
            this.tabPage_createEngagement.Controls.Add(this.lbl_engagementWarning);
            this.tabPage_createEngagement.Controls.Add(this.btn_createTabEng);
            this.tabPage_createEngagement.Controls.Add(this.txt_pageViews);
            this.tabPage_createEngagement.Controls.Add(this.label7);
            this.tabPage_createEngagement.Controls.Add(this.txt_videoViews);
            this.tabPage_createEngagement.Controls.Add(this.label8);
            this.tabPage_createEngagement.Controls.Add(this.txt_engagementName);
            this.tabPage_createEngagement.Controls.Add(this.label9);
            this.tabPage_createEngagement.Location = new System.Drawing.Point(4, 29);
            this.tabPage_createEngagement.Name = "tabPage_createEngagement";
            this.tabPage_createEngagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_createEngagement.Size = new System.Drawing.Size(358, 319);
            this.tabPage_createEngagement.TabIndex = 0;
            this.tabPage_createEngagement.Text = "Create Engagement";
            this.tabPage_createEngagement.UseVisualStyleBackColor = true;
            // 
            // lbl_engagementWarning
            // 
            this.lbl_engagementWarning.AutoSize = true;
            this.lbl_engagementWarning.Location = new System.Drawing.Point(25, 243);
            this.lbl_engagementWarning.Name = "lbl_engagementWarning";
            this.lbl_engagementWarning.Size = new System.Drawing.Size(145, 20);
            this.lbl_engagementWarning.TabIndex = 15;
            this.lbl_engagementWarning.Text = "Please enter a name.";
            // 
            // btn_createTabEng
            // 
            this.btn_createTabEng.Location = new System.Drawing.Point(216, 186);
            this.btn_createTabEng.Name = "btn_createTabEng";
            this.btn_createTabEng.Size = new System.Drawing.Size(123, 29);
            this.btn_createTabEng.TabIndex = 14;
            this.btn_createTabEng.Text = "Create";
            this.btn_createTabEng.UseVisualStyleBackColor = true;
            this.btn_createTabEng.Click += new System.EventHandler(this.btn_createTabEng_Click_1);
            // 
            // txt_pageViews
            // 
            this.txt_pageViews.Location = new System.Drawing.Point(182, 126);
            this.txt_pageViews.Name = "txt_pageViews";
            this.txt_pageViews.Size = new System.Drawing.Size(157, 27);
            this.txt_pageViews.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "# of page views: ";
            // 
            // txt_videoViews
            // 
            this.txt_videoViews.Location = new System.Drawing.Point(182, 77);
            this.txt_videoViews.Name = "txt_videoViews";
            this.txt_videoViews.Size = new System.Drawing.Size(157, 27);
            this.txt_videoViews.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "# of video views: ";
            // 
            // txt_engagementName
            // 
            this.txt_engagementName.Location = new System.Drawing.Point(182, 32);
            this.txt_engagementName.Name = "txt_engagementName";
            this.txt_engagementName.Size = new System.Drawing.Size(157, 27);
            this.txt_engagementName.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Engagement Name:";
            // 
            // tabPage_viewRecords
            // 
            this.tabPage_viewRecords.Controls.Add(this.lbl_engScore);
            this.tabPage_viewRecords.Controls.Add(this.lst_engRecords);
            this.tabPage_viewRecords.Location = new System.Drawing.Point(4, 29);
            this.tabPage_viewRecords.Name = "tabPage_viewRecords";
            this.tabPage_viewRecords.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_viewRecords.Size = new System.Drawing.Size(358, 319);
            this.tabPage_viewRecords.TabIndex = 1;
            this.tabPage_viewRecords.Text = "View Engagement Records";
            this.tabPage_viewRecords.UseVisualStyleBackColor = true;
            // 
            // lbl_engScore
            // 
            this.lbl_engScore.AutoSize = true;
            this.lbl_engScore.Location = new System.Drawing.Point(17, 260);
            this.lbl_engScore.Name = "lbl_engScore";
            this.lbl_engScore.Size = new System.Drawing.Size(250, 20);
            this.lbl_engScore.TabIndex = 11;
            this.lbl_engScore.Text = "Engagement score is displayed here.";
            // 
            // lst_engRecords
            // 
            this.lst_engRecords.FormattingEnabled = true;
            this.lst_engRecords.ItemHeight = 20;
            this.lst_engRecords.Location = new System.Drawing.Point(17, 8);
            this.lst_engRecords.Name = "lst_engRecords";
            this.lst_engRecords.Size = new System.Drawing.Size(320, 224);
            this.lst_engRecords.TabIndex = 0;
            this.lst_engRecords.SelectedIndexChanged += new System.EventHandler(this.lst_engRecords_SelectedIndexChanged1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 514);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_engagementRecords);
            this.Controls.Add(this.btn_createEngagement);
            this.Controls.Add(this.cBox_student);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lst_students);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_createEngagement.ResumeLayout(false);
            this.tabPage_createEngagement.PerformLayout();
            this.tabPage_viewRecords.ResumeLayout(false);
            this.tabPage_viewRecords.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_createStudent;
        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lst_students;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBox_student;
        private System.Windows.Forms.Button btn_createEngagement;
        private System.Windows.Forms.Button btn_engagementRecords;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_createEngagement;
        private System.Windows.Forms.Button btn_createTabEng;
        private System.Windows.Forms.TextBox txt_pageViews;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_videoViews;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_engagementName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage_viewRecords;
        private System.Windows.Forms.Label lbl_engScore;
        private System.Windows.Forms.ListBox lst_engRecords;
        private System.Windows.Forms.Label lbl_engagementWarning;
    }
}
