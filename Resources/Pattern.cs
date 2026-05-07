    using System.Collections.Generic;

    namespace GameOfLife
    {
        public class Pattern
        {
            public int id { get; set; }
            public string name { get; set; } = string.Empty;
            public List<Cell> Cells { get; set; } = new List<Cell>();

        }
    }
