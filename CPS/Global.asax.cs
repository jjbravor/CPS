﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;


namespace CPS
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
          
               BundleConfig.RegisterBundles(System.Web.Optimization.BundleTable.Bundles);
        }

    }
}