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
    public partial class Courseachievement : Form
    {
        public Courseachievement()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 课程成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Courseachievement_Load(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = Data.aql;

            Dao.dc = dao.Reader(sql);
            while (Dao.dc.Read())
            {
                dataCourseachievement.Rows.Add( Dao.dc[1].ToString(), Dao.dc[2].ToString(), Dao.dc[3].ToString(), Dao.dc[4].ToString(),Dao.dc[5].ToString(),
                    Dao.dc[6].ToString(), Dao.dc[7].ToString(), Dao.dc[8].ToString(), Dao.dc[9].ToString(), Dao.dc[10].ToString(), Dao.dc[11].ToString());
            }
        }

        private void dataCourseachievement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
