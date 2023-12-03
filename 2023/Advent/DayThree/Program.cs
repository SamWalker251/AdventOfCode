// See https://aka.ms/new-console-template for more information
using DayThree;

Console.WriteLine("Hello, World!");


var engine = EngineLoader.Load();

var runningTotal = 0;
var parts = new List<(int, int, int)>(); //Start, end, ypos

var gt = new GearTracker();


for(var  y= 0; y < engine.Length; y++)
{
    for(var x = 0; x < engine[y].Length; x++)
    {
        
        var character = engine[y][x];
        if (char.IsDigit(character))
        {
            (int start, int end) = PartFinder.IdentifyPart(x, y, engine);
            
            x = end + 1;

            var symbolFound = PartFinder.FindSymbol(start, end, y, engine, out var gearfound, out var gearyx);

            if(symbolFound)
            {
                var num = new String(engine[y]).Substring(start, end - start + 1);
                Console.WriteLine(num);
                parts.Add((start, end, y));
                var value = Convert.ToInt32(num);
                runningTotal += value;
                if (gearfound)
                {
                    gt.GearFound(gearyx.Item1, gearyx.Item2, value);
                }
            }

            
        }




        

    }
}

Console.WriteLine(runningTotal.ToString());

Console.WriteLine(gt.GetGearRatioTotal().ToString());

