using MVC.Module.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace MVC.Module.Test
{
    public class TestModule : IModule
    {
        public string Title
        {
            get { return "Test Plugin"; }
        }

        public string Name
        {
            get { return Assembly.GetAssembly(GetType()).GetName().Name; }
        }

        public Version Version
        {
            get { return new Version(1, 0, 0, 0); }
        }

        public string EntryControllerName
        {
            get { return "Test"; }
        }

        public string Action
        {
            get { return "Index"; }
        }
    }
}