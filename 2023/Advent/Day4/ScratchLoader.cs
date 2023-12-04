using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class ScratchLoader
    {
        public static IEnumerable<ScratchCard> Load()
        {
            var scratchies = new List<ScratchCard>();
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead("Scratchies.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    scratchies.Add(new ScratchCard(line));
                }
            }

            return scratchies;
        }
    }
}
