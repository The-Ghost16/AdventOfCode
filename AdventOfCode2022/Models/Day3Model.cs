// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Day3Model.cs" company="">
//   
// </copyright>
// <summary>
//   The day 3 model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdventOfCode2022.Models
{
    /// <summary>
    /// The day 3 model.
    /// </summary>
    internal class Day3Model : BaseModel
    {
        /// <inheritdoc />
        public Day3Model(IList<string> inputLines)
            : base(inputLines)
        {
        }

        /// <summary>
        /// The calculate priorities.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int CalculatePriorities()
        {
            var sum = 0;
            foreach (var inputLine in InputLines)
            {
                var splitLength = inputLine.Length / 2;
                var part1 = inputLine.Substring(0, splitLength);
                var part2 = inputLine.Substring(splitLength);

                var charsFound = new List<char>();

                foreach (var itemType in part1)
                {
                    if (charsFound.Contains(itemType))
                    {
                        continue;
                    }

                    if (part2.Contains(itemType))
                    {
                        charsFound.Add(itemType);

                        var removable = char.IsUpper(itemType) ? 38 : 64;
                        var index = char.ToUpper(itemType) - removable;
                        sum += index;
                    }
                }
            }

            return sum;
        }
    }
}