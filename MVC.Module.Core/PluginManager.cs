using MVC.Module.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MVC.Module.Core
{
    public class PluginManager
    {
        public string PluginFolder;

        //public PluginManager()
        //{
        //    Modules = new Dictionary<IModule, Assembly>();
        //}

        public PluginManager(string pluginFolder)
        {
            this.PluginFolder = pluginFolder;
            Modules = new Dictionary<IModule, Assembly>();
        }

        private static PluginManager _current;
        public static PluginManager Current
        {
            get { return _current ?? (_current = new PluginManager("plugins")); }
        }

        internal Dictionary<IModule, Assembly> Modules { get; set; }

        public List<IModule> GetModules()
        {
            return Modules.Select(m => m.Key).ToList();
        }

        public IModule GetModule(string name)
        {
            return GetModules().Where(m => m.Name == name).FirstOrDefault();
        }
    }
}
