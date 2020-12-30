using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models
{
    public class Player
    {
        private Deck PlayerDeck { get; set; }
        private List<Card> PlayerCardStack { get; set; }
        public int ValueOfCards { get; set; }
        public Player(Deck playerDeck)
        {
            this.PlayerDeck = playerDeck;
            this.PlayerCardStack = PlayerDeck.ViewCards();
            ValueOfCards = GatherValue(PlayerCardStack);
        }


        public void AddCard(Card newCard)
        {
            if (PlayerCardStack.FirstOrDefault(card => card.CardImageName == newCard.CardImageName) == null)
            {
                PlayerCardStack.Add(newCard);
                PlayerDeck = new Deck(PlayerCardStack);
            }
        }

        private int GatherValue(List<Card> playerCardStack)
        {
            int totalValue = 0;
            foreach(Card playerCard in playerCardStack)
            {
                
            }
            return totalValue;
        }

    }
}
