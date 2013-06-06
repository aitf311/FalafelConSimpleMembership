using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using SimpleMembershipDbFirst.Models;

namespace SimpleMembershipDbFirst
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            // https://manage.dev.live.com
            OAuthWebSecurity.RegisterMicrosoftClient(
                clientId: "00000000480F3528",
                clientSecret: "CAogwwIeS3jcJLbb-1GtNT2nzGfqWYMx");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            //OAuthWebSecurity.RegisterFacebookClient(
            //    appId: "",
            //    appSecret: "");

            //OAuthWebSecurity.RegisterLinkedInClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            //OAuthWebSecurity.RegisterYahooClient();

            OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
