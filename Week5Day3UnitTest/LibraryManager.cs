using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Day3UnitTest
{
    public class LibraryManager
    {
        public List<Book> books { get; set; }
        public List<Student> students { get; set; }
        public List<Library> libraries { get; set; }
                
        public void AddStudentToList(Student s)
        {
            s.Age = (int) (DateTime.Now.Subtract(s.DateOfBirth).TotalDays) / 365;
        }

        public void AddBookToList(Book b)
        {
            b.Id = books.Max(x => x.Id) + 1;
            books.Add(b);
            
        }

        public Library CheckOutBook(Book b, Student s, DateTime borrowdate)
        {
            var result = new Library();
            //if (libraries.Any())
            //{
            //    result.Id = libraries.Max(x => x.Id) + 1;
            //}
            //else
            //{
            //    result.Id = 1;
            //}
            //result.Book = b;
            //result.Student = s;
            result.BorrowDate = borrowdate;
            result.ExpectedReturnDate = borrowdate.AddMonths(1);
            //libraries.Add(result);
            return result;
        }
        public Library CheckInBook(Book b, DateTime returndate)
        {
            //var result = libraries.FirstOrDefault(x => x.Book.Id == b.Id && x.ExpectedReturnDate != null);
            var result = new Library();

            result.ExpectedReturnDate = null;
            result.ActualReturnDate = returndate;
            return result;
        }
    }
}
