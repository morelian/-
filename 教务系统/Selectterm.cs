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
    public partial class Selectterm : Form
    {
        public Selectterm()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// 选学期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonenquire_Click(object sender, EventArgs e)
        {
    

            if (this.comboxterm.SelectedIndex==0)
            {

                Data.aql="Select*from TScore where Id='"+Dao.Dc["Id"].ToString()+" '"+"and Term='2021-2022-1'";
                Courseachievement c = new Courseachievement();
              
                c.TopLevel=false;
                Login.user.panelscore.Controls.Clear();
                Login.user.panelscore.Controls.Add(c);
                Login.user.panelscore.Controls.Add(this);
                this.Show();
                c.Show();



            }
            else if (this.comboxterm.SelectedIndex==1)
            {
                Data.aql="Select*from TScore where Id='"+Dao.Dc["Id"].ToString()+" '"+"and Term='2021-2022-2'";
                Courseachievement c = new Courseachievement();
               
                c.TopLevel=false;
                Login.user.panelscore.Controls.Clear();
                Login.user.panelscore.Controls.Add(c);
                Login.user.panelscore.Controls.Add(this);
                this.Show();
                c.Show();
                
            }
            
        }
    }
}
