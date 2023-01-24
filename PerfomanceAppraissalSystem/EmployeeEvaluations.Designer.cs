namespace PerfomanceAppraissalSystem
{
    partial class EmployeeEvaluations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeEvaluations));
            this.cmdCheckEvaluation = new System.Windows.Forms.Button();
            this.txtEmployeeIDEvaluation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEvaluationType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSelectEvaluation = new System.Windows.Forms.ComboBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckbxAllevaluations = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdPReport = new System.Windows.Forms.Button();
            this.cmdEvalu = new System.Windows.Forms.Button();
            this.cmdRatings = new System.Windows.Forms.Button();
            this.cmdTask = new System.Windows.Forms.Button();
            this.cmdHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdLogout = new System.Windows.Forms.Button();
            this.cmdHelp = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCheckEvaluation
            // 
            this.cmdCheckEvaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCheckEvaluation.Location = new System.Drawing.Point(132, 121);
            this.cmdCheckEvaluation.Name = "cmdCheckEvaluation";
            this.cmdCheckEvaluation.Size = new System.Drawing.Size(163, 34);
            this.cmdCheckEvaluation.TabIndex = 12;
            this.cmdCheckEvaluation.Text = "Check Evaluation";
            this.cmdCheckEvaluation.UseVisualStyleBackColor = true;
            this.cmdCheckEvaluation.Click += new System.EventHandler(this.cmdCheckEvaluation_Click);
            // 
            // txtEmployeeIDEvaluation
            // 
            this.txtEmployeeIDEvaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeIDEvaluation.Location = new System.Drawing.Point(223, 79);
            this.txtEmployeeIDEvaluation.Name = "txtEmployeeIDEvaluation";
            this.txtEmployeeIDEvaluation.Size = new System.Drawing.Size(236, 26);
            this.txtEmployeeIDEvaluation.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Evaluation Type";
            // 
            // cmbEvaluationType
            // 
            this.cmbEvaluationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEvaluationType.FormattingEnabled = true;
            this.cmbEvaluationType.Items.AddRange(new object[] {
            "January-June",
            "July-December",
            "All Evaluations"});
            this.cmbEvaluationType.Location = new System.Drawing.Point(223, 45);
            this.cmbEvaluationType.Name = "cmbEvaluationType";
            this.cmbEvaluationType.Size = new System.Drawing.Size(236, 28);
            this.cmbEvaluationType.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Evaluation";
            // 
            // cmbSelectEvaluation
            // 
            this.cmbSelectEvaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectEvaluation.FormattingEnabled = true;
            this.cmbSelectEvaluation.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2026"});
            this.cmbSelectEvaluation.Location = new System.Drawing.Point(223, 11);
            this.cmbSelectEvaluation.Name = "cmbSelectEvaluation";
            this.cmbSelectEvaluation.Size = new System.Drawing.Size(236, 28);
            this.cmbSelectEvaluation.TabIndex = 3;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Commenter";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Comment";
            this.columnHeader3.Width = 182;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lastname";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Firstname";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Job Title";
            this.columnHeader13.Width = 70;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Year";
            this.columnHeader10.Width = 136;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Period";
            this.columnHeader9.Width = 107;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Rating";
            this.columnHeader8.Width = 70;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader13,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(35, 161);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(819, 162);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ckbxAllevaluations);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.cmdCheckEvaluation);
            this.panel2.Controls.Add(this.txtEmployeeIDEvaluation);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbEvaluationType);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbSelectEvaluation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 335);
            this.panel2.TabIndex = 6;
            // 
            // ckbxAllevaluations
            // 
            this.ckbxAllevaluations.AutoSize = true;
            this.ckbxAllevaluations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxAllevaluations.Location = new System.Drawing.Point(648, 68);
            this.ckbxAllevaluations.Name = "ckbxAllevaluations";
            this.ckbxAllevaluations.Size = new System.Drawing.Size(129, 24);
            this.ckbxAllevaluations.TabIndex = 19;
            this.ckbxAllevaluations.Text = "All evaluations";
            this.ckbxAllevaluations.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(644, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Evaluation Type";
            // 
            // cmdPReport
            // 
            this.cmdPReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPReport.Image = ((System.Drawing.Image)(resources.GetObject("cmdPReport.Image")));
            this.cmdPReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdPReport.Location = new System.Drawing.Point(496, 4);
            this.cmdPReport.Name = "cmdPReport";
            this.cmdPReport.Size = new System.Drawing.Size(124, 62);
            this.cmdPReport.TabIndex = 7;
            this.cmdPReport.Text = "Produce report";
            this.cmdPReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdPReport.UseVisualStyleBackColor = true;
            this.cmdPReport.Click += new System.EventHandler(this.cmdPReport_Click);
            // 
            // cmdEvalu
            // 
            this.cmdEvalu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEvalu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEvalu.Image = ((System.Drawing.Image)(resources.GetObject("cmdEvalu.Image")));
            this.cmdEvalu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdEvalu.Location = new System.Drawing.Point(377, 3);
            this.cmdEvalu.Name = "cmdEvalu";
            this.cmdEvalu.Size = new System.Drawing.Size(124, 62);
            this.cmdEvalu.TabIndex = 9;
            this.cmdEvalu.Text = "Evaluations";
            this.cmdEvalu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdEvalu.UseVisualStyleBackColor = true;
            this.cmdEvalu.Click += new System.EventHandler(this.cmdEvalu_Click);
            // 
            // cmdRatings
            // 
            this.cmdRatings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRatings.Image = ((System.Drawing.Image)(resources.GetObject("cmdRatings.Image")));
            this.cmdRatings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdRatings.Location = new System.Drawing.Point(249, 3);
            this.cmdRatings.Name = "cmdRatings";
            this.cmdRatings.Size = new System.Drawing.Size(131, 62);
            this.cmdRatings.TabIndex = 7;
            this.cmdRatings.Text = "Ratings";
            this.cmdRatings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdRatings.UseVisualStyleBackColor = true;
            this.cmdRatings.Click += new System.EventHandler(this.cmdRatings_Click);
            // 
            // cmdTask
            // 
            this.cmdTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTask.Image = ((System.Drawing.Image)(resources.GetObject("cmdTask.Image")));
            this.cmdTask.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdTask.Location = new System.Drawing.Point(112, 3);
            this.cmdTask.Name = "cmdTask";
            this.cmdTask.Size = new System.Drawing.Size(140, 62);
            this.cmdTask.TabIndex = 8;
            this.cmdTask.Text = "Tasks";
            this.cmdTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdTask.UseVisualStyleBackColor = true;
            this.cmdTask.Click += new System.EventHandler(this.cmdTask_Click);
            // 
            // cmdHome
            // 
            this.cmdHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome.Image = ((System.Drawing.Image)(resources.GetObject("cmdHome.Image")));
            this.cmdHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdHome.Location = new System.Drawing.Point(3, 3);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(110, 62);
            this.cmdHome.TabIndex = 6;
            this.cmdHome.Text = "Homepage";
            this.cmdHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdHome.UseVisualStyleBackColor = true;
            this.cmdHome.Click += new System.EventHandler(this.cmdHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.cmdHelp);
            this.panel1.Controls.Add(this.cmdLogout);
            this.panel1.Controls.Add(this.cmdPReport);
            this.panel1.Controls.Add(this.cmdEvalu);
            this.panel1.Controls.Add(this.cmdRatings);
            this.panel1.Controls.Add(this.cmdTask);
            this.panel1.Controls.Add(this.cmdHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 72);
            this.panel1.TabIndex = 5;
            // 
            // cmdLogout
            // 
            this.cmdLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogout.Image = ((System.Drawing.Image)(resources.GetObject("cmdLogout.Image")));
            this.cmdLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdLogout.Location = new System.Drawing.Point(728, 3);
            this.cmdLogout.Name = "cmdLogout";
            this.cmdLogout.Size = new System.Drawing.Size(138, 62);
            this.cmdLogout.TabIndex = 8;
            this.cmdLogout.Text = "Logout";
            this.cmdLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdLogout.UseVisualStyleBackColor = true;
            this.cmdLogout.Click += new System.EventHandler(this.cmdLogout_Click);
            // 
            // cmdHelp
            // 
            this.cmdHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHelp.Image = ((System.Drawing.Image)(resources.GetObject("cmdHelp.Image")));
            this.cmdHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdHelp.Location = new System.Drawing.Point(616, 4);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(117, 62);
            this.cmdHelp.TabIndex = 13;
            this.cmdHelp.Text = "Help";
            this.cmdHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdHelp.UseVisualStyleBackColor = true;
            this.cmdHelp.Click += new System.EventHandler(this.cmdHelp_Click);
            // 
            // EmployeeEvaluations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(866, 407);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeEvaluations";
            this.Text = "Evaluations";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCheckEvaluation;
        private System.Windows.Forms.TextBox txtEmployeeIDEvaluation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEvaluationType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSelectEvaluation;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdPReport;
        private System.Windows.Forms.Button cmdEvalu;
        private System.Windows.Forms.Button cmdRatings;
        private System.Windows.Forms.Button cmdTask;
        private System.Windows.Forms.Button cmdHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdLogout;
        private System.Windows.Forms.CheckBox ckbxAllevaluations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdHelp;
    }
}