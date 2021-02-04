﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExamSystem.Entities;
using Microsoft.Reporting.WinForms;

namespace ExamSystem
{
    public partial class frmInsertQuestions : Form
    {
        Examv2Context db;
        Examv2ContextProcedures procs;
        public frmInsertQuestions()
        {
            InitializeComponent();
            FormClosing += (sender, e) => db.Dispose();
            db = new Examv2Context();
            procs = new Examv2ContextProcedures(db);
            qtype.SelectedIndexChanged += Qtype_SelectedIndexChanged;
        }
        void TrueFalseAction()
        {
            choice1.Hide(); choice2.Hide(); choice3.Hide(); choice4.Hide();
            modelAnswer.Items.Clear();
            modelAnswer.Items.Add("False");
            modelAnswer.Items.Add("True");
        }
        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            //TF selected by default
            qtype.SelectedIndex = 0;
            TrueFalseAction(); 

            //Load courses
            var result = await procs.SelectCourseAsync();
            BindingSource CourseBS = new BindingSource(result,"");
            courses.DataSource = CourseBS;
            courses.DisplayMember = "name";
            courses.ValueMember = "courseID";
        }

        private void Qtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(qtype.SelectedIndex == 0) //TF
            {
                TrueFalseAction();
            }
            else if (qtype.SelectedIndex == 1) //MCQ
            {
                choice1.Show(); choice2.Show(); choice3.Show(); choice4.Show();
                modelAnswer.Items.Clear();
                modelAnswer.Items.Add("Choice1");
                modelAnswer.Items.Add("Choice2");
                modelAnswer.Items.Add("Choice3");
                modelAnswer.Items.Add("Choice4");
            }
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            if (qbody.Text != string.Empty && grade.Value > 0 && modelAnswer.SelectedIndex != -1)
            {
                var flag = new OutputParameter<bool?>();
                if (qtype.Text == "T/F")
                {
                    await procs.QuestionInsertAsync(qbody.Text, modelAnswer.SelectedIndex, (int)grade.Value, 0, (int)courses.SelectedValue, flag);
                    if ((bool)flag.Value) MessageBox.Show("Successfully Inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Some Error happened!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if (qtype.Text == "MCQ")
                {
                    if (choice1.Text != string.Empty && choice2.Text != string.Empty && choice3.Text != string.Empty && choice4.Text != string.Empty)
                    {
                        //Insert the question first (anticipate the right choice id)
                        await procs.QuestionInsertAsync(qbody.Text, modelAnswer.SelectedIndex+1, (int)grade.Value, 1, (int)courses.SelectedValue, flag);
                        if (!(bool)flag.Value) MessageBox.Show("Some Error happened!", "Question Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            //Insert the choices (auto get last inserted question id (in the SP))
                            await procs.ChoiceInsertAsync(null, choice1.Text, flag);
                            await procs.ChoiceInsertAsync(null, choice2.Text, flag);
                            await procs.ChoiceInsertAsync(null, choice3.Text, flag);
                            await procs.ChoiceInsertAsync(null, choice4.Text, flag);

                            if ((bool)flag.Value) MessageBox.Show("Successfully Inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Some Error happened!", "Choice Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
