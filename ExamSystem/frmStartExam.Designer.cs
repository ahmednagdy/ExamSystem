
namespace ExamSystem
{
    partial class frmStartExam
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdioanswer4 = new System.Windows.Forms.RadioButton();
            this.rdioanswer3 = new System.Windows.Forms.RadioButton();
            this.lblQuestionBody = new System.Windows.Forms.Label();
            this.rdioanswer2 = new System.Windows.Forms.RadioButton();
            this.rdioanswer1 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdioanswer4);
            this.groupBox1.Controls.Add(this.rdioanswer3);
            this.groupBox1.Controls.Add(this.lblQuestionBody);
            this.groupBox1.Controls.Add(this.rdioanswer2);
            this.groupBox1.Controls.Add(this.rdioanswer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdioanswer4
            // 
            this.rdioanswer4.AutoSize = true;
            this.rdioanswer4.Location = new System.Drawing.Point(22, 346);
            this.rdioanswer4.Name = "rdioanswer4";
            this.rdioanswer4.Size = new System.Drawing.Size(14, 13);
            this.rdioanswer4.TabIndex = 4;
            this.rdioanswer4.TabStop = true;
            this.rdioanswer4.UseVisualStyleBackColor = true;
            // 
            // rdioanswer3
            // 
            this.rdioanswer3.AutoSize = true;
            this.rdioanswer3.Location = new System.Drawing.Point(22, 281);
            this.rdioanswer3.Name = "rdioanswer3";
            this.rdioanswer3.Size = new System.Drawing.Size(14, 13);
            this.rdioanswer3.TabIndex = 3;
            this.rdioanswer3.TabStop = true;
            this.rdioanswer3.UseVisualStyleBackColor = true;
            // 
            // lblQuestionBody
            // 
            this.lblQuestionBody.AutoSize = true;
            this.lblQuestionBody.Location = new System.Drawing.Point(22, 23);
            this.lblQuestionBody.Name = "lblQuestionBody";
            this.lblQuestionBody.Size = new System.Drawing.Size(0, 15);
            this.lblQuestionBody.TabIndex = 2;
            this.lblQuestionBody.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdioanswer2
            // 
            this.rdioanswer2.AutoSize = true;
            this.rdioanswer2.Location = new System.Drawing.Point(22, 230);
            this.rdioanswer2.Name = "rdioanswer2";
            this.rdioanswer2.Size = new System.Drawing.Size(14, 13);
            this.rdioanswer2.TabIndex = 1;
            this.rdioanswer2.TabStop = true;
            this.rdioanswer2.UseVisualStyleBackColor = true;
            // 
            // rdioanswer1
            // 
            this.rdioanswer1.AutoSize = true;
            this.rdioanswer1.Location = new System.Drawing.Point(22, 178);
            this.rdioanswer1.Name = "rdioanswer1";
            this.rdioanswer1.Size = new System.Drawing.Size(14, 13);
            this.rdioanswer1.TabIndex = 0;
            this.rdioanswer1.TabStop = true;
            this.rdioanswer1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(674, 427);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            
            // frmStartExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 462);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStartExam";
            this.Text = "frmStartExam";
            this.Load += new System.EventHandler(this.frmStartExam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQuestionBody;
        private System.Windows.Forms.RadioButton rdioanswer2;
        private System.Windows.Forms.RadioButton rdioanswer1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rdioanswer4;
        private System.Windows.Forms.RadioButton rdioanswer3;
        private System.Windows.Forms.Button btnSubmit;
    }
}