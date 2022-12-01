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
    internal abstract class BaseModel
    {
        /// <summary>
        /// The input lines.
        /// </summary>
        protected readonly IList<string> InputLines;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseModel"/> class.
        /// </summary>
        /// <param name="inputLines">
        /// The input lines.
        /// </param>
        protected BaseModel(IList<string> inputLines)
        {
            this.InputLines = inputLines;
        }
    }
}