using System;
using System.Collections.Generic;

namespace Cse210Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            int tie_counter = 0;
            bool game_in_progress = true; //declares the starting boolean for in game while loop
            List<string> game_board = new List<string>{"7", "8", "9", "4", "5", "6", "1", "2", "3"}; //creates the board

            display_board(game_board); // displays the beginning board
            while (game_in_progress) { // starts the game
                // X's turn
                Console.Write("X's Turn - Please state the number you would like to claim (1-9): "); //prompt the user
                string x_letter = Console.ReadLine(); //gets and stores user input
                tie_counter = tie_counter + 1; //increments the tie counter for a possible nine moves
                Console.WriteLine(); //new line
                x_letter = x_letter.ToUpper(); //makes user input a capital letter
                for (int i = 0; i < game_board.Count; i++) { //for loop that loops through game board to replace the user letter with X
                    if (game_board[i] == x_letter) {
                        game_board[i] = "X";
                    }
                }
                
                bool x_won = victory_check(game_board); // uses the victory check function to see if the X has won the game, then
                if (x_won) {                            // assigns it to a bool. If X has won, break from the loop. 
                    game_in_progress = false;
                    display_board(game_board);
                    Console.WriteLine("X won the Game!");
                    break;
                } 

                if (tie_counter >= 9){ //checks to see if the tie counter has reached it's limit, if it has, end the game. 
                    game_in_progress = false;
                    display_board(game_board);
                    Console.WriteLine("The game is a tie!");
                    break;
                }
                
                display_board(game_board); //displays board

                // O's turn
                Console.Write("O's Turn - Please state the number you would like to claim (1-9): ");
                string o_letter = Console.ReadLine(); //reads the user input
                tie_counter = tie_counter + 1; //increments the tie counter for a possible nine moves
                Console.WriteLine(); //makes new line
                o_letter = o_letter.ToUpper(); //auto corrects user input to a capital letter
                for (int i = 0; i < game_board.Count; i++) {
                    if (game_board[i] == o_letter) {
                        game_board[i] = "O";
                    }
                }
                bool o_won = victory_check(game_board); // uses the victory check function to see if the O has won the game, then
                if (o_won) {                            // assigns it to a bool. If O has won, break from the loop.
                    game_in_progress = false;
                    display_board(game_board);
                    Console.WriteLine("O won the Game!");
                    break;
                }

                if (tie_counter >= 9){ //checks to see if the tie counter has reached its limit, if it has, end the game. 
                    game_in_progress = false;
                    display_board(game_board);
                    Console.WriteLine("The game is a tie!");
                    break;
                }

                display_board(game_board); //displays board

            }

            static void display_board(List<string> game_board) { //this function dispalys the board, according to the num pad on keyboard.
                Console.WriteLine($"{game_board[0]} | {game_board[1]} | {game_board[2]}");
                Console.WriteLine("--+---+--");
                Console.WriteLine($"{game_board[3]} | {game_board[4]} | {game_board[5]}");
                Console.WriteLine("--+---+--");
                Console.WriteLine($"{game_board[6]} | {game_board[7]} | {game_board[8]}");
            }

             static bool victory_check(List<string> gb) { //this function goes through the different line positions for a winning player. 
                for (int i = 0; i < gb.Count; i++) {
                    if (gb[0] == gb[1] && gb[0] == gb[2]) // horizontal win position 1
                        return true;
                    if (gb[3] == gb[4] && gb[3] == gb[5]) // horizontal win position 2
                        return true;
                    if (gb[6] == gb[7] && gb[6] == gb[8]) // horizontal win position 3
                        return true;
                    if (gb[0] == gb[3] && gb[0] == gb[6]) // vertical win position 1
                        return true;
                    if (gb[1] == gb[4] && gb[1] == gb[7]) // vertacil win position 2
                        return true;
                    if (gb[2] == gb[5] && gb[2] == gb[8]) // vertical win position 3 
                        return true;
                    if (gb[0] == gb[4] && gb[0] == gb[8]) // diagonal win position 1
                        return true;
                    if (gb[2] == gb[4] && gb[2] == gb[6]) // diagonal win position 1
                        return true;
                }
                return false; //if none of the winning positions are reached, return false. Current player doesn't win. 
            }
        }
    }
}
