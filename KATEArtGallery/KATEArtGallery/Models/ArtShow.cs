﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KATEArtGallery.Models
{
    public class ArtShow
    {
        public int ArtShowId { get; set; }
        public int ArtWorkId { get; set; }
        public string ShowLocation { get; set; }
        public string Agents { get; set; }
        public double Overhead { get; set; }
    }
}