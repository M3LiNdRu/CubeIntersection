namespace CubeIntersection.Domain.Model
{
    public class Edge
    {
        public Edge(double center, double length)
        {
            Start = center - length / 2.0;
            End = center + length / 2.0;
        }

        private double Start;
        private double End;
    }
}
