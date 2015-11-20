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
    public partial class frmAddScore : Form
    {
        private int score = -1;

        public frmAddScore()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (IsValidData())
            {
                score = Convert.ToInt32(txtBoxScore.Text);
                this.Close();
            }
            
        }

        public int GetNewScore()
        {
            this.ShowDialog();
            return score;
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtBoxScore, "Score") &&
                Validator.IsInt32(txtBoxScore, "Score") &&
                Validator.IsWithinRange(txtBoxScore, "Score", 0, 100);
        }
    }
}
