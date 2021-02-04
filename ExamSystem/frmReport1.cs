using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class frmReport1 : Form
    {
        public frmReport1()
        {
            InitializeComponent();
        }
        ReportViewer report;
        private void frmReport1_Load(object sender, EventArgs e)
        {
            /*ExamV2Context db = new ExamV2Context();
            var result = db.Students.Select(o => o);
            foreach (var item in result)
            {
                comboBox1.Items.Add(item.Name);
            }*/

            var src = new ReportDataSource();
            report = new ReportViewer();
            report.LocalReport.ReportPath = "rptStudentInfo.rdlc";
            //report.LocalReport.DataSources.Add();
            this.Controls.Add(report);
            report.Refresh();
        }
        frmInsertQuestions frmMain = new frmInsertQuestions();
        private void button1_Click(object sender, EventArgs e)
        {
            frmMain.Show();
        }
    }
}
