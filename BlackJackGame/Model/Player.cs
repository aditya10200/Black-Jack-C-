using System.Collections;
using System.Collections.Generic;
using static BlackJackGame.Model.Card;
namespace BlackJackGame.Model
{
    public class Player:Card
    {
        
        public int Score { get; set; }
        public string Name { get; set; }
       public List<Card> Cards { get; set; }
        public string Result { get; set; }
    }
}
