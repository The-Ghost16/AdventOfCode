
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Day2.cs" company="">
//   
// </copyright>
// <summary>
//   The day 2.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using AdventOfCode2022.Models;

namespace AdventOfCode2022
{
    /// <summary>
    /// The day 2.
    /// </summary>
    internal class Day5
    {
        /// <summary>
        /// The execute.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        internal async Task Execute()
        {
            var input = await InputReader.ReadInput(5);
            var model = new Day5Model(input);

            Console.WriteLine("Part 1: {0}", model.CalculatePart1());
            Console.WriteLine("Part 2: {0}", model.CalculatePart2());
        }
    }
}