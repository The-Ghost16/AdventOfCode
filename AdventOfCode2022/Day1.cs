// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Day1.cs" company="">
//   
// </copyright>
// <summary>
//   The day 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using AdventOfCode2022.Models;

namespace AdventOfCode2022
{
    /// <summary>
    /// The day 1.
    /// </summary>
    internal class Day1
    {
        /// <summary>
        /// The execute.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        internal async Task Execute()
        {
            var input = await InputReader.ReadInput(1);
            var model = new Day1Model(input);

            Console.WriteLine("Part 1: {0}", model.CalculatePart1().Max());

            Console.WriteLine(
                "Part 2: {0}",
                model.CalculatePart2().OrderByDescending(x => x).Take(3).Sum());
        }
    }
}