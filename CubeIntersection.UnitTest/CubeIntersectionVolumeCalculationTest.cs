using CubeIntersection.Domain.Concrete;
using CubeIntersection.Domain.Interface;
using Xunit;

namespace CubeIntersection.UnitTest
{
    public class CubeIntersectionVolumeCalculationTest
    {
        private readonly ICubeBuilder _builder;
        private readonly ICubeIntersectionVolumeCalculator _intersectionVolumeCalculator;

        public CubeIntersectionVolumeCalculationTest()
        {
            _builder = new CubeBuilder();
            _intersectionVolumeCalculator = new CubeIntersectionVolumeCalculator();
        }

        [Fact]
        public void Test_cubes_that_do_not_intersect_success()
        {
            var cubeA = _builder.Build(new Domain.Model.Point(2, 2, 2), 2);
            var cubeB = _builder.Build(new Domain.Model.Point(10, 10, 10), 2);
            var result = _intersectionVolumeCalculator.Calculate(cubeA, cubeB);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_cubes_with_same_height_and_depth_success()
        {
            var cubeA = _builder.Build(new Domain.Model.Point(2, 2, 2), 2);
            var cubeB = _builder.Build(new Domain.Model.Point(3, 2, 2), 2);
            var result = _intersectionVolumeCalculator.Calculate(cubeA, cubeB);
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test_cubes_with_same_width_and_depth_success()
        {
            var cubeA = _builder.Build(new Domain.Model.Point(2, 2, 2), 2);
            var cubeB = _builder.Build(new Domain.Model.Point(2, 3, 2), 2);
            var result = _intersectionVolumeCalculator.Calculate(cubeA, cubeB);
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test_cubes_with_same_width_and_height_success()
        {
            var cubeA = _builder.Build(new Domain.Model.Point(2, 2, 2), 2);
            var cubeB = _builder.Build(new Domain.Model.Point(2, 2, 3), 2);
            var result = _intersectionVolumeCalculator.Calculate(cubeA, cubeB);
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test_one_cube_is_contained_within_the_other_success()
        {
            var cubeA = _builder.Build(new Domain.Model.Point(2, 2, 2), 2);
            var cubeB = _builder.Build(new Domain.Model.Point(2, 2, 2), 1);
            var result = _intersectionVolumeCalculator.Calculate(cubeA, cubeB);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test_cubes_are_completely_overlapped_success()
        {
            var cubeA = _builder.Build(new Domain.Model.Point(2, 2, 2), 2);
            var cubeB = _builder.Build(new Domain.Model.Point(2, 2, 2), 2);
            var result = _intersectionVolumeCalculator.Calculate(cubeA, cubeB);

            Assert.Equal(8, result);
        }

        [Fact]
        public void Test_cubes_are_touching_but_not_intersecting_success()
        {
            var cubeA = _builder.Build(new Domain.Model.Point(2, 2, 2), 2);
            var cubeB = _builder.Build(new Domain.Model.Point(4, 2, 2), 2);
            var result = _intersectionVolumeCalculator.Calculate(cubeA, cubeB);

            Assert.Equal(0, result);
        }
    }
}
