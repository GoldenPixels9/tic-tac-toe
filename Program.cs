using System;
using System.Collections.Generic;

namespace Cse210Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool game_in_progress = true;
            List<string> game_board = new List<string>{"1", "2", "3", "4", "5", "6", "7", "8", "9"}; //creates the board

            display_board(game_board);
            while (game_in_progress) {
                Console.WriteLine("X's Turn - Please state the letter you would like to claim (A-I): ");
                string x_letter = Console.ReadLine();
                x_letter = x_letter.ToUpper();
                for (int i = 0; i < game_board.Count; i++) {
                    if (game_board[i] == x_letter) {
                        game_board[i] = "X";
                    }
                }
                display_board(game_board);

                Console.WriteLine("O's Turn - Please state the letter you would like to claim (A-I): ");
                string o_letter = Console.ReadLine();
                o_letter = o_letter.ToUpper();
                for (int i = 0; i < game_board.Count; i++) {
                    if (game_board[i] == o_letter) {
                        game_board[i] = "O";
                    }
                }
                display_board(game_board);

            }

            void display_board(List<string> game_board) {
                Console.WriteLine($"{game_board[0]} | {game_board[1]} | {game_board[2]}");
                Console.WriteLine("--+---+--");
                Console.WriteLine($"{game_board[3]} | {game_board[4]} | {game_board[5]}");
                Console.WriteLine("--+---+--");
                Console.WriteLine($"{game_board[6]} | {game_board[7]} | {game_board[8]}");
            }
        }
    }
}
