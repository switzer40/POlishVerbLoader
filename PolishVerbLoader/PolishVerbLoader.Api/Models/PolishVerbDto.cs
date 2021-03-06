﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PolishVerbLoader.Api.Models
{
    public class PolishVerbDto : PrimiiveVerbDto
    {
        public string JaP { get; set; }
        public string JaV { get; set; }
        public string TyP { get; set; }
        public string TyV { get; set; }
        public string OnP { get; set; }
        public string OnV { get; set; }
        public string MyP { get; set; }
        public string MyV { get; set; }
        public string WyP { get; set; }
        public string WyV { get; set; }
        public string OniP { get; set; }
        public string OniV { get; set; }
    }
}