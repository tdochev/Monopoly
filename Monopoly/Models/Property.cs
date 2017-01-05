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
        public Property(string name, TileType tileType):base(name, tileType)
        {
                
        }

        public Color Color
        {
            get
            {
                throw new NotImplementedException();
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
                throw new NotImplementedException();
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
