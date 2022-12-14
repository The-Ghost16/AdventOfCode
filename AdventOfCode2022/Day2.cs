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
    internal class Day2
    {
        /// <summary>
        /// The execute.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        internal async Task Execute()
        {
            var input = await InputReader.ReadInput(2);
            var model = new Day2Model(input);

            Console.WriteLine("Part 1: {0}", model.CalculatePart1().Sum(r => r.Score));
            Console.WriteLine("Part 2: {0}", model.CalculatePart2().Sum(r => r.Score));
        }
    }
}