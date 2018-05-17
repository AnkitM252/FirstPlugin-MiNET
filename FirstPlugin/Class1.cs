using log4net;
using MiNET;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;

namespace FirstPlugin
{
    [Plugin(Author = "AnkitM252", Description = "FirstPlugin", PluginName = "FirstPlugin", PluginVersion = "1.0")]
    public class Class1: Plugin
    {
        protected override void OnEnable()
        {
            LogManager.GetLogger(typeof (Class1)).InfoFormat("[FirstPlugin] FirstPlugin enabled!");
        }

        [Command(Description = "hello command description", Name = "hello")]
        public void hello(Player player)
        {
            player.SendMessage("FirstPlugin> Hello " + player.Username);
        }
    }
}
