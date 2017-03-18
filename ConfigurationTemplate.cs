using Rocket.API;

namespace PluginTemplate
{
    public class ConfigurationTemplate : IRocketPluginConfiguration
    {
        // You are not limited to one of each type, multiple variables can be used. The most commonly used options are:
        // Bool for true or false, string for a phrase/sentence, and int for a number.
        public bool ThisIsATrueOrFalseOption;
        public string ThisIsAStringOrPhrase;
        public int ThisIsANumber;

        public void LoadDefaults()
        {
            // Here you create the values for the default config, for example:
            ThisIsATrueOrFalseOption = false;
            ThisIsAStringOrPhrase = "Yes it is :)";
            ThisIsANumber = 21;
        }
    }
}
