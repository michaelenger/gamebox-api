﻿namespace GameBox.Connectors.IGDB.IGDBResponse
{
    internal class Cover
    {
        public int id { get; set; }
        public string url { get; set; }
        public int game {  get; set; }

        public Cover()
        {
            id = 0;
            url = string.Empty;
        }
    }
}
