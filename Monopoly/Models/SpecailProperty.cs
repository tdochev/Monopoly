using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Monopoly.Contracts;
using Monopoly.Enums;
using Monopoly.Common;

namespace Monopoly.Models
{
    public abstract class SpecailProperty : Tile, ISpecialProperty
    {
        private Player owner;

        public SpecailProperty(string name, TileType tileType) :base(name, tileType)
        {

        }

        public int MortgageValue
        {
            get
            {
                return PropertyConstants.STATION_MORTGAGE_VALUE;
            }
        }

        public Player Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                this.owner = value;
            }
        }

        public int Price
        {
            get
            {
                return PropertyConstants.STATION_PRICE;
            }
        }

        public int Rent
        {
            get
            {
                return PropertyConstants.STATION_RENT;
            }
        }
    }
}
