using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThree
{
    internal class EngineLoader
    {
        public static char[][] Load() 
        {
            var lines = new List<char[]>();


            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead("Engine.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    lines.Add(line.ToArray());
                }
            }

            return lines.ToArray();
        }

    }
}
