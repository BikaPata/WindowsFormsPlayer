namespace WindowsFormsPlayer
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.currentStateLabel = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnScanForward = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mdaTrackBar = new System.Windows.Forms.TrackBar();
            this.btnVol = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mediaDur = new System.Windows.Forms.Label();
            this.lbMediaTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.plyListBox = new System.Windows.Forms.ListBox();
            this.panelVolume = new System.Windows.Forms.Panel();
            this.mdaVolPerc = new System.Windows.Forms.Label();
            this.mdaVolume = new System.Windows.Forms.TrackBar();
            this.wmPLayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdaTrackBar)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdaVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmPLayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.currentStateLabel);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnScanForward);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 93);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "00:00:00:00";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(629, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "frameJobb";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "FrameBal";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // currentStateLabel
            // 
            this.currentStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentStateLabel.AutoSize = true;
            this.currentStateLabel.Location = new System.Drawing.Point(552, 46);
            this.currentStateLabel.Name = "currentStateLabel";
            this.currentStateLabel.Size = new System.Drawing.Size(35, 13);
            this.currentStateLabel.TabIndex = 6;
            this.currentStateLabel.Text = "label1";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(394, 26);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(74, 67);
            this.btnStop.TabIndex = 5;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(234, 26);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(77, 67);
            this.btnPause.TabIndex = 4;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPlay.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(317, 26);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(71, 67);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "TekerBal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnScanForward
            // 
            this.btnScanForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScanForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanForward.Location = new System.Drawing.Point(629, 26);
            this.btnScanForward.Name = "btnScanForward";
            this.btnScanForward.Size = new System.Drawing.Size(70, 33);
            this.btnScanForward.TabIndex = 1;
            this.btnScanForward.Text = "TekerJObb";
            this.btnScanForward.UseVisualStyleBackColor = true;
            this.btnScanForward.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.mdaTrackBar);
            this.panel3.Controls.Add(this.btnVol);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(699, 26);
            this.panel3.TabIndex = 0;
            // 
            // mdaTrackBar
            // 
            this.mdaTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mdaTrackBar.LargeChange = 1;
            this.mdaTrackBar.Location = new System.Drawing.Point(3, 2);
            this.mdaTrackBar.Name = "mdaTrackBar";
            this.mdaTrackBar.Size = new System.Drawing.Size(507, 45);
            this.mdaTrackBar.TabIndex = 4;
            this.mdaTrackBar.Scroll += new System.EventHandler(this.mdaTrackBar_Scroll);
            this.mdaTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mdaTrackBar_MouseUp);
            // 
            // btnVol
            // 
            this.btnVol.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVol.Location = new System.Drawing.Point(670, 0);
            this.btnVol.Name = "btnVol";
            this.btnVol.Size = new System.Drawing.Size(29, 26);
            this.btnVol.TabIndex = 3;
            this.btnVol.Text = "Vol";
            this.btnVol.UseVisualStyleBackColor = true;
            this.btnVol.Click += new System.EventHandler(this.btnVol_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.mediaDur);
            this.panel4.Controls.Add(this.lbMediaTime);
            this.panel4.Location = new System.Drawing.Point(516, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 26);
            this.panel4.TabIndex = 1;
            // 
            // mediaDur
            // 
            this.mediaDur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mediaDur.AutoSize = true;
            this.mediaDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mediaDur.Location = new System.Drawing.Point(67, 5);
            this.mediaDur.Name = "mediaDur";
            this.mediaDur.Size = new System.Drawing.Size(78, 15);
            this.mediaDur.TabIndex = 1;
            this.mediaDur.Text = "/ 00:00:00:00";
            // 
            // lbMediaTime
            // 
            this.lbMediaTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbMediaTime.AutoSize = true;
            this.lbMediaTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMediaTime.Location = new System.Drawing.Point(-3, 5);
            this.lbMediaTime.Name = "lbMediaTime";
            this.lbMediaTime.Size = new System.Drawing.Size(72, 15);
            this.lbMediaTime.TabIndex = 0;
            this.lbMediaTime.Text = "00:00:00:00";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnOpen);
            this.panel2.Controls.Add(this.btnMin);
            this.panel2.Controls.Add(this.btnMax);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 45);
            this.panel2.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(0, 0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(49, 43);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(550, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(49, 43);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMax
            // 
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(599, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(49, 43);
            this.btnMax.TabIndex = 1;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(648, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 45);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.plyListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelVolume);
            this.splitContainer1.Panel2.Controls.Add(this.wmPLayer);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(699, 220);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 2;
            // 
            // plyListBox
            // 
            this.plyListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plyListBox.FormattingEnabled = true;
            this.plyListBox.Location = new System.Drawing.Point(0, 0);
            this.plyListBox.Name = "plyListBox";
            this.plyListBox.Size = new System.Drawing.Size(232, 220);
            this.plyListBox.TabIndex = 0;
            this.plyListBox.SelectedIndexChanged += new System.EventHandler(this.plyListaBox_SelectedIndexChanged);
            // 
            // panelVolume
            // 
            this.panelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVolume.BackColor = System.Drawing.Color.Transparent;
            this.panelVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelVolume.Controls.Add(this.mdaVolPerc);
            this.panelVolume.Controls.Add(this.mdaVolume);
            this.panelVolume.Location = new System.Drawing.Point(434, 67);
            this.panelVolume.Name = "panelVolume";
            this.panelVolume.Size = new System.Drawing.Size(29, 153);
            this.panelVolume.TabIndex = 1;
            this.panelVolume.Visible = false;
            // 
            // mdaVolPerc
            // 
            this.mdaVolPerc.AutoSize = true;
            this.mdaVolPerc.Location = new System.Drawing.Point(0, 137);
            this.mdaVolPerc.Name = "mdaVolPerc";
            this.mdaVolPerc.Size = new System.Drawing.Size(33, 13);
            this.mdaVolPerc.TabIndex = 1;
            this.mdaVolPerc.Text = "100%";
            // 
            // mdaVolume
            // 
            this.mdaVolume.Location = new System.Drawing.Point(0, 0);
            this.mdaVolume.Maximum = 100;
            this.mdaVolume.Name = "mdaVolume";
            this.mdaVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.mdaVolume.Size = new System.Drawing.Size(45, 135);
            this.mdaVolume.TabIndex = 0;
            this.mdaVolume.Value = 100;
            this.mdaVolume.Scroll += new System.EventHandler(this.mdaVolume_Scroll);
            this.mdaVolume.ValueChanged += new System.EventHandler(this.mdaVolume_ValueChanged);
            // 
            // wmPLayer
            // 
            this.wmPLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmPLayer.Enabled = true;
            this.wmPLayer.Location = new System.Drawing.Point(0, 0);
            this.wmPLayer.Name = "wmPLayer";
            this.wmPLayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmPLayer.OcxState")));
            this.wmPLayer.Size = new System.Drawing.Size(463, 220);
            this.wmPLayer.TabIndex = 0;
            this.wmPLayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmPLayer_PlayStateChange);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 363);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Player";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Player_FormClosed);
            this.Load += new System.EventHandler(this.Player_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdaTrackBar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelVolume.ResumeLayout(false);
            this.panelVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdaVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmPLayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private AxWMPLib.AxWindowsMediaPlayer wmPLayer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnScanForward;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox plyListBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbMediaTime;
        private System.Windows.Forms.Panel panelVolume;
        private System.Windows.Forms.TrackBar mdaVolume;
        private System.Windows.Forms.Label mdaVolPerc;
        private System.Windows.Forms.Button btnVol;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar mdaTrackBar;
        private System.Windows.Forms.Label currentStateLabel;
        private System.Windows.Forms.Label mediaDur;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
    }
}