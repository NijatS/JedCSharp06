using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.CodeFirst
{
    public class StudentAddress
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public int StudentId   { get; set; }
        public Student Student { get; set; }
    }
}
