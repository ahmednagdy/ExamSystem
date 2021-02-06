using ExamSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ExamSystem
{
    public partial class frmInstructorHome : Form
    {
        public Instructor LoginInstructor;
        public frmInstructorHome(Instructor instructor)
        {
            InitializeComponent();
            LoginInstructor = instructor;
        }

        private void btnAllStudInDept_Click(object sender, EventArgs e)
        {
            int deptid = (int)comBoxDeptName.SelectedValue;
            frmReport frmReport = new frmReport();
            frmReport.SetReportParameters(0, deptid);
            frmReport.ShowDialog();
          
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void frmInstructorHome_Load(object sender, EventArgs e)
        {
            BindingSource Courses = new BindingSource();
            var cname = db.Course.ToList();
            var insCours = db.InstructorCourse.ToList();
            var Coursess= cname.Join(insCours,
              c=> c.CourseId,
              ic => ic.CourseId,
              (c, ic) => new { c.Name ,c.CourseId, c.CourseGrade,c.Duration,c.Nmcq,c.Ntf}
            ).ToList();
            Courses.DataSource = Coursess;
            combBoxCourseName.DataSource = Courses;
            combBoxCourseName.DisplayMember = "name";
            combBoxCourseName.ValueMember = "CourseId";

            crname.DataSource = Coursess;
            crname.DisplayMember = "name";
            crname.ValueMember = "CourseId";

            //===========================//
            BindingSource deptName = new BindingSource();
            var deptname = db.Department.ToList();

            deptName.DataSource = deptname;
            comBoxDeptName.DataSource = deptName;
            comBoxDeptName.DisplayMember = "Name";
            comBoxDeptName.ValueMember = "DeptId";


            //==================///=
            BindingSource InsName = new BindingSource();
            var insname = db.Instructor.ToList();

            InsName.DataSource = insname;
            comBoxInstructorName.DataSource = InsName;
            comBoxInstructorName.DisplayMember = "Name";
            comBoxInstructorName.ValueMember = "InsId";
            //==================///=
            BindingSource StudentName = new BindingSource();
            var student = db.Student.ToList();
            StudentName.DataSource = student;
            cbmStudentName.DataSource = StudentName;
            cbmStudentName.DisplayMember = "name";
            cbmStudentName.ValueMember = "StudentId";
            //==================///=
            BindingSource ExamID = new BindingSource();
            var examid = db.Exam.ToList();
            ExamID.DataSource = examid;
            combxExamID.DataSource = ExamID;
            combxExamID.DisplayMember = "ExamId";
            //combxExamID.ValueMember = "ExamId";

         

            /////////////////////////////////
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var procs = new Examv2ContextProcedures(db);
            var flag = new OutputParameter<bool?>();
            int cid =(int) crname.SelectedValue;
            int mcq = int.Parse(txtNumOFMcq.Text);
            int tf = int.Parse(txtNumOfTF.Text);
            if ((mcq + tf) == 10)
            {
                var result = await procs.SetNQuestionsAsync(LoginInstructor.InsId, cid, int.Parse(txtNumOFMcq.Text), int.Parse(txtNumOfTF.Text), flag);

            }
            else
            {
                MessageBox.Show("total num of Questions must be 10");
            }//int numOfMcq = txtNumOFMcq.Text;
            //int numOfTF = txtNumOfTF.Text;
            //then go to db to generate

        }
        Examv2Context db = new Examv2Context();
        private void btnCourseTopic_Click(object sender, EventArgs e)
        {

            int crsID = (int)combBoxCourseName.SelectedValue;
            //call report here and pass course id to its ctor
        }

        private void btnInsertQuestion_Click(object sender, EventArgs e)
        {
            frmInsertQuestions frmInsert = new frmInsertQuestions();
            frmInsert.ShowDialog();
            

        }

        private void btnAllGrade_Click(object sender, EventArgs e)
        {
            int studId = (int)cbmStudentName.SelectedValue;
            frmReport frmReport = new frmReport();
            frmReport.SetReportParameters(1, studId);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void crname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumOfTF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumOFMcq_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
