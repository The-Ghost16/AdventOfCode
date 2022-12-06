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
    internal class Day2Model : BaseModel<IList<Day2InputRound>>
    {
        /// <inheritdoc />
        public Day2Model(IList<string> inputLines)
            : base(inputLines)
        {
        }

        /// <inheritdoc />
        public override IList<Day2InputRound> CalculatePart1()
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

        /// <inheritdoc />
        public override IList<Day2InputRound> CalculatePart2()
        {
            var day2InputRounds = new List<Day2InputRound>();

            foreach (var inputLine in InputLines)
            {
                var chars = inputLine.Split(' ');
                var opponent = chars[0] == "A" ? Shape.Rock : chars[0] == "B" ? Shape.Paper : Shape.Scissors;
                var expectedResult = chars[1] == "X" ? Result.Loss : chars[1] == "Y" ? Result.Draw : Result.Win;

                var round = new Day2InputRound(opponent, expectedResult);
                day2InputRounds.Add(round);
            }

            return day2InputRounds;
        }
    }
}