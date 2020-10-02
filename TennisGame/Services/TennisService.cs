using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TennisGame.Enums;
using TennisGame.Interfaces;
using TennisGame.Models;

namespace TennisGame.Services
{
    public class TennisService : IGame
    {
        private readonly Player[] _players;

        public TennisService(Player player1, Player player2)
        {
            _players = new Player[] { player1, player2 };
        }

        public void GetScore()
        {
            var leadingPlayerScore = _players.First().Score;
            var lastPlayerName = _players.Last().Name;

            foreach (var player in _players)
            {
                Console.Write(player.Score);
                if (player.Name != lastPlayerName)
                {
                    Console.Write(" : ");
                }
                else
                {
                    Console.WriteLine();
                }

                if (leadingPlayerScore < player.Score)
                {
                    leadingPlayerScore = player.Score;
                }
            }

            var leadingPlayers =
                _players.Where(p => p.Score == leadingPlayerScore).ToList();

            if (leadingPlayers.Count() > 1)
            {
                Console.WriteLine("Draw!");
            }
            else
            {
                Console.WriteLine($"{leadingPlayers.First().Name} has advantage!");
            }
        }

        public void WonPoint(string playerName)
        {
            var player = _players.SingleOrDefault(p => p.Name == playerName);

            if(player != null)
            {
                player.Score += 1;
            }
        }
    }
}
