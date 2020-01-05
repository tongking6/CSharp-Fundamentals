using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void StringBehavesLikeValueType()
        {
            var name = "mike";
            MakeUpperCase(name);

            Assert.Equal("mike", name);
        }

        private void MakeUpperCase(string arg)
        {
            arg.ToUpper();
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var x = GetInt();
            SetInt(x);

            Assert.Equal(3, x);
        }

        private void SetInt(int v)
        {
            v = 5;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(out book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Book");

            Assert.Equal("New Book", book1.Name);
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1,book2));
        }

        private void GetBookSetName(out Book book, string name)
        {
            book = new Book(name);
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }

        private void SetName(Book book, string newName)
        {
            book.Name = newName;
        }
    }
}