using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 软件过程登录界面.Model
{
	class BaseDao
	{
		private static String driver = "com.mysql.jdbc.Driver";
		private static String url = "jdbc:mysql://127.0.0.1:3306/epet";
		private static String user = "root";
		private static String password = "root";

		public static void getConnection()
		{

		}
	}

}
