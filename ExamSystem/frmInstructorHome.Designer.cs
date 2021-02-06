
namespace ExamSystem
{
    partial class frmInstructorHome
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
            this.combBoxCourseName = new System.Windows.Forms.ComboBox();
            this.btnCourseTopic = new System.Windows.Forms.Button();
            this.btnNumOfTFMCQ = new System.Windows.Forms.Button();
            this.btnAllStudInDept = new System.Windows.Forms.Button();
            this.btnAllGrade = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comBoxDeptName = new System.Windows.Forms.ComboBox();
            this.cbmStudentName = new System.Windows.Forms.ComboBox();
            this.comBoxInstructorName = new System.Windows.Forms.ComboBox();
            this.txtNumOfTF = new System.Windows.Forms.TextBox();
            this.txtNumOFMcq = new System.Windows.Forms.TextBox();
            this.combxExamID = new System.Windows.Forms.ComboBox();
            this.QestionsAndAnswersinExam = new System.Windows.Forms.Button();
            this.crname = new System.Windows.Forms.ComboBox();
            this.btnInsertQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combBoxCourseName
            // 
            this.combBoxCourseName.FormattingEnabled = true;
            this.combBoxCourseName.Location = new System.Drawing.Point(119, 47);
            this.combBoxCourseName.Name = "combBoxCourseName";
            this.combBoxCourseName.Size = new System.Drawing.Size(202, 23);
            this.combBoxCourseName.TabIndex = 0;
            // 
            // btnCourseTopic
            // 
            this.btnCourseTopic.Location = new System.Drawing.Point(21, 47);
            this.btnCourseTopic.Name = "btnCourseTopic";
            this.btnCourseTopic.Size = new System.Drawing.Size(92, 23);
            this.btnCourseTopic.TabIndex = 1;
            this.btnCourseTopic.Text = "Course Topic";
            this.btnCourseTopic.UseVisualStyleBackColor = true;
            this.btnCourseTopic.Click += new System.EventHandler(this.btnCourseTopic_Click);
            // 
            // btnNumOfTFMCQ
            // 
            this.btnNumOfTFMCQ.Location = new System.Drawing.Point(12, 246);
            this.btnNumOfTFMCQ.Name = "btnNumOfTFMCQ";
            this.btnNumOfTFMCQ.Size = new System.Drawing.Size(211, 35);
            this.btnNumOfTFMCQ.TabIndex = 2;
            this.btnNumOfTFMCQ.Text = "Set Num Of TF and MCQ";
            this.btnNumOfTFMCQ.UseVisualStyleBackColor = true;
            this.btnNumOfTFMCQ.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAllStudInDept
            // 
            this.btnAllStudInDept.Location = new System.Drawing.Point(351, 46);
            this.btnAllStudInDept.Name = "btnAllStudInDept";
            this.btnAllStudInDept.Size = new System.Drawing.Size(175, 23);
            this.btnAllStudInDept.TabIndex = 3;
            this.btnAllStudInDept.Text = "All Student in Dept";
            this.btnAllStudInDept.UseVisualStyleBackColor = true;
            this.btnAllStudInDept.Click += new System.EventHandler(this.btnAllStudInDept_Click);
            // 
            // btnAllGrade
            // 
            this.btnAllGrade.Location = new System.Drawing.Point(351, 147);
            this.btnAllGrade.Name = "btnAllGrade";
            this.btnAllGrade.Size = new System.Drawing.Size(101, 23);
            this.btnAllGrade.TabIndex = 4;
            this.btnAllGrade.Text = "All Grade";
            this.btnAllGrade.UseVisualStyleBackColor = true;
            this.btnAllGrade.Click += new System.EventHandler(this.btnAllGrade_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 69);
            this.button5.TabIndex = 5;
            this.button5.Text = "All Courses And Student Num with ins";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comBoxDeptName
            // 
            this.comBoxDeptName.FormattingEnabled = true;
            this.comBoxDeptName.Location = new System.Drawing.Point(532, 46);
            this.comBoxDeptName.Name = "comBoxDeptName";
            this.comBoxDeptName.Size = new System.Drawing.Size(164, 23);
            this.comBoxDeptName.TabIndex = 9;
            // 
            // cbmStudentName
            // 
            this.cbmStudentName.FormattingEnabled = true;
            this.cbmStudentName.Location = new System.Drawing.Point(469, 147);
            this.cbmStudentName.Name = "cbmStudentName";
            this.cbmStudentName.Size = new System.Drawing.Size(175, 23);
            this.cbmStudentName.TabIndex = 11;
            // 
            // comBoxInstructorName
            // 
            this.comBoxInstructorName.FormattingEnabled = true;
            this.comBoxInstructorName.Location = new System.Drawing.Point(119, 148);
            this.comBoxInstructorName.Name = "comBoxInstructorName";
            this.comBoxInstructorName.Size = new System.Drawing.Size(182, 23);
            this.comBoxInstructorName.TabIndex = 12;
            // 
            // txtNumOfTF
            // 
            this.txtNumOfTF.Location = new System.Drawing.Point(244, 258);
            this.txtNumOfTF.Name = "txtNumOfTF";
            this.txtNumOfTF.Size = new System.Drawing.Size(145, 23);
            this.txtNumOfTF.TabIndex = 13;
            this.txtNumOfTF.Text = "Num Of TF";
            // 
            // txtNumOFMcq
            // 
            this.txtNumOFMcq.Location = new System.Drawing.Point(421, 258);
            this.txtNumOFMcq.Name = "txtNumOFMcq";
            this.txtNumOFMcq.Size = new System.Drawing.Size(116, 23);
            this.txtNumOFMcq.TabIndex = 14;
            this.txtNumOFMcq.Text = "NUM Of Mcq";
            // 
            // combxExamID
            // 
            this.combxExamID.FormattingEnabled = true;
            this.combxExamID.Location = new System.Drawing.Point(173, 351);
            this.combxExamID.Name = "combxExamID";
            this.combxExamID.Size = new System.Drawing.Size(194, 23);
            this.combxExamID.TabIndex = 15;
            // 
            // QestionsAndAnswersinExam
            // 
            this.QestionsAndAnswersinExam.Location = new System.Drawing.Point(38, 337);
            this.QestionsAndAnswersinExam.Name = "QestionsAndAnswersinExam";
            this.QestionsAndAnswersinExam.Size = new System.Drawing.Size(115, 58);
            this.QestionsAndAnswersinExam.TabIndex = 16;
            this.QestionsAndAnswersinExam.Text = "Qeustions and Answers in Exam";
            this.QestionsAndAnswersinExam.UseVisualStyleBackColor = true;
            // 
            // crname
            // 
            this.crname.FormattingEnabled = true;
            this.crname.Location = new System.Drawing.Point(616, 257);
            this.crname.Name = "crname";
            this.crname.Size = new System.Drawing.Size(121, 23);
            this.crname.TabIndex = 17;
            // 
            // btnInsertQuestion
            // 
            this.btnInsertQuestion.Location = new System.Drawing.Point(450, 350);
            this.btnInsertQuestion.Name = "btnInsertQuestion";
            this.btnInsertQuestion.Size = new System.Drawing.Size(138, 23);
            this.btnInsertQuestion.TabIndex = 18;
            this.btnInsertQuestion.Text = "insert Question";
            this.btnInsertQuestion.UseVisualStyleBackColor = true;
            this.btnInsertQuestion.Click += new System.EventHandler(this.btnInsertQuestion_Click);
            // 
            // frmInstructorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 448);
            this.Controls.Add(this.btnInsertQuestion);
            this.Controls.Add(this.crname);
            this.Controls.Add(this.QestionsAndAnswersinExam);
            this.Controls.Add(this.combxExamID);
            this.Controls.Add(this.txtNumOFMcq);
            this.Controls.Add(this.txtNumOfTF);
            this.Controls.Add(this.comBoxInstructorName);
            this.Controls.Add(this.cbmStudentName);
            this.Controls.Add(this.comBoxDeptName);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnAllGrade);
            this.Controls.Add(this.btnAllStudInDept);
            this.Controls.Add(this.btnNumOfTFMCQ);
            this.Controls.Add(this.btnCourseTopic);
            this.Controls.Add(this.combBoxCourseName);
            this.Name = "frmInstructorHome";
            this.Text = "frmInstructorHome";
            this.Load += new System.EventHandler(this.frmInstructorHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combBoxCourseName;
        private System.Windows.Forms.Button btnCourseTopic;
        private System.Windows.Forms.Button btnNumOfTFMCQ;
        private System.Windows.Forms.Button btnAllStudInDept;
        private System.Windows.Forms.Button btnAllGrade;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comBoxDeptName;
        private System.Windows.Forms.ComboBox cbmStudentName;
        private System.Windows.Forms.ComboBox comBoxInstructorName;
        private System.Windows.Forms.TextBox txtNumOfTF;
        private System.Windows.Forms.TextBox txtNumOFMcq;
        private System.Windows.Forms.ComboBox combxExamID;
        private System.Windows.Forms.Button QestionsAndAnswersinExam;
        private System.Windows.Forms.ComboBox crname;
        private System.Windows.Forms.Button btnInsertQuestion;
    }
}