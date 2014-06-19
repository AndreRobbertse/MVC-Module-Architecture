using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC.Module.Core
{
    public static class PluginBootstrapper
    {
        static PluginBootstrapper()
        {

        }

        public static void Initialize(string pluginPath)
        {
            foreach (var asmbl in PluginManager.Current.Modules.Values)
            {
                BoC.Web.Mvc.PrecompiledViews.ApplicationPartRegistry.Register(asmbl);
            }
        }
    }
}
