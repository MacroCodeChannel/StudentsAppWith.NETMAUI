using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Business.Models
{
    public  class Student
    {
        [Key]
        public int Id { get; set; }

        public  string FirstName { get; set; }

        public  string MiddleName { get; set; }

        public  string LastName { get; set; }

        public  int PhoneNumber { get; set; }

        public  string EmailAddress { get; set; }

        public   string Gender { get; set; }

        public   string Address { get; set; }

        public  string Country { get; set; }

        public  string City { get; set; }
    }
}
