using CubeIntersection.Domain.Model;

namespace CubeIntersection.Domain.Interface
{
    public interface ICubeBuilder
    {
        Cube Build(Point center, double edgeLength);
    }
}
