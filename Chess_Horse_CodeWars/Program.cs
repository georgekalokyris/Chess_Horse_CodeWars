using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Horse_CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChessKnight("g6"));



        }

        public static int ChessKnight(string cell)
        {
            char[] letters = new char[8] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            
            int x = int.Parse(cell.Substring(1,1));
            int y = 0;
            //a1 is equivalent to x = 1 and y = 1
            for (int i = 0; i < 8; i++)
            {
                if (letters[i] == cell[0]) { y = i ; break; }
                else continue;
            }

            return x;
           
            //return Program.Check(x, y);
        }

        public static int Check(int x, int y)
        {
            int num = 0;

            int[] block = new int[4] {-2, -1, 1, 2 };

            //[-1,  -2] 1
            if (x - 1 > 0 && y - 2 > 0) num++;

            //[-2,  -1] 2
            if (x - 2 > 0 && y - 1 > 0) num++;
           
            //[-2,   1] 3
            if (x - 2  > 0 && y + 1> 0 && y + 1 <=8) num++;
          
            //[-1,   2] 4
            if (x - 1  > 0 && y + 2 > 0 && y + 2 <=8) num++;
           
            //[1,    2] 5
            if (x + 1 > 0 && y + 2 > 0 && x + 1<=8 && y+2 <=8) num++;
            
            //[2,    1] 6
            if (x + 2 > 0 && y + 1 > 0 && x + 2<=8 && y+1 <=8) num++;
           
            //[2,   -1] 7 
            if (x + 2 > 0 && y - 1 > 0 && x+2 <=8) num++;
            
            //[1,   -2] 8
            if (x + 1 > 0 && y - 2 > 0 && x+1 <=8) num++;

            return num;

        }


    }
}
