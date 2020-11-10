using CubeIntersection.Domain.Model;

namespace CubeIntersection.Domain
{
    public class Cube
    {
        public Cube(Point center, double edgeLength)
        {
            Width = new Edge(center.X, edgeLength);
            Height = new Edge(center.Y, edgeLength);
            Depth = new Edge(center.Z, edgeLength);
        }

        private Edge Width;
        private Edge Height;
        private Edge Depth;

    }
}
