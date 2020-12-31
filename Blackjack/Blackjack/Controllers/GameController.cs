using Blackjack.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Controllers
{
    public class GameController : Controller
    {
        private Board gameBoard { get; set; }

        [HttpPost]
        public IActionResult InitiateGame([FromForm] int numberOfPlayers)
        {
            gameBoard = new Board(numberOfPlayers);

            return null;
        }

        [HttpPost]
        public IActionResult PlayerStand()
        {
            return null;
        }

        [HttpPost]
        public IActionResult PlayerHit()
        {
            return null;
        }




    }
}
