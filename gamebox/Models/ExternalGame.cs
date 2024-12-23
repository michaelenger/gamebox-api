﻿namespace GameBox.Models
{
    /// <summary>
    /// Holds information for a game
    /// </summary>
    public class ExternalGame
    {
        /// <summary>
        /// ID of this game from the source
        /// </summary>
        public int ExternalID { get; set; }
        /// <summary>
        /// List of Platforms this game is available on
        /// </summary>
        public List<ExternalPlatform> Platforms { get; set; }
        /// <summary>
        /// Title of the game
        /// </summary>
        public string Title {  get; set; }
        /// <summary>
        /// Summary of the game
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Path to where the image of this game's cover is stored
        /// </summary>
        public string? ImagePath { get; set; }

        public ExternalGame()
        {
            ExternalID = 0;
            Platforms = new List<ExternalPlatform>();
            Title = string.Empty;
            Description = string.Empty;
            ImagePath = null;
        }

        public static ExternalGame Empty => new ExternalGame();
    }

    public class ExternalPlatform
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public ExternalPlatform()
        {
            ID = 0;
            Name = string.Empty;
        }
    }
}
