using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBM1Feb2024MVCIntro.Controllers
{
    public class SortController : Controller
    {
        // GET: Sort
        public ActionResult Index(string values, string id)
        {
            var brokenValues = values.Split('/');
            Array.Sort(brokenValues);
            return Content(  String.Join(", ", brokenValues));
        }
    }
}