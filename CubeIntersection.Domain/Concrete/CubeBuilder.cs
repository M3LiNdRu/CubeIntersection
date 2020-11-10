using CubeIntersection.Domain.Interface;
using CubeIntersection.Domain.Model;

namespace CubeIntersection.Domain.Concrete
{
    public class CubeBuilder : ICubeBuilder
    {
        public CubeBuilder()
        {
        }

        Cube ICubeBuilder.Build(Point center, double edgeLength)
        {
            return new Cube(center, edgeLength);
        }
    }
}
