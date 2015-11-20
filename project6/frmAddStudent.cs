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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private Student student = null;

        public Student GetNewStudent()
        {
            this.ShowDialog();
            return student;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtName, "Name"))
            {
                student = new Student(txtName.Text, tempList);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<int> tempList = new List<int>();

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                tempList.Add(Convert.ToInt32(txtScore.Text));
                string total = "";
                foreach (int scores in tempList)
                {
                    total += Convert.ToString(scores) + " ";
                }
                lblScores.Text = total;
            }
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            tempList.Clear();
            lblScores.Text = String.Empty;
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtScore, "Score") &&
                Validator.IsInt32(txtScore, "Score") &&
                Validator.IsWithinRange(txtScore, "Score", 0, 100);
        }
    }
}
