namespace 教务系统
{
    partial class Courseachievement
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
            this.dataCourseachievement = new System.Windows.Forms.DataGridView();
            this.Columnterm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columncourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columncoursemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columncredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columntime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnattribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnnature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnoperate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataCourseachievement)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCourseachievement
            // 
            this.dataCourseachievement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCourseachievement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnterm,
            this.Columnnum,
            this.Columnname,
            this.Columncourse,
            this.Columncoursemark,
            this.Columncredit,
            this.Columntime,
            this.Columnway,
            this.Columnattribute,
            this.Columnnature,
            this.Columnoperate});
            this.dataCourseachievement.Location = new System.Drawing.Point(12, 12);
            this.dataCourseachievement.Name = "dataCourseachievement";
            this.dataCourseachievement.RowTemplate.Height = 23;
            this.dataCourseachievement.Size = new System.Drawing.Size(513, 228);
            this.dataCourseachievement.TabIndex = 0;
            this.dataCourseachievement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCourseachievement_CellContentClick);
            // 
            // Columnterm
            // 
            this.Columnterm.HeaderText = "开课学期";
            this.Columnterm.Name = "Columnterm";
            // 
            // Columnnum
            // 
            this.Columnnum.HeaderText = "课程编号";
            this.Columnnum.Name = "Columnnum";
            // 
            // Columnname
            // 
            this.Columnname.HeaderText = "课程名称";
            this.Columnname.Name = "Columnname";
            // 
            // Columncourse
            // 
            this.Columncourse.HeaderText = "成绩";
            this.Columncourse.Name = "Columncourse";
            // 
            // Columncoursemark
            // 
            this.Columncoursemark.HeaderText = "成绩标志";
            this.Columncoursemark.Name = "Columncoursemark";
            // 
            // Columncredit
            // 
            this.Columncredit.HeaderText = "学分";
            this.Columncredit.Name = "Columncredit";
            // 
            // Columntime
            // 
            this.Columntime.HeaderText = "总学时";
            this.Columntime.Name = "Columntime";
            // 
            // Columnway
            // 
            this.Columnway.HeaderText = "考核方式";
            this.Columnway.Name = "Columnway";
            this.Columnway.ReadOnly = true;
            // 
            // Columnattribute
            // 
            this.Columnattribute.HeaderText = "课程属性";
            this.Columnattribute.Name = "Columnattribute";
            this.Columnattribute.ReadOnly = true;
            // 
            // Columnnature
            // 
            this.Columnnature.HeaderText = "课程性质";
            this.Columnnature.Name = "Columnnature";
            this.Columnnature.ReadOnly = true;
            // 
            // Columnoperate
            // 
            this.Columnoperate.HeaderText = "操作";
            this.Columnoperate.Name = "Columnoperate";
            this.Columnoperate.ReadOnly = true;
            // 
            // Courseachievement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(535, 247);
            this.Controls.Add(this.dataCourseachievement);
            this.Name = "Courseachievement";
            this.Text = "课程成绩查询";
            this.Load += new System.EventHandler(this.Courseachievement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCourseachievement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCourseachievement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnterm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columncourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columncoursemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columncredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columntime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnway;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnattribute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnnature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnoperate;
    }
}