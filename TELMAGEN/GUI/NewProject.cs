using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TELMAGEN.IO;

namespace TELMAGEN
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

            //// copy the selected file to a temp file, in case it has a file lock on it
            //FilePath temp = FilePaths.TempFile;
            //System.IO.FileInfo imagefile = new System.IO.FileInfo(txtImageName.Text);
            //imagefile.CopyTo(temp.FullName);
            //txtImageName.Text = imagefile.FullName;

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
