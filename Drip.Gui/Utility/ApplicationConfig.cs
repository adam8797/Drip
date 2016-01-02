using System;
using System.IO;
using Newtonsoft.Json;
using XInputDotNetPure;

namespace Drip.Gui.Utility
{
    public class ApplicationConfig
    {

        //Shared app singleton
        private static ApplicationConfig _shared;
        public static ApplicationConfig Shared
        {
            get
            {
                if (_shared == null)
                {
                    _shared = Load("default.json");
                }
                return _shared;
            }
            set
            {
                _shared = value;
                ConfigUpdated?.Invoke(value);
            }
        }

        public static Action<ApplicationConfig> ConfigUpdated; 

        public static ApplicationConfig Load(string path)
        {
            _shared = JsonConvert.DeserializeObject<ApplicationConfig>(File.ReadAllText(path));
            return _shared;
        }

        public static void Save(ApplicationConfig cfg, string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(cfg, Formatting.Indented));
        }

        //Properties
        public string MainVideoUrl { get; set; }
        public string AuxVideoUrl { get; set; }
        public string RoverIp { get; set; }
        public string RoverPort { get; set; }
        public int UpdateRate { get; set; }
        public GamePadDeadZone DeadZone { get; set; }
        public decimal ServoCoefficient { get; set; }
    }
}
