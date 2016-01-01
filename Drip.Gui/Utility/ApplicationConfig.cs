using System.IO;
using Newtonsoft.Json;

namespace Drip.Gui.Utility
{
    public class ApplicationConfig
    {

        //Shared app singleton
        private static ApplicationConfig _sharedApplicationConfig;
        public static ApplicationConfig SharedApplicationConfig
        {
            get
            {
                if (_sharedApplicationConfig == null)
                {
                    _sharedApplicationConfig = LoadApplicationConfig("default.json");
                }
                return _sharedApplicationConfig;
            }
        }

        public static ApplicationConfig LoadApplicationConfig(string path)
        {
            _sharedApplicationConfig = JsonConvert.DeserializeObject<ApplicationConfig>(File.ReadAllText(path));
            return _sharedApplicationConfig;
        }


        //Properties
        public string MainVideoUrl { get; set; }
        public string AuxVideoUrl { get; set; }
        public string RoverIp { get; set; }
        public string RoverPort { get; set; }
        public int UpdateRate { get; set; }
    }
}
