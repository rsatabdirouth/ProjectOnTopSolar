using ProjectOnTopSolar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectOnTopSolar.ViewModels
{
    public class SecondIndexViewModel
    {
        public SecondIndexViewModel()
        {
            EnquieryViewModel = new EnquieryViewModel();
            PropertyViewModel = new PropertyViewModel();
        }
        public EnquieryViewModel EnquieryViewModel { get; set; }
        public PropertyViewModel PropertyViewModel { get; set; }
    }
}