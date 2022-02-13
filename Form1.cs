using CEIT310_Final2_OzanAksoy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEIT310_Final2_OzanAksoy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentDbContext dbContext = new StudentDbContext();
        List<Engagement> engagements;

        public void ViewEngagements()
        {
            int selectedStudentId = (int)cBox_student.SelectedValue;
            engagements = dbContext.Engagements.Where(e => e.StudentId == selectedStudentId).ToList();
            lst_engRecords.DataSource = engagements;
            lst_engRecords.ValueMember = "EngagementId";
            lst_engRecords.DisplayMember = "EngagementName";
        }

        
        private void btn_createStudent_Click_1(object sender, EventArgs e)
        {
            if (!txt_email.Text.Contains("@"))
            {
                lbl_warning.Text = "An error has occured. Enter a valid E-Mail Address.";
                lbl_warning.ForeColor = Color.Red;

            }
            else if (txt_email.Text == "")
            {
                lbl_warning.Text = "Enter a valid E-Mail Address.";
                lbl_warning.ForeColor = Color.Red;
            }
            else if (txt_name.Text == "")
            {
                lbl_warning.Text = "Enter a valid Name.";
                lbl_warning.ForeColor = Color.Red;
            }
            else if (txt_surname.Text == "")
            {
                lbl_warning.Text = "Enter a valid Surname.";
                lbl_warning.ForeColor = Color.Red;
            }
            else
            {
                Student mystudent = new Student();
                mystudent.Name = txt_name.Text;
                mystudent.Surname = txt_surname.Text;
                mystudent.Email = txt_email.Text;

                dbContext.Students.Add(mystudent);
                dbContext.SaveChanges();

                lbl_warning.Text = "Student is successfully created.";
                lbl_warning.ForeColor = Color.Green;
                txt_name.Text = "";
                txt_surname.Text = "";
                txt_email.Text = "";

                lbl_warning.Text = "Student record is added.";
                lbl_warning.ForeColor = Color.Green;

                cBox_student.DataSource = dbContext.Students.ToList();
                cBox_student.ValueMember = "StudentId";
                cBox_student.DisplayMember = "Name";

                lst_students.DataSource = dbContext.Students.ToList();
                lst_students.ValueMember = "StudentId";
                lst_students.DisplayMember = "Name";
            }
        }

        private void btn_createEngagement_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage_createEngagement;

        }

        private void btn_engagementRecords_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage_viewRecords;
            ViewEngagements();
        }

        private void btn_createTabEng_Click_1(object sender, EventArgs e)
        {
            try
            {
                Engagement myEngagement = new Engagement();
                myEngagement.EngagementName = txt_engagementName.Text;
                myEngagement.VideoView = int.Parse(txt_videoViews.Text);
                myEngagement.PageView = int.Parse(txt_pageViews.Text);
                myEngagement.StudentId = (int)cBox_student.SelectedValue;

                dbContext.Engagements.Add(myEngagement);
                dbContext.SaveChanges();

                tabControl1.SelectedTab = tabPage_viewRecords;
                ViewEngagements();

                int selected = (int)lst_engRecords.SelectedItem;
                Engagement engagements = dbContext.Engagements.Single(s => s.EngagementId == selected);
                lbl_engScore.Text = "Engagement Score : " + engagements.EngagementScore.ToString();
            }
            catch (Exception ex)
            {
                lbl_engagementWarning.Text = "An error has occured. More info: \n" + ex.Message;
                lbl_engagementWarning.ForeColor = Color.Red;
            }
        }

        private void lst_engRecords_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Engagement eng = (Engagement)lst_engRecords.SelectedItem;
            lbl_engScore.Text = "Engagement Score : " + eng.EngagementScore.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayLists();
        }

        private void DisplayLists()
        {
            lst_students.DataSource = dbContext.Students.ToList();
            lst_students.ValueMember = "StudentId";
            lst_students.DisplayMember = "Name";

            cBox_student.DataSource = dbContext.Students.ToList();
            cBox_student.ValueMember = "StudentId";
            cBox_student.DisplayMember = "Name";
        }

        
    }
}