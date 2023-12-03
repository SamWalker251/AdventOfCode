using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThree
{
    internal class PartFinder
    {

        public static (int, int) IdentifyPart(int x, int y, char[][] arr)
        {
            var searcher = 0;
            var start = x;
            var end = x;
            while (Char.IsDigit(arr[y][x + searcher]))
            {
                end = x + searcher;

                searcher++;
                if(x+searcher == arr.Length)
                {
                    break;
                }
            }

            return (start, end);
        }

        public static bool FindSymbol(int start, int end, int ypos, char[][]arr, out bool gearFound, out (int, int) gearyx)
        {
            gearFound = false;
            gearyx = (-1, -1);
            for(var y = -1; y <= 1; y++)
            {
                for(var x = start-1; x <= end+1; x++)
                {
                    if(x < 0 || x > arr[ypos].Length-1 || ypos + y < 0 || ypos + y > arr.Length-1)
                    {

                    }
                    else
                    {
                        var search = arr[ypos + y][x];
                        if (!Char.IsLetterOrDigit(search) && search != '.')
                        {
                            if(search == '*')
                            {
                                gearFound = true;
                                gearyx = (ypos + y, x);
                            }
                            return true;
                        }
                    }
                }
            }

            return false;
        }

    }
}
