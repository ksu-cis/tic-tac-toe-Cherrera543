﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TicTacToe.Pages
{
    public class TicTacToeModel : PageModel
    {
        public char[,] Board { get; } = new char[3, 3];
        public void OnGet()
        {
            Board[0, 0] = 'X';
        }
    }
}