using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Monopoly.Contracts;
using Monopoly.Models;

namespace Monopoly
{
    class Startup
    {

        static void Main()
        {
            Console.WriteLine(Board.GetTileAt(1).Name);
            IPlayer goshoPlayer = new Player("Gosho");
            goshoPlayer.BuyProperty((IProperty)Board.GetTileAt(1));
            Console.WriteLine(goshoPlayer.Money);
            Console.WriteLine(goshoPlayer.Properties[0].TileType);

        }
    }
}
