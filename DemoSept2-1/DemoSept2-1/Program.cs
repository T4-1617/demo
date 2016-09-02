using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSept2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "A", "B", "C" };
            int[] i = { 1, 2, 54, 32, 8 };

            Console.WriteLine(s.Length);
            Console.WriteLine(i.Length);

            Console.WriteLine(s[2]);
            Console.WriteLine(i[2] + i[3]);

            Console.WriteLine("Skriv din mening:");
            string text = Console.ReadLine();
            string[] Text = text.Split(' ');

            Console.WriteLine("Det finns {0} st ord i din mening", Text.Length);

            for (int j = 0; j < Text.Length; j++)
            {
                Console.WriteLine(Text[j]);
            }

            string[,] MoreText = { { "A", "B" }, { "AA", "BB" } };

            Console.WriteLine(MoreText[0, 0]); //A
            Console.WriteLine(MoreText[0, 1]); //B
            Console.WriteLine(MoreText[1, 0]); //AA
            Console.WriteLine(MoreText[1, 1]); //BB

            //Sänka skepp...typ

            //Spelplan
            //Båtarna kan endast vara 1 ruta stora
            //Antal båtar
            //Spela genom att spelaren anger en koordinat
            //Träff eller miss
            //Fortsätt tills alla båtar har hittats

            //7x5 dvs 0-6 och 0-4
            bool[,] GameMap = new bool[7, 5];

            //Fyll spelplanen med startvärden, dvs false = inga båtar
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    GameMap[x, y] = false;
                }
            }

            //Placera ut några båtar på spelplanen
            GameMap[2, 3] = true;
            GameMap[6, 4] = true;
            GameMap[0, 4] = true;



            //Vi testar att skriva ut hela spelplanen
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    string p;
                    if (GameMap[x, y] == true)
                    {
                        p = " X ";
                    }
                    else
                    {
                        p = " O ";
                    }
                    //Console.Write(GameMap[x, y]); 
                    Console.Write(p);
                }
                Console.WriteLine();
            }






            Random r = new Random();
            int Boats = 3;
            while (Boats > 0)
            {
                int x = r.Next(0, 7);
                int y = r.Next(0, 5);

                if (GameMap[x,y]==true)
                {
                    Console.WriteLine("Hit at {0},{1}",x,y);
                    GameMap[x, y] = false;
                    Boats--;
                }
            } 
            
        }
    }
}
