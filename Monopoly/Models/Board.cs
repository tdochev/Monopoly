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
        private static Tile[] tiles =
        {
            new Tile("Start", TileType.Chance)
        };

        public static Tile GetTileAt(int index)
        {
            return tiles[index];
        }
    }
}
