﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwnProject.Models
{
    public class Artist
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long SongId { get; set; }
    }
}