﻿namespace PerfomanceAppraissalSystem
{
    partial class EmployeeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeReport));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdLogout = new System.Windows.Forms.Button();
            this.cmdPReport = new System.Windows.Forms.Button();
            this.cmdEvalu = new System.Windows.Forms.Button();
            this.cmdRatings = new System.Windows.Forms.Button();
            this.cmdTask = new System.Windows.Forms.Button();
            this.cmdHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdHelp = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeeIDReport = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.cmdReport);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtEmployeeName);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtEmployeeIDReport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(897, 362);
            this.panel3.TabIndex = 9;
            // 
            // cmdLogout
            // 
            this.cmdLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogout.Image = ((System.Drawing.Image)(resources.GetObject("cmdLogout.Image")));
            this.cmdLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdLogout.Location = new System.Drawing.Point(778, 3);
            this.cmdLogout.Name = "cmdLogout";
            this.cmdLogout.Size = new System.Drawing.Size(116, 62);
            this.cmdLogout.TabIndex = 8;
            this.cmdLogout.Text = "Logout";
            this.cmdLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdLogout.UseVisualStyleBackColor = true;
            this.cmdLogout.Click += new System.EventHandler(this.cmdLogout_Click);
            // 
            // cmdPReport
            // 
            this.cmdPReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPReport.Image = ((System.Drawing.Image)(resources.GetObject("cmdPReport.Image")));
            this.cmdPReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdPReport.Location = new System.Drawing.Point(525, 4);
            this.cmdPReport.Name = "cmdPReport";
            this.cmdPReport.Size = new System.Drawing.Size(135, 62);
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
            this.cmdEvalu.Location = new System.Drawing.Point(403, 4);
            this.cmdEvalu.Name = "cmdEvalu";
            this.cmdEvalu.Size = new System.Drawing.Size(126, 62);
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
            this.cmdRatings.Location = new System.Drawing.Point(272, 4);
            this.cmdRatings.Name = "cmdRatings";
            this.cmdRatings.Size = new System.Drawing.Size(132, 62);
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
            this.cmdTask.Location = new System.Drawing.Point(149, 4);
            this.cmdTask.Name = "cmdTask";
            this.cmdTask.Size = new System.Drawing.Size(126, 62);
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
            this.cmdHome.Location = new System.Drawing.Point(3, 4);
            this.cmdHome.Name = "cmdHome";
            this.cmdHome.Size = new System.Drawing.Size(147, 62);
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
            this.panel1.Size = new System.Drawing.Size(897, 72);
            this.panel1.TabIndex = 8;
            // 
            // cmdHelp
            // 
            this.cmdHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHelp.Image = ((System.Drawing.Image)(resources.GetObject("cmdHelp.Image")));
            this.cmdHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdHelp.Location = new System.Drawing.Point(655, 4);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(125, 62);
            this.cmdHelp.TabIndex = 13;
            this.cmdHelp.Text = "Help";
            this.cmdHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdHelp.UseVisualStyleBackColor = true;
            this.cmdHelp.Click += new System.EventHandler(this.cmdHelp_Click);
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
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(27, 116);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(791, 162);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Rating";
            this.columnHeader8.Width = 70;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Period";
            this.columnHeader9.Width = 107;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Year";
            this.columnHeader10.Width = 136;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Job Title";
            this.columnHeader13.Width = 70;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Firstname";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lastname";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Department";
            this.columnHeader3.Width = 284;
            // 
            // cmdReport
            // 
            this.cmdReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReport.Location = new System.Drawing.Point(323, 296);
            this.cmdReport.Name = "cmdReport";
            this.cmdReport.Size = new System.Drawing.Size(163, 34);
            this.cmdReport.TabIndex = 22;
            this.cmdReport.Text = "Report";
            this.cmdReport.UseVisualStyleBackColor = true;
            this.cmdReport.Click += new System.EventHandler(this.cmdReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(506, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "* optional";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Employee Name";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(310, 68);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(176, 26);
            this.txtEmployeeName.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Employee ID";
            // 
            // txtEmployeeIDReport
            // 
            this.txtEmployeeIDReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeIDReport.Location = new System.Drawing.Point(310, 36);
            this.txtEmployeeIDReport.Name = "txtEmployeeIDReport";
            this.txtEmployeeIDReport.Size = new System.Drawing.Size(176, 26);
            this.txtEmployeeIDReport.TabIndex = 17;
            // 
            // EmployeeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(897, 434);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeReport";
            this.Text = "Reports";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cmdLogout;
        private System.Windows.Forms.Button cmdPReport;
        private System.Windows.Forms.Button cmdEvalu;
        private System.Windows.Forms.Button cmdRatings;
        private System.Windows.Forms.Button cmdTask;
        private System.Windows.Forms.Button cmdHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdHelp;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button cmdReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmployeeIDReport;
    }
}