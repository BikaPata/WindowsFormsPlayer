using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsPlayer
{
    public partial class Player : Form
    {

        public void moving()
        {
            wmPLayer.Ctlcontrols.play();
            wmPLayer.Ctlcontrols.pause();

        }

        public void frameStep(bool irany)
        {
            double frameRate = wmPLayer.network.encodedFrameRate;
            double step = 1.0 / frameRate;
            label1.Text = "STEP: " + step;
            wmPLayer.Ctlcontrols.pause();
            if (irany)
            {
                wmPLayer.Ctlcontrols.currentPosition += step;
            }
            else
            {
                wmPLayer.Ctlcontrols.currentPosition -= step;
            }
        }

        private void tracBarLep()
        {
            decimal aktPos = 0;
            if ((wmPLayer.playState == WMPLib.WMPPlayState.wmppsPlaying) || (wmPLayer.playState == WMPPlayState.wmppsScanForward) || (wmPLayer.playState == WMPPlayState.wmppsScanReverse))
            {
                string pos = wmPLayer.Ctlcontrols.currentPosition.ToString();
                lbMediaTime.Text = pos;
                aktPos = Convert.ToDecimal(pos);
                mdaTrackBar.Value = Convert.ToInt16(aktPos);
            }

        }

        public Player()
        {
            InitializeComponent();
        }

        private void Player_Load(object sender, EventArgs e)
        {

        }

        private void Player_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            wmPLayer.Ctlcontrols.play();

            if (wmPLayer.currentMedia != null)
            {

                var hosz = Convert.ToInt16(wmPLayer.currentMedia.duration);
                mdaTrackBar.Maximum = hosz;
            }

          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wmPLayer.Ctlcontrols.pause();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmPLayer.Ctlcontrols.stop();     
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult ofd = openFileDialog1.ShowDialog();
            if (ofd == DialogResult.OK)
            {
                wmPLayer.URL = openFileDialog1.FileName;
                plyListBox.Items.Add(openFileDialog1.FileName);
             
            }

        }

        private void plyListaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmPLayer.URL = plyListBox.SelectedItem.ToString();
            
        }

        private void mdaVolume_Scroll(object sender, EventArgs e)
        {
            wmPLayer.settings.volume = mdaVolume.Value;

        }

        private void mdaVolume_ValueChanged(object sender, EventArgs e)
        {
            mdaVolPerc.Text = mdaVolume.Value+"%";
        }

        private void btnVol_Click(object sender, EventArgs e)
        {
            if (panelVolume.Visible)
            {
                panelVolume.Visible = false;
            }
            else
            {
                panelVolume.Visible = true;
            }
 
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
           tracBarLep();
        }

        private void wmPLayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            mdaVolPerc.Text = wmPLayer.settings.volume.ToString();
            mdaVolume.Value = wmPLayer.settings.volume;

            switch (e.newState)
            {
                case 0:    // Undefined
                    currentStateLabel.Text = "Undefined";
                    break;

                case 1:    // Stopped
                    currentStateLabel.Text = "Stopped";
                    break;

                case 2:    // Paused
                    currentStateLabel.Text = "Paused";
                    break;

                case 3:    // Playing
                    currentStateLabel.Text = "Playing";
                    var hosz = Convert.ToInt16(wmPLayer.currentMedia.duration);
                    mdaTrackBar.Maximum = hosz;
                    mediaDur.Text = "/"+Convert.ToString(hosz);
                    break;

                case 4:    // ScanForward
                    currentStateLabel.Text = "ScanForward";
                    break;

                case 5:    // ScanReverse
                    currentStateLabel.Text = "ScanReverse";
                    break;

                case 6:    // Buffering
                    currentStateLabel.Text = "Buffering";
                    break;

                case 7:    // Waiting
                    currentStateLabel.Text = "Waiting";
                    break;

                case 8:    // MediaEnded
                    currentStateLabel.Text = "MediaEnded";
                    break;

                case 9:    // Transitioning
                    currentStateLabel.Text = "Transitioning";
                    break;

                case 10:   // Ready
                    currentStateLabel.Text = "Ready";
                    break;

                case 11:   // Reconnecting
                    currentStateLabel.Text = "Reconnecting";
                    break;

                case 12:   // Last
                    currentStateLabel.Text = "Last";
                    break;

                default:
                    currentStateLabel.Text = ("Unknown State: " + e.newState.ToString());
                    break;
            }


        }

        private void mdaTrackBar_Scroll(object sender, EventArgs e)
        {
            wmPLayer.Ctlcontrols.pause();
            int pos = mdaTrackBar.Value;

            wmPLayer.Ctlcontrols.currentPosition = pos;
            moving();
            lbMediaTime.Text = Convert.ToString( pos);
        }

        private void mdaTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            //wmPLayer.Ctlcontrols.play();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (wmPLayer.playState == WMPPlayState.wmppsScanForward)
            {
                wmPLayer.Ctlcontrols.play();
                timer2.Enabled = false;
            }
            else
            {
                timer2.Enabled = true;
                wmPLayer.Ctlcontrols.fastForward();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (wmPLayer.playState == WMPPlayState.wmppsScanReverse)
            {
                wmPLayer.Ctlcontrols.play();
                timer2.Enabled = false;
            }
            else
            {
                timer2.Enabled = true;
                wmPLayer.Ctlcontrols.fastReverse();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frameStep(true);
            tracBarLep();
            moving();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tracBarLep();
        }
    }
}
