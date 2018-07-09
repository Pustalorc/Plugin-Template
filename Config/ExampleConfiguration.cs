using Rocket.API;

namespace persiafighter.Plugins.RocketMod.Example.Config
{
    public class ExampleConfiguration
    {
        // In here you should put any property for configuration/settings that you may need.
        public string AString { get; set; }
        public bool ABoolean { get; set; }
        public int AnInteger { get; set; }
        
        // You may also give default values to the properties as shown below.
        public string AStringWithADefaultValue { get; set; } = "Hello world!";
    }
}
