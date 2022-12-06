// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Day4Model.cs" company="">
//   
// </copyright>
// <summary>
//   The day 4 model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdventOfCode2022.Models
{
    /// <summary>
    /// The day 4 model.
    /// </summary>
    internal class Day4Model : BaseModel<int>
    {
        /// <inheritdoc />
        public Day4Model(IList<string> inputLines)
            : base(inputLines)
        {
        }

        /// <inheritdoc />
        public override int CalculatePart1()
        {
            var count = 0;
            foreach (var inputLine in InputLines)
            {
                var parts = inputLine.Split(',');
                var numbers1 = parts[0].Split('-').Select(x => int.Parse(x)).ToArray();
                var numbers2 = parts[1].Split('-').Select(x => int.Parse(x)).ToArray();

                if ((numbers1[0] <= numbers2[0] && numbers1[1] >= numbers2[1])
                    || (numbers2[0] <= numbers1[0] && numbers2[1] >= numbers1[1]))
                {
                    count++;
                }
            }

            return count;
        }

        /// <inheritdoc />
        public override int CalculatePart2()
        {
            return 0;
        }
    }
}