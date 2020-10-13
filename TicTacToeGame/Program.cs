using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Arr = Board();
            char Player = ChooseLetter();
            char Comp;
            if (Player == 'X')           
                Comp = 'O';
            else
                Comp = 'X';
            Console.WriteLine("Player chose " + Player);
            Console.WriteLine("Computer chose " + Comp);
            DisplayBoard(Arr);
        }
        public static char[] Board()
        {
            char[] Arr = new char[10];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = ' ';
            }
            return Arr;
        }
        private static char ChooseLetter()
        {     
            while (true)
            {
                Console.WriteLine("Choose 'X' or 'O' ");
                char choice = Convert.ToChar(Console.ReadLine());
                choice = Char.ToUpper(choice);
                if (choice == 'X' || choice == 'O')
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid Input !!");
                }
            }
            
        }
        private static void DisplayBoard(char[] Arr)
        {
            Console.WriteLine(Arr[1] +"   |  "+ Arr[2] +  "  |  " + Arr[3]);             
            Console.WriteLine("--------------    ");
            Console.WriteLine(Arr[4] + "  |  " + Arr[5] + "  |  " + Arr[6]);
            Console.WriteLine("--------------    ");
            Console.WriteLine(Arr[7] + "  |  " + Arr[8] + "  |  " + Arr[9]);

        }
    }
}
