using System.Collections.Generic;
using CHW;
using Xunit;

namespace CHomework.Tests
{
    public class StructuredArrayTests
    {
        public static IEnumerable<object[]> ListWithZeros()
        {
            yield return new object[] {
                new List<int>{3,2,0,1}
            };
        }
        public static IEnumerable<object[]> ListWithoutZeros()
        {
            yield return new object[] {
                new List<int>{5,2,3,1}
            };
        }

        [Theory]
        [MemberData(nameof(ListWithZeros))]
        public void SecondTask_StructuredArray_ReturnZerosAtTheEnd(List<int> initial)
        {
            //Arrange
            var expected = new List<int> { 3, 2, 1, 0 };
            //Act
            var actual = CsharpTasks.StructuredArray(initial);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(ListWithoutZeros))]
        public void SecondTask_StructuredArray_ReturnInitialList(List<int> initial)
        {
            //Arrange
            var expected = new List<int> { 5, 2, 3, 1 };
            //Act
            var actual = CsharpTasks.StructuredArray(initial);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
