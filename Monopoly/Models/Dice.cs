using System;
namespace Monopoly.Models
{
	//TODO: Implement singleton
	public class Dice : IDice
	{
		private int firstDice;
		private int secondDice;

		public Dice()
		{
		}

		public void Throw()
		{
			var rnd = new Random();
			this.FirstDice = rnd.Next(1, 7);
			this.SecondDice = rnd.Next(1, 7);
		}

		public int FirstDice
		{
			get 
			{
				return this.firstDice;
			}
			private set 
			{
				ValidateDice(value);
				this.firstDice = value;
			}
		}

		public int SecondDice
		{
			get 
			{
				return this.secondDice;
			}
			private set 
			{
				ValidateDice(value);
				this.secondDice = value;
			}
		}

		//TODO: move to static validator class
		private void ValidateDice(int value)
		{
			if (value < 1 || value > 6)
			{
				throw new IndexOutOfRangeException();
			}
		}
	}
}
