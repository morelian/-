namespace 教务系统
{
    partial class Selectterm
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
            this.comboxterm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonenquire = new System.Windows.Forms.Button();
            this.eduadmsystemDBDataSet = new 教务系统.EduadmsystemDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.eduadmsystemDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboxterm
            // 
            this.comboxterm.FormattingEnabled = true;
            this.comboxterm.Items.AddRange(new object[] {
            "2021-2022-1",
            "2021-2022-2"});
            this.comboxterm.Location = new System.Drawing.Point(168, 101);
            this.comboxterm.Name = "comboxterm";
            this.comboxterm.Size = new System.Drawing.Size(121, 20);
            this.comboxterm.Sorted = true;
            this.comboxterm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "开课时间：";
            // 
            // buttonenquire
            // 
            this.buttonenquire.Location = new System.Drawing.Point(182, 196);
            this.buttonenquire.Name = "buttonenquire";
            this.buttonenquire.Size = new System.Drawing.Size(75, 23);
            this.buttonenquire.TabIndex = 2;
            this.buttonenquire.Text = "查询";
            this.buttonenquire.UseVisualStyleBackColor = true;
            this.buttonenquire.Click += new System.EventHandler(this.buttonenquire_Click);
            // 
            // eduadmsystemDBDataSet
            // 
            this.eduadmsystemDBDataSet.DataSetName = "EduadmsystemDBDataSet";
            this.eduadmsystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Selectterm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 278);
            this.Controls.Add(this.buttonenquire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboxterm);
            this.Name = "Selectterm";
            this.Text = "查询";
            ((System.ComponentModel.ISupportInitialize)(this.eduadmsystemDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EduadmsystemDBDataSet eduadmsystemDBDataSet;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox comboxterm;
        internal System.Windows.Forms.Button buttonenquire;
    }
}