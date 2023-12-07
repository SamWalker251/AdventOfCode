using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Loader
    {
        public static long[][] Load()
        {
            
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead("Races.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                var line1 = streamReader.ReadLine();
                var line2 = streamReader.ReadLine();

                return new[] { GetLongNum(line1), GetLongNum(line2) };
            }
        }

        private static int[] Get(string line)
        {
            var colonLoc = line.IndexOf(':');
            return Array.ConvertAll(line.Substring(colonLoc+1).Trim().Split(" ").Where(x => x!="").ToArray(), int.Parse);
        }

        private static long[] GetLongNum(string line)
        {
            var colonLoc = line.IndexOf(':');
            var stringos = line.Substring(colonLoc + 1).Trim().ToArray();
            return new []{ Convert.ToInt64(new String(stringos.Where(x => x != ' ').ToArray())) };
        }
    }
}
