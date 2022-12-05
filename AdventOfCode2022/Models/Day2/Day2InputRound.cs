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
        /// The result.
        /// </summary>
        private readonly Result result;

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
            result = GetResult();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Day2InputRound"/> class.
        /// </summary>
        /// <param name="opponent">
        /// The opponent.
        /// </param>
        /// <param name="expectedResult">
        /// The expected result.
        /// </param>
        public Day2InputRound(Shape opponent, Result expectedResult)
        {
            this.opponent = opponent;
            result = expectedResult;
            player = GetPlayerShape();
        }

        /// <summary>
        /// Gets the score.
        /// </summary>
        public int Score => (int)player + (int)result;

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

        /// <summary>
        /// The get player shape.
        /// </summary>
        /// <returns>
        /// The <see cref="Shape"/>.
        /// </returns>
        private Shape GetPlayerShape()
        {
            if (result == Result.Draw)
            {
                return opponent;
            }

            if (result == Result.Loss)
            {
                return opponent == Shape.Rock ? Shape.Scissors : opponent - 1;
            }

            return opponent == Shape.Scissors ? Shape.Rock : opponent + 1;
        }
    }
}