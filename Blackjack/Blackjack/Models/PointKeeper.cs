using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models
{
    public class PointKeeper
    {
        public int Value { get; set; }

        public PointKeeper(List<Card> playerCardStack)
        {
            Value = GatherValue(playerCardStack);
        }

        public void UpdateValue(List<Card> playerCardStack)
        {
            Value = GatherValue(playerCardStack);
        }

        public int GatherValue(List<Card> playerCardStack)
        {
            int totalValue = 0;
            foreach (Card playerCard in playerCardStack)
            {
                totalValue += playerCard.CardValue;
            }
            return totalValue;
        }
    }
}
