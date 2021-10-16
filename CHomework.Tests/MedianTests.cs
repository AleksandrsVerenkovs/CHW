using System.Collections.Generic;
using Xunit;

namespace CHomework.Tests
{
    public class MedianTests
    {
        public static IEnumerable<object[]> ArrayWithEvenAmount()
        {
            yield return new object[] {
                new List<int> {3,2,0,1},
                new List<int> {5,3,6,4,1,9},
                new List<int> {5,3,6,4,1,9,10,16},
            };
        }
        public static IEnumerable<object[]> ArrayWithOddAmount()
        {
            yield return new object[] {
                new List<int> {3,2,0},
                new List<int> {5,3,6,4,1},
                new List<int> {5,3,6,4,1,9,10},
            };
        }

        public static IEnumerable<object[]> ArrayWithOneValue()
        {
            yield return new object[] {
                new List<int> {2},

            };
        }

        public static IEnumerable<object[]> EmptyArray()
        {
            yield return new object[] {
                new List<int> {},

            };
        }

        [Theory]
        [MemberData(nameof(ArrayWithEvenAmount))]
        public void SecondTask_Median_ReturnMedianOfEvenArray(List<int> a, List<int> b, List<int> c)
        {
            //Assert
            Assert.True(Program.Median(a) == 1.5);
            Assert.True(Program.Median(b) == 4.5);
            Assert.True(Program.Median(c) == 5.5);
        }

        [Theory]
        [MemberData(nameof(ArrayWithOddAmount))]
        public void SecondTask_Median_ReturnMedianOfOddArray(List<int> a, List<int> b, List<int> c)
        {
            //Assert
            Assert.True(Program.Median(a) == 2);
            Assert.True(Program.Median(b) == 4);
            Assert.True(Program.Median(c) == 5);
        }

        [Theory]
        [MemberData(nameof(ArrayWithOneValue))]
        public void SecondTask_Median_ReturnArrayValue(List<int> a)
        {
            //Assert
            Assert.True(Program.Median(a) == 2);
        }

        [Theory]
        [MemberData(nameof(EmptyArray))]
        public void SecondTask_Median_ReturnZero(List<int> a)
        {
            //Assert
            Assert.True(Program.Median(a) == 0);
        }
    }
}
