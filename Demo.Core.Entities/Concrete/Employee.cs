using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.Core.Entities.Concrete
{
    public class Employee : IEntity
    {
        [Key]
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }

        public DateTime BirthDate { get; set; }
        public string City { get; set; }

    }
}
