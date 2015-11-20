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
    public partial class frmUpdateStudentScores : Form
    {
        public frmUpdateStudentScores(Student student)
        {
            InitializeComponent();
            lblName.Text = student.Name;
            
            StudentSelected = student;

            foreach (int scores in student.ScoreList)
            {
                scoresList.Add(scores);
            }
            FillScoresListBox();
        }

        public void FillScoresListBox()
        {
            lstBoxScores.Items.Clear();
            foreach (int scores in scoresList)
            {
                lstBoxScores.Items.Add(scores);

            }
        }

        private Student student = null;

        List<int> scoresList = new List<int>();

        public Student StudentSelected
        {
            get
            {
                return student;
            }
            set
            {
                student = value;
            }
        }

        public Student GetUpdatedStudent()
        {
            this.ShowDialog();
            return student; 
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            frmAddScore addScoreForm = new frmAddScore();
            int score = addScoreForm.GetNewScore();
            if (score != -1)
            {    
                scoresList.Add(score);
                FillScoresListBox();
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            student.ScoreList = scoresList;
            this.Close();
        }

        private void btnUpdateScore_Click(object sender, EventArgs e)
        {
            int i = lstBoxScores.SelectedIndex;
            if (i != -1)
            {
                frmUpdateScores updateStudentScoresForm = new frmUpdateScores(scoresList[i]);
                int score = updateStudentScoresForm.GetUpdatedScore();

                if (score != -1)
                {
                    scoresList[i] = score;
                    FillScoresListBox();
                }
            }
        }

        private void btnRemoveScore_Click(object sender, EventArgs e)
        {
            int i = lstBoxScores.SelectedIndex;

            if (i != -1)
            {
                int score = scoresList[i];
                scoresList.Remove(score);
                FillScoresListBox();
            }
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            scoresList.Clear();
            FillScoresListBox();
        }
    }
}
