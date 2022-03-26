using System;
using Xunit;
using Lab03___System.IO;

namespace Lab03_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Challenge01()
        {
            string testString = ("5 5 5");
            int result = Program.Challenge1(testString);
            Assert.Equal(125, result);
        }

        [Fact]
        public void Challenge01MoreThanThreeNumbers()
        {
            string testString = ("5 5 5 5 5 5 5");
            int result = Program.Challenge1(testString);
            Assert.Equal(125, result);
        }

        [Fact]
        public void Challenge01LessThanThreeNumbers()
        {
            string testString = ("4 5");
            int result = Program.Challenge1(testString);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Challenge01NegativeNumbers()
        {
            string testString = ("5 5 -10");
            int result = Program.Challenge1(testString);
            Assert.Equal(-250, result);
        }

        /////////////////////////////////////////////////////////

        [Fact]
        public void Challenge02()
        {
            int[] array1 = new int[2] { 10, 20 };
            int result1 = Program.Challenge2(array1);
            Assert.Equal(15, result1);
            int[] array2 = new int[3] { 10, 20, 30 };
            int result2 = Program.Challenge2(array2);
            Assert.Equal(20, result2);
            int[] array3 = new int[4] { 7, 7, 7, 7};
            int result3 = Program.Challenge2(array3);
            Assert.Equal(7, result3);
            int[] array5 = new int[6] { 0, 0, 0, 0, 0, 0 };
            int result5 = Program.Challenge2(array5);
            Assert.Equal(0, result5);
        }
        [Fact]
        public void Challenge04()
        {
            int[] array1 = { 3, 3, 4, 3, 7, 8, 2, 4, 1, 3, 4 };
            Assert.Equal(3, Program.Challenge4(array1));
           
            int[] array2 = { 5, 5, 5, 7, 7, 7 };
            Assert.Equal(5, Program.Challenge4(array2));
            
            int[] array3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.Equal(1, Program.Challenge4(array3));

            int[] array4 = { 5, 5, 5, 5, 5 };
            Assert.Equal(5, Program.Challenge4(array4));

            

        }
        
        [Fact]
        public void TestFindMaximumValue()
        {
            
            int[] array1 = { -10, -90, -10, -30, 100 };
            Assert.Equal(100, Program.Challenge5(array1));
            
            int[] array2 = { -20, -30, -90, -100, -50, -1 };
            Assert.Equal(-1, Program.Challenge5(array2));
            
            int[] array3 = { 7, 7, 7, 7 };
            Assert.Equal(7, Program.Challenge5(array3));
            
            
        }

    }
}
