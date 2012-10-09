using System;

namespace Hello2.Infrastructure.MVC
{
	public interface IAppSetup
	{
		void SetupDependencies();
		void SetupControllers(AppControl app);
	}
}

