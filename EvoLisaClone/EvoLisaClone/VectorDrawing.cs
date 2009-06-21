﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace EvoLisaClone
{
    public class VectorDrawing : IEquatable<VectorDrawing>
    {
        public IEnumerable<ColoredTriangle> Vectors { get; set; }

        public bool Equals(VectorDrawing other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return this.GetHashCode() == other.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as VectorDrawing);
        }

        public override int GetHashCode()
        {
            if (ReferenceEquals(null, this.Vectors) || Vectors.Count() == 0) return 0;
            var hashCode = 0;
            foreach (var triangle in this.Vectors)
            {
                hashCode += triangle.GetHashCode();
            }
            return hashCode;
        }
    }
}
