using Drip.Gui.Api;
using Drip.Gui.Controls;

namespace Drip.Gui.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.propA = new Drip.Gui.Controls.MotorGuage();
            this.propC = new Drip.Gui.Controls.MotorGuage();
            this.propB = new Drip.Gui.Controls.MotorGuage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mainVideoStream = new Drip.Gui.Controls.MJPEGVideo();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.auxVideoStream = new Drip.Gui.Controls.MJPEGVideo();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rightTrigger = new Drip.Gui.Controls.Gauge();
            this.leftTrigger = new Drip.Gui.Controls.Gauge();
            this.rightThumbstick = new Drip.Gui.Controls.JoystickDisplay();
            this.leftThumbstick = new Drip.Gui.Controls.JoystickDisplay();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblLight = new System.Windows.Forms.Label();
            this.outputTabs = new System.Windows.Forms.TabControl();
            this.pageGraphs = new System.Windows.Forms.TabPage();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pageRawData = new System.Windows.Forms.TabPage();
            this.lblSensor2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblSensor3 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblSensor1 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblRThrusterPower = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblRThrusterMode = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblQualityCommand = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblMessageTime = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblVoltage = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblVThrusterPower = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblVThrusterMode = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblDepth = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblWaterTemp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCpuTemp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLThrusterPower = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLThrusterMode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pageServos = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.servo4 = new Drip.Gui.Controls.ServoDisplay();
            this.servo3 = new Drip.Gui.Controls.ServoDisplay();
            this.servo2 = new Drip.Gui.Controls.ServoDisplay();
            this.servo1 = new Drip.Gui.Controls.ServoDisplay();
            this.pageConsole = new System.Windows.Forms.TabPage();
            this.appConsole = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.lblServo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.outputTabs.SuspendLayout();
            this.pageGraphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.pageRawData.SuspendLayout();
            this.pageServos.SuspendLayout();
            this.pageConsole.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.propA);
            this.groupBox1.Controls.Add(this.propC);
            this.groupBox1.Controls.Add(this.propB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 228);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propeller Output";
            // 
            // propA
            // 
            this.propA.DangerColor = System.Drawing.Color.Chartreuse;
            this.propA.Location = new System.Drawing.Point(8, 19);
            this.propA.Name = "propA";
            this.propA.NormalColor = System.Drawing.Color.Chartreuse;
            this.propA.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.propA.Size = new System.Drawing.Size(40, 182);
            this.propA.TabIndex = 23;
            this.propA.Value = 0;
            // 
            // propC
            // 
            this.propC.DangerColor = System.Drawing.Color.Chartreuse;
            this.propC.Location = new System.Drawing.Point(138, 19);
            this.propC.Name = "propC";
            this.propC.NormalColor = System.Drawing.Color.Chartreuse;
            this.propC.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.propC.Size = new System.Drawing.Size(40, 182);
            this.propC.TabIndex = 22;
            this.propC.Value = 0;
            // 
            // propB
            // 
            this.propB.DangerColor = System.Drawing.Color.Chartreuse;
            this.propB.Location = new System.Drawing.Point(71, 19);
            this.propB.Name = "propB";
            this.propB.NormalColor = System.Drawing.Color.Chartreuse;
            this.propB.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.propB.Size = new System.Drawing.Size(40, 182);
            this.propB.TabIndex = 21;
            this.propB.Value = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Prop C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Prop B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Prop A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mainVideoStream);
            this.groupBox2.Location = new System.Drawing.Point(298, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 432);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main Video Stream";
            // 
            // mainVideoStream
            // 
            this.mainVideoStream.BackColor = System.Drawing.Color.Black;
            this.mainVideoStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainVideoStream.FlipMode = Ozeki.Media.FlipMode.None;
            this.mainVideoStream.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.mainVideoStream.FullScreenEnabled = true;
            this.mainVideoStream.Location = new System.Drawing.Point(3, 16);
            this.mainVideoStream.MJPEGUrl = null;
            this.mainVideoStream.Name = "mainVideoStream";
            this.mainVideoStream.RotateAngle = 0;
            this.mainVideoStream.Size = new System.Drawing.Size(762, 413);
            this.mainVideoStream.TabIndex = 0;
            this.mainVideoStream.Text = "videoViewerWF1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.auxVideoStream);
            this.groupBox3.Location = new System.Drawing.Point(807, 465);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 144);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aux Video Stream";
            // 
            // auxVideoStream
            // 
            this.auxVideoStream.BackColor = System.Drawing.Color.Black;
            this.auxVideoStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auxVideoStream.FlipMode = Ozeki.Media.FlipMode.None;
            this.auxVideoStream.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.auxVideoStream.FullScreenEnabled = true;
            this.auxVideoStream.Location = new System.Drawing.Point(3, 16);
            this.auxVideoStream.MJPEGUrl = null;
            this.auxVideoStream.Name = "auxVideoStream";
            this.auxVideoStream.RotateAngle = 0;
            this.auxVideoStream.Size = new System.Drawing.Size(250, 125);
            this.auxVideoStream.TabIndex = 0;
            this.auxVideoStream.Text = "videoViewerWF2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rightTrigger);
            this.groupBox4.Controls.Add(this.leftTrigger);
            this.groupBox4.Controls.Add(this.rightThumbstick);
            this.groupBox4.Controls.Add(this.leftThumbstick);
            this.groupBox4.Location = new System.Drawing.Point(15, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 198);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gamepad";
            // 
            // rightTrigger
            // 
            this.rightTrigger.GuageColor = System.Drawing.Color.Chartreuse;
            this.rightTrigger.Location = new System.Drawing.Point(155, 153);
            this.rightTrigger.MaxValue = 100;
            this.rightTrigger.MinValue = 0;
            this.rightTrigger.Name = "rightTrigger";
            this.rightTrigger.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.rightTrigger.Size = new System.Drawing.Size(100, 40);
            this.rightTrigger.TabIndex = 17;
            this.rightTrigger.Value = 0;
            // 
            // leftTrigger
            // 
            this.leftTrigger.GuageColor = System.Drawing.Color.Chartreuse;
            this.leftTrigger.Location = new System.Drawing.Point(20, 153);
            this.leftTrigger.MaxValue = 100;
            this.leftTrigger.MinValue = 0;
            this.leftTrigger.Name = "leftTrigger";
            this.leftTrigger.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.leftTrigger.Size = new System.Drawing.Size(100, 40);
            this.leftTrigger.TabIndex = 16;
            this.leftTrigger.Value = 0;
            // 
            // rightThumbstick
            // 
            this.rightThumbstick.DotSize = 15;
            this.rightThumbstick.GuageMargin = 5;
            this.rightThumbstick.Location = new System.Drawing.Point(140, 17);
            this.rightThumbstick.Name = "rightThumbstick";
            this.rightThumbstick.Size = new System.Drawing.Size(130, 130);
            this.rightThumbstick.TabIndex = 15;
            // 
            // leftThumbstick
            // 
            this.leftThumbstick.DotSize = 15;
            this.leftThumbstick.GuageMargin = 5;
            this.leftThumbstick.Location = new System.Drawing.Point(5, 17);
            this.leftThumbstick.Name = "leftThumbstick";
            this.leftThumbstick.Size = new System.Drawing.Size(130, 130);
            this.leftThumbstick.TabIndex = 14;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblServo);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.lblLight);
            this.groupBox5.Location = new System.Drawing.Point(209, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(86, 228);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Status";
            // 
            // lblLight
            // 
            this.lblLight.BackColor = System.Drawing.Color.Red;
            this.lblLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblLight.Location = new System.Drawing.Point(6, 19);
            this.lblLight.Name = "lblLight";
            this.lblLight.Size = new System.Drawing.Size(74, 52);
            this.lblLight.TabIndex = 0;
            this.lblLight.Text = "Light";
            this.lblLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputTabs
            // 
            this.outputTabs.Controls.Add(this.pageGraphs);
            this.outputTabs.Controls.Add(this.pageRawData);
            this.outputTabs.Controls.Add(this.pageServos);
            this.outputTabs.Controls.Add(this.pageConsole);
            this.outputTabs.Location = new System.Drawing.Point(15, 465);
            this.outputTabs.Name = "outputTabs";
            this.outputTabs.SelectedIndex = 0;
            this.outputTabs.Size = new System.Drawing.Size(786, 167);
            this.outputTabs.TabIndex = 14;
            // 
            // pageGraphs
            // 
            this.pageGraphs.Controls.Add(this.chart);
            this.pageGraphs.Location = new System.Drawing.Point(4, 22);
            this.pageGraphs.Name = "pageGraphs";
            this.pageGraphs.Padding = new System.Windows.Forms.Padding(3);
            this.pageGraphs.Size = new System.Drawing.Size(778, 141);
            this.pageGraphs.TabIndex = 0;
            this.pageGraphs.Text = "Graphs";
            this.pageGraphs.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            chartArea1.AxisX.Maximum = 200D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Pressure";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Temp";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(772, 135);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // pageRawData
            // 
            this.pageRawData.Controls.Add(this.lblSensor2);
            this.pageRawData.Controls.Add(this.label25);
            this.pageRawData.Controls.Add(this.lblSensor3);
            this.pageRawData.Controls.Add(this.label27);
            this.pageRawData.Controls.Add(this.lblSensor1);
            this.pageRawData.Controls.Add(this.label29);
            this.pageRawData.Controls.Add(this.lblRThrusterPower);
            this.pageRawData.Controls.Add(this.label31);
            this.pageRawData.Controls.Add(this.lblRThrusterMode);
            this.pageRawData.Controls.Add(this.label33);
            this.pageRawData.Controls.Add(this.lblQualityCommand);
            this.pageRawData.Controls.Add(this.label15);
            this.pageRawData.Controls.Add(this.lblMessageTime);
            this.pageRawData.Controls.Add(this.label17);
            this.pageRawData.Controls.Add(this.lblVoltage);
            this.pageRawData.Controls.Add(this.label19);
            this.pageRawData.Controls.Add(this.lblVThrusterPower);
            this.pageRawData.Controls.Add(this.label21);
            this.pageRawData.Controls.Add(this.lblVThrusterMode);
            this.pageRawData.Controls.Add(this.label23);
            this.pageRawData.Controls.Add(this.lblDepth);
            this.pageRawData.Controls.Add(this.label13);
            this.pageRawData.Controls.Add(this.lblWaterTemp);
            this.pageRawData.Controls.Add(this.label11);
            this.pageRawData.Controls.Add(this.lblCpuTemp);
            this.pageRawData.Controls.Add(this.label9);
            this.pageRawData.Controls.Add(this.lblLThrusterPower);
            this.pageRawData.Controls.Add(this.label7);
            this.pageRawData.Controls.Add(this.lblLThrusterMode);
            this.pageRawData.Controls.Add(this.label1);
            this.pageRawData.Location = new System.Drawing.Point(4, 22);
            this.pageRawData.Name = "pageRawData";
            this.pageRawData.Size = new System.Drawing.Size(778, 141);
            this.pageRawData.TabIndex = 2;
            this.pageRawData.Text = "Raw Response Data";
            this.pageRawData.UseVisualStyleBackColor = true;
            // 
            // lblSensor2
            // 
            this.lblSensor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSensor2.Location = new System.Drawing.Point(649, 83);
            this.lblSensor2.Name = "lblSensor2";
            this.lblSensor2.Size = new System.Drawing.Size(120, 23);
            this.lblSensor2.TabIndex = 29;
            this.lblSensor2.Text = "[No Data]";
            this.lblSensor2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label25.Location = new System.Drawing.Point(511, 83);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(132, 23);
            this.label25.TabIndex = 28;
            this.label25.Text = "Sensor 2";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSensor3
            // 
            this.lblSensor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSensor3.Location = new System.Drawing.Point(649, 107);
            this.lblSensor3.Name = "lblSensor3";
            this.lblSensor3.Size = new System.Drawing.Size(120, 23);
            this.lblSensor3.TabIndex = 27;
            this.lblSensor3.Text = "[No Data]";
            this.lblSensor3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label27.Location = new System.Drawing.Point(511, 107);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(132, 23);
            this.label27.TabIndex = 26;
            this.label27.Text = "Sensor 3";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSensor1
            // 
            this.lblSensor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSensor1.Location = new System.Drawing.Point(650, 59);
            this.lblSensor1.Name = "lblSensor1";
            this.lblSensor1.Size = new System.Drawing.Size(120, 23);
            this.lblSensor1.TabIndex = 25;
            this.lblSensor1.Text = "[No Data]";
            this.lblSensor1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label29.Location = new System.Drawing.Point(512, 59);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(132, 23);
            this.label29.TabIndex = 24;
            this.label29.Text = "Sensor 1";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRThrusterPower
            // 
            this.lblRThrusterPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRThrusterPower.Location = new System.Drawing.Point(650, 35);
            this.lblRThrusterPower.Name = "lblRThrusterPower";
            this.lblRThrusterPower.Size = new System.Drawing.Size(120, 23);
            this.lblRThrusterPower.TabIndex = 23;
            this.lblRThrusterPower.Text = "[No Data]";
            this.lblRThrusterPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label31.Location = new System.Drawing.Point(512, 35);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(132, 23);
            this.label31.TabIndex = 22;
            this.label31.Text = "R Thruster Power";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRThrusterMode
            // 
            this.lblRThrusterMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRThrusterMode.Location = new System.Drawing.Point(650, 11);
            this.lblRThrusterMode.Name = "lblRThrusterMode";
            this.lblRThrusterMode.Size = new System.Drawing.Size(120, 23);
            this.lblRThrusterMode.TabIndex = 21;
            this.lblRThrusterMode.Text = "[No Data]";
            this.lblRThrusterMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label33.Location = new System.Drawing.Point(512, 11);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(132, 23);
            this.label33.TabIndex = 20;
            this.label33.Text = "R Thruster Mode";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQualityCommand
            // 
            this.lblQualityCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQualityCommand.Location = new System.Drawing.Point(398, 82);
            this.lblQualityCommand.Name = "lblQualityCommand";
            this.lblQualityCommand.Size = new System.Drawing.Size(120, 23);
            this.lblQualityCommand.TabIndex = 19;
            this.lblQualityCommand.Text = "[No Data]";
            this.lblQualityCommand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(260, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 23);
            this.label15.TabIndex = 18;
            this.label15.Text = "Quality Cmd";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMessageTime
            // 
            this.lblMessageTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMessageTime.Location = new System.Drawing.Point(398, 106);
            this.lblMessageTime.Name = "lblMessageTime";
            this.lblMessageTime.Size = new System.Drawing.Size(120, 23);
            this.lblMessageTime.TabIndex = 17;
            this.lblMessageTime.Text = "[No Data]";
            this.lblMessageTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.Location = new System.Drawing.Point(260, 106);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 23);
            this.label17.TabIndex = 16;
            this.label17.Text = "Message Time";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVoltage
            // 
            this.lblVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVoltage.Location = new System.Drawing.Point(399, 58);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(120, 23);
            this.lblVoltage.TabIndex = 15;
            this.lblVoltage.Text = "[No Data]";
            this.lblVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.Location = new System.Drawing.Point(261, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 23);
            this.label19.TabIndex = 14;
            this.label19.Text = "Voltage";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVThrusterPower
            // 
            this.lblVThrusterPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVThrusterPower.Location = new System.Drawing.Point(399, 34);
            this.lblVThrusterPower.Name = "lblVThrusterPower";
            this.lblVThrusterPower.Size = new System.Drawing.Size(120, 23);
            this.lblVThrusterPower.TabIndex = 13;
            this.lblVThrusterPower.Text = "[No Data]";
            this.lblVThrusterPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.Location = new System.Drawing.Point(261, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 23);
            this.label21.TabIndex = 12;
            this.label21.Text = "V Thruster Power";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVThrusterMode
            // 
            this.lblVThrusterMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVThrusterMode.Location = new System.Drawing.Point(399, 10);
            this.lblVThrusterMode.Name = "lblVThrusterMode";
            this.lblVThrusterMode.Size = new System.Drawing.Size(120, 23);
            this.lblVThrusterMode.TabIndex = 11;
            this.lblVThrusterMode.Text = "[No Data]";
            this.lblVThrusterMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label23.Location = new System.Drawing.Point(261, 10);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(132, 23);
            this.label23.TabIndex = 10;
            this.label23.Text = "V Thruster Mode";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepth
            // 
            this.lblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDepth.Location = new System.Drawing.Point(150, 83);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(110, 23);
            this.lblDepth.TabIndex = 9;
            this.lblDepth.Text = "[No Data]";
            this.lblDepth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(12, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 23);
            this.label13.TabIndex = 8;
            this.label13.Text = "Depth";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWaterTemp
            // 
            this.lblWaterTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWaterTemp.Location = new System.Drawing.Point(150, 107);
            this.lblWaterTemp.Name = "lblWaterTemp";
            this.lblWaterTemp.Size = new System.Drawing.Size(110, 23);
            this.lblWaterTemp.TabIndex = 7;
            this.lblWaterTemp.Text = "[No Data]";
            this.lblWaterTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(12, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "Water Temp";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCpuTemp
            // 
            this.lblCpuTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCpuTemp.Location = new System.Drawing.Point(151, 59);
            this.lblCpuTemp.Name = "lblCpuTemp";
            this.lblCpuTemp.Size = new System.Drawing.Size(110, 23);
            this.lblCpuTemp.TabIndex = 5;
            this.lblCpuTemp.Text = "[No Data]";
            this.lblCpuTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(13, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "CPU Temp";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLThrusterPower
            // 
            this.lblLThrusterPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLThrusterPower.Location = new System.Drawing.Point(151, 35);
            this.lblLThrusterPower.Name = "lblLThrusterPower";
            this.lblLThrusterPower.Size = new System.Drawing.Size(110, 23);
            this.lblLThrusterPower.TabIndex = 3;
            this.lblLThrusterPower.Text = "[No Data]";
            this.lblLThrusterPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(13, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "L Thruster Power";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLThrusterMode
            // 
            this.lblLThrusterMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLThrusterMode.Location = new System.Drawing.Point(151, 11);
            this.lblLThrusterMode.Name = "lblLThrusterMode";
            this.lblLThrusterMode.Size = new System.Drawing.Size(110, 23);
            this.lblLThrusterMode.TabIndex = 1;
            this.lblLThrusterMode.Text = "[No Data]";
            this.lblLThrusterMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "L Thruster Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pageServos
            // 
            this.pageServos.Controls.Add(this.label10);
            this.pageServos.Controls.Add(this.label8);
            this.pageServos.Controls.Add(this.label3);
            this.pageServos.Controls.Add(this.label2);
            this.pageServos.Controls.Add(this.servo4);
            this.pageServos.Controls.Add(this.servo3);
            this.pageServos.Controls.Add(this.servo2);
            this.pageServos.Controls.Add(this.servo1);
            this.pageServos.Location = new System.Drawing.Point(4, 22);
            this.pageServos.Name = "pageServos";
            this.pageServos.Padding = new System.Windows.Forms.Padding(3);
            this.pageServos.Size = new System.Drawing.Size(778, 141);
            this.pageServos.TabIndex = 3;
            this.pageServos.Text = "Servos";
            this.pageServos.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(651, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Servo 4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(455, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Servo 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(260, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Servo 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(64, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Servo 1";
            // 
            // servo4
            // 
            this.servo4.Angle = 45;
            this.servo4.AutoAdjustSize = true;
            this.servo4.BarWidth = 5;
            this.servo4.GuageMargin = 10;
            this.servo4.Location = new System.Drawing.Point(597, 8);
            this.servo4.MaxAngle = 90;
            this.servo4.MinAngle = -90;
            this.servo4.Name = "servo4";
            this.servo4.ShowDetails = false;
            this.servo4.Size = new System.Drawing.Size(169, 104);
            this.servo4.TabIndex = 7;
            // 
            // servo3
            // 
            this.servo3.Angle = 45;
            this.servo3.AutoAdjustSize = true;
            this.servo3.BarWidth = 5;
            this.servo3.GuageMargin = 10;
            this.servo3.Location = new System.Drawing.Point(402, 8);
            this.servo3.MaxAngle = 90;
            this.servo3.MinAngle = -90;
            this.servo3.Name = "servo3";
            this.servo3.ShowDetails = false;
            this.servo3.Size = new System.Drawing.Size(169, 104);
            this.servo3.TabIndex = 6;
            // 
            // servo2
            // 
            this.servo2.Angle = 45;
            this.servo2.AutoAdjustSize = true;
            this.servo2.BarWidth = 5;
            this.servo2.GuageMargin = 10;
            this.servo2.Location = new System.Drawing.Point(207, 8);
            this.servo2.MaxAngle = 90;
            this.servo2.MinAngle = -90;
            this.servo2.Name = "servo2";
            this.servo2.ShowDetails = false;
            this.servo2.Size = new System.Drawing.Size(169, 104);
            this.servo2.TabIndex = 5;
            // 
            // servo1
            // 
            this.servo1.Angle = 45;
            this.servo1.AutoAdjustSize = true;
            this.servo1.BarWidth = 5;
            this.servo1.GuageMargin = 10;
            this.servo1.Location = new System.Drawing.Point(12, 8);
            this.servo1.MaxAngle = 90;
            this.servo1.MinAngle = -90;
            this.servo1.Name = "servo1";
            this.servo1.ShowDetails = false;
            this.servo1.Size = new System.Drawing.Size(169, 104);
            this.servo1.TabIndex = 4;
            // 
            // pageConsole
            // 
            this.pageConsole.Controls.Add(this.appConsole);
            this.pageConsole.Location = new System.Drawing.Point(4, 22);
            this.pageConsole.Name = "pageConsole";
            this.pageConsole.Padding = new System.Windows.Forms.Padding(3);
            this.pageConsole.Size = new System.Drawing.Size(778, 141);
            this.pageConsole.TabIndex = 1;
            this.pageConsole.Text = "Console";
            this.pageConsole.UseVisualStyleBackColor = true;
            // 
            // appConsole
            // 
            this.appConsole.BackColor = System.Drawing.SystemColors.Window;
            this.appConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appConsole.Location = new System.Drawing.Point(3, 3);
            this.appConsole.Multiline = true;
            this.appConsole.Name = "appConsole";
            this.appConsole.ReadOnly = true;
            this.appConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.appConsole.Size = new System.Drawing.Size(772, 135);
            this.appConsole.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadConfigToolStripMenuItem,
            this.saveConfigToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadConfigToolStripMenuItem
            // 
            this.loadConfigToolStripMenuItem.Name = "loadConfigToolStripMenuItem";
            this.loadConfigToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.loadConfigToolStripMenuItem.Text = "Load Config";
            this.loadConfigToolStripMenuItem.Click += new System.EventHandler(this.loadConfigToolStripMenuItem_Click);
            // 
            // saveConfigToolStripMenuItem
            // 
            this.saveConfigToolStripMenuItem.Name = "saveConfigToolStripMenuItem";
            this.saveConfigToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveConfigToolStripMenuItem.Text = "Save Config";
            this.saveConfigToolStripMenuItem.Click += new System.EventHandler(this.saveConfigToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(6, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 52);
            this.label12.TabIndex = 1;
            this.label12.Text = "Servo\r\nCoeff";
            // 
            // lblServo
            // 
            this.lblServo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblServo.Location = new System.Drawing.Point(6, 194);
            this.lblServo.Name = "lblServo";
            this.lblServo.Size = new System.Drawing.Size(80, 23);
            this.lblServo.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 637);
            this.Controls.Add(this.outputTabs);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.outputTabs.ResumeLayout(false);
            this.pageGraphs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.pageRawData.ResumeLayout(false);
            this.pageServos.ResumeLayout(false);
            this.pageServos.PerformLayout();
            this.pageConsole.ResumeLayout(false);
            this.pageConsole.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MJPEGVideo mainVideoStream;
        private MJPEGVideo auxVideoStream;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private MotorGuage propA;
        private MotorGuage propC;
        private MotorGuage propB;
        private JoystickDisplay leftThumbstick;
        private JoystickDisplay rightThumbstick;
        private System.Windows.Forms.Label lblLight;
        private Gauge rightTrigger;
        private Gauge leftTrigger;
        private System.Windows.Forms.TabControl outputTabs;
        private System.Windows.Forms.TabPage pageGraphs;
        private System.Windows.Forms.TabPage pageRawData;
        private System.Windows.Forms.TabPage pageConsole;
        private System.Windows.Forms.Label lblQualityCommand;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblMessageTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblVoltage;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblVThrusterPower;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblVThrusterMode;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblWaterTemp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCpuTemp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLThrusterPower;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLThrusterMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSensor2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblSensor3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblSensor1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblRThrusterPower;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblRThrusterMode;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TabPage pageServos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ServoDisplay servo4;
        private ServoDisplay servo3;
        private ServoDisplay servo2;
        private ServoDisplay servo1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TextBox appConsole;
        private System.Windows.Forms.Label lblServo;
        private System.Windows.Forms.Label label12;
    }
}