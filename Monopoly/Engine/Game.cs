using System;
using System.Collections.Generic;
using System.Linq;
using Monopoly.Contracts;
using Monopoly.Models;

namespace Monopoly.Engine
{
	public class Game
	{
		private IList<IPlayer> players;
		private IDice dice;
		private ILogger logger;

		public Game(IDice dice, ILogger logger, IEnumerable<IPlayer> playersToAdd)
		{
			this.players = new List<IPlayer>();
			this.dice = dice;
			this.logger = logger;

			this.Initialize(playersToAdd);
		}

		private void Initialize(IEnumerable<IPlayer> playersToAdd)
		{
			var playersTurn = new Dictionary<int, IPlayer>();
			int count = 0;
			logger.Log("The players are throwing dice to set the play order.");
			foreach (var player in playersToAdd)
			{
				
				//The players are throwing dice to decide the order of players 

				player.ThrowDice(dice);
				playersTurn[dice.FirstDice + dice.SecondDice] = player;
				count++;

				//TODO: move to global game messages
				logger.Log(string.Format("{0} threw {1} + {2}", player.Name, dice.FirstDice, dice.SecondDice));
			}
			logger.Log(Environment.NewLine);
			int distinctCount = playersTurn.Keys.Distinct().Count();

			if (count != distinctCount)
			{
				logger.Log("There are players with same dice!");
				//TODO: implement logic for the two players with same dice to Throw again
			}
			else
			{
				logger.Log("The players will take turn in the following order:");
				var ordered = playersTurn.OrderByDescending(x => x.Key).ToList();
				foreach (var pl in ordered)
				{
					this.players.Add(pl.Value);
					logger.Log(pl.Value.Name);

				}
				logger.Log(Environment.NewLine);
			}
		}

		public void Start()
		{
			while (this.players.Count > 0)
			{
				foreach (var plyr in this.players)
				{
					logger.Log(string.Format("It is {0}'s turn.",plyr.Name));
					System.Console.ReadLine();
				}
			}
		}
	}

}
