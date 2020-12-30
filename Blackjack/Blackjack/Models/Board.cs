using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models
{
    public class Board
    {
        private Dealer DealerObject { get; set; }
        private List<Player> PlayersList { get; set; }
        

        public Board(int numberOfPlayers)
        {
            Player tempPlayer;
            List<Card> playerHand;

            this.DealerObject = new Dealer(numberOfPlayers);
            for(int playerCounter = 0; playerCounter < numberOfPlayers; playerCounter++)
            {
                playerHand = new List<Card>();
                playerHand.Add(DealerObject.DistributeCard());
                tempPlayer = new Player(new Deck(playerHand));
                PlayersList.Add(tempPlayer);
            }
        }

        public void GameLoop() 
        {
            do
            {
                //Perform Game Logic here
                InitializeGame();
            } while (!IsGameOver());
        }
        private void InitializeGame() 
        {
            //This is where the user and dealer will be given their TWO cards EACH
            //The player gets 2 cards face up
            //The dealer gets 2 cards, One face up, One face down

            
            
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
