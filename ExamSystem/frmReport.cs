using ExamSystem.Entities;
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
    public partial class frmReport : Form
    {
        Examv2Context db;
        Examv2ContextProcedures procs;
        public frmReport()
        {
            InitializeComponent();
            db = new Examv2Context();
            procs = new Examv2ContextProcedures(db);
            FormClosing += (sender, e) => db.Dispose();
        }
        ReportViewer report;
        int reportIndex = -1;
        int firstParameter = -1;
        int secondParameter = -1;
        public void SetReportParameters(int _reportIndex, int _firstParameter, int _secondParameter = -1)
        {
            reportIndex = _reportIndex;
            firstParameter = _firstParameter;
            secondParameter = _secondParameter;
        }
        private async void frmReport_Load(object sender, EventArgs e)
        {
            ReportDataSource src = new ReportDataSource();
            switch (reportIndex)
            {
                case 0:
                    report.LocalReport.ReportPath = "rptStudentInfo.rdlc";
                    var data = await procs.reportStudentInfoAsync(firstParameter);
                    src = new ReportDataSource("stdInfo", data.ToList());
                    break;
                /*case 1:
                    report.LocalReport.ReportPath = "rptStudentInfo.rdlc";
                    var data1 = await procs.reportStudentInfoAsync(firstParameter);
                    src = new ReportDataSource("stdInfo", data1.ToList());
                    break;
                case 2:
                    report.LocalReport.ReportPath = "rptStudentInfo.rdlc";
                    var data2 = await procs.reportStudentInfoAsync(firstParameter);
                    src = new ReportDataSource("stdInfo", data2.ToList());
                    break;
                case 3:
                    report.LocalReport.ReportPath = "rptStudentInfo.rdlc";
                    var data3 = await procs.reportStudentInfoAsync(firstParameter);
                    src = new ReportDataSource("stdInfo", data3.ToList());
                    break;
                case 4:
                    report.LocalReport.ReportPath = "rptStudentInfo.rdlc";
                    var data4 = await procs.reportStudentInfoAsync(firstParameter);
                    src = new ReportDataSource("stdInfo", data4.ToList());
                    break;
                case 5:
                    report.LocalReport.ReportPath = "rptStudentInfo.rdlc";
                    var data5 = await procs.reportStudentInfoAsync(firstParameter);
                    src = new ReportDataSource("stdInfo", data5.ToList());
                    break;*/
                default:
                    break;
            }

            report = new ReportViewer();
            report.Dock = DockStyle.Fill;
            report.LocalReport.DataSources.Clear();
            report.LocalReport.DataSources.Add(src);

            this.Controls.Add(report);
            report.RefreshReport();
        }
    }
}
