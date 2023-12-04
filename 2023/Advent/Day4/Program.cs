// See https://aka.ms/new-console-template for more information

using Day4;

var scra = new ScratchCard("Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53");

var myWinners = scra.GetMyWinningNumbers();

var scratchies = ScratchLoader.Load().ToList();

var scratchiesCount = scratchies.Count();

var runningTotal = 0;
var x = 0;
while(x < scratchies.Count)
{
    var winners = scratchies[x].GetMyWinningNumbers();
    if (winners.Count() > 0)
    {
        runningTotal += (int)Math.Pow(2, winners.Count() - 1);
        for (int i = 0; i < winners.Count(); i++)
        {
            if (scratchies[x].CardID + i < scratchiesCount)
            {
                scratchies.Add(scratchies[scratchies[x].CardID + i]);
            }
        }
    }

    
    x++;
}

Console.WriteLine(x);
Console.WriteLine(runningTotal);
Console.WriteLine(scratchies.Count);