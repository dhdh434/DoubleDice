using System;

namespace DoubleDice
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare Variables
            string input = "";
            int numRolls = 0;
            int diceTotal = 0;
            int sumDice = 0;
            int[] freq = new int[10];
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            int counter6 = 0;
            int counter7 = 0;
            int counter8 = 0;
            int counter9 = 0;
            int counter10 = 0;
            int counter11 = 0;
            int counter12 = 0;

            //put the starting words and collect input
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine();
            Console.WriteLine("How many times would you like to roll the dice simulator?");
            input = Console.ReadLine();
            numRolls = int.Parse(input);
            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \" * \" represents 1 % of the total number of rolls.");
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Total number of rolls = " + numRolls);

            //create array
            int[] numbers = new int[numRolls];


            //set the dice and roll the dice and keep track of the counts
            for (int i = 0; i < numRolls; i++){
                Dice myDice1 = new Dice(); // refers to classes
                Dice myDice2 = new Dice();
                diceTotal = myDice1.roll + myDice2.roll;
                numbers[i] = diceTotal;
                //Console.Write(numbers[i] + ", ");
                sumDice += numbers[i];

                if (diceTotal == 2)
                {
                    counter2 += 1;
                }
                else if (diceTotal == 3)
                {
                    counter3 += 1;
                }
                else if (diceTotal == 4)
                {
                    counter4 += 1;
                }
                else if (diceTotal == 5)
                {
                    counter5 += 1;
                }
                else if (diceTotal == 6)
                {
                    counter6 += 1;
                }
                else if (diceTotal == 7)
                {
                    counter7 += 1;
                }
                else if (diceTotal == 8)
                {
                    counter8 += 1;
                }
                else if (diceTotal == 9)
                {
                    counter9 += 1;
                }
                else if (diceTotal == 10)
                {
                    counter10 += 1;
                }
                else if (diceTotal == 11)
                {
                    counter11 += 1;
                }
                else if (diceTotal == 12)
                {
                    counter12 += 1;
                }
            }
            Console.WriteLine();

            //Display counters
            //Console.WriteLine("counter 2: " + counter2);
            //Console.WriteLine("counter 3: " + counter3);
            //Console.WriteLine("counter 4: " + counter4);
            //Console.WriteLine("counter 5: " + counter5);
            //Console.WriteLine("counter 6: " + counter6);
            //Console.WriteLine("counter 7: " + counter7);
            //Console.WriteLine("counter 8: " + counter8);
            //Console.WriteLine("counter 9: " + counter9);
            //Console.WriteLine("counter 10: " + counter10);
            //Console.WriteLine("counter 11: " + counter11);
            //Console.WriteLine("counter 11: " + counter12);



            //calculate percentages
            double percent = 0;
            double fraction = 0;
            double numRollsReplace = numRolls;
            Console.Write("2:  ");
            fraction = (counter2 / numRollsReplace) * 100;
            percent = Math.Round(fraction);

            //display the patterns with these things: **
            for (int i = 0; i < percent; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.Write("3:  ");
            fraction = (counter3 / numRollsReplace) * 100;
            percent = Math.Round(fraction);
            for (int i = 0; i < percent; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.Write("4:  ");
            fraction = (counter4 / numRollsReplace) * 100;
            percent = Math.Round(fraction);
            for (int i = 0; i < percent; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.Write("5:  ");
            fraction = (counter5 / numRollsReplace) * 100;
            percent = Math.Round(fraction);
            for (int i = 0; i < percent; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.Write("6:  ");
            fraction = (counter6 / numRollsReplace) * 100;
            percent = Math.Round(fraction);
            for (int i = 0; i < percent; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.Write("7:  ");
            fraction = (counter7 / numRollsReplace) * 100;
            percent = Math.Round(fraction);
            for (int i = 0; i < percent; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.Write("8:  ");
            fraction = (counter8 / numRollsReplace) * 100;
            percent = Math.Round(fraction);
            for (int i = 0; i < percent; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.Write("9:  ");
            fraction = (counter9 / numRollsReplace) * 100;
            percent = Math.Round(fraction);
            for (int i = 0; i < percent; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.Write("10: ");
            fraction = (counter10 / numRollsReplace) * 100;
            percent = Math.Round(fraction);
            for (int i = 0; i < percent; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.Write("11: ");
            fraction = (counter11 / numRollsReplace) * 100;
            percent = Math.Round(fraction);
            for (int i = 0; i < percent; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.Write("12: ");
            fraction = (counter12 / numRollsReplace) * 100;
            percent = Math.Round(fraction);
            for (int i = 0; i < percent; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            //its the end buddy
            Console.WriteLine();
            Console.WriteLine("THE END");



        }
    }
}
