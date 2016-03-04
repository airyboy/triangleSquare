using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TriangleCalc;

namespace Tests
{
    public class TriangleSquareTests
    {
        [Fact]
        public void the_square_is_correct()
        {
            Assert.True(TriangleSquare.CalcSquare(3,4,5) == 6);
        }

        [Fact]
        public void on_negative_sides_throws_exception()
        {
            Assert.Throws(typeof(TriangleSquare.IncorrectSideLengthException), () => TriangleSquare.CalcSquare(-1, 0, 1));
        }

        [Fact]
        public void on_impossible_triangle_throws_exception()
        {
            Assert.Throws(typeof(TriangleSquare.ImpossibleTriangleException), () => TriangleSquare.CalcSquare(10, 4, 4));
        }
    }
}
