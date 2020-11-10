using CubeIntersection.Domain.Concrete;
using CubeIntersection.Domain.Interface;
using Xunit;

namespace CubeIntersection.UnitTest
{
    public class CubeCollisionDetectorTest
    {
        private readonly ICubeCollisionDetector _collisionDetector;
        private readonly ICubeBuilder _builder;

        public CubeCollisionDetectorTest()
        {
            _collisionDetector = new CubeCollisionDetector();
            _builder = new CubeBuilder();
        }

        [Fact]
        public void Test_cubes_that_do_not_touch_success()
        {
            var cubeA = _builder.Build(new Domain.Model.Point(2, 2, 2), 2);
            var cubeB = _builder.Build(new Domain.Model.Point(10, 10, 10), 2);

            var result = _collisionDetector.Collides(cubeA, cubeB);

            Assert.False(result);
        }

        [Fact]
        public void Test_cubes_that_overlap_success()
        {
            var cubeA = _builder.Build(new Domain.Model.Point(2, 2, 2), 2);
            var cubeB = _builder.Build(new Domain.Model.Point(3, 2, 2), 2);

            var result = _collisionDetector.Collides(cubeA, cubeB);

            Assert.True(result);
        }

        [Fact]
        public void Test_cubes_that_touch_success()
        {
            var cubeA = _builder.Build(new Domain.Model.Point(2, 2, 2), 2);
            var cubeB = _builder.Build(new Domain.Model.Point(4, 2, 2), 2);

            var result = _collisionDetector.Collides(cubeA, cubeB);

            Assert.True(result);
        }
        
    }
}
