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
    public partial class frmUpdateScores : Form
    {
        private int updatedScore = -1;

        public frmUpdateScores(int score)
        {
            InitializeComponent();
            txtBoxScore.Text = score.ToString();
        }

        public int GetUpdatedScore()
        {
            this.ShowDialog();
            return updatedScore;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                updatedScore = Convert.ToInt32(txtBoxScore.Text);
                this.Close();
            }        
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtBoxScore, "Score") &&
                Validator.IsInt32(txtBoxScore, "Score") &&
                Validator.IsWithinRange(txtBoxScore, "Score", 0, 100);
        }
    }
}
