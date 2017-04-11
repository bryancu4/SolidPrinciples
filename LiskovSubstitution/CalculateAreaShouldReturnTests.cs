﻿using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiskovSubstitution
{
    [TestClass]
    public class CalculateAreaShouldReturnTests
    {
        [TestMethod]
        public void SixFor2X3Rectangle()
        {
            var myRectangle = new Rectangle { Height = 2, Width = 3 };
            Assert.AreEqual(6, myRectangle.Area());
        }

        [TestMethod]
        public void NineFor3X3Square()
        {
            var mySquare = new Square { SideLength = 3 };
            Assert.AreEqual(9, mySquare.Area());
        }

        [TestMethod]
        public void TwentyFor4X5ShapeFromRectangleAnd9For3X3Square()
        {
            var shapes = new List<Shape>
                             {
                                 new Rectangle {Height = 4, Width = 5},
                                 new Square {SideLength = 3}
                             };
            var areas = new List<int>();
            foreach (Shape shape in shapes)
            {
                if (shape.GetType() == typeof(Rectangle))
                {
                    areas.Add(((Rectangle)shape).Area());
                }
                if (shape.GetType() == typeof(Square))
                {
                    areas.Add(((Square)shape).Area());
                }
            }
            Assert.AreEqual(20, areas[0]);
            Assert.AreEqual(9, areas[1]);
        }
    }
}