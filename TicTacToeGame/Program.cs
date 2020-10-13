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
            Console.WriteLine( Arr[0] +"  |  "+ Arr[1] +  "  |  " + Arr[2]);             
            Console.WriteLine("--------------    ");
            Console.WriteLine(Arr[3] + "  |  " + Arr[4] + "  |  " + Arr[5]);
            Console.WriteLine("--------------    ");
            Console.WriteLine(Arr[6] + "  |  " + Arr[7] + "  |  " + Arr[8]);

        }
    }
}
