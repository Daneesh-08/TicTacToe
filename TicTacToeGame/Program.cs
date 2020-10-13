using System;

namespace TicTacToe
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] Arr = Board();
        }
        static char[] Board()
        {
            char[] Arr = new char[10];
            for (int i = 0; i < 10; i++)
            {
                Arr[i] = ' ';
            }
            return Arr;
        }
    }
}
