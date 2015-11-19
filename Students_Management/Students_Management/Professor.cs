using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Management
{
    class Professor
    {
        public Professor()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Course { get; set; }

        private void selectCourseToTeach()
        {

        }

    }
}
