using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project6
{
    public partial class frmStudentScores : Form
    {
        public frmStudentScores()
        {
            InitializeComponent();
        }

        private List<Student> students = null;

        private void FillStudentListBox()
        {
            lstBoxStudents.Items.Clear();
            foreach (Student s in students)
            {
                lstBoxStudents.Items.Add(s.GetDisplayText());
            }
        }

        private void frmStudentScores_Load(object sender, EventArgs e)
        {
            StudentDB.LoadSampleStudents();
            students = StudentDB.GetStudents();
            FillStudentListBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddStudent addStudentForm = new frmAddStudent();
            Student student = addStudentForm.GetNewStudent();

            if (student != null)
            {
                students.Add(student);
                StudentDB.SaveStudents(students);
                FillStudentListBox();
                int i = students.Count - 1;
                lstBoxStudents.SetSelected(i, true);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = lstBoxStudents.SelectedIndex;
            if (i != -1)
            {
                Student selectedStudent = students[i];
                frmUpdateStudentScores updateStudentScoresForm = new frmUpdateStudentScores(selectedStudent);
                updateStudentScoresForm.GetUpdatedStudent();
                StudentDB.SaveStudents(students);
                FillStudentListBox();
                lstBoxStudents.SetSelected(i, true);  
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstBoxStudents.SelectedIndex;

            if (i != -1)
            {
                Student student = students[i];
                students.Remove(student);
                StudentDB.SaveStudents(students);
                FillStudentListBox();
                lblScoreTotal.Text = String.Empty;
                lblScoreCount.Text = String.Empty;
                lblAverage.Text = String.Empty;
            }
        }

        private void lstBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculations();
        }

        private void Calculations()
        {
            int i = lstBoxStudents.SelectedIndex;
            
            if (i != -1)
            {
                Student selectedStudent = students[i];
                if (selectedStudent.ScoreList.Count() == 0)
                {
                    lblScoreTotal.Text = "n/a";
                    lblScoreCount.Text = "0";
                    lblAverage.Text = "n/a";
                }
                else
                {
                    int total = 0;
                    foreach (int score in selectedStudent.ScoreList)
                    {
                        total += score;
                    }
                    int count = selectedStudent.ScoreList.Count();
                    decimal average = Convert.ToDecimal(total) / Convert.ToDecimal(count);

                    lblScoreTotal.Text = Convert.ToString(total);
                    lblScoreCount.Text = Convert.ToString(count);
                    lblAverage.Text = average.ToString("#.##");

                }
            }
        }
    }
}
