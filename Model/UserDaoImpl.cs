using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 软件过程登录界面.Model
{
	class UserDaoImpl : UserDao
	{
		public bool exist(string id)
		{
			return id.Equals("3170212030");
		}

		public string findPassword(string id)
		{
			if (exist(id))
				return "123456";
			else
				return "";
		}

		public User findUser(string id)
		{
			if (exist(id))
				return new User();
			else
				return null;
		}
	}
}
