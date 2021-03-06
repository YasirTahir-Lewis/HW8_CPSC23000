using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is view class
namespace Students_Courses
{
    public partial class Form1 : Form
    {
        private MenuStrip mainMenu;
        private CourseController courseController;

        public Form1(CourseController courseController)
        {
            InitializeComponent();
            this.courseController = courseController;
            LoadCoursesDropdown();
            mainMenu = new MenuStrip();
            this.MainMenuStrip = mainMenu;
            Controls.Add(mainMenu);

            ToolStripMenuItem mnuFile = new ToolStripMenuItem("File");
            mainMenu.Items.Add(mnuFile);
            ToolStripMenuItem mnuHelp = new ToolStripMenuItem("Help");
            mainMenu.Items.Add(mnuHelp);

            // adding menu items to the File menu
            ToolStripMenuItem miOpen = new ToolStripMenuItem("Open");
            ToolStripMenuItem miSave = new ToolStripMenuItem("Save");
            ToolStripMenuItem miExit = new ToolStripMenuItem("Exit");
            mnuFile.DropDownItems.Add(miOpen);
            mnuFile.DropDownItems.Add(miSave);
            mnuFile.DropDownItems.Add(miExit);

            // add one item to the Help menu
            ToolStripMenuItem miAbout = new ToolStripMenuItem("About");
            mnuHelp.DropDownItems.Add(miAbout);

            // set up the event handling. Do this by adding to the click property for each menu item
            miOpen.Click += MiOpen_Click;
            miSave.Click += MiSave_Click;
            miExit.Click += MiExit_Click;
            miAbout.Click += MiAbout_Click;

        }

        private void MiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is created to take courses student has taken, save them in the dropdown. It can also write, save and read courses to and from the text file and it also calculate grade points for each course.");
        }

        private void MiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MiSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.InitialDirectory = "c:\\users";
            dlgSave.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.RestoreDirectory = true;
            String fname;
            
            if(dlgSave.ShowDialog() == DialogResult.OK)
            {
                fname = dlgSave.FileName;
                courseController.WriteCoursesToTextFile(fname);
            }
            MessageBox.Show("Text file with all the courses was written.");
        }

        private void MiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.InitialDirectory = "c:\\users";
            dlgOpen.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.RestoreDirectory = true;
            string fname;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fname = dlgOpen.FileName;
                string text = courseController.ReadCoursesFromTextFile(fname);
                MessageBox.Show(text);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void ddSemesters_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void ddRequirements_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            // Extracting data the user entered from the appropriate fields, saving them in variables and calling controller class to create course object and add to the list
            string courseSemester = ddSemesters.Text;
            string courseName = txtCourseName.Text;
            string courseNumber = txtCourseNumber.Text;
            string instructorName = txtInstructorName.Text;
            string courseRequirement = ddRequirements.Text;
            int courseCredits = Convert.ToInt32(txtCourseCredits.Text);
            string courseGrade = ddGrades.Text;
            string courseFeedback = txtCourseFeedback.Text;

            courseController.AddCourse(courseSemester, courseName, courseNumber, instructorName, courseRequirement, courseCredits, courseGrade, courseFeedback);
            LoadCoursesDropdown();
            ChooseCourseFromDropdown(courseName);
            MessageBox.Show("All the courses you added: \n" + "\n" + courseController.GetCoursesAsString());
            ddSemesters.Text = "";
            txtCourseName.Text = "";
            txtCourseNumber.Text = "";
            txtInstructorName.Text = "";
            ddRequirements.Text = "";
            txtCourseCredits.Text = "";
            ddGrades.Text = "";
            txtCourseFeedback.Text = "";
        }

        private void LoadCoursesDropdown()
        {
            List<String> courseNames = courseController.GetCourseNames();                
            ddCourses.DataSource = courseNames;
            ddCourses.Refresh();
        }

        private void ChooseCourseFromDropdown(string courseName)
        {
            int index = ddCourses.Items.IndexOf(courseName);
            if (index >= 0)
            {
                ddCourses.SelectedIndex = index;
            }

        }

        private void ddCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void ddCourses_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string courseName;
            Dictionary<string, string> data;

            if (ddCourses.SelectedIndex != -1)
            {  // populate the controls with the data corresponding to the selected user
                // figure out what the newly selected name is
                courseName = ddCourses.GetItemText(ddCourses.SelectedItem);

                data = courseController.GetCourseDetailsForCourseByName(courseName);
                if (data != null)
                {
                    ddSemesters.Text = data["semester"];
                    txtCourseName.Text = data["courseName"];
                    txtCourseNumber.Text = data["courseNumber"];
                    txtInstructorName.Text = data["instructorName"];
                    ddRequirements.Text = data["courseRequirement"];
                    txtCourseCredits.Text = data["courseCredits"];
                    ddGrades.Text = data["courseGrade"];
                    txtCourseFeedback.Text = data["courseFeedback"];
                    Refresh(); // refreshes the form so that all the controls update to reflect new settings.
                }

            }
        }


    }
}
