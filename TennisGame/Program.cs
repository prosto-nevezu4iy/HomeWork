using System;
using TennisGame.Models;
using TennisGame.Services;

namespace TennisGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Player()
            {
                Name = "player1"
            };

            var player2 = new Player()
            {
                Name = "player2"
            };

            var tennisGame = new TennisService(player1, player2);

            string[] pointsOrder = { "player1", "player2", "player2", "player2", "player1", "player1" };

            foreach (var playerName in pointsOrder)
            {
                tennisGame.WonPoint(playerName);
                tennisGame.GetScore();
            }
        }
    }
}
