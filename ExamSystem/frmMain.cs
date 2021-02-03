using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using ExamSystem.Entities;
using Microsoft.Reporting.WinForms;

namespace ExamSystem
{
    public partial class frmMain : Form
    {
        Examv2Context db;
        public frmMain()
        {
            InitializeComponent();
            FormClosing += (sender, e) => db.Dispose();
        }
        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            db = new Examv2Context();
            var procs = new Examv2ContextProcedures(db);

            BindingSource CourseBS = new BindingSource();
            var result = await procs.SelectCourseAsync();
            //var r = db.Courses.Select(c=>c.name).ToList();
            //CourseBS.DataSource = procs.SelectCourseAsync();
            CourseBS.DataSource = result.ToList();
            foreach (var item in result)
            {
                Trace.WriteLine(item.name);
            }
            //courses.DataBindings.Add("Text", CourseBS, "name");
            courses.DataSource = CourseBS;
            courses.DisplayMember = "name";
        }
    }
}
