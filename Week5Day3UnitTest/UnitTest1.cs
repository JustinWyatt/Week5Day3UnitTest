using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Week5Day3UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckIfAgeIsCaluclatedCorrectly()
        {
            LibraryManager mgr = new LibraryManager();
            var student = new Student();
            const decimal expectedAge = 24m;
            decimal daysOfYear = 365m;

            student.DateOfBirth = DateTime.Now.AddDays((int)(-expectedAge * daysOfYear));

            mgr.AddStudentToList(student);            

            Assert.AreEqual(expectedAge, student.Age);
        }

        [TestMethod]
        public void CheckForCheckOut()
        {
            var book = new Book();
            var student = new Student();

            LibraryManager mgr = new LibraryManager();
            var library = mgr.CheckOutBook(book, student, DateTime.Parse("9/05/2004"));
            List<Library> libraries = new List<Library>();

            Assert.AreEqual(DateTime.Parse("9/05/2004"), library.BorrowDate);
            Assert.AreEqual(DateTime.Parse("10/05/2004"), library.ExpectedReturnDate);
        }

        [TestMethod]
        public void CheckForCheckIn()
        {
            LibraryManager mgr = new LibraryManager();
            var book = new Book();
            var library = mgr.CheckInBook(book, DateTime.Parse("10/7/2015"));

            //mgr.AddBookToList(book);

            Assert.AreEqual(DateTime.Parse("10/7/2015"), library.ActualReturnDate);
            Assert.IsNull(library.ExpectedReturnDate);
        }
    }
}
