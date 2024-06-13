using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VLUTESTAPI.Models
{
    public partial class Customer
    {
        public int Code { get; set; }
        public string IdUser { get; set; }
        public string Name { get; set; }
        public DateTime? Birth { get; set; }
        public int? Gender { get; set; }
        public string Avartar { get; set; }

        public virtual User IdUserNavigation { get; set; }
    }
}
