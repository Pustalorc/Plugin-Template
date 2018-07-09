using Rocket.API.DependencyInjection;
using Rocket.API.Permissions;
using Rocket.API.User;
using Rocket.Core.Plugins;
using System.Collections.Generic;
using Rocket.Core.Logging;
using persiafighter.Plugins.RocketMod.Example.Config;

namespace persiafighter.Plugins.RocketMod.Example
{
    public class ExamplePlugin : Plugin<ExampleConfiguration>
    {
        /* This is required for the plugin to correctly register.
        * You can request for permissions manager, player manager and more from here
        * to directly have ready.
        */
        public ExamplePlugin(IDependencyContainer container) : base("Example", container) { }

        /* Just like RocketMod4, you need a load.
        * However, in RocketMod5 you are given directly if the plugin is reloading or not.
        */
        protected override void OnLoad(bool isFromReload)
        {
            Logger.LogInformation("Example Universal Plugin, by persiafigther, " +
                "has been sucessfully loaded!");
        }

        /* And like in RocketMod4, you have your unload, which you can do anything on here.
        * Clear variables, etc.
        */
        protected override void OnUnload()
        {
            Logger.LogInformation("Example Universal Plugin, by persiafighter, " +
                "has been successfully unloaded!");
        }
    }
}
