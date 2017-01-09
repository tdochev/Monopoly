using System;
using System.Collections.Generic;

using Monopoly.Contracts;
using Monopoly.Common;

namespace Monopoly.Models
{
    public class Player : IPlayer
    {
        int money;
        string name;
        IList<IProperty> properties;

        public Player(string name)
        {
            this.properties = new List<IProperty>();
            this.money = GameConstants.INITIAL_PLAYER_MONEY;
            this.Name = name;
        }

        public int Money
        {
            get
            {
                return this.money;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

		public void BuyProperty(IProperty property)
        {
            this.money -= property.Price;
            this.properties.Add(property);
        }

        public List<IProperty> Properties
        {
            get
            {
                return new List<IProperty>(properties);
            }
        }

        public bool IsInJail { get; set; }

        public void MortgageProperty()
        {
            throw new NotImplementedException();
        }

		public void PlayTurn()
        {
            throw new NotImplementedException();
        }

        public void SellProperty()
        {
            throw new NotImplementedException();
        }

		public void ThrowDice(IDice dice)
		{
			dice.Throw();
		}
    }
}