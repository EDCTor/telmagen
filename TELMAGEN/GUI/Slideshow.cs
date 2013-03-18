using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TELMAGEN.GUI
{
    public partial class Slideshow : Form
    {
        private TelmagenProject project = null;
        private int shown_ttime = -1;
        private Bitmap working_bm = null;
        private bool playing = false;

        private static readonly object playpause_lock = new object();

        public Slideshow()
        {
            InitializeComponent();
        }

        public int RefreshIntervalMilliSeconds
        {
            set
            {
                this.timer1.Interval = value;
            }
        }
        public TelmagenProject Project
        {
            set
            {
                this.project = value;
            }
        }
        public void RefreshCanvas()
        {
            // reset the GUI to defaults
            if (this.project == null)
            {
                //using (Bitmap b = new Bitmap(TELMAGEN.Properties.Resources.telmagen_splash))
                //{
                //    pbcanvas.Image = b;
                //}
                pbcanvas.Image = new Bitmap(TELMAGEN.Properties.Resources.telmagen_splash);

                lblTime.Text = "00:00";
                lblPosition.Text = "0 of 0";
                return;
            }

            if (this.project.Image != null)
            {
                // draw the base image
                pbcanvas.Image = this.project.Image;
            }

            // if we have a current ttime lets refresh its values into the GUI
            if (this.shown_ttime > 0)
            {
                // draw the time of day label
                TTime ttime = this.project.GetTTime(this.shown_ttime);
                lblTime.Text = ttime.ToString();

                // draw the time slice number label (i.e. position)
                int minttime = this.shown_ttime;
                int maxttime = this.project.GetLastTTime();
                lblPosition.Text = minttime.ToString() + " of " + maxttime.ToString();

                // plot the saved points
                PlotPoints(ttime.TPoints);

                // plot any uncommitted points
                //PlotPoints(this.uncommitted_points.ToArray());
            }
        }
        private void PlotPoints(TPoint[] tpoints)
        {
            // abort if we dont have valid input
            if (this.project == null) { return; }
            if (this.project.Image == null) { return; }
            if (tpoints == null) { return; }

            //
            // while we have to convert the x/y of the paintbox mouse click event
            // no such conversion is required for the paintbox refresh as all points are plotted
            // on the original image and then the paintbox is set to contain the image
            //

            // clear the last image if there was one
            if (working_bm != null) { this.working_bm.Dispose(); }

            // make a clone of the base image
            this.working_bm = this.project.Image.Clone() as Bitmap;

            // draw the points on the clone then set the canvas
            using (Graphics g = Graphics.FromImage(working_bm))
            {
                foreach (TPoint tpoint in tpoints)
                {
                    SolidBrush b = ColorCodeAttribute.GetBrush(tpoint.TColor);
                    g.FillEllipse(b, tpoint.x, tpoint.y, 10, 10);
                }

                // if (pbcanvas.Image != null) { pbcanvas.Image.Dispose(); }
                pbcanvas.Image = this.working_bm;
            }

        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            lock (playpause_lock)
            {
                if (this.playing)
                {
                    // tell it not to play
                    this.playing = false;
                    this.timer1.Enabled = false;
                    btnFirst.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    btnPlayPause.Text = "Play";
                }
                else
                {
                    // tell it to play
                    this.playing = true;
                    this.timer1.Enabled = true;
                    btnFirst.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnPlayPause.Text = "Pause";
                }
            }
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (this.project == null) { return; }

            lock (playpause_lock)
            {
                this.shown_ttime = 1;
                RefreshCanvas();
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (this.project == null) { return; }

            lock (playpause_lock)
            {
                if (this.shown_ttime > 1)
                {
                    this.shown_ttime -= 1;
                    RefreshCanvas();
                }
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.project == null) { return; }

            lock (playpause_lock)
            {
                if (this.shown_ttime < this.project.GetLastTTime())
                {
                    this.shown_ttime += 1;
                    RefreshCanvas();
                }
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            if (this.project == null) { return; }

            lock (playpause_lock)
            {
                this.shown_ttime = this.project.GetLastTTime();
                RefreshCanvas();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.project == null) { return; }

            if (this.shown_ttime < this.project.GetLastTTime())
            {
                this.shown_ttime += 1;
                RefreshCanvas();
            }
        }
    }
}
