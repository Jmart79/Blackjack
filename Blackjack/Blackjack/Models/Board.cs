using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models
{
    public class Board
    {
        public Dealer DealerObject { get; set; }
        public List<Player> PlayersList { get; set; }
        

        public Board(int numberOfPlayers)
        {
            Player tempPlayer;
            List<Card> playerHand;

            this.DealerObject = new Dealer(numberOfPlayers);
            for(int playerCounter = 0; playerCounter < numberOfPlayers; playerCounter++)
            {
                playerHand = new List<Card>();
                playerHand.Add(DealerObject.DistributeCard());
                playerHand.Add(DealerObject.DistributeCard());
                tempPlayer = new Player(new Deck(playerHand));
                PlayersList.Add(tempPlayer);
            }
        }

  
        private void PlayerTurn()
        {
          
        }
        private void DealerTurn() { }
        private void Hit(Dealer dealer = null, Player player = null) { }
        private void Stand() { }

        private bool IsGameOver() { return false; }

    }
}
