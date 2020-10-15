﻿using System;
using System.Text;

namespace TicTacToe
{
    class Program
    {
        private static char Player;
        private static char Comp;
        private static int Toss;
        private static bool Bool = true;
        const int HEADS = 0;
        static void Main(string[] args)
        {
            char[] Arr = Board();
            Player = ChooseLetter();
            Comp = (Player == 'X')? 'O' : 'X';       
            Console.WriteLine("Player chose '" + Player + "'");
            Console.WriteLine("Computer chose '" + Comp+"'");
            DisplayBoard(Arr);
            CheckWhoPlaysFirst();
            char CurrentSymbol = (Toss == HEADS)? Player : Comp;
            Arr = Move(Arr, CurrentSymbol);
            DisplayBoard(Arr);
            Console.WriteLine("Check if Game is Won : " + IsWinner(Arr, Player));
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
            while (Bool == true)
            {
                Console.WriteLine("Enter Position where you want to make your move from 1-9");
                int pos = Convert.ToInt32(Console.ReadLine());
                if (pos>9 || pos<1)
                {
                    Console.WriteLine("Array out of Index");
                    Console.WriteLine("Press Y to Try Again ");
                    char Y = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                    Bool = (Y == 'Y') ? true : false;
                }                              
                else if (Arr[pos] == ' ' && pos >= 1 && pos <= 9)
                {
                    Arr[pos] = user;
                    break;
                }                                              
                else
                {
                    Console.WriteLine("Index not available !!");
                    Console.WriteLine("Press Y to Try Again ");
                    char Y = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                    Bool = (Y == 'Y') ? true : false;
                }                 
            }
            return Arr;                   
        }        
        private static void CheckWhoPlaysFirst()
        {
            Console.WriteLine("\n");
            Random random = new Random();
            Toss = random.Next(0, 2);
            if (Toss == HEADS)
                Console.WriteLine("Player moves First");
            else
                Console.WriteLine("Computer moves First");
            Console.WriteLine("\n");
        }
        private static bool IsWinner(char[] b, char ch)
        {
            return ((b[1] == ch && b[2] == ch && b[3] == ch) ||
                (b[4] == ch && b[5] == ch && b[6] == ch) ||
                (b[7] == ch && b[8] == ch && b[9] == ch) ||
                (b[1] == ch && b[4] == ch && b[7] == ch) ||
                (b[2] == ch && b[5] == ch && b[8] == ch) ||
                (b[3] == ch && b[6] == ch && b[9] == ch) ||
                (b[1] == ch && b[5] == ch && b[9] == ch) ||
                (b[7] == ch && b[5] == ch && b[3] == ch));
        }
    }
}