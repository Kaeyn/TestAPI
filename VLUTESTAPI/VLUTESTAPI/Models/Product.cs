using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VLUTESTAPI.Models
{
    public partial class Product
    {
        public int Code { get; set; }
        public string IdProduct { get; set; }
        public string ProductName { get; set; }
    }
}
