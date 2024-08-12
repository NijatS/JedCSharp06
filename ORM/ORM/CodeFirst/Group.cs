using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.CodeFirst
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        #region Convention 2
        //public List<Student> Students { get; set; }
        #endregion
        #region Convention 3
        //public List<Student> Students { get; set; }
        #endregion
        #region Convention 3
        public List<Student> Students { get; set; }
        #endregion
    }
}
