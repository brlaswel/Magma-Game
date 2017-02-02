using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Magma.Environment.Tiles;
using Magma.Game.Levels;


namespace Magma.Control.Tests
{


    [TestClass()]
    public class MovementTests
    {

        [TestMethod()]
        public void DownTest()
        {
            Console.WriteLine("Downward Movement");
            Level2 TestLevel2 = new Level2();

            Movement instance = new Movement();
            RedPlayer actualR = new RedPlayer();
            BluePlayer actualB = new BluePlayer();
            instance.Down(actualR, actualB, TestLevel2);
            int expectedR = actualR.GetY -40;
            int expectedB = actualB.GetY -40;


            instance.Down(actualR, actualB, TestLevel2);
            Assert.AreEqual(expectedR, actualR.GetY);
        }

        [TestMethod()]
        public void UpTest()
        {
            Console.WriteLine("Upward Movement");
            Level2 TestLevel2 = new Level2();

            Movement instance = new Movement();
            RedPlayer actualR = new RedPlayer();
            BluePlayer actualB = new BluePlayer();
            instance.Up(actualR, actualB, TestLevel2);
            int expectedR = actualR.GetY -40;
            int expectedB = actualB.GetY -40 ;


            instance.Up(actualR, actualB, TestLevel2);
            Assert.AreEqual(expectedR, actualR.GetY);

        }

        [TestMethod()]
        public void RightTest()
        {
            Console.WriteLine("Upward Movement");
            Level2 TestLevel2 = new Level2();

            Movement instance = new Movement();
            RedPlayer actualR = new RedPlayer();
            BluePlayer actualB = new BluePlayer();
            instance.Right(actualR, actualB, TestLevel2);
            int expectedR = actualR.GetX + 40;
            int expectedB = actualB.GetX + 40;


            instance.Right(actualR, actualB, TestLevel2);
            Assert.AreEqual(expectedR, actualR.GetX);

        }

        [TestMethod()]
        public void LeftTest()
        {
            Console.WriteLine("Upward Movement");
            Level2 TestLevel2 = new Level2();

            Movement instance = new Movement();
            RedPlayer actualR = new RedPlayer();
            BluePlayer actualB = new BluePlayer();
            instance.Left(actualR, actualB, TestLevel2);
            int expectedR = actualR.GetX - 40;
            int expectedB = actualB.GetX - 40;


            instance.Left(actualR, actualB, TestLevel2);
            Assert.AreEqual(expectedR, actualR.GetX);

        }

        public void testDown()
        {
            Console.WriteLine("Downward Movement");
            Level2 TestLevel2 = new Level2();
            TestLevel2.AddRedPlayer(12, 8);

            Movement instance = new Movement();
            RedPlayer actualR = new RedPlayer();
            BluePlayer actualB = new BluePlayer();

            instance.Down(TestLevel2.GetRedPlayer, actualB, TestLevel2);
            int expectedR = actualR.GetY -40;
            int expectedB = actualB.GetY -40;
           

            instance.Down(actualR, actualB, TestLevel2);
            Assert.AreEqual(expectedR, actualR.GetY);

            }
        public void testUp()
        {
            Console.WriteLine("Upward Movement");
            Level2 TestLevel2 = new Level2();

            Movement instance = new Movement();
            RedPlayer actualR = new RedPlayer();
            BluePlayer actualB = new BluePlayer();
            instance.Up(actualR, actualB, TestLevel2);
            int expectedR = actualR.GetY + 40;
            int expectedB = actualB.GetY + 40;


            instance.Up(actualR, actualB, TestLevel2);
            Assert.AreEqual(expectedR, actualR.GetY);


        }
    }
}