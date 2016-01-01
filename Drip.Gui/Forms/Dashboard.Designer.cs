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
            this.mainVideoStream = new Ozeki.Media.VideoViewerWF();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.propA = new Drip.Gui.Control.MotorGuage();
            this.propC = new Drip.Gui.Control.MotorGuage();
            this.propB = new Drip.Gui.Control.MotorGuage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.auxVideoStream = new Ozeki.Media.VideoViewerWF();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rightX = new Drip.Gui.Control.MotorGuage();
            this.rightY = new Drip.Gui.Control.MotorGuage();
            this.leftX = new Drip.Gui.Control.MotorGuage();
            this.leftY = new Drip.Gui.Control.MotorGuage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainVideoStream
            // 
            this.mainVideoStream.BackColor = System.Drawing.Color.Black;
            this.mainVideoStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainVideoStream.FlipMode = Ozeki.Media.FlipMode.None;
            this.mainVideoStream.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.mainVideoStream.FullScreenEnabled = true;
            this.mainVideoStream.Location = new System.Drawing.Point(3, 16);
            this.mainVideoStream.Name = "mainVideoStream";
            this.mainVideoStream.RotateAngle = 0;
            this.mainVideoStream.Size = new System.Drawing.Size(762, 413);
            this.mainVideoStream.TabIndex = 0;
            this.mainVideoStream.Text = "videoViewerWF1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.propA);
            this.groupBox1.Controls.Add(this.propC);
            this.groupBox1.Controls.Add(this.propB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
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
            this.groupBox2.Location = new System.Drawing.Point(298, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 432);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main Video Stream";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.auxVideoStream);
            this.groupBox3.Location = new System.Drawing.Point(807, 450);
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
            this.auxVideoStream.Name = "auxVideoStream";
            this.auxVideoStream.RotateAngle = 0;
            this.auxVideoStream.Size = new System.Drawing.Size(250, 125);
            this.auxVideoStream.TabIndex = 0;
            this.auxVideoStream.Text = "videoViewerWF2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rightX);
            this.groupBox4.Controls.Add(this.rightY);
            this.groupBox4.Controls.Add(this.leftX);
            this.groupBox4.Controls.Add(this.leftY);
            this.groupBox4.Location = new System.Drawing.Point(15, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 195);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gamepad";
            // 
            // rightX
            // 
            this.rightX.DangerColor = System.Drawing.Color.Red;
            this.rightX.Location = new System.Drawing.Point(153, 140);
            this.rightX.Name = "rightX";
            this.rightX.NormalColor = System.Drawing.Color.Chartreuse;
            this.rightX.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.rightX.Size = new System.Drawing.Size(115, 25);
            this.rightX.TabIndex = 14;
            this.rightX.Value = 0;
            // 
            // rightY
            // 
            this.rightY.DangerColor = System.Drawing.Color.Red;
            this.rightY.Location = new System.Drawing.Point(200, 19);
            this.rightY.Name = "rightY";
            this.rightY.NormalColor = System.Drawing.Color.Chartreuse;
            this.rightY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.rightY.Size = new System.Drawing.Size(25, 115);
            this.rightY.TabIndex = 13;
            this.rightY.Value = 0;
            // 
            // leftX
            // 
            this.leftX.DangerColor = System.Drawing.Color.Red;
            this.leftX.Location = new System.Drawing.Point(10, 140);
            this.leftX.Name = "leftX";
            this.leftX.NormalColor = System.Drawing.Color.Chartreuse;
            this.leftX.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.leftX.Size = new System.Drawing.Size(115, 25);
            this.leftX.TabIndex = 12;
            this.leftX.Value = 0;
            // 
            // leftY
            // 
            this.leftY.DangerColor = System.Drawing.Color.Red;
            this.leftY.Location = new System.Drawing.Point(57, 19);
            this.leftY.Name = "leftY";
            this.leftY.NormalColor = System.Drawing.Color.Chartreuse;
            this.leftY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.leftY.Size = new System.Drawing.Size(25, 115);
            this.leftY.TabIndex = 11;
            this.leftY.Value = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(209, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(86, 228);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Status";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 629);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Ozeki.Media.VideoViewerWF mainVideoStream;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Ozeki.Media.VideoViewerWF auxVideoStream;
        private System.Windows.Forms.GroupBox groupBox4;
        private Control.MotorGuage rightX;
        private Control.MotorGuage rightY;
        private Control.MotorGuage leftX;
        private Control.MotorGuage leftY;
        private System.Windows.Forms.GroupBox groupBox5;
        private Control.MotorGuage propA;
        private Control.MotorGuage propC;
        private Control.MotorGuage propB;
    }
}