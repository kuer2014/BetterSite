﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BetterSite.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            /// /Article/2.html           
            routes.MapRoute(
              name: "AllArticleList",
              url: "Article/{Page}.html",
              defaults: new { controller = "Article", action = "Index", Page = 1 },
               namespaces: new string[] { "BetterSite.UI.Controllers" },
             constraints: new
             {
                 Page = @"\d{1,5}"
             }
          );
            /// /Article/1
            routes.MapRoute(
          name: "ArticleDetail",
          url: "Article/{id}",
          defaults: new { controller = "Article", action = "Details", id= 1 },
           namespaces: new string[] { "BetterSite.UI.Controllers" },
             constraints: new
             {
                 id = @"\d{1,5}"
             }
      );
            /// /Sites/SITE1494393044614
            routes.MapRoute(
          name: "SiteDetail",
          url: "Sites/{SiteCode}",
          defaults: new { controller = "Sites", action = "Detail", SiteCode = UrlParameter.Optional },
           namespaces: new string[] { "BetterSite.UI.Controllers" },
             constraints: new
             {
                 SiteCode = @"SITE\d{13}"
             }
      );
            /// /ZY/2.html           
            routes.MapRoute(
              name: "SiteListByType",
              url: "{TypeCode}/{Page}.html",
              defaults: new { controller = "Sites", action = "Index",  Page = 1 },
               namespaces: new string[] { "BetterSite.UI.Controllers" },
             constraints: new
             {
                 TypeCode = @"[a-z]{2,10}",
                 Page = @"\d{0,5}"
             }
          );
            ///
            /// /zy/tag/学习/1.html
            routes.MapRoute(
              name: "SiteListByTag",
              url: "{TypeCode}/{Tag}/{Page}.html",
              defaults: new { controller = "Sites", action = "Index", Page =1 },
               namespaces: new string[] { "BetterSite.UI.Controllers" },
             constraints: new
             {
                 TypeCode = @"[a-z]{2,10}",
                 Page= @"\d{0,5}"
             }
          );
            /// /2.html           
            routes.MapRoute(
              name: "AllSiteList",
              url: "{Page}.html",
              defaults: new { controller = "Sites", action = "Index", Page = 1 },
               namespaces: new string[] { "BetterSite.UI.Controllers" },
             constraints: new
             {              
                 Page = @"\d{0,5}"
             }
          );
            /// /Blog/1
            routes.MapRoute(
          name: "BlogDetail",
          url: "blog/{id}",
          defaults: new { controller = "Blog", action = "Details" },
           namespaces: new string[] { "BetterSite.UI.Controllers" },
             constraints: new
             {
                 id = @"\d{1,5}"
             }
      );
            /// /Blog/
            routes.MapRoute(
          name: "BlogList",
          url: "blog",
          defaults: new { controller = "Blog", action = "Index" },
           namespaces: new string[] { "BetterSite.UI.Controllers" }
           
      );  /// /DoubanRank/
            routes.MapRoute(
          name: "DoubanRank",
          url: "douban/{desc}",
          defaults: new { controller = "DoubanRank", action = "Index" },
           namespaces: new string[] { "BetterSite.UI.Controllers" }

      );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                //constraints: new string[] { "BetterSite.UI.Controllers" }
                namespaces: new string[] { "BetterSite.UI.Controllers" }

            );
        }
    }
}