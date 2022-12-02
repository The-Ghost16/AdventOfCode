// --------------------------------------------------------------------------------------------------------------------
// <copyright company="" file="Day2InputRound.cs">
//   
// </copyright>
// <summary>
//   The day 2 input action.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace AdventOfCode2022.Models.Day2
{
    /// <summary>
    /// The day 2 input action.
    /// </summary>
    internal class Day2InputRound
    {
        /// <summary>
        /// The opponent.
        /// </summary>
        private readonly Shape opponent;

        /// <summary>
        /// The player.
        /// </summary>
        private readonly Shape player;

        /// <summary>
        /// Initializes a new instance of the <see cref="Day2InputRound"/> class.
        /// </summary>
        /// <param name="opponent">
        /// The opponent.
        /// </param>
        /// <param name="player">
        /// The player.
        /// </param>
        public Day2InputRound(Shape opponent, Shape player)
        {
            this.opponent = opponent;
            this.player = player;
            var result = GetResult();
            Score = (int)player + (int)result;
        }

        /// <summary>
        /// Gets the score.
        /// </summary>
        public int Score { get; }

        /// <summary>
        /// The get result.
        /// </summary>
        /// <returns>
        /// The <see cref="Result" />.
        /// </returns>
        private Result GetResult()
        {
            if (opponent == player)
            {
                return Result.Draw;
            }

            if (opponent - player == 1 || opponent - player == -2)
            {
                return Result.Loss;
            }

            return Result.Win;
        }
    }
}