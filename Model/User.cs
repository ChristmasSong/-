using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 软件过程登录界面.Model
{
	class User
	{
		private String id;
		private String password;

		public string Id { get => id; set => id = value; }
		public string Password { get => password; set => password = value; }
	}
}
