using Bkstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bkstore.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Random()
        {
            var book = new Book() { Name = "With the old breed"};

            return View(book);
        }
    }
}