using PolishVerbLoader.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolishVerbLoader.Core.Entities
{
    public class PrimitiveVerb : BaseEntity
    {
        public string Imperfective { get; set; }
        public string Perfective { get; set; }
        public bool Reflexive { get; set; }
        public int ConjugationClass { get; set; }
        public string PStem { get; set; }
        public string VStem { get; set; }
    }
}
