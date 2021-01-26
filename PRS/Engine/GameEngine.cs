using System;
using System.Collections.Generic;
using System.Text;

namespace PRS.Engine
{
    public class GameEngine
    {
        private int playerCount;
        public GameEngine(int players)
        {
            playerCount = players;
        }

        public string Throw(string Choice)
        {
            return "";
        }

        public void AddPlayer()
        {
            playerCount = playerCount + 1;
        }

        public int GetPlayerCount()
        {
            return playerCount; 
        }

        private int CalculateComputerChoice()
        {
            return new Random().Next(0, 3);
        }
    }
}
