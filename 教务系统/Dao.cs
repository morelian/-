using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 教务系统
{
    
    internal class Dao
    {
        /// <summary>
        /// 登入用
        /// </summary>
       public static IDataReader  Dc;
        /// <summary>
        /// 查找用
        /// </summary>
        public static IDataReader dc;
        SqlConnection Sc;
        public SqlConnection Connect()
        {
            //数据库链接字符串
            string Str = @"Data Source = DESKTOP-RK89C0A; Initial Catalog= EduadmsystemDB;Integrated Security=True";
            
             Sc = new SqlConnection(Str);//创建数据库链接对象
            Sc.Open();//打开数据库
            return Sc;//返回数据库连接对象
        }

        public SqlCommand Command(string sql)
        {
            SqlCommand Command = new SqlCommand(sql, Connect());
            return Command;
        }
        public int Execute(string sql)//修改
        {
            return Command(sql).ExecuteNonQuery();
        }
        public SqlDataReader Reader(string sql)//读取
        {
            return Command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            Sc.Close();//关闭数据连接
        }
    }
}
