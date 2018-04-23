using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DXWebApplication1.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        public ActionResult GridViewPartial() {
            return GridViewPartialCore();
        }
        public ActionResult GridViewPartialCustom(string searchString) {
            ViewData["SearchString"] = searchString;
            return GridViewPartialCore();
        }
        public ActionResult GridViewPartialCore() {
            var model = GetModel();
            return PartialView("GridViewPartial", model);
        }
        private IEnumerable<DataEntry> GetModel() {
            return Enumerable.Range(0, 100).Select(i => new DataEntry { ID = i, Text = "Text " + i });
        }
    }
    public class DataEntry {
        public int ID { get; set; }
        public string Text { get; set; }
    }
}