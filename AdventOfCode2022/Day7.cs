
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Day7.cs" company="">
//   
// </copyright>
// <summary>
//   The day 7.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using AdventOfCode2022.Models;

namespace AdventOfCode2022
{
    /// <summary>
    /// The day 6.
    /// </summary>
    internal class Day7
    {
        /// <summary>
        /// The execute.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        internal async Task Execute()
        {
            var input = await InputReader.ReadInput(7);
            var model = new Day7Model(input);

            Console.WriteLine("Part 1: {0}", model.CalculatePart1());
            Console.WriteLine("Part 2: {0}", model.CalculatePart2());
        }
    }
}