namespace Minesweeper
{
    using System;

    /// <summary>
    /// Used to store high score.
    /// </summary>
    public class Score
    {
        /// <summary>
        /// The name of the player.
        /// </summary>
        private string playernName;

        /// <summary>
        /// Amount of points a player has.
        /// </summary>
        private int playerPoints;
        
        /// <summary>
        /// Initializes a new instance of the Score class.
        /// </summary>
        public Score()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Score class.
        /// </summary>
        /// <param name="name">Name of player.</param>
        /// <param name="points">Score of player.</param>
        public Score(string name, int points)
        {
            this.playernName = name;
            this.playerPoints = points;
        }

        /// <summary>
        /// Gets or sets name of player.
        /// </summary>
        public string Name
        {
            get
            {
                return this.playernName;
            }

            set
            {
                this.playernName = value;
            }
        }

        /// <summary>
        /// Gets or sets score of player.
        /// </summary>
        public int Points
        {
            get
            {
                return this.playerPoints;
            }

            set
            {
                this.playerPoints = value;
            }
        }
    }
}