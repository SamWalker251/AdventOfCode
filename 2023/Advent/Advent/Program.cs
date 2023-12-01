// See https://aka.ms/new-console-template for more information

using Advent;



var values = Input.Value.Split("\r\n");
var runningTotal = 0;



foreach (var value in values)
{
    runningTotal = runningTotal + Decoder.Decode(value);
}

Console.WriteLine(runningTotal);


