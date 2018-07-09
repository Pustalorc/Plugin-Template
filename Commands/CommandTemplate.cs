using System;
using Rocket.API.Commands;
using Rocket.API.Plugins;

namespace persiafighter.Plugins.RocketMod.Example.Commands
{
    public class CommandExample : ICommand
    {
        /* This is a beautiful constructor for the command, if you need an instance of your plugin,
        * here is where you should store locally the instance.
        */
        public CommandExample(IPlugin plugin) { }

        /* Just like in RocketMod4, you need to specify if the console or players should be able
        * to execute the command. With this variable, you decide that.
        */
        public bool SupportsUser(Type user) => true;

        /* This is the name of the command, or what the player has to do ingame to run the command.
        * In this case, the command ingame would be /example
        */
        public string Name => "example";

        // This should be a very brief but concise description of what the command is.
        public string Summary => "Lists the available jobs.";

        // This should be a betterdescription of what the command is and is supposed to function.
        public string Description => "Lists the available jobs.";

        // This is the permission required by the player in order for the command to even execute.
        public string Permission => "Jobs";

        // Here is where you give a small string of what the syntax of the command should be.
        public string Syntax => null;

        // Finally, these will be the aliases create for the command itself.
        public string[] Aliases => new[] { "LJ", "LJobs", "ListJobs" };

        // This field should be left as null unless a set of commands are very similar in name (or function).
        public IChildCommand[] ChildCommands => null;

        /* Here is where you tell the command what to do.
        * context variable will have everything you need, arguments,
        * caller and all of that sweet meat.
        */
        public void Execute(ICommandContext context) { }
    }
}
