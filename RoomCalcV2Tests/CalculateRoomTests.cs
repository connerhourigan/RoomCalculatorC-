using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomCalcV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalcV2.Tests
{
    [TestClass()]
    public class CalculateRoomTests
    {
        [TestMethod()]
        public void CalcWallPaintTest()
        {
            List<float> walls = new List<float>();
            walls.Add(4.2f);
            walls.Add(5.5f);
            float wallheight = 4.7f;
            float value = 0;
            value = CalculateRoom.CalcWallPaint(walls, wallheight);
            Assert.AreEqual(91.18, Math.Round(value, 2));
        }
    }
}