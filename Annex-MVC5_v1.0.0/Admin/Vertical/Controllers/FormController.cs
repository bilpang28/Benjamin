﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vertical.Controllers
{
    public class FormController : Controller
    {
        [ActionName("form-advanced")]
        public ActionResult formadvanced()
        {
            return View();
        }

        [ActionName("form-editors")]
        public ActionResult formeditors()
        {
            return View();
        }

        [ActionName("form-elements")]
        public ActionResult formelements()
        {
            return View();
        }

        [ActionName("form-mask")]
        public ActionResult formmask()
        {
            return View();
        }

        [ActionName("form-summernote")]
        public ActionResult formsummernote()
        {
            return View();
        }

        [ActionName("form-uploads")]
        public ActionResult formuploads()
        {
            return View();
        }

        [ActionName("form-validation")]
        public ActionResult formvalidation()
        {
            return View();
        }

        [ActionName("form-xeditable")]
        public ActionResult formxeditable()
        {
            return View();
        }
    }
}