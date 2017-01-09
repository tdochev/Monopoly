using System;
using Monopoly.Enums;
using Monopoly.Models;

namespace Monopoly
{
	public class Street : Property
	{
		private Color color;

		public Street(string name, Color color, int price, int mortgageValue, int rent) : base(name, price, mortgageValue, rent)
		{
			this.Color = color;
		}

		public Color Color
		{
			get
			{
				return this.color;
			}
			private set
			{
				this.color = value;
			}
		}
	}
}
