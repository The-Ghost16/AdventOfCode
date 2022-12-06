// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Day1Model.cs" company="">
//   
// </copyright>
// <summary>
//   The day 1 model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdventOfCode2022.Models
{
    /// <summary>
    /// The day 1 model.
    /// </summary>
    internal class Day1Model : BaseModel<IList<int>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Day1Model"/> class.
        /// </summary>
        /// <param name="inputLines">
        /// The input lines.
        /// </param>
        public Day1Model(IList<string> inputLines) : base(inputLines)
        {
        }

        /// <inheritdoc />
        public override IList<int> CalculatePart1()
        {
            var output = new List<int>();

            var sum = 0;
            foreach (var line in InputLines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    output.Add(sum);
                    sum = 0;
                    continue;
                }

                sum += int.Parse(line);
            }

            output.Add(sum);

            return output;
        }

        /// <inheritdoc />
        public override IList<int> CalculatePart2()
        {
            var output = new List<int>();

            var sum = 0;
            foreach (var line in InputLines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    output.Add(sum);
                    sum = 0;
                    continue;
                }

                sum += int.Parse(line);
            }

            output.Add(sum);

            return output;
        }
    }
}