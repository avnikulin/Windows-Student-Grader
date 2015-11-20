namespace project6
{
    partial class frmStudentScores
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
            this.lblStudents = new System.Windows.Forms.Label();
            this.lstBoxStudents = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(13, 13);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(52, 13);
            this.lblStudents.TabIndex = 0;
            this.lblStudents.Text = "Students:";
            // 
            // lstBoxStudents
            // 
            this.lstBoxStudents.FormattingEnabled = true;
            this.lstBoxStudents.Location = new System.Drawing.Point(16, 39);
            this.lstBoxStudents.Name = "lstBoxStudents";
            this.lstBoxStudents.Size = new System.Drawing.Size(242, 134);
            this.lstBoxStudents.TabIndex = 1;
            this.lstBoxStudents.SelectedIndexChanged += new System.EventHandler(this.lstBoxStudents_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(271, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(271, 68);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "&Update...";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(271, 97);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(271, 233);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Score total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Score count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Average:";
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.AutoSize = true;
            this.lblScoreTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreTotal.Location = new System.Drawing.Point(208, 192);
            this.lblScoreTotal.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(50, 15);
            this.lblScoreTotal.TabIndex = 9;
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreCount.Location = new System.Drawing.Point(208, 215);
            this.lblScoreCount.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(50, 15);
            this.lblScoreCount.TabIndex = 10;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(208, 237);
            this.lblAverage.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(50, 15);
            this.lblAverage.TabIndex = 11;
            // 
            // frmStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(358, 271);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstBoxStudents);
            this.Controls.Add(this.lblStudents);
            this.MaximizeBox = false;
            this.Name = "frmStudentScores";
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.frmStudentScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.ListBox lstBoxStudents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScoreTotal;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblAverage;
    }
}

