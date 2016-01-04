using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drip.Gui.Utility
{
    public static class AppConsole
    {
        private static TextBoxTextWriter writer;

        public static void RegisterTextbox(TextBox box)
        {
            writer = new TextBoxTextWriter(box);
        }

        public static void RedirectConsoleOutput()
        {
            Console.SetOut(writer);
        }
        

        public static void WriteLine(string line, EventLevel el = EventLevel.Logging)
        {
            Write(line + "\n", el);
        }

        public static void Write(string line, EventLevel el = EventLevel.Logging)
        {
            Debug.Write($"[{DateTime.Now.ToString("MM-dd-yy hh:mm:ss")}] [{el}]: {line}");
            var level = ApplicationConfig.ConfigLoaded ? ApplicationConfig.Shared.LoggingLevel : EventLevel.Debugging;
            if (el >= level)
            {
                foreach (var c in line)
                {
                    writer.Write(c);
                }
            }
        }
    }

    public enum EventLevel
    {
        Debugging,
        Logging,
        Warning,
        Critical
    }
}
