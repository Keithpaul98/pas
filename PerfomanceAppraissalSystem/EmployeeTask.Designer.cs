namespace PerfomanceAppraissalSystem
{
    partial class EmployeeTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeTask));
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaskname = new System.Windows.Forms.TextBox();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaskID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdViewTasks = new System.Windows.Forms.Button();
            this.cmdChangeTask = new System.Windows.Forms.Button();
            this.cmdRemoveTask = new System.Windows.Forms.Button();
            this.cmdAddTask = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cmdPReport = new System.Windows.Forms.Button();
            this.cmdEvalu = new System.Windows.Forms.Button();
            this.cmdRatings = new System.Windows.Forms.Button();
            this.cmdTask = new System.Windows.Forms.Button();
            this.cmdHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdHelp = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status";
            // 
            // txtTaskname
            // 
            this.txtTaskname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskname.Location = new System.Drawing.Point(349, 101);
            this.txtTaskname.Name = "txtTaskname";
            this.txtTaskname.Size = new System.Drawing.Size(196, 26);
            this.txtTaskname.TabIndex = 5;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Task Status";
            this.columnHeader3.Width = 210;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Task Name";
            this.columnHeader2.Width = 294;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Task ID";
            this.columnHeader1.Width = 194;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Completed task",
            "Incomplete task"});
            this.cmbStatus.Location = new System.Drawing.Point(349, 146);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(196, 28);
            this.cmbStatus.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tasks ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 212);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(703, 128);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbStatus);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtTaskname);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtTaskID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 368);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Task Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Task ID";
            // 
            // txtTaskID
            // 
            this.txtTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskID.Location = new System.Drawing.Point(349, 53);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.Size = new System.Drawing.Size(196, 26);
            this.txtTaskID.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdViewTasks);
            this.panel2.Controls.Add(this.cmdChangeTask);
            this.panel2.Controls.Add(this.cmdRemoveTask);
            this.panel2.Controls.Add(this.cmdAddTask);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 368);
            this.panel2.TabIndex = 7;
            // 
            // cmdViewTasks
            // 
            this.cmdViewTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdViewTasks.Location = new System.Drawing.Point(19, 278);
            this.cmdViewTasks.Name = "cmdViewTasks";
            this.cmdViewTasks.Size = new System.Drawing.Size(175, 40);
            this.cmdViewTasks.TabIndex = 13;
            this.cmdViewTasks.Text = "View Tasks";
            this.cmdViewTasks.UseVisualStyleBackColor = true;
            this.cmdViewTasks.Click += new System.EventHandler(this.cmdViewTasks_Click);
            // 
            // cmdChangeTask
            // 
            this.cmdChangeTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdChangeTask.Location = new System.Drawing.Point(19, 194);
            this.cmdChangeTask.Name = "cmdChangeTask";
            this.cmdChangeTask.Size = new System.Drawing.Size(175, 40);
            this.cmdChangeTask.TabIndex = 12;
            this.cmdChangeTask.Text = "Change Task";
            this.cmdChangeTask.UseVisualStyleBackColor = true;
            this.cmdChangeTask.Click += new System.EventHandler(this.cmdChangeTask_Click);
            // 
            // cmdRemoveTask
            // 
            this.cmdRemoveTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemoveTask.Location = new System.Drawing.Point(19, 104);
            this.cmdRemoveTask.Name = "cmdRemoveTask";
            this.cmdRemoveTask.Size = new System.Drawing.Size(175, 40);
            this.cmdRemoveTask.TabIndex = 11;
            this.cmdRemoveTask.Text = "Remove Task";
            this.cmdRemoveTask.UseVisualStyleBackColor = true;
            this.cmdRemoveTask.Click += new System.EventHandler(this.cmdRemoveTask_Click);
            // 
            // cmdAddTask
            // 
            this.cmdAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddTask.Location = new System.Drawing.Point(19, 21);
            this.cmdAddTask.Name = "cmdAddTask";
            this.cmdAddTask.Size = new System.Drawing.Size(175, 40);
            this.cmdAddTask.TabIndex = 10;
            this.cmdAddTask.Text = "Add Task";
            this.cmdAddTask.UseVisualStyleBackColor = true;
            this.cmdAddTask.Click += new System.EventHandler(this.cmdAddTask_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(815, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 62);
            this.button5.TabIndex = 8;
            this.button5.Text = "Login";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cmdPReport
            // 
            this.cmdPReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPReport.Image = ((System.Drawing.Image)(resources.GetObject("cmdPReport.Image")));
            this.cmdPReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdPReport.Location = new System.Drawing.Point(549, 4);
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
            this.cmdEvalu.Location = new System.Drawing.Point(408, 4);
            this.cmdEvalu.Name = "cmdEvalu";
            this.cmdEvalu.Size = new System.Drawing.Size(142, 62);
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
            this.cmdRatings.Location = new System.Drawing.Point(269, 4);
            this.cmdRatings.Name = "cmdRatings";
            this.cmdRatings.Size = new System.Drawing.Size(140, 62);
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
            this.cmdTask.Location = new System.Drawing.Point(127, 3);
            this.cmdTask.Name = "cmdTask";
            this.cmdTask.Size = new System.Drawing.Size(144, 62);
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
            this.cmdHome.Size = new System.Drawing.Size(126, 62);
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
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.cmdPReport);
            this.panel1.Controls.Add(this.cmdEvalu);
            this.panel1.Controls.Add(this.cmdRatings);
            this.panel1.Controls.Add(this.cmdTask);
            this.panel1.Controls.Add(this.cmdHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 72);
            this.panel1.TabIndex = 6;
            // 
            // cmdHelp
            // 
            this.cmdHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHelp.Image = ((System.Drawing.Image)(resources.GetObject("cmdHelp.Image")));
            this.cmdHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdHelp.Location = new System.Drawing.Point(670, 4);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(150, 62);
            this.cmdHelp.TabIndex = 13;
            this.cmdHelp.Text = "Help";
            this.cmdHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdHelp.UseVisualStyleBackColor = true;
            this.cmdHelp.Click += new System.EventHandler(this.cmdHelp_Click);
            // 
            // EmployeeTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(937, 440);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeTask";
            this.Text = "EmployeeTask";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaskname;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaskID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdViewTasks;
        private System.Windows.Forms.Button cmdChangeTask;
        private System.Windows.Forms.Button cmdRemoveTask;
        private System.Windows.Forms.Button cmdAddTask;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button cmdPReport;
        private System.Windows.Forms.Button cmdEvalu;
        private System.Windows.Forms.Button cmdRatings;
        private System.Windows.Forms.Button cmdTask;
        private System.Windows.Forms.Button cmdHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdHelp;
    }
}