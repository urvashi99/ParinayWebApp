using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_WebApp.Models
{
    public class SearchDto 
    {
        public SearchBaseDto searchFilter { get; set; }
        public List<ProfileDto> profiles { get; set; }
    }
}