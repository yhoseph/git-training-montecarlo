using System;
using System.Collections.Generic;
using System.Text;

namespace MontecarloAlgorithms
{
    public struct MPoint
    {
        public float X;
        public float Y;

        public MPoint()
        {
            X = Y = 0;
        }

        public MPoint(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
