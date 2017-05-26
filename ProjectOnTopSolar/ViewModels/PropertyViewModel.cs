using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectOnTopSolar.ViewModels
{
    public class PropertyViewModel
    {   public int Id { get; set; }
        public string PropertyType { get; set; }
        public string HomeOwner { get; set; }
        public string YourPostCode { get; set; }
    }
}