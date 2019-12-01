using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCaptcha.Models;

namespace WebAppCaptcha.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ViewBag.Message = "Result of CAPTCHA image displayed!";
            return View();
        }

        [HttpPost]
        public ActionResult Index(string CaptchaText)
        {
            if (CaptchaText == HttpContext.Session["captchastring"].ToString())
                ViewBag.Message = "CAPTCHA verification successful!";
            else
                ViewBag.Message = "CAPTCHA verification failed!";

            return View();
        }

        public CaptchaImageResult ShowCaptchaImage()
        {
            return new CaptchaImageResult();
        }
    }
}