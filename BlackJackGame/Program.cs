using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackGame.Logic;
using BlackJackGame.Model;

namespace BlackJackGame
{
    class Program
    {
        private static List<Player> _players;

        private static int totalPlayers = 0;

        static void Main(string[] args)
        {
            Console.Title = "Let's Play Blackjack!";
            Console.WriteLine("Welcome to Blackjack");
            Deck deck = new Deck();
            deck.Started();
            Console.ReadKey();

        }

    }
}
