// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Day6Model.cs" company="">
//   
// </copyright>
// <summary>
//   The day 6 model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdventOfCode2022.Models
{
    /// <summary>
    /// The day 6 model.
    /// </summary>
    internal class Day6Model : BaseModel<int>
    {
        /// <inheritdoc />
        public Day6Model(IList<string> inputLines)
            : base(inputLines)
        {
        }

        /// <inheritdoc />
        public override int CalculatePart1()
        {
            return FindMarker(4);
        }

        /// <inheritdoc />
        public override int CalculatePart2()
        {
            return FindMarker(14);
        }

        /// <summary>
        /// The find marker.
        /// </summary>
        /// <param name="length">
        /// The length.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        private int FindMarker(int length)
        {
            var onlyLine = InputLines[0];

            var index = 0;
            do
            {
                var chars = onlyLine.Skip(index).Take(length);
                if (chars.Distinct().Count() == length)
                {
                    return index + length;
                }

                index++;
            }
            while (index < onlyLine.Length - length);

            return -1;
        }
    }
}