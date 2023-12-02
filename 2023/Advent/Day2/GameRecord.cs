using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class GameRecord
    {
        public GameRecord(string input)
        {
            var colonPos = input.IndexOf(": ");
            var id = input.Substring(0, colonPos).Split(" ")[1];

            Id = Convert.ToInt32(id);

            var stringRounds = input.Substring(colonPos+2).Split("; ");

            foreach(var round in stringRounds)
            {
                GameRounds.Add(new GameRound(round));
            }
        }


        public int Id { get; set; }
        public List<GameRound> GameRounds { get; set; } = new List<GameRound>();
    }


    class GameRound
    {
        public GameRound(string round)
        {
            var pulls = round.Split(", ");

            foreach(var pull in pulls)
            {
                var parts = pull.Split(" ");

                switch (parts[1])
                {
                    case "red":
                        Red = Convert.ToInt32(parts[0]);
                        break;
                    case "green":
                        Green = Convert.ToInt32(parts[0]);
                        break;
                    case "blue":
                        Blue = Convert.ToInt32(parts[0]);
                        break;
                }
            }
        }

        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
    }
}
