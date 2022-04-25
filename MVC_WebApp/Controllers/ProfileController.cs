using MVC_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WebApp.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            if (Session["EmpId"] != null && Session["EmpId"].ToString() != "0")
            {
                DBClass obj = new DBClass();
                IEnumerable<ProfileDto> profiles = obj.getAllProfiles();
                return View(profiles);
            }
            else
                return RedirectToAction("Create", "Login");
        }

        // GET: Profile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Profile/Create
        public ActionResult Create()
        {
            DBClass obj = new DBClass();
            DropdownDto drp = obj.GetDropdownList();
            ViewBag.GenderDrp = drp.gender;
            ViewBag.heightDrp = drp.height;
            ViewBag.IncomeDrp = drp.income;
            ViewBag.MothertoungeDrp = drp.mother_tounge;
            ViewBag.ProfessionDrp = drp.profession;
            ViewBag.QualificationDrp = drp.qualification;
            ViewBag.ReligionDrp = drp.religion;
            ViewBag.WorkingDrp = drp.working;
            ViewBag.WorkTypeDrp = drp.work_type;
            ViewBag.eating = drp.eating;
            //ViewBag.Communitydrp = drp.community;
            return View();
        }

        // POST: Profile/Create
        [HttpPost]
        public ActionResult Create(ProfileDto empProfile)
        {
            try
            {
                // TODO: Add insert logic here
                DBClass obj = new DBClass();
                if (Session["EmpId"] == null)
                    Session["EmpId"] = "1100";
                empProfile.EmpId = Convert.ToInt32(Session["EmpId"].ToString());
                int result = obj.SaveProfile(empProfile);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Profile/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Profile/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
