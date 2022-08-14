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
    public partial class Studentstatuscard : Form
    {
        public Studentstatuscard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Studentstatuscard_Load(object sender, EventArgs e)
        {
            this.labelname.Text=Dao.Dc["Name"].ToString();
            labelsex.Text=Dao.Dc["Sex"].ToString();
            labelMajor.Text=Dao.Dc["Major"].ToString();
            labeltelephone.Text=Dao.Dc["Telephone"].ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
