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
    internal class Day3Model : BaseModel<int>
    {
        /// <inheritdoc />
        public Day3Model(IList<string> inputLines)
            : base(inputLines)
        {
        }

        /// <inheritdoc />
        public override int CalculatePart1()
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

        /// <inheritdoc />
        public override int CalculatePart2()
        {
            var sum = 0;
            for (var i = 0; i < InputLines.Count; i += 3)
            {
                var line1 = InputLines[i].ToCharArray();
                var line2 = InputLines[i + 1].ToCharArray();
                var line3 = InputLines[i + 2].ToCharArray();

                var chars = line1.Intersect(line2).Intersect(line3).ToArray();

                if (chars.Length == 1)
                {
                    var removable = char.IsUpper(chars[0]) ? 38 : 64;
                    var index = char.ToUpper(chars[0]) - removable;
                    sum += index;
                }
                else
                {
                    Console.WriteLine("NOT VALID!!!!");
                }
            }

            return sum;
        }
    }
}