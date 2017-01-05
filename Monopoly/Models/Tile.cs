using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Monopoly.Contracts;
using Monopoly.Enums;

namespace Monopoly.Models
{
    public class Tile : ITile
    {

        private string name;
        private TileType tileType;

        public Tile(string name, TileType tileType)
        {
            this.Name = name;
            this.TileType = tileType;
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

        public TileType TileType
        {
            get
            {
                return this.tileType;
            }
            private set
            {
                this.tileType = value;
            }
        }
    }
}
