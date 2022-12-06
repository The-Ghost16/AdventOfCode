// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseModel.cs" company="">
//   
// </copyright>
// <summary>
//   The base model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdventOfCode2022.Models
{
    /// <summary>
    /// The base model.
    /// </summary>
    /// <typeparam name="T">
    /// The type returned by the methods
    /// </typeparam>
    internal abstract class BaseModel<T>
    {
        /// <summary>
        /// The input lines.
        /// </summary>
        protected readonly IList<string> InputLines;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseModel{T}"/> class.
        /// </summary>
        /// <param name="inputLines">
        /// The input lines.
        /// </param>
        protected BaseModel(IList<string> inputLines)
        {
            this.InputLines = inputLines;
        }

        /// <summary>
        /// The calculate part 1.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public abstract T CalculatePart1();

        /// <summary>
        /// The calculate part 2.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public abstract T CalculatePart2();
    }
}