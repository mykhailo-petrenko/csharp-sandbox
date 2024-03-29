using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookSmokeTest
    {
        [Fact]
        public void BookConstructor_ShouldSetName()
        {
            string expectedName = "Hello Name";
            var b = new Book(expectedName);

            Assert.Equal(expectedName, b.Name);
        }

        [Fact]
        public void ToString_shouldContainName()
        {
            var book = new Book("Test");

            Assert.Equal("'Test': ", book.ToString());
        }

        [Fact]
        public void ToString_shouldContainGrades()
        {
            var book = new Book("Test");

            book.AddGrade(1);
            book.AddGrade(2.3);

            Assert.Equal("'Test': 1 2.3", book.ToString());
        }

        [Fact]
        public void GetStatisctics_ReturnNullForEmptyGrades() {
            var book = new Book("Empty");

            Assert.Null(book.GetStatistics());
        }

        [Fact]
        public void GetStatistics_SmokeTest() {
            var book = new Book("Test");

            book.AddGrade(1);
            book.AddGrade(1);
            book.AddGrade(2);

            var statistics = book.GetStatistics();

            Assert.Equal(1.33, statistics.Average, 2);
            Assert.Equal(1, statistics.Low);
            Assert.Equal(2, statistics.High);
        }

        [Fact]
        public void AddGrade_ShouldNotAcceptLessThenMinGrade()
        {
            var b1 = new Book("Min Range");
            
            Assert.Throws<ArgumentOutOfRangeException>(() => b1.AddGrade(-1));
        }

                [Fact]
        public void AddGrade_ShouldNotAcceptMoreThenMaxGrade()
        {
            var b1 = new Book("Max Range");
            
            Assert.Throws<ArgumentOutOfRangeException>(() => b1.AddGrade(101));
        }
    }
}
