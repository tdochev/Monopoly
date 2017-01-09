using System;
namespace Monopoly
{
	//TODO: Implement singleton
	public class Dice
	{
		private int firstDice;
		private int secondDice;

		public Dice()
		{
		}

		public void Throw()
		{
			var rnd = new Random();
			this.FirtDice = rnd.Next(1, 7);
			this.SecondDice = rnd.Next(1, 7);
		}

		public int FirtDice
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
			set 
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
