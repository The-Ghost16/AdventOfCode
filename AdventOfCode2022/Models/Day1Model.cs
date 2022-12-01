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
    internal class Day1Model : BaseModel
    {
        /// <summary>
        /// The result.
        /// </summary>
        private IList<int> result = new List<int>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Day1Model"/> class.
        /// </summary>
        /// <param name="inputLines">
        /// The input lines.
        /// </param>
        public Day1Model(IList<string> inputLines) : base(inputLines)
        {
        }

        /// <summary>
        /// Gets the total calories per elf.
        /// </summary>
        public IList<int> TotalCaloriesPerElf
        {
            get
            {
                if (result.Any())
                {
                    return result;
                }

                lock (result)
                {
                    if (result.Any() == false)
                    {
                        result = InputToTotalCalories();
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// The input to total calories.
        /// </summary>
        /// <returns>
        /// The <see cref="IList" />.
        /// </returns>
        private IList<int> InputToTotalCalories()
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