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
        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public TileType TileType
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
