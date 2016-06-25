using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Project.Startup1))]

namespace Project
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
