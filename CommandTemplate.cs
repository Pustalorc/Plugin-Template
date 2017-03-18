using Rocket.API;
using Rocket.API.Serialisation;
using Rocket.Core.Logging;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;

namespace PluginTemplate
{
    public class CommandTemplate : IRocketCommand
    {
        public AllowedCaller AllowedCaller
        {
            // This will tell rocket if the console or player can execute the command.
            // Valid values are: Both, Console, Player
            get { return AllowedCaller.Both; }
        }

        public string Name
        {
            // This is the name of the command, or what the player has to do ingame to run the command.
            // In this case, the command ingame would be /template
            get { return "Template"; }
        }

        public string Help
        {
            // This is the help that will be shown on the rocket page about what the command does.
            get { return "This is a template command."; }
        }

        public string Syntax
        {
            // This will show in the rocket page what the arguments, or the syntax of the command is.
            // In other words, if you require the person to specify a player name, you would put here in between
            // '{}' or '[]' or '<>', depending on how you or others might interpretate the symbols.
            get { return "<example>"; }
        }

        public List<string> Aliases
        {
            // This will allow you to set aliases for this command. Most of the times this is used if the main name
            // Of the command is too long. For example, the alias below would allow the player ingame to use /tmp
            // Which will execute this command.
            get { return new List<string>() { "tmp" }; }
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            // This is the part of the code where you tell what the command does. Most programmers here will check if
            // The caller is the console or an actual player by doing the following:
            if (caller is ConsolePlayer)
            {
                // This is the console, so execute things for the console, depending on what your plugin does. Normally
                // Here Rocket.Core.Logging.Logger.LogWarning(); is used.
            }
            else if (!(caller is ConsolePlayer))
            {
                // This is the ingame player. There are other ways to check, like to see if the caller is null, but this
                // Is so far the best way to check it. In here you would execute things for the player, like
                // "UnturnedChat.Say();" or others.
            }
        }

        public List<string> Permissions
        {
            // These are the permissions of the plugin. ie: what will tell rocket that if the group has this permission
            // Then that group can use the command. More permissions can be added, but most of the times those are better
            // Not to be included here and rather checked for in the execute part.
            get
            {
                return new List<string>
                {
                    "template"
                };
            }
        }
    }
}
