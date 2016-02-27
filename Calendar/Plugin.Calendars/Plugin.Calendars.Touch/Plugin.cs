using MvvmCross.Platform.Plugins;
using MvvmCross.Platform;

namespace Plugin.Calendars.Touch
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<ICalendars>(new Calendars());
        }
    }
}