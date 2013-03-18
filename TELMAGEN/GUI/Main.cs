using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TELMAGEN.IO;

namespace TELMAGEN
{
    public partial class Main : Form
    {
        private TelmagenProject project = null;
        private int shown_ttime = -1;
        private Bitmap working_bm = null;

        public Main()
        {
            InitializeComponent();
        }

        private void RefreshCanvas()
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

        private TColor GetSelectedTColor()
        {
            if (rbBlue.Checked)
            {
                return TColor.BLUE;
            }
            else if (rbRed.Checked)
            {
                return TColor.RED;
            }
            else if (rbGreen.Checked)
            {
                return TColor.GREEN;
            }
            else if (rbYellow.Checked)
            {
                return TColor.YELLOW;
            }
            else if (rbPink.Checked)
            {
                return TColor.PINK;
            }
            else if (rbPurple.Checked)
            {
                return TColor.PURPLE;
            }
            else if (rbOrange.Checked)
            {
                return TColor.ORANGE;
            }
            else if (rbLtBlue.Checked)
            {
                return TColor.BABYBLUE;
            }
            else
            {
                throw new InvalidOperationException("Color not selected in toolbox");
            }
        }
        public Color Lighten(Color inColor, double inAmount)
        {
            return Color.FromArgb(
              inColor.A,
              (int)Math.Min(255, inColor.R + 255 * inAmount),
              (int)Math.Min(255, inColor.G + 255 * inAmount),
              (int)Math.Min(255, inColor.B + 255 * inAmount));
        }

        #region event handlers
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (NewProject form = new NewProject())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        string name = form.ProjectName;
                        int interval = form.Interval;
                        string full_image_name = form.ImageName;

                        //get a project folder name
                        string folder_name = DataHelpers.FilterStringForFileName(name);

                        // create a folder for the project
                        DirectoryPath projects_folder = FilePaths.Projects;
                        DirectoryPath project_folder = new DirectoryPath(projects_folder, folder_name);

                        if (project_folder.Exists)
                        {
                            MessageBox.Show("Cannot create this project as it already exists");
                            return;
                        }
                        else
                        {
                            project_folder.Create(); 
                        }

                        // create the new project object
                        this.project = new TelmagenProject(name, interval, full_image_name);
                        // init this form to what we are looking at (the first ttime)
                        this.shown_ttime = this.project.GetFirstTTime();

                        #region write the xml file that represents the project
                        string s = this.project.Serialize;
                        FilePath p = new FilePath(project_folder, folder_name + ".xml");
                        p.WriteAllText(s);
                        #endregion
                        #region save the image file to disk
                        // save the image to disk, into the new project folder
                        FilePath i = new FilePath(full_image_name);
                        this.project.Image.Save(project_folder.FullName + "\\" + this.project.ImageName);
                        #endregion

                        RefreshCanvas();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.project == null)
                {
                    MessageBox.Show("Please create a new project or open an existing project before attempting a save operation");
                    return;
                }

                //get a project folder name
                string name = DataHelpers.FilterStringForFileName(project.Name);

                // create a folder for the project
                DirectoryPath projects_folder = FilePaths.Projects;
                DirectoryPath project_folder = new DirectoryPath(projects_folder, name);

                if (!project_folder.Exists)
                {
                    MessageBox.Show("Cannot save project as project folder does not exist (" + project_folder.FullName + ")");
                    return;
                }

                // write the xml file that represents the project
                string s = this.project.Serialize;
                FilePath p = new FilePath(project_folder, name + ".xml");
                p.WriteAllText(s);

                // image save is purposely skipped, the base image never changes after initial project creation
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during save: " + ex.Message + System.Environment.NewLine + ex.StackTrace);
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dlgOpenFile.Title = "Select XML Project File";
                dlgOpenFile.InitialDirectory = FilePaths.Projects.FullName;

                if (DialogResult.OK == dlgOpenFile.ShowDialog())
                {
                    #region data checks on input
                    if (string.IsNullOrEmpty(dlgOpenFile.FileName))
                    {
                        MessageBox.Show("You must select a file");
                        return;
                    }

                    FilePath file = new FilePath(dlgOpenFile.FileName);
                    if (!file.Exists)
                    {
                        MessageBox.Show("File does not exist");
                        return;
                    }
                    #endregion

                    #region get the project file and load it into a project object
                    FilePath path = new FilePath(dlgOpenFile.FileName);
                    string s = path.ReadAllText();

                    TelmagenProject p = new TelmagenProject();
                    p.Serialize = s;
                    #endregion

                    #region we restored the project settings, lets restore the image now
                    FilePath image_path = new FilePath(path.Directory.FullName + "\\" + p.ImageName);
                    if (image_path.Exists)
                    {
                        p.Image = new Bitmap(image_path.FullName);
                    }
                    else
                    {
                        MessageBox.Show("Found project file, but could not load image " + image_path.FullName + " " + System.Environment.NewLine +
                            "Ensure the image file exists and try again.");
                        return;
                    }
                    #endregion

                    this.project = p;
                    this.shown_ttime = p.GetFirstTTime();

                    RefreshCanvas();

                    MessageBox.Show("Project successfully opened");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during save: " + ex.Message + System.Environment.NewLine + ex.StackTrace);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (DialogResult.No == MessageBox.Show("Are you sure?", "Exit TELMAGEN", MessageBoxButtons.YesNo))
            //{
            //    return;
            //}
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.project == null) { return; }

            int max_ttime = this.project.GetLastTTime();
            if (shown_ttime >= max_ttime) { return; }

            this.shown_ttime += 1;

            RefreshCanvas();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.project == null) { return; }
            if (shown_ttime <= 1) { return; }

            this.shown_ttime -= 1;

            RefreshCanvas();
        }
        private void closeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.project = null;
            this.shown_ttime = -1;
            //this.uncommitted_points = new List<TPoint>();

            RefreshCanvas();
        }
        private void pbcanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.project == null) { return; }

            int xcoor = e.X;
            int ycoor = e.Y;

            // convert the x/y to map to the original image
            xcoor = this.project.ConvertDisplayedXCoor(pbcanvas.Width, xcoor);
            ycoor = this.project.ConvertDisplayedYCoor(pbcanvas.Height, ycoor);

            // locate the proper color
            TColor c = GetSelectedTColor();

            // get the current ttime
            TTime t = this.project.GetTTime(this.shown_ttime);
            // add the new point
            t.AddTPoint(xcoor, ycoor, c);

            // refresh the GUI
            RefreshCanvas();
        }
        private void btnClearPoints_Click(object sender, EventArgs e)
        {
            if (this.project == null) { return; }
            if (this.shown_ttime <= 0) { return; }

            TTime t = this.project.GetTTime(this.shown_ttime);
            t.TPoints = null;

            RefreshCanvas();
        }
        private void slideshowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.project == null) 
            {
                MessageBox.Show("Please open or create a project before attempting a slideshow");
                return; 
            }

            //save changes just in case
            if (DialogResult.Yes == MessageBox.Show("Would you like to save first", "Save Project", MessageBoxButtons.YesNo))
            {
                saveToolStripMenuItem_Click(null, null);
            }

            try
            {
                using (Slideshow form = new Slideshow())
                {
                    form.Project = this.project;
                    form.Text = "Slideshow " + this.project.Name;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        //
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.project == null)
            {
                slideshowToolStripMenuItem.Enabled = false;
            }
            else
            {
                slideshowToolStripMenuItem.Enabled = true;
            }
        }

        #endregion
    }
}
