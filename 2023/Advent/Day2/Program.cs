using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var inputProv = new InputProvider();

            var listOfGames = inputProv.Read();


            var redThresh = 12;

            var blueThresh = 14;

            var greenThresh = 13;

            var idTotal = 0;

            var powerTotal = 0;

            foreach(var game in listOfGames)
            {
                var ok = true;
                var highestRed = 0;
                var highestBlue = 0;
                var highestGreen = 0;


                foreach(var round in game.GameRounds)
                {
                    if(round.Red > redThresh || round.Blue > blueThresh || round.Green > greenThresh)
                    {
                        ok = false;
                    }

                    if(round.Red > highestRed)
                    {
                        highestRed = round.Red;
                    }

                    if (round.Blue > highestBlue)
                    {
                        highestBlue = round.Blue;
                    }

                    if (round.Green > highestGreen)
                    {
                        highestGreen = round.Green;
                    }


                }

                var power = highestRed * highestGreen * highestBlue;
                powerTotal += power;
                if (ok)
                {
                    idTotal = idTotal + game.Id;
                }
            }

            Console.WriteLine(idTotal);
            Console.WriteLine(powerTotal);
        }
    }
}
