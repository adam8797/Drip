using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Drip.Gui.Api
{
    public interface IDashboardContract
    {
        //Left Column
        string LThrusterMode { get; set; }
        string LThrusterPower { get; set; }
        string CpuTemp { get; set; }
        string Depth { get; set; }
        string WaterTemp { get; set; }

        //Center Column
        string VThrusterMode { get; set; }
        string VThrusterPower { get; set; }
        string Voltage { get; set; }
        string QualityCommand { get; set; }
        string MessageTime { get; set; }

        //Right Column
        string RThrusterMode { get; set; }
        string RThrusterPower { get; set; }
        string Sensor1 { get; set; }
        string Sensor2 { get; set; }
        string Sensor3 { get; set; }

        int SelectedTab { get; }

        Chart Chart { get; }
    }
}
