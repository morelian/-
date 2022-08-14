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
    public partial class UserUI : Form
    {
        public UserUI()
        {
            InitializeComponent();
        }

     /// <summary>
     /// 已收公告
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>
        private void labelboard_Click(object sender, EventArgs e)
        {

            Board board = new Board();

            board.TopLevel=false;
            paneldesk.Controls.Clear();
            paneldesk.Controls.Add(board);
            board.Show();



        }
        /// <summary>
        /// 已收留言
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelmessage_Click(object sender, EventArgs e)
        {

            Message me = new Message();
            me.TopLevel=false;
            paneldesk.Controls.Clear();
            paneldesk.Controls.Add(me);
            me.Show();

        }


        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelchangecode_Click(object sender, EventArgs e)
        {
            Changepassword c = new Changepassword();
            c.TopLevel=false;
            paneldesk.Controls.Clear();
            paneldesk.Controls.Add(c);
            c.Show();
        }

        private void labelname_Click_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 修改个人信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelinformination_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.TopLevel=false;
            paneldesk.Controls.Clear();
            paneldesk.Controls.Add(information);
            information.Show();
        }
        /// <summary>
        /// 教学计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelteaching_Click(object sender, EventArgs e)
        {
            Teachingprogram t = new Teachingprogram();
            t.TopLevel=false;
            paneldesk.Controls.Clear();
            paneldesk.Controls.Add(t);
            t.Show();
        }
        /// <summary>
        /// 课程成绩查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelcourseachievement_Click(object sender, EventArgs e)
        {

            Selectterm s = new Selectterm();
            s.TopLevel=false;
            panelscore.Controls.Clear();
            panelscore.Controls.Add(s);
            s.Show();
            
           

        }



        /// <summary>
        /// 学籍卡片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelstudentstatuscard_Click(object sender, EventArgs e)
        {
            Studentstatuscard s = new Studentstatuscard();
            s.TopLevel=false;
            panelscore.Controls.Clear();
            panelscore.Controls.Add(s);
            s.Show();
        }
        /// <summary>
        /// 教学周历
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label9_Click(object sender, EventArgs e)
        {
            Schooltimetable s = new Schooltimetable();
            s.TopLevel=false;
            panelTraining.Controls.Clear();
            panelTraining.Controls.Add(s);
            s.Show();
        }

        private void Exam_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 学期理论课表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelexaminquiry_Click(object sender, EventArgs e)
        {
            Examinquiry o = new Examinquiry();
            o.TopLevel=false;
            panelexam.Controls.Clear();
            panelexam.Controls.Add(o);
            o.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panelTraining_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelscore_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 实习信息查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelinterm_Click(object sender, EventArgs e)
        {
            Intern n = new Intern();
            n.TopLevel=false;
            panelpractical.Controls.Clear();
            panelpractical.Controls.Add(n);
            n.Show();
        }
        /// <summary>
        /// 我的评教
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelevaluation_Click(object sender, EventArgs e)
        {
            Teachingevaluation t = new Teachingevaluation();
            t.TopLevel=false;
            panelJudge.Controls.Clear();
            panelJudge.Controls.Add(t);
            t.Show();
        }
        /// <summary>
        /// 课程成绩查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelschooltimetable_Click(object sender, EventArgs e)
        {
            Schooltimetable s = new Schooltimetable();
            s.TopLevel=false;
            panelTraining.Controls.Clear();
            panelTraining.Controls.Add(s);
            s.Show();
        }
        /// <summary>
        /// 学生成绩查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttoncourseachievement_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex=2;

            Selectterm s = new Selectterm();
            s.TopLevel=false;
            panelscore.Controls.Clear();
            panelscore.Controls.Add(s);
            s.Show();

        }
        /// <summary>
        /// 教学周历
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonteachingcalender_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex=1;
            Schooltimetable s = new Schooltimetable();
            s.TopLevel=false;
            paneldesk.Controls.Clear();
            paneldesk.Controls.Add(s);
            s.Show();
        }
        /// <summary>
        /// 授课计划查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonteachingplaninquiry_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex=3;
            Examinquiry o = new Examinquiry();
            o.TopLevel=false;
            panelTraining.Controls.Clear();
            panelTraining.Controls.Add(o);
            o.Show();
        }

        /// <summary>
        /// 选课中心
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonselectcourse_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex=3;
            Selectcourse s = new Selectcourse();
            s.TopLevel=false;
            panelTraining.Controls.Clear();
            panelTraining.Controls.Add(s);
            s.Show();
        }
        /// <summary>
        /// 学生选课中心
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelselectcourse_Click(object sender, EventArgs e)
        {
            Selectcourse s = new Selectcourse();
            s.TopLevel=false;
            panelTraining.Controls.Clear();
            panelTraining.Controls.Add(s);
            s.Show();
        }
        /// <summary>
        /// 考试成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex=2;
            Selectterm s = new Selectterm();
            s.TopLevel=false;
            panelscore.Controls.Clear();
            panelscore.Controls.Add(s);
            s.Show();
        }
        /// <summary>
        /// 执行计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelplan_Click(object sender, EventArgs e)
        {
            Keeptotheplan k = new Keeptotheplan();
            k.TopLevel=false;
            panelTraining.Controls.Clear();
            panelTraining.Controls.Add(k);
            k.Show();
        }
        /// <summary>
        /// 培养方案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonplan_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex=3;
            Keeptotheplan k = new Keeptotheplan();
            k.TopLevel=false;
            panelTraining.Controls.Clear();
            panelTraining.Controls.Add(k);
            k.Show();
        }
        /// <summary>
        /// 学生评教
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonevaluate_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex=6;
            Teachingevaluation t = new Teachingevaluation();
            t.TopLevel=false;
            panelJudge.Controls.Clear();
            panelJudge.Controls.Add(t);
            t.Show();

        }
        /// <summary>
        /// 已收留言
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonmessage_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex=1;
            Message me = new Message();
            me.TopLevel=false;
            paneldesk.Controls.Clear();
            paneldesk.Controls.Add(me);
            me.Show();
        }

        /// <summary>
        /// 已收公告
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonboard_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex=1;
            Board board = new Board();

            board.TopLevel=false;
            paneldesk.Controls.Clear();
            paneldesk.Controls.Add(board);
            board.Show();
        }
        /// <summary>
        /// 学籍卡片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonstudentstatuscard_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex=1;
            Studentstatuscard s = new Studentstatuscard();
            s.TopLevel=false;
            paneldesk.Controls.Clear();
            paneldesk.Controls.Add(s);
            s.Show();
        }
        /// <summary>
        /// 社会考试报名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelexamregistration_Click(object sender, EventArgs e)
        {
            Socialexaminationregistration s = new Socialexaminationregistration();
            s.TopLevel=false;
            panelexam.Controls.Clear();
            panelexam.Controls.Add(s);
            s.Show();

        }
        /// <summary>
        /// 社会考试报名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonsocialexam_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex=4;
            Socialexaminationregistration s = new Socialexaminationregistration();
            s.TopLevel=false;
            panelexam.Controls.Clear();
            panelexam.Controls.Add(s);
            s.Show();

        }

        private void UserUI_Load(object sender, EventArgs e)
        {

        }
    }
}
