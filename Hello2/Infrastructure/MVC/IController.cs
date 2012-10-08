using System;

namespace Hello2.Infrastructure.MVC
{
	public interface IController
	{
		string Navigate(string[] path);
	}
}

