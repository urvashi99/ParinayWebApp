using MVC_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WebApp.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
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
            SearchDto filters = new SearchDto();
            filters.profiles = new List<ProfileDto>();
            return View(filters);
        }

        // GET: Search/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Search/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Search/Create
        [HttpPost]
        public ActionResult Create(SearchDto search)
        {
            try
            {
                // TODO: Add insert logic here
                SearchDto filters = new SearchDto();
                filters.profiles = new List<ProfileDto>
                {
                    new ProfileDto
                    {
                        PID = 1,
                        ReligionText = "Test",
                        FirstName = "FName",
                        LastName = "LName",
                        Age = 30,
                        EmailID = "test@test.com",
                        PrimaryMobileNo = "123"
                    }
                };
                return RedirectToAction("Index", filters);
            }
            catch
            {
                return View();
            }
        }

        // GET: Search/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Search/Edit/5
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

        // GET: Search/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Search/Delete/5
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
