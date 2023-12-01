using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    
    public class Decoder
    {
        private static string GetNumbers(string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
        }



        public static int Decode(string input)
        {
            var numbers = GetNumbers(stringMapper.Map(input));
            var numbersLen = numbers.Length;

            var val1 = numbers[0].ToString();

            var val2 = numbers[numbersLen - 1].ToString();

            var total = val1 + val2;
            return Convert.ToInt32(total);
        }


    }
}
