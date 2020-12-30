using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models
{
    public class Deck
    {
        private List<Card> CardStack { get; set; }
        private List<Card> DrawnCards = new List<Card>();
        private Card CurrentCard { get; set; }
        
        public Deck()
        {
            CardStack = ShuffleCards(GenerateCards());
            CurrentCard = DrawCard();

        }

        public Deck(List<Card> cardStack)
        {
                 this.CardStack = ShuffleCards(cardStack);
                CurrentCard = DrawCard();            
        }

        public Card DrawCard()
        {
            Card drawnCard = CardStack.First();

            CardStack.Remove(drawnCard);

            DrawnCards.Add(drawnCard);

            return drawnCard;            
        }

        public void Reset()
        {
            CardStack = ShuffleCards(GenerateCards());
        }

        public List<Card> ViewCards()
        {
            return CardStack;
        }

        private List<Card> ShuffleCards(List<Card> initialDeck)
        {
            Random rand = new Random();
            List<Card> shuffledDeckList = new List<Card>();
            int deckLength = initialDeck.Count - 1;
            int randomIndex = rand.Next(0, deckLength);

            shuffledDeckList = Shuffle(initialDeck[randomIndex], randomIndex, shuffledDeckList, initialDeck.ToList());
          

            return shuffledDeckList;
        }

        //returns true when completed,
        private List<Card> Shuffle(Card randomCard,int randomIndex,List<Card> shuffledList,List<Card> originalDeck)
        {
            Random rand = new Random();

            bool isCardPresent = shuffledList.Find(card => card.CardImageName == randomCard.CardImageName) != null;
            if (!isCardPresent)
            {
                //add card to list reshuffle
                randomIndex = rand.Next(0, originalDeck.Count-1);
                randomCard = originalDeck[randomIndex];
                shuffledList = Shuffle(randomCard, randomIndex, shuffledList, originalDeck);
            }
            else
            {
                if(shuffledList.Count == originalDeck.Count)
                {
                    return shuffledList;
                }
            }

                return originalDeck;
        }

        private List<Card> GenerateCards()
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

            return generatedCardList;
        }
    }
}
