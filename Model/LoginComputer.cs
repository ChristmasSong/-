using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 软件过程登录界面.Model
{
	class LoginComputer
	{
		private int idCoumputer;
		private User user;
		private UserDaoImpl userDaoImpl;

		public LoginComputer()
		{
			userDaoImpl = new UserDaoImpl();
		}

		public bool LoginIn(string id, string password)
		{
			user = userDaoImpl.findUser(id);
			if (user == null)
				return false;
			return checkAccount(id, password);
		}

		private bool checkAccount(string id, string password)
		{
			return password == userDaoImpl.findPassword(id);
		}
	}
}
