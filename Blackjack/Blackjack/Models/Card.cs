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
        public bool IsAce { get; set; }
        public string CardName { get; set; }
        public string CardImageName { get; set; }
        public int CardValue { get; set; }
        private string BackOfCardImageName = "~/Images/CardBacks/red_back.png";

        public Card(string cardName, string cardImageName)
        {
            this.CardName = cardName;
            this.CardValue = GenerateValue();
            this.CardImageName = cardImageName;
        }

        private int GenerateValue()
        {
            string[] nameContents = CardName.Split("S|D|C|H");
            /***
             * Using the fact that the png files are named in a specific convention, I split the name into an array seperated by its suit identifier
             * Once the array is created I assign the first segment, the value segment to the valueSubstring variable.
             */
            string valueSubstring = nameContents[0];
            int value = 0;

            switch (valueSubstring)
            {
                case "A":
                    value = 1;
                    IsAce = true;
                    break;
                case "2":
                    value = 2;
                    break;
                case "3":
                    value = 3;
                    break;
                case "4":
                    value = 4;
                    break;
                case "5":
                    value = 5;
                    break;
                case "6":
                    value = 6;
                    break;
                case "7":
                    value = 7;
                    break;
                case "8":
                    value = 8;
                    break;
                case "9":
                    value = 9;
                    break;
                default:
                    value = 10;
                    break;
            }
            return value;
        }
    }
}
