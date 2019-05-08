namespace MontecarloAlgorithms
{
    using System.Collections.Generic;
    using System.Linq;
    using System;

    public class MonteCarloPI
    {
        private List<MPoint> points;
        public List<MPoint> Points { get { return points; } }

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

        public MonteCarloPI()
        {
            this.points = new List<MPoint>();
        }

        private MPoint GenerateRandomPoint()
        {
            float x = GenerateRandomValue();
            float y = GenerateRandomValue();

            double ratio = Math.Sqrt(x * x + y * y);
            bool insideCircle = ratio <= 0.5;

            MPoint newOne = new MPoint(x, y, insideCircle);
            return newOne;
        }

        private float GenerateRandomValue()
        {
            Random rnd = new Random();
            return (float)rnd.NextDouble() - 0.5f;
        }
    }
}
