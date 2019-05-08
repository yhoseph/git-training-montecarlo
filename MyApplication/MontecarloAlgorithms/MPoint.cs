using System;
using System.Collections.Generic;
using System.Text;

namespace MontecarloAlgorithms
{
    public struct MPoint
    {
        public float X;
        public float Y;
        public bool insideCircle;

        public MPoint(float x, float y, bool insideCircle)
        {
            this.X = x;
            this.Y = y;
            this.insideCircle = insideCircle;
        }
    }
}
