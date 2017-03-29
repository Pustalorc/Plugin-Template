using Rocket.API.Collections;
using Rocket.Core.Plugins;

namespace PluginTemplate
{
    public class PluginTemplate : RocketPlugin<ConfigurationTemplate>
    {
        // This static variable called Instance is required if you want to communicate your main template with this or use
        // Translations or other useful stuff, so keep it here, but do change the type of the variable if you change the
        // Class name.
        public static PluginTemplate Instance;

        // These are the default translations that are generated. The first part is the name or identifier and the 2nd part
        // Is the string that will be sent when calling the translation.
        public override TranslationList DefaultTranslations
        {
            get
            {
                return new TranslationList(){
                    { "template_translation_1", "This is the message that will appear on chat when the translation is called." },
                    { "template_translation_2", "This is the message that will appear on chat when the translation is called." }
                };
            }
        }

        protected override void Load()
        {
            Instance = this;

            // Any variables or things you need to do when the plugin loads, like handle events, etc. Should be done here.

            Rocket.Core.Logging.Logger.LogWarning("Plugin Template has been loaded!");
        }

        protected override void Unload()
        {
            Instance = null;

            // Any variables or things you had to do when the plugin loaded, like handle events, etc. should be undone here.
            // Example with an event: 

            Rocket.Core.Logging.Logger.LogWarning("Tempban by persiafighter has been unloaded!");
        }
    }
}
