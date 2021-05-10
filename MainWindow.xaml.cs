using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using 软件过程登录界面.Model;

namespace 软件过程登录界面
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void MoveWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			DragMove();
		}

		private void Close_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string userId = textBox_userId.Text;
			string userPassword = passwordBox_userPassword.Password;
			LoginComputer login = new LoginComputer();
			bool flag = login.LoginIn(userId, userPassword);
			Console.WriteLine(flag);
			if (flag)
			{
				MessageBox.Show("登录成功");
			}
			else
			{
				MessageBox.Show("登录失败");
			}
		}
	}
}
