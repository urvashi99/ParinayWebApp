using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_WebApp.Models
{
    public class ProfileDto
    {
        public int PID { get; set; }
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; } = DateTime.Now;
        [DisplayName("Gender")]
        public int GenderID { get; set; }

        [DisplayName("Gender")]
        public string GenderText { get; set; }
        [DisplayName("Height")]
        public int HeightID { get; set; }
        [DisplayName("Religion")]
        public string ReligionText { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        [DisplayName("Religion")]
        public int ReligionID { get; set; }
        [DisplayName("Community")]
        public int CommunityID { get; set; }
        [DisplayName("Community")]
        public string CommunityText { get; set; }
        [DisplayName("MotherToungue")]
        public int MotherToungeID { get; set; }
        [DisplayName("Qualification")]
        public int QualificationID { get; set; }
        [DisplayName("Currently Working?")]
        public int IsWorkingID { get; set; }
        [DisplayName("Organization Type")]
        public int WorkingWithID { get; set; }
        [DisplayName("Profession")]
        public int ProfessionID { get; set; }
        public string Company { get; set; }
        [DisplayName("Annual Income")]
        public int IncomeID { get; set; }
        public string CreatingFor { get; set; }
        public string MoreDetails { get; set; }
        public string PrimaryMobileNo { get; set; }
        public string AlternateMobileNo { get; set; }
        public string EmailID { get; set; }
        public string ProfileImageURL1 { get; set; }
        public string ProfileImageURL2 { get; set; }
        public string ProfileImageURL3 { get; set; }
        public string ProfileImageURL4 { get; set; }
        [DisplayName("Diet")]
        public int EatingID { get; set; }
        public DateTime EnterDate { get; set; }
    }
}