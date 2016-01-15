using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Drip.AppConsole
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
            System.Console.SetOut(writer);
        }

        public static void WriteLine(string line, EventLevel el = EventLevel.Logging)
        {
            Write(line + "\n", el);
        }

        public static EventLevel LoggingLevel { get; set; }

        public static void Write(string line, EventLevel el = EventLevel.Logging)
        {
            Debug.Write($"[{DateTime.Now.ToString("MM-dd-yy hh:mm:ss")}] [{el}]: {line}");
            if (el >= LoggingLevel)
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
