using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Day3UnitTest
{
    public class Library
    {
        public Book Book { get; set; }
        public DateTime? BorrowDate { get; set; }
        public DateTime? ExpectedReturnDate { get; set; }
        public int? Id { get; set; }
        public Student Student { get; set; }
        public DateTime? ActualReturnDate { get; set; }
    }
}
