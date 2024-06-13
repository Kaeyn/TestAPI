using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VLUTESTAPI.Models
{
    public partial class Category
    {
        public int Code { get; set; }
        public string IdCategory { get; set; }
        public string CategoryName { get; set; }
        public string ParentId { get; set; }
    }
}
