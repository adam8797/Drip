using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drip.Gui.Api;
using Drip.Gui.Processing;
using Drip.Gui.Utility;
using Illinois.SeaPerch.Net;
using XInputDotNetPure;

namespace Drip.Gui.CustomLogic
{
    public class DefaultDashboardModifier : IDashboardModifier
    {
        public void OnDataRecieved(
            IDashboardContract dash,
            CentralClock centralClock,
            object data)
        {

            var responseData = (ResponseData)data;

            //Update the data on the raw response tab.
            if (dash.SelectedTab == 1)
            {
                var form = "N3";

                //Left Column
                dash.LThrusterMode = responseData.LeftThrusterMode.ToString();
                dash.LThrusterPower = responseData.LeftThrusterPower.ToString();
                dash.CpuTemp = responseData.CpuTemp.ToString(form);
                dash.Depth = responseData.Depth.ToString(form);
                dash.WaterTemp = responseData.WaterTemp.ToString(form);

                //Center Column
                dash.VThrusterMode = responseData.VertThrusterMode.ToString();
                dash.VThrusterPower = responseData.VertThrusterPower.ToString();
                dash.Voltage = responseData.Voltage.ToString(form);
                dash.QualityCommand = responseData.QualityCmd.ToString();
                dash.MessageTime = responseData.MessageTime.ToString("HH:mm:ss.fff");

                //Right Column
                dash.RThrusterMode = responseData.RightThrusterMode.ToString();
                dash.RThrusterPower = responseData.RightThrusterPower.ToString();
                dash.Sensor1 = responseData.Sensor1.ToString(form);
                dash.Sensor2 = responseData.Sensor2.ToString(form);
                dash.Sensor3 = responseData.Sensor3.ToString(form);
            }


            //Update the data on the graph
            dash.Chart.Series[0].Points.AddXY(centralClock.LastFrameIndex, responseData.Depth);
            dash.Chart.Series[1].Points.AddXY(centralClock.LastFrameIndex, responseData.WaterTemp);

            if (ApplicationConfig.Shared.YMinimum == ApplicationConfig.Shared.YMaximum)
            {
                //Set the dash.Chart back to autoscaling mode.
                dash.Chart.ChartAreas[0].AxisY.Minimum = double.NaN;
                dash.Chart.ChartAreas[0].AxisY.Maximum = double.NaN;
            }
            else
            {
                dash.Chart.ChartAreas[0].AxisY.Minimum = (double)ApplicationConfig.Shared.YMinimum;
                dash.Chart.ChartAreas[0].AxisY.Maximum = (double)ApplicationConfig.Shared.YMaximum;
            }

            // Define some variables
            int numberOfFramesInChart = ApplicationConfig.Shared.FramesShownInGraph;

            //Loop through both Series
            for (int i = 0; i < 1; i++)
            {
                //If the current frame is past the threshold
                if (centralClock.LastFrameIndex > numberOfFramesInChart)
                {
                    //This loop is weird, but it will end up repeating, with the index
                    //being 0. It removes any points that are at the same x position,
                    //with that x position being the oldest frame we are keeping
                    for (int j = 0; j < dash.Chart.Series[i].Points.Count; j++)
                    {
                        if (dash.Chart.Series[i].Points[j].XValue == centralClock.LastFrameIndex - numberOfFramesInChart)
                        {
                            dash.Chart.Series[i].Points.RemoveAt(j);
                            j--;
                        }
                    }

                    dash.Chart.ChartAreas[0].AxisX.Minimum = centralClock.LastFrameIndex - numberOfFramesInChart;
                    dash.Chart.ChartAreas[0].AxisX.Maximum = centralClock.LastFrameIndex;
                }
                else
                {
                    //Here to keep the graph from changing scale on startup
                    dash.Chart.ChartAreas[0].AxisX.Minimum = 0;
                    dash.Chart.ChartAreas[0].AxisX.Maximum = numberOfFramesInChart;
                }
            }

            //Mark the control to be redrawn.
            dash.Chart.Invalidate();
        }

        public void OnStateGenerated(IDashboardContract dash, CentralClock clock, GamePadState state)
        {
            
        }

        public void OnRobotFrameGenerated(IDashboardContract dash, CentralClock clock, RobotFrame frame)
        {

        }
    }
}
