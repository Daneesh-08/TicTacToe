using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Arr = Board();
        }
        private static char[] Board()
        {
            char[] Arr = new char[10];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = ' ';
            }
            return Arr;
        }
    }
}
