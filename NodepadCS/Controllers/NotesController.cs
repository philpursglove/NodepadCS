using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NodepadCS.Controllers
{
    public class NotesController : Controller
    {
        private readonly INoteRepository noteRepository;

        public NotesController(INoteRepository noteRepository)
        {
            this.noteRepository = noteRepository;
        }

        // GET: Notes
        public ActionResult Index()
        {
            return View();
        }
    }
}