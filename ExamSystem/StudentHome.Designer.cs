
namespace ExamSystem
{
    partial class StudentHome
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
            this.comboxCourses = new System.Windows.Forms.ComboBox();
            this.btnStartExam = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboxCourses
            // 
            this.comboxCourses.FormattingEnabled = true;
            this.comboxCourses.Location = new System.Drawing.Point(154, 54);
            this.comboxCourses.Name = "comboxCourses";
            this.comboxCourses.Size = new System.Drawing.Size(304, 23);
            this.comboxCourses.TabIndex = 0;
            // 
            // btnStartExam
            // 
            this.btnStartExam.Location = new System.Drawing.Point(154, 127);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(127, 71);
            this.btnStartExam.TabIndex = 1;
            this.btnStartExam.Text = "Sart Exam";
            this.btnStartExam.UseVisualStyleBackColor = true;
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(321, 127);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(114, 71);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course Name";
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnStartExam);
            this.Controls.Add(this.comboxCourses);
            this.Name = "StudentHome";
            this.Text = "StudentHome";
            this.Load += new System.EventHandler(this.StudentHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxCourses;
        private System.Windows.Forms.Button btnStartExam;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label label1;
    }
}