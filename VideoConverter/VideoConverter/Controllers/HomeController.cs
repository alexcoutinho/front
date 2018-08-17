using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;



namespace VideoConverter.Controllers
{


    public class HomeController : Controller
    {

        private HostingEnvironment hostingEnv;


        public HomeController(HostingEnvironment env)
        {
            this.hostingEnv = env;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
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

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
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

        [HttpPost]
        public ActionResult UploadFiles()
        {
            long size = 0;
            var files = Request.Form;

            foreach (string file in Request.Files)
            {
                HttpPostedFileBase hpf = Request.Files[file] as HttpPostedFileBase;
                if (hpf.ContentLength == 0)
                    continue;

                //string filename = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot") + $@"\uploadedfiles\{file}";
                string filename = Path.Combine(Server.MapPath("~/App_Data"), Path.GetFileName(hpf.FileName));

                //size += file.Length;
                //using (FileStream fs = System.IO.File.Create(filename))
                //{
                //    file.CopyTo(fs);
                //    fs.Flush();
                //}
            }
            string message = $"{files.Count} file(s) / { size}  bytes uploaded successfully!";

            return Json(message);
        }











    }
}
