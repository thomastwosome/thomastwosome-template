﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.Mvc.Startup))]
namespace Web.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
