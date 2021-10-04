using System;
using System.Collections.Generic;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {

    
            Console.WriteLine("Hello, please enter your name ");
            string name = Console.ReadLine();
            Console.Write("\nHi " + name+ "," + " Enter number and letter to play the game. n\n\n ");

           Console.Write("   1 2 3 4 5 6 7 8 9 10 \n");
           Console.Write("   -------------------- \n");
        
        for (char i = 'A'; i <= 'J'; i++)
        {
            Console.WriteLine(i + " |");
        }

        int minNum = 0;
        int maxNum = 10;
       

        Random randomNumber = new Random();

          int firstNumbers = randomNumber.Next(minNum, maxNum);
          int secondNumbers = randomNumber.Next(minNum, maxNum);
      
              Console.WriteLine(firstNumbers);
              Console.WriteLine(secondNumbers);

        }      

        class playing {
            
        }
                   int x = 0;
                   int y = 0;
                   public int Hitcount = 0;
                   public int Misscount = 0;
            public int getHitCount()
            {
            return Hitcount;
            }

            public int getMissCount()
            {
                    return Misscount;
            }



        public void AskInput(){


           
            Console.WriteLine("Enter first number ?");
            string Firstnum =  Console.ReadLine();
            int value;
            if(int.TryParse( Firstnum, out value))
            {
              x = value;       
            }
            else {
                Console.WriteLine("Wrong number");
            }

            Console.WriteLine("Enter second number");
            string secondNum = Console.ReadLine();
            if (int.TryParse( secondNum, out value))
            {
                y = value;
            }else {
                Console.WriteLine("Wrong number");
            }
            }

        }
    
    }
 
