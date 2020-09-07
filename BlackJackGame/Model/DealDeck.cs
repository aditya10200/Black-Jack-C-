using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame.Model
{
    class DealDeck
    {
        private static int totalPlayers = 0;
        public void setPlayerTotal()
        {

            var totalPlayer = Console.ReadLine();

            var isDigit = IsDigitsOnly(totalPlayer);
            while (!isDigit)
            {
                totalPlayer = Console.ReadLine();
                isDigit = IsDigitsOnly(totalPlayer);
            }


            if (totalPlayer != null)
                totalPlayers = int.Parse(totalPlayer);

        }

        static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        public int getPlayerTotal()
        {
            return totalPlayers;
        }
    }
}
