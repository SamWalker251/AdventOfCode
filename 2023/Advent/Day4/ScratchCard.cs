using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class ScratchCard
    {
        public ScratchCard(string line)
        {
            var colonLoc = line.IndexOf(':');
            var idString = line.Substring(0, colonLoc);

            CardID = Convert.ToInt32(idString.Split("Card")[1].Trim());

            var numsString = line.Substring(colonLoc+1).Trim();

            var splitResult = numsString.Split(" | ");
            var numbsArr = splitResult[1].Split(" ").ToList();
            var winNumbsArr = splitResult[0].Split(" ").ToList();
            numbsArr.RemoveAll(x => x.Equals(""));
            winNumbsArr.RemoveAll(x => x.Equals(""));
            Numbers = Array.ConvertAll(numbsArr.ToArray(), int.Parse);
            WinningNumbers = Array.ConvertAll(winNumbsArr.ToArray(), int.Parse);
        }

        public IEnumerable<int> Numbers { get; set; }
        public IEnumerable<int> WinningNumbers { get; set; }

        public int CardID { get; set; }

        public IEnumerable<int> GetMyWinningNumbers()
        {
            return Numbers.Intersect(WinningNumbers);
        }
    }
}
