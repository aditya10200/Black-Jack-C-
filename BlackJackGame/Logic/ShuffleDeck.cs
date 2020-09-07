using BlackJackGame.Model;
using System;
using static BlackJackGame.Model.Card;

namespace BlackJackGame.Logic
{
    public class ShuffleDeck
    {
        Random cardRandom = new Random();

        public Player GetShuffleCards(Player player)
        {
            Player card = new Player();

            var randomRank = cardRandom.Next(1, 14);
            var randomSuit = cardRandom.Next(1, 4);

            switch (randomRank)
            {
                case (int)CardValue.Two:
                    card.Rank = "2"; player.Score += 2;
                    break;
                case (int)CardValue.Three:
                    card.Rank = "3"; player.Score += 3;
                    break;
                case (int)CardValue.Four:
                    card.Rank = "4"; player.Score += 4;
                    break;
                case (int)CardValue.Five:
                    card.Rank = "5"; player.Score += 5;
                    break;
                case (int)CardValue.Six:
                    card.Rank = "6"; player.Score += 6;
                    break;
                case (int)CardValue.Seven:
                    card.Rank = "7"; player.Score += 7;
                    break;
                case (int)CardValue.Eight:
                    card.Rank = "8"; player.Score += 8;
                    break;
                case (int)CardValue.Nine:
                    card.Rank = "9"; player.Score += 9;
                    break;
                case (int)CardValue.Ten:
                    card.Rank = "10"; player.Score += 10;
                    break;
                case (int)CardValue.Jack:
                    card.Rank = "J"; player.Score += 10;
                    break;
                case (int)CardValue.Queen:
                    card.Rank = "Q"; player.Score += 10;
                    break;
                case (int)CardValue.King:
                    card.Rank = "K"; player.Score += 10;
                    break;
                case (int)CardValue.Ace:
                    card.Rank = "A"; player.Score += 11;
                    break;
                default:
                    card.Rank = "2"; player.Score += 2;
                    break;
            }


            switch (randomSuit)
            {
                case (int)CardSuit.Hearts:
                    card.Suit = "H";
                    break;
                case (int)CardSuit.Spades:
                    card.Suit = "S";
                    break;
                case (int)CardSuit.Clubs:
                    card.Suit = "C";
                    break;
                case (int)CardSuit.Diamonds:
                    card.Suit = "D";
                    break;
                default:
                    card.Suit = "";
                    break;
            }


            player.Cards.Add(card);

            return player;
        }
    }
}
