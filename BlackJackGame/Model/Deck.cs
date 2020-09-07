using BlackJackGame.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame.Model
{
    class Deck
    {
        private static List<Player> _players;

       
        public void Started()
        {
            var isHouseLost = false;

            Console.WriteLine("How Many Players(1-7)? : ");

            _players = new List<Player>();
            Player _house = new Player();
            DealDeck dealDeck = new DealDeck();
            ShuffleDeck shuffleDeck = new ShuffleDeck();
            dealDeck.setPlayerTotal();
            int totalPlayers = dealDeck.getPlayerTotal();
            Player[] playerArray = new Player[totalPlayers];

            for (var i = 0; i < totalPlayers; i++)
            {
                Console.WriteLine("Enter Player Name : ");

                Player player = new Player
                {
                    Name = Console.ReadLine()
                };



                player.Cards = new List<Card>();
                player = shuffleDeck.GetShuffleCards(player);

                player = shuffleDeck.GetShuffleCards(player);

                playerArray[i] = player;
            }


            foreach (var v in playerArray)
            {
                var print = v.Name + " : " + v.Cards[0].Rank + v.Cards[0].Suit + " " +
                            v.Cards[1].Rank + v.Cards[1].Suit + " -- " + v.Score;

                Console.WriteLine("\n" + print + "\n");
            }

            _house.Cards = new List<Card>();

            _house = shuffleDeck.GetShuffleCards(_house);

            _house = shuffleDeck.GetShuffleCards(_house);

            var printMessage = "House : " + _house.Cards[0].Rank + _house.Cards[0].Suit + " " +
                                   _house.Cards[1].Rank + _house.Cards[1].Suit;

            Console.WriteLine("\n" + printMessage);


            for (var i = 0; i < playerArray.Length; i++)
            {
                if (playerArray[i].Score > 21)
                {
                    playerArray[i].Result = "Loses";
                    continue;
                }

                var cardIndex = playerArray[i].Cards.Count - 1;

                var message = "Do you want a card (y/n)?";
                Console.WriteLine(playerArray[i].Name + "  " + message);

                var reponse = Console.ReadLine();

                while (reponse.Equals("y"))
                {


                    playerArray[i] = shuffleDeck.GetShuffleCards(playerArray[i]);

                    var print = playerArray[i].Name + " : " + playerArray[i].Cards[cardIndex].Rank + playerArray[i].Cards[cardIndex].Suit + " " +
                                    " -- " + playerArray[i].Score;

                    Console.WriteLine("\n" + print + "\n");

                    if (playerArray[i].Score > 21)
                    {
                        break;
                    }

                    message = "Do you want a card? (y/n)";
                    Console.WriteLine(playerArray[i].Name + "  " + message);

                    reponse = Console.ReadLine();

                }
                if (reponse.Equals("n"))
                {
                    continue;
                }
            }




            _house = shuffleDeck.GetShuffleCards(_house);

            printMessage = "House : " + _house.Cards[0].Rank + _house.Cards[0].Suit + " " +
                                    _house.Cards[1].Rank + _house.Cards[1].Suit + " " +
                                    _house.Cards[2].Rank + _house.Cards[2].Suit;

            if (_house.Score > 21)
            {
                isHouseLost = true;
                printMessage = printMessage + "-- bust !";
            }


            Console.WriteLine("\n" + printMessage + "\n");

            foreach (var v in playerArray)
            {
                if (isHouseLost && v.Score < 22)
                {
                    v.Result = "Wins!";
                }
                else if (!isHouseLost && v.Score > _house.Score)
                {
                    v.Result = "Wins!";
                }
                else
                    v.Result = "Loses!";

                Console.WriteLine(v.Name + "\t" + v.Result);
            }

            var messageEnd = "\n\n Do you want to continuing Playing (y/n) : ";
            Console.WriteLine(messageEnd);

            var reponseInput = Console.ReadLine();

            if (reponseInput.Equals("y"))
            {
                Console.WriteLine("\n\n");
                Started();
            }
        }



    }
}
