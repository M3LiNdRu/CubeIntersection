using CubeIntersection.Domain.Model;

namespace CubeIntersection.Domain.Interface
{
    public interface ICubeCollisionDetector
    {
        bool Collides(Cube cubeA, Cube cubeB);
    }
}
