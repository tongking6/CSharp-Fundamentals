using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var book = new Book("Tong Gradebook");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(95.5);

            var expectedAverage = (89.1 + 90.5 + 95.5) / 3;

            // act
            var actual = book.GetStatistics();

            //assert
            Assert.Equal(expectedAverage, actual.Average, 1);
            Assert.Equal(89.1, actual.LowestGrade, 1);
            Assert.Equal(95.5, actual.HighestGrade, 1);
        }
    }
}
