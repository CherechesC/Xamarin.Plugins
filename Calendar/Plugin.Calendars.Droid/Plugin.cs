using MvvmCross.Platform.Plugins;
using MvvmCross.Platform;

namespace Plugin.Calendars.Droid
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<ICalendars>(new Calendars());
        }
    }
}