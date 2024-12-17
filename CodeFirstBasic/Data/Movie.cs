﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstBasic.Data
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; } = "";

        public string Genre { get; set; } = "";

        public int ReleaseYear { get; set; }
    }
}
