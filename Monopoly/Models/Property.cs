using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Monopoly.Contracts;
using Monopoly.Enums;

namespace Monopoly.Models
{
    public class Property : Tile, IProperty
    {
        Color color;
        int mortgageValue;
        int price;
        int rent;

        public Property(string name, Color color, int price, int mortgageValue, int rent) :base(name, TileType.Property)
        {
            this.color = color;
            this.mortgageValue = mortgageValue;
            this.price = price;
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

        public int MortgageValue
        {
            get
            {
                return this.mortgageValue;
            }
            private set
            {
                this.mortgageValue = value;
            }
        }

        public Player Owner
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }

        public int Rent
        {
            get
            {
                return this.rent;
            }
            private set
            {
                this.rent = value;
            }
        }
    }
}
