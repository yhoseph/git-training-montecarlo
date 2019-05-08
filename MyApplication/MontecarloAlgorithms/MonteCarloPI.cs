using System;
using System.Collections.Generic;
using System.Linq;

namespace MontecarloAlgorithms
{
    public class MonteCarloPI
    {
        private List<MPoint> points;
        public List<MPoint> Points { get { return points; } }

        public MonteCarloPI()
        {
            this.points = new List<MPoint>();
        }

        public void GeneratePoint()
        {
            MPoint newPoint = GenerateRandomPoint();
            this.points.Add(newPoint);
        }

        public float GetPI()
        {
            int circleCounter = this.points.Count(x=>x.insideCircle);
            int rectangleCounter = this.points.Count;

            return 4.0f * circleCounter / rectangleCounter;
        }

        private MPoint GenerateRandomPoint()
        {
            float x = GenerateRandomCoordinate();
            float y = GenerateRandomCoordinate();

            MPoint newOne = new MPoint(x, y, false);
            return newOne;
        }

        private float GenerateRandomCoordinate()
        {
            Random rnd = new Random();
            return (float)rnd.NextDouble() - 0.5f;
        }
    }
}
