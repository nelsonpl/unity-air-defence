using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Entities
{
    internal class Rule
    {
        public string Tag { get; set; }
        public float Time { get; set; }
        public List<List<Shape>> Shapes { get; set; }
    }
}
