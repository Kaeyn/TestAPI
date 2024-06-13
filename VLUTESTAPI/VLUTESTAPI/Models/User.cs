using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VLUTESTAPI.Models
{
    public partial class User
    {
        public User()
        {
            Customer = new HashSet<Customer>();
            Employee = new HashSet<Employee>();
        }

        public string IdUser { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime? Birth { get; set; }
        public int? Gender { get; set; }
        public int Status { get; set; }
        public int Permission { get; set; }
        public string Avatar { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
