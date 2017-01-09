using System;
namespace Monopoly
{
	public interface IDice
	{

		void Throw();

		int FirstDice 
		{
			get;
		}

		int SecondDice
		{
			get;
		}

	}
}
