using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TELMAGEN.IO;
using TELMAGEN.Library;

namespace TELMAGEN.GUI
{
    public partial class NewProject : Form
    {
        public NewProject()
        {
            InitializeComponent();
        }

        public string ProjectName
        {
            get { return txtName.Text; }
        }
        public int Interval
        {
            get
            {
                int? i = DataHelpers.C2I(txtInterval.Text);
                if (i.HasValue)
                {
                    return i.Value;
                }
                else
                {
                    throw new InvalidOperationException("Interval is not a valid integer between 1 and 1440");
                }
            }
        }
        public string ImageName
        {
            get
            {
                return txtImageName.Text; 
            }
        }
        public ColorLabel ColorLabel
        {
            get
            {
                ColorLabel c = new ColorLabel();
                c.red = txtRed.Text;
                c.blue = txtBlue.Text;
                c.yellow = txtYellow.Text;
                c.green = txtGreen.Text;
                c.pink = txtPink.Text;
                c.purple = txtPurple.Text;
                c.orange = txtOrange.Text;
                c.ltblue = txtLtBlue.Text;
                c.ltgreen = txtLtGreen.Text;
                c.ltpink = txtLtPink.Text;
                c.grey = txtGrey.Text;
                c.white = txtWhite.Text;
                c.black = txtBlack.Text;

                return c;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            #region data checks
            int? i = DataHelpers.C2I(txtInterval.Text);
            if (i.HasValue)
            {
                if ((i.Value < 1) || (i.Value > 1440))
                {
                    MessageBox.Show("Interval must be between 1 and 1440");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Interval is not a valid integer");
                return;
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name must be set");
                return;
            }

            if (string.IsNullOrEmpty(txtImageName.Text))
            {
                MessageBox.Show("Image Name must be set");
                return;
            }
            #endregion

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == dlgOpenFile.ShowDialog())
            {
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

                txtImageName.Text = dlgOpenFile.FileName;
            }
        }
    }
}
