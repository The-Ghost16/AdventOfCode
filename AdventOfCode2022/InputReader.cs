// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputReader.cs" company="">
//   
// </copyright>
// <summary>
//   The input reader.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdventOfCode2022
{
    /// <summary>
    /// The input reader.
    /// </summary>
    internal static class InputReader
    {
        /// <summary>
        /// The read input.
        /// </summary>
        /// <param name="dayNumber">
        /// The day number.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public static async Task<IList<string>> ReadInput(int dayNumber)
        {
            var content = new List<string>();
            var file = Path.Combine("inputs", $"day{dayNumber}.txt");
            using (var sr = new StreamReader(file))
            {
                while (sr.EndOfStream == false)
                {
                    var line = await sr.ReadLineAsync();
                    if (line != null)
                    {
                        content.Add(line);
                    }
                }
            }

            return content;
        }
    }
}