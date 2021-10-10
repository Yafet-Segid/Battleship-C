using System;


namespace c_
{
    class BattleBoard
    {
     


                public void DisplayBoard(char[,] Board)
        {
            int Row;
            int Column;
 
            Console.WriteLine("  ¦ 0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("--+--------------------");
            for (Row = 0; Row <= 9; Row++)
            {
                Console.Write((Row).ToString() + " ¦ ");
                for (Column = 0; Column <= 9; Column++)
                {
                    Console.Write(Board[Column, Row] + " ");
                }
                Console.WriteLine();
            }
 
            Console.WriteLine("\n");
        }
    }
     

        class playing 
        {
            char[,] Grid = new char[10, 10];
            public int Hitcount = 0;
            public int Misscount = 0;
            int x = 0;
            int y = 0;
            
            public int getHitCount()
            {
                 return Hitcount;
            }

            public int getMissCount()
            {
                 return Misscount;
            }
            public void AskInput(){   

            Console.WriteLine("Enter vertical number ?");
            string Firstnum =  Console.ReadLine();
            int value;
            if(int.TryParse( Firstnum, out value))
            {
              x = value;       
            }
            else {
                Console.WriteLine("Wrong number");
            }

            Console.WriteLine("Enter horizontal number ?");
            string secondNum = Console.ReadLine();
            if (int.TryParse(secondNum, out value))
            {
                y = value;

            }else {
                Console.WriteLine("Wrong number");
            }

            try{
                int counts = 0;
                           

                if (Grid[x, y].Equals(' '))
                {
                    Grid[x, y] = 'X';
                    counts++;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue ;
                    Console.WriteLine(" Hit \r\n");
                     Console.ResetColor();
                    Hitcount += 1;
                }
                else
                {            
                    Grid[x, y] = 'O';
                     Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Miss \r\n");
                    Console.ResetColor();                                    
                    Misscount += 1;
                    
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black ;
                Console.BackgroundColor = ConsoleColor.Yellow ;
                Console.WriteLine(" Error: Please enter number between 0 and 9 \r\n");
                Console.ResetColor();
            }
                }

        public char[,] GetGrid()
        {
            return Grid;
        }
        public void SetGrid(int q, int w)
        {
            Grid[q, w] = ' ';
        }
        public void Randomize()
        {
            // test 
 
            Random r = new Random(2);
            //
            SetGrid(1, 2);
            SetGrid(2, 2);
            SetGrid(3, 2);
            ///
            SetGrid(4, 3);
            SetGrid(4, 4);
            SetGrid(4, 5);
 
            SetGrid(5, 0);
            SetGrid(6, 0);
            SetGrid(7, 0);
         
            SetGrid(7, 4);
            SetGrid(7, 5);
            SetGrid(7, 6);
            SetGrid(7, 7);
            SetGrid(7, 8);
        }
 
    }  

      class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter your name ");
            string name = Console.ReadLine();
            Console.Write("\nHi " + name+ "," + " Enter horizontal and vertical numbers to play the game. n\n\n ");


            BattleBoard b = new BattleBoard();
            playing p = new playing();
           p.Randomize();
           while (p.getHitCount() < 17)
           {
               b.DisplayBoard(p.GetGrid());
               p.AskInput();
           }

        //    Console.WriteLine("Congrats you win!");
        //    Console.WriteLine("you missed: "+ p.getMissCount() + " times");
        //    Console.WriteLine("Please press enter to quite");
        //    System.Console.ReadLine();
        }      

    }
    
    
}
