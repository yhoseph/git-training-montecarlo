using System;
using System.Collections.Generic;

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
            return 0;
        }

        private MPoint GenerateRandomPoint()
        {
            MPoint newOne = new MPoint(GenerateRandomCoordinate(), GenerateRandomCoordinate());
            return newOne;
        }

        private float GenerateRandomCoordinate()
        {
            Random rnd = new Random();
            return (float)rnd.NextDouble();
        }
    }
}
