using Blackjack.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models
{
    public class Card
    {
        public bool IsFaceUp { get; set; } = false;
        public string CardName { get; set; }
        public string CardImageName { get; set; }
        private string BackOfCardImageName = "~/Images/CardBacks/red_back.png";

        public Card(string cardName, string cardImageName)
        {
            this.CardName = cardName;
            this.CardImageName = cardImageName;
        }
    }
}
