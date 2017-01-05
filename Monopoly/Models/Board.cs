using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Monopoly.Contracts;
using Monopoly.Enums;

namespace Monopoly.Models
{
    public static class Board
    {
        private static readonly ITile[] tiles =
        {
            new Tile("Start", TileType.Chance),
            new Property("Mediterranean Avenue", TileType.Property, Color.Brown, 60)
        };

        public static ITile GetTileAt(int index)
        {
            return tiles[index];
        }
    }
}
