// See https://aka.ms/new-console-template for more information

using Day5;

Console.WriteLine("Hello, World!");

var ranges = new[] { new[] { 5, 11 }, new[] { 7, 17 }, new[] { 19, 25 } };



var sd = Loader.Load();

Console.WriteLine();


long lowestVal = 0;

Console.WriteLine("Begin");
foreach (var seed in sd.Seeds)
{
    var val = seed;
    var mappedVal = seed;
    foreach (var op in sd.Maps)
    {
        if (op.Length == 0)
        {
            val = mappedVal;
        }
        else
        {
            if (val >= op[0] && val < op[1])
            {
                mappedVal = val + op[2];
            }
        }
    }
    if (lowestVal == 0) { lowestVal = val; }

    if (val < lowestVal)
    {
        lowestVal = val;
    }

}
Console.WriteLine("LowestVal");
Console.WriteLine(lowestVal);