using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleXO
{
    class Program
    {
      static bool turn = true;
      static  char[,] board = new char[3, 3];
        static int counter=0;
        static bool turnCheck1=false;
        static bool turnCheck2 = false;
        static bool turnCheck3 = false;
        static bool turnCheck4 = false;
        static bool turnCheck5 = false;
        static bool turnCheck6 = false;
        static bool turnCheck7 = false;
        static bool turnCheck8 = false;
        static bool turnCheck9 = false;
        public static char Input(int num)
        {
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Please insert a number");
                Console.ReadKey();
            }
            if (num == 1 && turn) { if (!turnCheck1) { turnCheck1 = !turnCheck1; counter++; turn = !turn; return board[2, 0] = 'X'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            else if (num == 1 && !turn) { if (!turnCheck1) { turnCheck1 = !turnCheck1; counter++; turn = !turn; return board[2, 0] = 'O'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            if (num == 2 && turn) { if (!turnCheck2) { turnCheck2 = !turnCheck2; counter++; turn = !turn; return board[2, 1] = 'X'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            else if (num == 2 && !turn) { if (!turnCheck2) { turnCheck2 = !turnCheck2; counter++; turn = !turn; return board[2, 1] = 'O'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            if (num == 3 && turn) { if (!turnCheck3) { turnCheck3 = !turnCheck3; counter++; turn = !turn; return board[2, 2] = 'X'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            else if (num == 3 && !turn) { if (!turnCheck3) { turnCheck3 = !turnCheck3; counter++; turn = !turn; return board[2, 2] = 'O'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            if (num == 4 && turn) { if (!turnCheck4) { turnCheck4 = !turnCheck4; counter++; turn = !turn; return board[1, 0] = 'X'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            else if (num == 4 && !turn) { if (!turnCheck4) { turnCheck4 = !turnCheck4; counter++; turn = !turn; return board[1, 0] = 'O'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            if (num == 5 && turn) { if (!turnCheck5) { turnCheck5 = !turnCheck5; counter++; turn = !turn; return board[1, 1] = 'X'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            else if (num == 5 && !turn) { if (!turnCheck5) { turnCheck5 = !turnCheck5; counter++; turn = !turn; return board[1, 1] = 'O'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            if (num == 6 && turn) { if (!turnCheck6) { turnCheck6 = !turnCheck6; counter++; turn = !turn; return board[1, 2] = 'X'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            else if (num == 6 && !turn) { if (!turnCheck6) { turnCheck6 = !turnCheck6; counter++; turn = !turn; return board[1,2] = 'O'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            if (num == 7 && turn) { if (!turnCheck7) { turnCheck7 = !turnCheck7; counter++; turn = !turn; return board[0, 0] = 'X'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            else if (num == 7 && !turn) { if (!turnCheck7) { turnCheck7 = !turnCheck7; counter++; turn = !turn; return board[0, 0] = 'O'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            if (num == 8 && turn) { if (!turnCheck8) { turnCheck8 = !turnCheck8; counter++; turn = !turn; return board[0, 1] = 'X'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            else if (num == 8 && !turn) { if (!turnCheck8) { turnCheck8 = !turnCheck8; counter++; turn = !turn; return board[0, 1] = 'O'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            if (num == 9 && turn) { if (!turnCheck9) { turnCheck9 = !turnCheck9; counter++; turn = !turn; return board[0, 2] = 'X'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            else if (num == 9 && !turn) { if (!turnCheck9) { turnCheck9 = !turnCheck9; counter++; turn = !turn; return board[0,2] = 'O'; } else { Console.WriteLine("Illigal Move!"); Console.ReadKey(); return ' '; } }
            else
                return ' ';


        }
        public static void Winner()
        {
            if (counter == 9)
            {
                Console.WriteLine("It's a draw!");
                Console.ReadKey();
                Restart();
            }
            else
            {

                if ((board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] == 'X') ||
                    (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] == 'X') ||
                    (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] == 'X') ||
                    (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] == 'X') ||
                    (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] == 'X') ||
                    (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] == 'X') ||
                    (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] == 'X') ||
                    (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] == 'X')
                    )
                {
                    Console.WriteLine("X Wins!");
                    Console.ReadKey();
                    Restart();
                }
                else if ((board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] == 'O') ||
                  (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] == 'O') ||
                  (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] == 'O') ||
                  (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] == 'O') ||
                  (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] == 'O') ||
                  (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] == 'O') ||
                  (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] == 'O') ||
                  (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] == 'O')
                  )
                {
                    Console.WriteLine("O Wins!");
                    Console.ReadKey();
                    Restart();
                }
            }


        }
        static public void Restart()
        {
            turn = true;
            counter = 0;
            turnCheck1 = false;
            turnCheck2 = false;
            turnCheck3 = false;
            turnCheck4 = false;
            turnCheck5 = false;
            turnCheck6 = false;
            turnCheck7 = false;
            turnCheck8 = false;
            turnCheck9 = false;
            board[0, 0] = board[0, 1] = board[0, 2] = board[1, 0] = board[1, 1] = board[1, 2] = board[2, 0] = board[2, 1] = board[2, 2] = ' ';
            Console.Clear();
            Main();
        }
        static void Main(/*string[] args*/)
        {
             int num=0;

            while (true)
            {

                Console.WriteLine($" {board[0, 0]} | {board[0, 1]} | {board[0, 2]}");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" {board[1, 0]} | {board[1, 1]} | {board[1, 2]}");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" {board[2, 0]} | {board[2, 1]} | {board[2, 2]}");
                Winner();
                Input(num);
                Console.Clear();
            }
            


        }
    }
}
