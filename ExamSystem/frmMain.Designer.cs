
namespace ExamSystem
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.courses = new System.Windows.Forms.ComboBox();
            this.qtype = new System.Windows.Forms.ComboBox();
            this.choice1 = new System.Windows.Forms.TextBox();
            this.choice2 = new System.Windows.Forms.TextBox();
            this.choice3 = new System.Windows.Forms.TextBox();
            this.choice4 = new System.Windows.Forms.TextBox();
            this.qbody = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courses
            // 
            this.courses.FormattingEnabled = true;
            this.courses.Location = new System.Drawing.Point(247, 80);
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(151, 28);
            this.courses.TabIndex = 0;
            // 
            // qtype
            // 
            this.qtype.FormattingEnabled = true;
            this.qtype.Items.AddRange(new object[] {
            "T/F",
            "MCQ"});
            this.qtype.Location = new System.Drawing.Point(521, 80);
            this.qtype.Name = "qtype";
            this.qtype.Size = new System.Drawing.Size(151, 28);
            this.qtype.TabIndex = 1;
            // 
            // choice1
            // 
            this.choice1.Location = new System.Drawing.Point(247, 188);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(425, 27);
            this.choice1.TabIndex = 2;
            // 
            // choice2
            // 
            this.choice2.Location = new System.Drawing.Point(247, 242);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(425, 27);
            this.choice2.TabIndex = 3;
            // 
            // choice3
            // 
            this.choice3.Location = new System.Drawing.Point(247, 302);
            this.choice3.Name = "choice3";
            this.choice3.Size = new System.Drawing.Size(425, 27);
            this.choice3.TabIndex = 4;
            // 
            // choice4
            // 
            this.choice4.Location = new System.Drawing.Point(247, 355);
            this.choice4.Name = "choice4";
            this.choice4.Size = new System.Drawing.Size(425, 27);
            this.choice4.TabIndex = 5;
            // 
            // qbody
            // 
            this.qbody.Location = new System.Drawing.Point(247, 132);
            this.qbody.Name = "qbody";
            this.qbody.Size = new System.Drawing.Size(425, 27);
            this.qbody.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Question Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Choice 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Choice 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Choice 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Choice 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Question";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(733, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 66);
            this.button1.TabIndex = 14;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qbody);
            this.Controls.Add(this.choice4);
            this.Controls.Add(this.choice3);
            this.Controls.Add(this.choice2);
            this.Controls.Add(this.choice1);
            this.Controls.Add(this.qtype);
            this.Controls.Add(this.courses);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox courses;
        private System.Windows.Forms.ComboBox qtype;
        private System.Windows.Forms.TextBox choice1;
        private System.Windows.Forms.TextBox choice2;
        private System.Windows.Forms.TextBox choice3;
        private System.Windows.Forms.TextBox choice4;
        private System.Windows.Forms.TextBox qbody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

