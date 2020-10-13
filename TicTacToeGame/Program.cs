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
            Arr = Move(Arr, Player);
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
            Console.WriteLine("\n");
            Console.WriteLine(Arr[1] +"  |  "+ Arr[2] +  "  |  " + Arr[3]);             
            Console.WriteLine("--------------    ");
            Console.WriteLine(Arr[4] + "  |  " + Arr[5] + "  |  " + Arr[6]);
            Console.WriteLine("--------------    ");
            Console.WriteLine(Arr[7] + "  |  " + Arr[8] + "  |  " + Arr[9]);
            Console.WriteLine("\n");
        }
        private static char[] Move(char[] Arr,char user)
        {
            
            while (true)
            {
                Console.WriteLine("Enter Position where you want to make your move from 1-9");
                int pos = Convert.ToInt32(Console.ReadLine());
                if (pos>9 || pos<1)
                {
                    Console.WriteLine("Array out of Index");
                    break;
                }
                else if (Arr[pos] == ' ' && pos >= 1 && pos <= 9)
                {
                    Arr[pos] = user;
                    break;
                }          
                else
                {
                    Console.WriteLine("Index not available !!");
                    break;
                }                   
            }
            return Arr;                   
        }        
    }
}
