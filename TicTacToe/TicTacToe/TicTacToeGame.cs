using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class TicTacToeGame
    {
        public static void CreateBoard()
        {
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            arr[1] = ' ';
            arr[2] = ' ';
            arr[3] = ' ';
            arr[4] = ' ';
            arr[5] = ' ';
            arr[6] = ' ';
            arr[7] = ' ';
            arr[8] = ' ';
            arr[9] = ' ';


        }
        public static void ChooseOption()
        {
            char player;// computer;
            char x = 'X';
            char o = 'O';
            Console.WriteLine("Enter Option X or O");
            player = Console.ReadKey().KeyChar;
           
            if (player =='x')
            {
              Console.WriteLine("player choice :"+x );
                Console.WriteLine("computer choice :"+o);

            }
            else if(player =='o')
            {  
                Console.WriteLine("player choice {0},computer choise {1}", +o, +x);
            }
            else
            {
                Console.WriteLine("invalid");
            }

            
        }
    }
}
