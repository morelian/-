using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 教务系统
{
    public partial class Changepassword : Form
    {
        public Changepassword()
        {
            InitializeComponent();
        }

        private void Changepassword_Load(object sender, EventArgs e)
        {
            this.labeluser.Text=Dao.Dc["Id"].ToString();
            this.textoldcode.Text=Dao.Dc["Code"].ToString();

        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonyes_Click(object sender, EventArgs e)
        {
            if(this.textnewcode2.Text!=""/*&&this.textoldcode.Text==Dao.Dc["Code"].ToString()*/)
            { 
            if (this.textnewcode.Text==this.textnewcode2.Text)
            {


                if (Regex.IsMatch(this.textnewcode2.Text, "[0-9]")&&(Regex.IsMatch(this.textnewcode2.Text, "[a-z]")||Regex.IsMatch(this.textnewcode2.Text, "[A-Z]"))&&this.textnewcode2.Text.Length>=8)
                {

                    Dao dao = new Dao();
                        string s = $"update Table_user set Code='{this.textnewcode2.Text}' where Id='{this.labeluser.Text}'";
                        if (dao.Execute(s)>0)
                        {
                            MessageBox.Show($"更改完成！");

                        }
                        else MessageBox.Show("修改失败！");

                        Login login = new Login();
                        this.Hide();
                        login.ShowDialog();
                        this.Show();

                }
                else
                {
                    MessageBox.Show("密码设置格式有误请重新输入！");
                    this.textnewcode.Text="";
                    this.textnewcode2.Text="";

                }
            }
            else
            {
                MessageBox.Show("两次密码输入不同，请重新输入！");
                this.textnewcode.Text="";
                this.textnewcode2.Text="";
            }

        }
            else MessageBox.Show("请输入完整！");
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            this.textnewcode2.Text="";
            this.textnewcode.Text="";
        }
    }
}
