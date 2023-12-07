using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Loader
    {
        public static SeedsAndMaps Load()
        {
            var sd = new SeedsAndMaps();
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead("InFile.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    if (line.Contains("seeds"))
                    {
                        sd.Seeds = GetSeeds(line);
                    }
                    else if (line.Length == 0 || line.Contains("map"))
                    {
                        if (line.Contains("map"))
                        {
                            sd.Maps.Add(new List<long>().ToArray());
                        }
                    }
                    else
                    {
                        sd.Maps.Add(GetMap(line));
                    }

                }
            }

            sd.Maps.Add(new List<long>().ToArray());
            return sd;
        }

        public static IEnumerable<long> GetSeeds(string seedsLine)
        {
            var colon = seedsLine.IndexOf(':');
            var substring = seedsLine.Substring(colon+1).Trim().Split(" ");

            var map = Array.ConvertAll(substring, long.Parse);

            var realMap = new List<long>();
            for (var i = 0; i < map.Count(); i += 2)
            {
                for (var x = map[i]; x < map[i] + map[i + 1]; x++)
                {
                    realMap.Add(x);
                }

                Console.Write("x");
            }
            Console.WriteLine("");
            Console.WriteLine("Seeds Loaded");

            var dedupe = realMap.Distinct();
            Console.WriteLine("Seed deduped");
            Console.WriteLine(dedupe.Count());
            return dedupe;
        }

        public static long[] GetMap(string line)
        {
            var map = Array.ConvertAll(line.Trim().Split(" "), long.Parse);
            Console.WriteLine("Map Loaded");
            return new[] { map[1], map[1] + map[2], map[0] - map[1] }; //Start, End and diff
            
        }


        //public static long[] RangeFinder(long[][] ranges)
        //{
        //    var optimisedRanges = new List<long[]>();

        //    foreach (var range in ranges)
        //    {
        //        if (optimisedRanges.Count == 0)
        //        {
        //            optimisedRanges.Add(range);
        //        }


        //        var placeFound = false;
        //        var index = 0;
                
        //        while (placeFound == false)
        //        {
        //            if (range[0] > optimisedRanges[index][0] && )
        //        }
        //    }
        //}
    }
}
