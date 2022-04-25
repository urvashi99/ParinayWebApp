using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC_WebApp.Models
{
    public class DropdownDto
    {
        public List<SelectListItem> gender { get; set; }
        public List<SelectListItem> height { get; set; }
        public List<SelectListItem> religion { get; set; }
        public List<SelectListItem> community { get; set; }
        public List<SelectListItem> mother_tounge { get; set; }
        public List<SelectListItem> qualification { get; set; }
        public List<SelectListItem> working { get; set; }
        public List<SelectListItem> work_type { get; set; }
        public List<SelectListItem> profession { get; set; }
        public List<SelectListItem> income { get; set; }
        public List<SelectListItem> eating { get; set; }
    }
}