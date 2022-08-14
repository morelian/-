namespace 教务系统
{
    partial class Finduser
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
            this.Affirm = new System.Windows.Forms.Button();
            this.textname = new System.Windows.Forms.TextBox();
            this.textcode = new System.Windows.Forms.TextBox();
            this.textcode2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // Affirm
            // 
            this.Affirm.Location = new System.Drawing.Point(189, 193);
            this.Affirm.Name = "Affirm";
            this.Affirm.Size = new System.Drawing.Size(52, 31);
            this.Affirm.TabIndex = 1;
            this.Affirm.Text = "确认";
            this.Affirm.UseVisualStyleBackColor = true;
            this.Affirm.Click += new System.EventHandler(this.Affirm_Click);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(189, 49);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(88, 21);
            this.textname.TabIndex = 2;
            // 
            // textcode
            // 
            this.textcode.Location = new System.Drawing.Point(189, 92);
            this.textcode.Name = "textcode";
            this.textcode.PasswordChar = '*';
            this.textcode.Size = new System.Drawing.Size(88, 21);
            this.textcode.TabIndex = 3;
            // 
            // textcode2
            // 
            this.textcode2.Location = new System.Drawing.Point(189, 129);
            this.textcode2.Name = "textcode2";
            this.textcode2.PasswordChar = '*';
            this.textcode2.Size = new System.Drawing.Size(88, 21);
            this.textcode2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "确认密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(134, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "密码必须八位且必须包含数字、字母";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(290, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "必填";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(290, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "必填";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(290, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "必填";
            // 
            // Finduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 281);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textcode2);
            this.Controls.Add(this.textcode);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.Affirm);
            this.Controls.Add(this.label1);
            this.Name = "Finduser";
            this.Text = "找回密码";
            this.Load += new System.EventHandler(this.Finduser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Affirm;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textcode;
        private System.Windows.Forms.TextBox textcode2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}