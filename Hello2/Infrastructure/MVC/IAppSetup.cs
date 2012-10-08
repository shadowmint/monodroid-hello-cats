using System;

namespace Hello2.Infrastructure.MVC
{
	public interface IAppSetup
	{
		void SetupDependencies(AppControlFactory factory);
		void SetupControllers(Controllers controllers);
	}
}

