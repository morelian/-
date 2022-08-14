using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教务系统
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 静态窗口
        /// </summary>
        public static UserUI user=new UserUI();
        /// <summary>
        /// 登入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (textUsername.Text!=""&&textCode.Text!="")
            {

                Dao dao = new Dao();
                string sql = "Select*from Table_user where Id='"+textUsername.Text+"'and Code='"+textCode.Text+" '";
             
                 Dao.Dc = dao.Reader(sql);
                if (Dao.Dc.Read())
                {


                    //MessageBox.Show(Dao.Dc[0].ToString()+ Dao.Dc["Name"].ToString());
                    MessageBox.Show("登入成功！");
                    user.tabControl1.SelectedIndex=0;
                    user.paneldesk.Controls.Clear();
                    user.panelexam.Controls.Clear();
                    user.panelJudge.Controls.Clear();
                    user.panelpractical.Controls.Clear();
                    user.panelscore.Controls.Clear();
                    user.panelTraining.Controls.Clear();
                    user.labelname.Text= Dao.Dc["Name"].ToString();
                    user.labelnum.Text=  Dao.Dc["Id"].ToString();
                    this.Hide();
                    user.ShowDialog();
                    
                  
                    this.Show();
                }
                else MessageBox.Show("账号或者密码错误！");
            }
            else if(textUsername.Text==""&&textCode.Text!="")
            {
                MessageBox.Show("请输入用户名！");
            }
            else if (textUsername.Text!=""&&textCode.Text=="")
            {
                MessageBox.Show("请输入密码！");
            }
            else MessageBox.Show("请输入用户名和密码！");

        }
        /// <summary>
        /// 找回密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFindCode_Click(object sender, EventArgs e)
        {
            Finduser find = new Finduser();
            this.Hide();
            find.ShowDialog();
            this.Show();


        }

        private void textCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
