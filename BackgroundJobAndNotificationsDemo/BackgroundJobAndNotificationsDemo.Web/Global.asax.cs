﻿using System;
using Abp.Dependency;
using Abp.Web;
using Castle.Facilities.Logging;

namespace BackgroundJobAndNotificationsDemo.Web
{
    public class MvcApplication : AbpWebApplication<BackgroundJobAndNotificationsDemoWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            IocManager.Instance.IocContainer.AddFacility<LoggingFacility>(f => f.UseLog4Net().WithConfig("log4net.config"));
            base.Application_Start(sender, e);
        }
    }
}
