﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Twitter.Controllers
{
    public class NotificacionesController : Controller
    {
        // GET: Notificaciones
        public ActionResult Index()
        {
            return View();
        }
    }
}