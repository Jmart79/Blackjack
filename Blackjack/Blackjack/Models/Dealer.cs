using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models
{
    public class Dealer
    {
        private int NumberOfDecks { get; set; }
        private List<Deck> DeckList { get; set; }
        private PointKeeper pointTracker { get; set; }

        public int GetStackValue()
        {
            pointTracker.UpdateValue(null);
            return pointTracker.Value;
        }
        public Card DistributeCard() { return null; }


    }
}
