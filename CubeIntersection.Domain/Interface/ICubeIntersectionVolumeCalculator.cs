using CubeIntersection.Domain.Model;

namespace CubeIntersection.Domain.Interface
{
    public interface ICubeIntersectionVolumeCalculator
    {
        double Calculate(Cube cubeA, Cube cubeB);
    }
}
