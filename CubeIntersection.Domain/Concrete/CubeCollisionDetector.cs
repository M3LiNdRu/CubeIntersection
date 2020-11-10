using CubeIntersection.Domain.Extensions;
using CubeIntersection.Domain.Interface;
using CubeIntersection.Domain.Model;

namespace CubeIntersection.Domain.Concrete
{
    public class CubeCollisionDetector : ICubeCollisionDetector
    {
        public CubeCollisionDetector()
        {
        }

        bool ICubeCollisionDetector.Collides(Cube cubeA, Cube cubeB)
        {
            return cubeA.Width.Collides(cubeB.Width)
                || cubeA.Height.Collides(cubeB.Height)
                || cubeA.Depth.Collides(cubeB.Depth);
        }
    }
}
