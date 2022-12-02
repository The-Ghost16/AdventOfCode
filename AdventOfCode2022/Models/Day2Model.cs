// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Day2Model.cs" company="">
//   
// </copyright>
// <summary>
//   The day 2 model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using AdventOfCode2022.Models.Day2;

namespace AdventOfCode2022.Models
{
    /// <summary>
    /// The day 2 model.
    /// </summary>
    internal class Day2Model : BaseModel
    {
        /// <summary>
        /// The actions.
        /// </summary>
        private IList<Day2InputRound> rounds = new List<Day2InputRound>();

        /// <inheritdoc />
        public Day2Model(IList<string> inputLines)
            : base(inputLines)
        {
        }

        /// <summary>
        /// Gets the rounds.
        /// </summary>
        public IList<Day2InputRound> Rounds
        {
            get
            {
                if (rounds.Any())
                {
                    return rounds;
                }

                lock (rounds)
                {
                    if (rounds.Any() == false)
                    {
                        rounds = InputToRounds();
                    }
                }

                return rounds;
            }
        }

        /// <summary>
        /// The input to rounds.
        /// </summary>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        private IList<Day2InputRound> InputToRounds()
        {
            var day2InputRounds = new List<Day2InputRound>();

            foreach (var inputLine in InputLines)
            {
                var chars = inputLine.Split(' ');
                var opponent = chars[0] == "A" ? Shape.Rock : chars[0] == "B" ? Shape.Paper : Shape.Scissors;
                var player = chars[1] == "X" ? Shape.Rock : chars[1] == "Y" ? Shape.Paper : Shape.Scissors;

                var round = new Day2InputRound(opponent, player);
                day2InputRounds.Add(round);
            }

            return day2InputRounds;
        }
    }
}