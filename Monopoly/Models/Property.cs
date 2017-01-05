using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Monopoly.Contracts;
using Monopoly.Enums;

namespace Monopoly.Models
{
    class Property : Tile, IProperty
    {
        Color color;
        int price;

        public Property(string name, TileType tileType, Color color, int price):base(name, tileType)
        {
            this.color = color;
            this.price = price;
        }

        public Color Color
        {
            get
            {
                throw new NotImplementedException();
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
                throw new NotImplementedException();
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
                throw new NotImplementedException();
            }
        }
    }
}
