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
    public partial class Finduser : Form
    {
        public Finduser()
        {
            InitializeComponent();
        }
        Dao dao = new Dao();
        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Affirm_Click(object sender, EventArgs e)
        {
            if (this.textname.Text!=""&&this.textcode.Text!=""&&this.textcode2.Text!="")
            {
                if (this.textcode.Text==this.textcode2.Text)
                {

                    //string str = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890";
               
                    if (Regex.IsMatch(this.textcode2.Text,"[0-9]")&&(Regex.IsMatch(this.textcode2.Text, "[a-z]")||Regex.IsMatch(this.textcode2.Text, "[A-Z]"))&&this.textcode2.Text.Length>=8)
                    {

                        


                        Dao dao = new Dao();
                        string sql = "Select*from Table_user where Id='"+textname.Text+"'";

                        Dao.Dc = dao.Reader(sql);
                        if (Dao.Dc.Read())
                        {
                            //MessageBox.Show(Dao.Dc[0].ToString()+ Dao.Dc["Name"].ToString());
                            //MessageBox.Show("更改完成！");

                            string s = $"update Table_user set Code='{this.textcode.Text}' where Id='{this.textname.Text}'";
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
                        else MessageBox.Show("用户不存在！");
                    }
                    else
                    {
                        MessageBox.Show("密码设置格式有误请重新输入！");
                        this.textcode.Text="";
                        this.textcode2.Text="";

                    }
                }
                else
                {
                    MessageBox.Show("两次密码输入不同，请重新输入！");
                    this.textcode.Text="";
                    this.textcode2.Text="";
                }
                
            }
            else MessageBox.Show("请输入完整！");
        }
        /// <summary>
        /// 找回密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Finduser_Load(object sender, EventArgs e)
        {
        

        }
    }
}
