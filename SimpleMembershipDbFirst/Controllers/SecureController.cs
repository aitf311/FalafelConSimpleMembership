using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMembershipDbFirst.Controllers
{
    using System.Web.Security;

    using WebMatrix.WebData;

    public class SecureController : Controller
    {
        //
        // GET: /Secure/
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Administrators")]
        public ActionResult AdminOnly()
        {
            // Use attribute, or:
            //WebSecurity.RequireRoles(new [] { "Administrators" });

            return View();
        }
    }
}
