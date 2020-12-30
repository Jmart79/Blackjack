using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models
{
    public class Dealer
    {
        private int NumberOfDecks { get; set; }
        private List<Deck> DecksList { get; set; }
        private List<Card> DealerCardStack { get; set; }
        private Deck DealerHand { get; set; }
        private Deck CurrentDeck { get; set; }
        private HandTracker handTracker { get; set; }

        public Dealer(int numberOfDecks)
        {
            DecksList = new List<Deck>();
            Deck temporaryDeck;
            for(int numberOfDecksCounter = 0; numberOfDecksCounter < numberOfDecks; numberOfDecksCounter++)
            {
                temporaryDeck = new Deck();
                DecksList.Add(temporaryDeck);
                
            }
            CurrentDeck = DecksList.First();
            DealerCardStack = CurrentDeck.ViewCards();

            //This draws the first two cards and assigns them to the dealers hand
            List<Card> dealerHandList = new List<Card>();
            Card faceDownCard = DistributeCard();
            faceDownCard.IsFaceUp = false;
            dealerHandList.Add(faceDownCard);
            dealerHandList.Add(DistributeCard());

            DealerHand = new Deck(dealerHandList);
        }

        public Deck GetDeck()
        {
            return CurrentDeck;
        }

        public int GetStackValue()
        {
            handTracker.UpdateValue(null);
            return handTracker.Value;
        }

        public Card DistributeCard()
        {
            Card drawnCard = CurrentDeck.DrawCard();
            return drawnCard;
        }


    }
}
