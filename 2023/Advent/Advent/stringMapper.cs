using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{

    internal static class stringMapper
    {
        private static Dictionary<string, string> _map = new Dictionary<string, string>()
        {
            { "one", "1" },
            { "two", "2" },
            { "three", "3" },
            { "four", "4" },
            { "five", "5" },
            { "six", "6" },
            { "seven", "7" },
            { "eight", "8" },
            { "nine", "9" },
        };

        public static string Map(string input)
        {
            var newString = "";
            for (var x = 0; x < input.Length; x++)
            {
                if (char.IsDigit(input[x]))
                {
                    newString = newString + input[x];
                }
                else
                {
                    for (var search = 0; search < "seven".Length + 1; search++)
                    {
                        if (x + search < input.Length + 1)
                        {
                            var substring = input.Substring(x, search);
                            if (_map.Keys.Contains(substring))
                            {
                                if (_map.TryGetValue(substring, out var newValue))
                                {
                                    newString = newString + newValue;
                                }
                            }
                        }
                    }
                }
            }
            return newString;
        }
    }
}
