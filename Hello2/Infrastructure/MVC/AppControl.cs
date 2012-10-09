using System;

namespace Hello2.Infrastructure.MVC
{
	public class AppControl
	{
		/** 
		 * Attach controllers using a path like "blah.blah.{0}"
		 * <p>
		 * Any controller can be bound multiple times to different generic routes.
		 * When the controller is invoked for a path like "{0}.blah.{1}", the 
		 * arguments passed to the controller are [{0}, {1}].
		 */
		public void Attach<T>(T controller, string path) where T : IController {
		}
		
		/** Attempts to navigate to a new controller */
		public void Navigate(string path) {
			
			// Find the controller, invoke the controller action
			
			// Check if we have a match for that activity already
			
			// If so, update that activity
		}
	}
}

