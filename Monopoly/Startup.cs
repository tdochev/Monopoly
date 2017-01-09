using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Monopoly.Contracts;
using Monopoly.Engine;
using Monopoly.Models;

namespace Monopoly
{
    class Startup
    {

        static void Main()
        {
			var players = new List<IPlayer>();
            IPlayer goshoPlayer = new Player("Gosho");
			IPlayer peshoPlayer = new Player("Pesho");
			players.Add(goshoPlayer);
			players.Add(peshoPlayer);

			IDice dice = new Dice();
			ILogger logger = new ConsoleLogger();

			var game = new Game(dice,logger,players);
			game.Start();
        }
    }
}
