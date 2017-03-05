using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PolishVerbLoader.Api.Models
{
    public class PrimiiveVerbDto : BaseEntityDto
    {
        public string Imperfective { get; set; }
        public string Perfective { get; set; }
        public bool Reflexive { get; set; }
        public int ConjugationClass { get; set; }
        public string PStem { get; set; }
        public string VStem { get; set; }
    }
}