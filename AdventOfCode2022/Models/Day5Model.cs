// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Day5Model.cs" company="">
//   
// </copyright>
// <summary>
//   The day 5 model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdventOfCode2022.Models
{
    /// <summary>
    /// The day 5 model.
    /// </summary>
    internal class Day5Model : BaseModel<string>
    {
        /// <inheritdoc />
        public Day5Model(IList<string> inputLines)
            : base(inputLines)
        {
        }

        /// <inheritdoc />
        public override string CalculatePart1()
        {
            var stacks = GetStacks();
            var moves = InputLines.Skip(10).ToList();

            foreach (var line in moves)
            {
                var elements = line.Split(' ');
                var move = int.Parse(elements[1]);
                var from = int.Parse(elements[3]) - 1;
                var to = int.Parse(elements[5]) - 1;

                var left = stacks[from].Count - move;
                var containersToMove = stacks[from].Skip(left).Take(move).Reverse();
                stacks[from] = stacks[from].Take(left).ToList();
                stacks[to].AddRange(containersToMove);
            }

            var result = stacks.Select(x => x.Last());
            return string.Concat(result);
        }

        /// <inheritdoc />
        public override string CalculatePart2()
        {
            var stacks = GetStacks();
            var moves = InputLines.Skip(10).ToList();

            foreach (var line in moves)
            {
                var elements = line.Split(' ');
                var move = int.Parse(elements[1]);
                var from = int.Parse(elements[3]) - 1;
                var to = int.Parse(elements[5]) - 1;

                var left = stacks[from].Count - move;
                var containersToMove = stacks[from].Skip(left).Take(move);
                stacks[from] = stacks[from].Take(left).ToList();
                stacks[to].AddRange(containersToMove);
            }

            var result = stacks.Select(x => x.Last());
            return string.Concat(result);
        }

        /// <summary>
        /// The get stacks.
        /// </summary>
        /// <returns>
        /// The <see cref="IList"/>.
        /// </returns>
        private List<List<char>> GetStacks()
        {
            List<List<char>> stacks = new List<List<char>>();

            var numberOfStacks = (InputLines[0].Length + 1) / 4;
            for (var i = 0; i < numberOfStacks; i++)
            {
                stacks.Add(new List<char>());
            }

            foreach (var line in InputLines.Take(8))
            {
                var nextIndex = 0;
                do
                {
                    var container = line.Substring((nextIndex * 4) + 1, 1);
                    if (string.IsNullOrWhiteSpace(container) == false)
                    {
                        stacks[nextIndex].Insert(0, container[0]);
                    }

                    nextIndex++;
                }
                while ((nextIndex * 4) < line.Length);
            }

            return stacks;
        }
    }
}