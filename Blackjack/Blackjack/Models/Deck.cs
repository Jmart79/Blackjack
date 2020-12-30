using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models
{
    public class Deck
    {
        private Card[] CardStack { get; set; }
        
        public Deck()
        {
            CardStack = ShuffleCards(GenerateCards());

        }

        public Deck(Card[] cardStack)
        {
            if(cardStack.Length == 52)
            {
                 this.CardStack = cardStack;
            }
        }

        private Card[] ShuffleCards(Card[] initialDeck)
        {
            return null;
        }

        private Card[] GenerateCards()
        {
            string[] fileEntries = Directory.GetFiles("~/Images/CardFronts");
            List<Card> generatedCardList = new List<Card>();
            Card placeholderCard;
            foreach(string fileEntry in fileEntries)
            {
                string[] fileNameContents = fileEntry.Split(".");
                placeholderCard = new Card(fileNameContents[0], fileEntry);
                generatedCardList.Add(placeholderCard);
            }

            return generatedCardList.ToArray();
        }
    }
}
