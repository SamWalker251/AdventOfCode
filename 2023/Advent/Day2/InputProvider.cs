using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class InputProvider
    {
        
        public List<GameRecord> Read()
        {
            var listOfGames = new List<GameRecord>();

            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead("Games.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    listOfGames.Add(new GameRecord(line));
                }
            }

            return listOfGames;
        }
    }
}
