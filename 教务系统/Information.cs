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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
           

            this.labeluser.Text=Dao.Dc["Id"].ToString();
            this.textname.Text=Dao.Dc["Name"].ToString();
      

        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonyes_Click(object sender, EventArgs e)
        {
            Dao Dao2 = new Dao();
            Dao.dc=Dao.Dc;
            string s = $"update Table_user set Name='{this.textname.Text}',Securityissue1='{this.textproblem1.Text}', Securityissue2='{this.textproblem2.Text}',Answer1='{this.textanswer1.Text}',Answer2='{this.textanswer2.Text}' where Id='{Dao.Dc["Id"]}'";
            if (Dao2.Execute(s)>0)
            {
                MessageBox.Show($"更改完成！");

            }
            else MessageBox.Show("修改失败！");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonclear_Click(object sender, EventArgs e)
        {
            this.textanswer1.Text="";
            this.textanswer2.Text="";
            this.textproblem1.Text="";
            this.textproblem2.Text="";
            this.textname.Text=Dao.Dc["Name"].ToString();
        }
    }
}
