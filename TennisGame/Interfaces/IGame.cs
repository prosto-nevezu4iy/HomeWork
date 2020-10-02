using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGame.Interfaces
{
    public interface IGame
    {
        void WonPoint(string playerName);
        void GetScore();
    }
}
