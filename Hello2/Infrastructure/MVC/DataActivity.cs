using System;

namespace Hello2
{
	public interface IStateActivity<ViewModelType>
	{
		void Update(ViewModelType model); 

		// TODO: Set model, 
	}
}

