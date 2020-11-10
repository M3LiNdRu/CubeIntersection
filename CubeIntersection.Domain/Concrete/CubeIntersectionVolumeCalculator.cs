using CubeIntersection.Domain.Extensions;
using CubeIntersection.Domain.Interface;
using CubeIntersection.Domain.Model;

namespace CubeIntersection.Domain.Concrete
{
    public class CubeIntersectionVolumeCalculator : ICubeIntersectionVolumeCalculator
    {
        public CubeIntersectionVolumeCalculator()
        {
        }

        double ICubeIntersectionVolumeCalculator.Calculate(Cube cubeA, Cube cubeB)
        {
            return cubeA.Width.Overlap(cubeB.Width)
                * cubeA.Height.Overlap(cubeB.Height)
                * cubeA.Depth.Overlap(cubeB.Depth);
        }
    }
}
