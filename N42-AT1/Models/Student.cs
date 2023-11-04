using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N42_AT1.Models
{
    internal class Student
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public long SubjectId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatesAt { get; set; }

        public Student(long id, string firstName, string lastName, string emailAddress, long subjectId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            SubjectId = subjectId;
            CreatedAt = DateTime.Now;
        }
    }
}
