﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SimpleMembershipDbFirst
{
    using System.Web.Security;

    using WebMatrix.WebData;

    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            // Initialize SimpleMembership DB
            try
            {
                if (!WebSecurity.Initialized)
                {
                    WebSecurity.InitializeDatabaseConnection(
                        "DefaultConnection", "UserProfile", "UserId", "UserName", autoCreateTables: false);

                    // Seed Admin Role and User
                    if (!Roles.RoleExists("Administrators"))
                    {
                        Roles.CreateRole("Administrators");
                    }
                    if (!WebSecurity.UserExists("admin"))
                    {
                        WebSecurity.CreateUserAndAccount("admin", "password", propertyValues: new { FirstName = "Administrator" });
                        Roles.AddUserToRole("admin", "Administrators");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("The ASP.NET Simple Membership database could not be initialized. For more information, please see http://go.microsoft.com/fwlink/?LinkId=256588", ex);
            }
        }
    }
}