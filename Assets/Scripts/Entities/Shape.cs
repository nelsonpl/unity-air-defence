using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Entities
{
    internal class Shape
    {
        public EPosition EPosition { get; set; }
        public EVelocity EVelocity { get; set; }
        public EShapeType EType { get; set; }
    }
}
