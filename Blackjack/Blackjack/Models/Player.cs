﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models
{
    public class Player
    {
        private Deck PlayerDeck { get; set; }
        private List<Card> PlayerCardStack { get; set; }
        public HandTracker handTracker { get; set; }

        public Player(Deck playerDeck)
        {
            this.PlayerDeck = playerDeck;
            this.PlayerCardStack = PlayerDeck.ViewCards();
            this.handTracker = new HandTracker(PlayerCardStack);
        }

        public void AddCard(Card newCard)
        {
            if (PlayerCardStack.FirstOrDefault(card => card.CardImageName == newCard.CardImageName) == null)
            {
                PlayerCardStack.Add(newCard);
                PlayerDeck = new Deck(PlayerCardStack);

                handTracker.UpdateValue(PlayerCardStack);
            }
        }

        public int GetStackValue()
        {
            handTracker.UpdateValue(PlayerCardStack);
            return handTracker.Value;
        }

    }
}
