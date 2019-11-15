using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferTracker.ViewModels
{
	public class LoginViewModel : Screen
	{
		private string _userName;
		private string _password;

		public string UserName
		{
			get { return _userName; }
			set
			{
				_userName = value;
				NotifyOfPropertyChange(() => UserName);
				NotifyOfPropertyChange(() => CanLogIn);
			}
		}

		public string Password
		{
			get { return _password; }
			set
			{
				_password = value;
				NotifyOfPropertyChange(() => Password);
				NotifyOfPropertyChange(() => CanLogIn);
			}
		}

		public bool CanLogIn
		{
			get
			{
				bool result = false;
				if (_userName?.Length > 0 && _password?.Length > 0)
				{
					result = true;
				}
				return result;
			}
		}

		public void LogIn()
		{
			Console.WriteLine();
		}

	}
}
