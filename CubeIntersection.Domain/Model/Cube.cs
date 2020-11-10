namespace CubeIntersection.Domain.Model
{
    public class Cube
    {
        public Cube(Point center, double edgeLength)
        {
            Width = new Edge(center.X, edgeLength);
            Height = new Edge(center.Y, edgeLength);
            Depth = new Edge(center.Z, edgeLength);
        }

        public Edge Width { get; }
        public Edge Height { get; }
        public Edge Depth { get; }

    }
}
