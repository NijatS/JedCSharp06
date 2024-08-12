using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.CodeFirst
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public StudentAddress StudentAddress { get; set; }
        #region    Convention 1
        //public Group Group { get; set; }
        #endregion

        #region    Convention 3
        //public Group Group { get; set; }
        #endregion
        #region    Convention 4
        public int GroupId { get; set; }
        public Group Group { get; set; }
        #endregion
    }
}
