using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TL;

namespace WebSite.Models
{
    public class HomeViewModel
    {
        public List<CarouselDto> CarouselItems { get; set; }
        public List<PhotoDto> PortfolioItems { get; set; } 
    }
}