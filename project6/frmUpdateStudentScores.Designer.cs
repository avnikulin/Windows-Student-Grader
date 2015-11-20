namespace project6
{
    partial class frmUpdateStudentScores
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstBoxScores = new System.Windows.Forms.ListBox();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.btnUpdateScore = new System.Windows.Forms.Button();
            this.btnRemoveScore = new System.Windows.Forms.Button();
            this.btnClearScores = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(57, 9);
            this.lblName.MinimumSize = new System.Drawing.Size(200, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(200, 20);
            this.lblName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Scores:";
            // 
            // lstBoxScores
            // 
            this.lstBoxScores.FormattingEnabled = true;
            this.lstBoxScores.Location = new System.Drawing.Point(57, 42);
            this.lstBoxScores.Name = "lstBoxScores";
            this.lstBoxScores.Size = new System.Drawing.Size(120, 108);
            this.lstBoxScores.TabIndex = 3;
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(182, 42);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(75, 23);
            this.btnAddScore.TabIndex = 4;
            this.btnAddScore.Text = "&Add";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // btnUpdateScore
            // 
            this.btnUpdateScore.Location = new System.Drawing.Point(182, 71);
            this.btnUpdateScore.Name = "btnUpdateScore";
            this.btnUpdateScore.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateScore.TabIndex = 5;
            this.btnUpdateScore.Text = "&Update";
            this.btnUpdateScore.UseVisualStyleBackColor = true;
            this.btnUpdateScore.Click += new System.EventHandler(this.btnUpdateScore_Click);
            // 
            // btnRemoveScore
            // 
            this.btnRemoveScore.Location = new System.Drawing.Point(182, 100);
            this.btnRemoveScore.Name = "btnRemoveScore";
            this.btnRemoveScore.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveScore.TabIndex = 6;
            this.btnRemoveScore.Text = "R&emove";
            this.btnRemoveScore.UseVisualStyleBackColor = true;
            this.btnRemoveScore.Click += new System.EventHandler(this.btnRemoveScore_Click);
            // 
            // btnClearScores
            // 
            this.btnClearScores.Location = new System.Drawing.Point(182, 129);
            this.btnClearScores.Name = "btnClearScores";
            this.btnClearScores.Size = new System.Drawing.Size(75, 23);
            this.btnClearScores.TabIndex = 7;
            this.btnClearScores.Text = "&Clear Scores";
            this.btnClearScores.UseVisualStyleBackColor = true;
            this.btnClearScores.Click += new System.EventHandler(this.btnClearScores_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(102, 167);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(183, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmUpdateStudentScores
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnClearScores);
            this.Controls.Add(this.btnRemoveScore);
            this.Controls.Add(this.btnUpdateScore);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.lstBoxScores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateStudentScores";
            this.Text = "Update Student Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstBoxScores;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.Button btnUpdateScore;
        private System.Windows.Forms.Button btnRemoveScore;
        private System.Windows.Forms.Button btnClearScores;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}