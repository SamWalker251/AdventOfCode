// See https://aka.ms/new-console-template for more information

using Day6;

Console.WriteLine("Hello, World!");


var arr = Loader.Load();

var raceDurs = arr[0];
var raceRecs = arr[1];

//Turn into one long num;




var runningTotal = 1;
for (int i = 0; i < raceDurs.Length; i++)
{
    var possibilities = 0;
    for (int j = 1; j < raceDurs[i]; j++)
    {
        var timeLeft = raceDurs[i] - j;
        if (j * timeLeft > raceRecs[i])
        {
            possibilities++;
        }
    }

    Console.WriteLine(possibilities);
    runningTotal = runningTotal * possibilities;
}

Console.WriteLine(runningTotal);