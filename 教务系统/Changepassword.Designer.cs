namespace 教务系统
{
    partial class Changepassword
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
            this.buttonyes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textoldcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.textnewcode = new System.Windows.Forms.TextBox();
            this.textnewcode2 = new System.Windows.Forms.TextBox();
            this.buttonclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonyes
            // 
            this.buttonyes.Location = new System.Drawing.Point(104, 202);
            this.buttonyes.Name = "buttonyes";
            this.buttonyes.Size = new System.Drawing.Size(103, 29);
            this.buttonyes.TabIndex = 0;
            this.buttonyes.Text = "保存";
            this.buttonyes.UseVisualStyleBackColor = true;
            this.buttonyes.Click += new System.EventHandler(this.buttonyes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "登陆账号：";
            // 
            // textoldcode
            // 
            this.textoldcode.Location = new System.Drawing.Point(175, 60);
            this.textoldcode.Name = "textoldcode";
            this.textoldcode.PasswordChar = '*';
            this.textoldcode.Size = new System.Drawing.Size(156, 21);
            this.textoldcode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "旧密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "新密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "确认新密码：";
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Location = new System.Drawing.Point(227, 27);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(53, 12);
            this.labeluser.TabIndex = 6;
            this.labeluser.Text = "登陆账号";
            // 
            // textnewcode
            // 
            this.textnewcode.Location = new System.Drawing.Point(175, 103);
            this.textnewcode.Name = "textnewcode";
            this.textnewcode.PasswordChar = '*';
            this.textnewcode.Size = new System.Drawing.Size(156, 21);
            this.textnewcode.TabIndex = 7;
            // 
            // textnewcode2
            // 
            this.textnewcode2.Location = new System.Drawing.Point(175, 141);
            this.textnewcode2.Name = "textnewcode2";
            this.textnewcode2.PasswordChar = '*';
            this.textnewcode2.Size = new System.Drawing.Size(156, 21);
            this.textnewcode2.TabIndex = 8;
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(252, 202);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(103, 29);
            this.buttonclear.TabIndex = 9;
            this.buttonclear.Text = "重置";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // Changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 274);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.textnewcode2);
            this.Controls.Add(this.textnewcode);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoldcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonyes);
            this.Name = "Changepassword";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.Changepassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonyes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoldcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.TextBox textnewcode;
        private System.Windows.Forms.TextBox textnewcode2;
        private System.Windows.Forms.Button buttonclear;
    }
}