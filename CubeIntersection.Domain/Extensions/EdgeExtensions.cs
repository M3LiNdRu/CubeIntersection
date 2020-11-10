using System;
using CubeIntersection.Domain.Model;

namespace CubeIntersection.Domain.Extensions
{
    public static class EdgeExtensions
    {
        public static double Overlap(this Edge edgeA, Edge edgeB) => Math.Max(0, EdgeExtensions.Difference(edgeA, edgeB));

        public static bool Collides(this Edge edgeA, Edge edgeB) => EdgeExtensions.Difference(edgeA, edgeB) >= 0;

        private static double Difference(Edge edgeA, Edge edgeB) => Math.Min(edgeA.End, edgeB.End) - Math.Max(edgeA.Start, edgeB.Start);
    }
}
