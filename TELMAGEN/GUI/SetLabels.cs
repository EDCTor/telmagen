using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TELMAGEN.Library;

namespace TELMAGEN.GUI
{
    public partial class SetLabels : Form
    {
        public SetLabels()
        {
            InitializeComponent();
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
            set
            {
                if (value != null)
                {
                    txtRed.Text = value.red;
                    txtBlue.Text = value.blue;
                    txtYellow.Text = value.yellow;
                    txtGreen.Text = value.green;
                    txtPink.Text = value.pink;
                    txtPurple.Text = value.purple;
                    txtOrange.Text = value.orange;
                    txtLtBlue.Text = value.ltblue;
                    txtLtGreen.Text = value.ltgreen;
                    txtLtPink.Text = value.ltpink;
                    txtGrey.Text = value.grey;
                    txtWhite.Text = value.white;
                    txtBlack.Text = value.black;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
