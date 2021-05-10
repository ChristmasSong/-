using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 软件过程登录界面.Model
{
	interface UserDao
	{
		String findPassword(string id);
		User findUser(string id);
		bool exist(string id);
	}
}
