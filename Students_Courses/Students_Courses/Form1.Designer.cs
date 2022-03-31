
namespace Students_Courses
{
    partial class Form1
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
            this.lblRegister = new System.Windows.Forms.Label();
            this.gblCourseInfo = new System.Windows.Forms.GroupBox();
            this.ddSemesters = new System.Windows.Forms.ComboBox();
            this.ddRequirements = new System.Windows.Forms.ComboBox();
            this.txtInstructorName = new System.Windows.Forms.TextBox();
            this.txtCourseNumber = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblRequirement = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblCourseNumber = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.gblUserInfo = new System.Windows.Forms.GroupBox();
            this.ddGrades = new System.Windows.Forms.ComboBox();
            this.txtCourseFeedback = new System.Windows.Forms.TextBox();
            this.lblUserFeedback = new System.Windows.Forms.Label();
            this.lblCourseGrade = new System.Windows.Forms.Label();
            this.ddCourses = new System.Windows.Forms.ComboBox();
            this.lblCourses = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.lblCourseCredits = new System.Windows.Forms.Label();
            this.txtCourseCredits = new System.Windows.Forms.TextBox();
            this.gblCourseInfo.SuspendLayout();
            this.gblUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(27, 103);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(241, 13);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Enter the courses you have taken at Lewis so far.";
            // 
            // gblCourseInfo
            // 
            this.gblCourseInfo.Controls.Add(this.ddSemesters);
            this.gblCourseInfo.Controls.Add(this.ddRequirements);
            this.gblCourseInfo.Controls.Add(this.txtInstructorName);
            this.gblCourseInfo.Controls.Add(this.txtCourseNumber);
            this.gblCourseInfo.Controls.Add(this.txtCourseName);
            this.gblCourseInfo.Controls.Add(this.lblRequirement);
            this.gblCourseInfo.Controls.Add(this.lblInstructor);
            this.gblCourseInfo.Controls.Add(this.lblCourseNumber);
            this.gblCourseInfo.Controls.Add(this.lblCourseName);
            this.gblCourseInfo.Controls.Add(this.lblSemester);
            this.gblCourseInfo.Location = new System.Drawing.Point(30, 132);
            this.gblCourseInfo.Name = "gblCourseInfo";
            this.gblCourseInfo.Size = new System.Drawing.Size(359, 239);
            this.gblCourseInfo.TabIndex = 1;
            this.gblCourseInfo.TabStop = false;
            this.gblCourseInfo.Text = "Course Information";
            // 
            // ddSemesters
            // 
            this.ddSemesters.FormattingEnabled = true;
            this.ddSemesters.Items.AddRange(new object[] {
            "Spring 2022",
            "Fall 2021",
            "Summer 2021",
            "Spring 2021",
            "Fall 2020",
            "Summer 2020",
            "Spring 2020",
            "Fall 2019",
            "Summer 2019",
            "Spring 2019"});
            this.ddSemesters.Location = new System.Drawing.Point(150, 44);
            this.ddSemesters.Name = "ddSemesters";
            this.ddSemesters.Size = new System.Drawing.Size(166, 21);
            this.ddSemesters.TabIndex = 11;
            this.ddSemesters.SelectedIndexChanged += new System.EventHandler(this.ddSemesters_SelectedIndexChanged);
            // 
            // ddRequirements
            // 
            this.ddRequirements.FormattingEnabled = true;
            this.ddRequirements.Items.AddRange(new object[] {
            "General Education",
            "Major Requirement",
            "Minor Requirement",
            "Concentration"});
            this.ddRequirements.Location = new System.Drawing.Point(150, 204);
            this.ddRequirements.Name = "ddRequirements";
            this.ddRequirements.Size = new System.Drawing.Size(166, 21);
            this.ddRequirements.TabIndex = 10;
            this.ddRequirements.SelectedIndexChanged += new System.EventHandler(this.ddRequirements_SelectedIndexChanged);
            // 
            // txtInstructorName
            // 
            this.txtInstructorName.Location = new System.Drawing.Point(150, 162);
            this.txtInstructorName.Name = "txtInstructorName";
            this.txtInstructorName.Size = new System.Drawing.Size(166, 20);
            this.txtInstructorName.TabIndex = 8;
            // 
            // txtCourseNumber
            // 
            this.txtCourseNumber.Location = new System.Drawing.Point(150, 123);
            this.txtCourseNumber.Name = "txtCourseNumber";
            this.txtCourseNumber.Size = new System.Drawing.Size(166, 20);
            this.txtCourseNumber.TabIndex = 7;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(150, 82);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(166, 20);
            this.txtCourseName.TabIndex = 6;
            // 
            // lblRequirement
            // 
            this.lblRequirement.AutoSize = true;
            this.lblRequirement.Location = new System.Drawing.Point(17, 207);
            this.lblRequirement.Name = "lblRequirement";
            this.lblRequirement.Size = new System.Drawing.Size(70, 13);
            this.lblRequirement.TabIndex = 4;
            this.lblRequirement.Text = "Requirement:";
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Location = new System.Drawing.Point(17, 165);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(85, 13);
            this.lblInstructor.TabIndex = 3;
            this.lblInstructor.Text = "Instructor Name:";
            // 
            // lblCourseNumber
            // 
            this.lblCourseNumber.AutoSize = true;
            this.lblCourseNumber.Location = new System.Drawing.Point(17, 126);
            this.lblCourseNumber.Name = "lblCourseNumber";
            this.lblCourseNumber.Size = new System.Drawing.Size(83, 13);
            this.lblCourseNumber.TabIndex = 2;
            this.lblCourseNumber.Text = "Course Number:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(17, 85);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(74, 13);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(17, 47);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(57, 13);
            this.lblSemester.TabIndex = 0;
            this.lblSemester.Text = "Semester: ";
            // 
            // gblUserInfo
            // 
            this.gblUserInfo.Controls.Add(this.txtCourseCredits);
            this.gblUserInfo.Controls.Add(this.lblCourseCredits);
            this.gblUserInfo.Controls.Add(this.ddGrades);
            this.gblUserInfo.Controls.Add(this.txtCourseFeedback);
            this.gblUserInfo.Controls.Add(this.lblUserFeedback);
            this.gblUserInfo.Controls.Add(this.lblCourseGrade);
            this.gblUserInfo.Location = new System.Drawing.Point(461, 132);
            this.gblUserInfo.Name = "gblUserInfo";
            this.gblUserInfo.Size = new System.Drawing.Size(304, 239);
            this.gblUserInfo.TabIndex = 2;
            this.gblUserInfo.TabStop = false;
            this.gblUserInfo.Text = "User\'s Information";
            // 
            // ddGrades
            // 
            this.ddGrades.FormattingEnabled = true;
            this.ddGrades.Items.AddRange(new object[] {
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D"});
            this.ddGrades.Location = new System.Drawing.Point(125, 59);
            this.ddGrades.Name = "ddGrades";
            this.ddGrades.Size = new System.Drawing.Size(121, 21);
            this.ddGrades.TabIndex = 4;
            this.ddGrades.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtCourseFeedback
            // 
            this.txtCourseFeedback.Location = new System.Drawing.Point(26, 126);
            this.txtCourseFeedback.Multiline = true;
            this.txtCourseFeedback.Name = "txtCourseFeedback";
            this.txtCourseFeedback.Size = new System.Drawing.Size(259, 94);
            this.txtCourseFeedback.TabIndex = 2;
            // 
            // lblUserFeedback
            // 
            this.lblUserFeedback.AutoSize = true;
            this.lblUserFeedback.Location = new System.Drawing.Point(23, 100);
            this.lblUserFeedback.Name = "lblUserFeedback";
            this.lblUserFeedback.Size = new System.Drawing.Size(209, 13);
            this.lblUserFeedback.TabIndex = 1;
            this.lblUserFeedback.Text = "What did you liked the most in this course?";
            // 
            // lblCourseGrade
            // 
            this.lblCourseGrade.AutoSize = true;
            this.lblCourseGrade.Location = new System.Drawing.Point(23, 62);
            this.lblCourseGrade.Name = "lblCourseGrade";
            this.lblCourseGrade.Size = new System.Drawing.Size(75, 13);
            this.lblCourseGrade.TabIndex = 0;
            this.lblCourseGrade.Text = "Course Grade:";
            // 
            // ddCourses
            // 
            this.ddCourses.FormattingEnabled = true;
            this.ddCourses.Location = new System.Drawing.Point(109, 66);
            this.ddCourses.Name = "ddCourses";
            this.ddCourses.Size = new System.Drawing.Size(146, 21);
            this.ddCourses.TabIndex = 3;
            this.ddCourses.SelectedIndexChanged += new System.EventHandler(this.ddCourses_SelectedIndexChanged_1);
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(27, 69);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(51, 13);
            this.lblCourses.TabIndex = 4;
            this.lblCourses.Text = "Courses: ";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(303, 405);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(217, 33);
            this.btnAddCourse.TabIndex = 5;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // lblCourseCredits
            // 
            this.lblCourseCredits.AutoSize = true;
            this.lblCourseCredits.Location = new System.Drawing.Point(24, 27);
            this.lblCourseCredits.Name = "lblCourseCredits";
            this.lblCourseCredits.Size = new System.Drawing.Size(75, 13);
            this.lblCourseCredits.TabIndex = 5;
            this.lblCourseCredits.Text = "Course Credits";
            // 
            // txtCourseCredits
            // 
            this.txtCourseCredits.Location = new System.Drawing.Point(125, 24);
            this.txtCourseCredits.Name = "txtCourseCredits";
            this.txtCourseCredits.Size = new System.Drawing.Size(121, 20);
            this.txtCourseCredits.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.ddCourses);
            this.Controls.Add(this.gblUserInfo);
            this.Controls.Add(this.gblCourseInfo);
            this.Controls.Add(this.lblRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gblCourseInfo.ResumeLayout(false);
            this.gblCourseInfo.PerformLayout();
            this.gblUserInfo.ResumeLayout(false);
            this.gblUserInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.GroupBox gblCourseInfo;
        private System.Windows.Forms.Label lblRequirement;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblCourseNumber;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.ComboBox ddSemesters;
        private System.Windows.Forms.ComboBox ddRequirements;
        private System.Windows.Forms.TextBox txtInstructorName;
        private System.Windows.Forms.TextBox txtCourseNumber;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.GroupBox gblUserInfo;
        private System.Windows.Forms.ComboBox ddGrades;
        private System.Windows.Forms.TextBox txtCourseFeedback;
        private System.Windows.Forms.Label lblUserFeedback;
        private System.Windows.Forms.Label lblCourseGrade;
        private System.Windows.Forms.ComboBox ddCourses;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.TextBox txtCourseCredits;
        private System.Windows.Forms.Label lblCourseCredits;
    }
}

