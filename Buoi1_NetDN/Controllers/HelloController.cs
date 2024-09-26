using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Buoi1_NetDN.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public string Index()
        {
            return "Tôi là action index";
        }
 
        // GET: Hello/Details/5
        
        public string Welcome(String name,int id=1)
        {
           
            return HttpUtility.HtmlDecode("Hello " + name + ",Numtimes: " + id);
        }
        public string Giaiphuongtrinhbac2(decimal a=2, decimal b=7 , decimal c=3)
        {

            if (a == 0)
            {
                return "Hệ số a không thể bằng 0 trong phương trình bậc 2.";
            }

            decimal delta = b * b - 4 * a * c;
            string result = "";

            if (delta > 0)
            {
                decimal x1 = (-b + (decimal)Math.Sqrt((double)delta)) / (2 * a);
                decimal x2 = (-b - (decimal)Math.Sqrt((double)delta)) / (2 * a);
                result = $"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}";
            }
            else if (delta == 0)
            {
                decimal x = -b / (2 * a);
                result = $"Phương trình có nghiệm kép: x = {x}";
            }
            else
            {
                result = "Phương trình vô nghiệm (Delta < 0).";
            }

            return HttpUtility.HtmlDecode(result);
        }

        // GET: Hello/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hello/Create
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

        // GET: Hello/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hello/Edit/5
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

        // GET: Hello/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hello/Delete/5
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
