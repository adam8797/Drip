﻿using System;
using System.IO;
using Drip.AppConsole;
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
                    AppConsole.AppConsole.WriteLine("Loading Default Configuration...");
                    _shared = JsonConvert.DeserializeObject<ApplicationConfig>(File.ReadAllText("default.json"));
                }
                return _shared;
            }
            set
            {
                _shared = value;
                AppConsole.AppConsole.WriteLine("System Configuration Updated");
                ConfigUpdated?.Invoke(value);
            }
        }

        public static bool ConfigLoaded => _shared != null;

        public static Action<ApplicationConfig> ConfigUpdated; 

        public static void Load(string path)
        {
            AppConsole.AppConsole.WriteLine("Loading configuration from file: " + path);
            Shared = JsonConvert.DeserializeObject<ApplicationConfig>(File.ReadAllText(path));
            Shared.LoadedFrom = path;
        }

        public static void Save(ApplicationConfig cfg, string path)
        {
            AppConsole.AppConsole.WriteLine("Saving configuration to file: " + path);
            File.WriteAllText(path, JsonConvert.SerializeObject(cfg, Formatting.Indented));
        }

        public static void Save(ApplicationConfig cfg)
        {
            Save(cfg, cfg.LoadedFrom);
        }

        [JsonIgnore]
        public string LoadedFrom { get; set; }

        //Properties
        public string MainVideoUrl { get; set; }
        public string AuxVideoUrl { get; set; }
        public string RoverIp { get; set; }
        public string RoverPort { get; set; }
        public int UpdateRate { get; set; }

		public string ImageSaveDirectory { get; set; }
		public string ImageNameFormat { get; set; }
		public decimal ImageDelay { get; set; }
		public string CaptureUrl { get; set; }

        public GamePadDeadZone DeadZone { get; set; }
        public decimal ServoCoefficient { get; set; }
        public int FramesShownInGraph { get; set; }

        public decimal YMinimum { get; set; }
        public decimal YMaximum { get; set; }

        public EventLevel LoggingLevel { get; set; }
    }
}
