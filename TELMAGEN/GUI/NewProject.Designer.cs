namespace TELMAGEN.GUI
{
    partial class NewProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProject));
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.lblCustomLabels = new System.Windows.Forms.Label();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtYellow = new System.Windows.Forms.TextBox();
            this.txtLtBlue = new System.Windows.Forms.TextBox();
            this.txtPurple = new System.Windows.Forms.TextBox();
            this.txtOrange = new System.Windows.Forms.TextBox();
            this.txtPink = new System.Windows.Forms.TextBox();
            this.txtLtGreen = new System.Windows.Forms.TextBox();
            this.txtWhite = new System.Windows.Forms.TextBox();
            this.txtGrey = new System.Windows.Forms.TextBox();
            this.txtLtPink = new System.Windows.Forms.TextBox();
            this.txtBlack = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 6);
            this.txtName.MaxLength = 255;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(305, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(108, 31);
            this.txtInterval.MaxLength = 4;
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(29, 20);
            this.txtInterval.TabIndex = 1;
            this.txtInterval.Text = "15";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interval (minutes):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Base Image:";
            // 
            // txtImageName
            // 
            this.txtImageName.Enabled = false;
            this.txtImageName.Location = new System.Drawing.Point(108, 57);
            this.txtImageName.MaxLength = 512;
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(249, 20);
            this.txtImageName.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(359, 57);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(54, 20);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(334, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(253, 254);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "Image Files (*.jpg)|*.jpg";
            // 
            // lblCustomLabels
            // 
            this.lblCustomLabels.AutoSize = true;
            this.lblCustomLabels.Location = new System.Drawing.Point(12, 91);
            this.lblCustomLabels.Name = "lblCustomLabels";
            this.lblCustomLabels.Size = new System.Drawing.Size(79, 13);
            this.lblCustomLabels.TabIndex = 38;
            this.lblCustomLabels.Text = "Custom Labels:";
            // 
            // txtBlue
            // 
            this.txtBlue.BackColor = System.Drawing.Color.Blue;
            this.txtBlue.ForeColor = System.Drawing.Color.White;
            this.txtBlue.Location = new System.Drawing.Point(15, 107);
            this.txtBlue.MaxLength = 255;
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(196, 20);
            this.txtBlue.TabIndex = 4;
            this.txtBlue.Text = "Blue";
            // 
            // txtRed
            // 
            this.txtRed.BackColor = System.Drawing.Color.Red;
            this.txtRed.ForeColor = System.Drawing.Color.White;
            this.txtRed.Location = new System.Drawing.Point(15, 128);
            this.txtRed.MaxLength = 255;
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(196, 20);
            this.txtRed.TabIndex = 5;
            this.txtRed.Text = "Red";
            // 
            // txtGreen
            // 
            this.txtGreen.BackColor = System.Drawing.Color.Green;
            this.txtGreen.ForeColor = System.Drawing.Color.White;
            this.txtGreen.Location = new System.Drawing.Point(15, 149);
            this.txtGreen.MaxLength = 255;
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(196, 20);
            this.txtGreen.TabIndex = 6;
            this.txtGreen.Text = "Green";
            // 
            // txtYellow
            // 
            this.txtYellow.BackColor = System.Drawing.Color.Yellow;
            this.txtYellow.ForeColor = System.Drawing.Color.Black;
            this.txtYellow.Location = new System.Drawing.Point(15, 170);
            this.txtYellow.MaxLength = 255;
            this.txtYellow.Name = "txtYellow";
            this.txtYellow.Size = new System.Drawing.Size(196, 20);
            this.txtYellow.TabIndex = 7;
            this.txtYellow.Text = "Yellow";
            // 
            // txtLtBlue
            // 
            this.txtLtBlue.BackColor = System.Drawing.Color.Aqua;
            this.txtLtBlue.ForeColor = System.Drawing.Color.Black;
            this.txtLtBlue.Location = new System.Drawing.Point(217, 107);
            this.txtLtBlue.MaxLength = 255;
            this.txtLtBlue.Name = "txtLtBlue";
            this.txtLtBlue.Size = new System.Drawing.Size(196, 20);
            this.txtLtBlue.TabIndex = 11;
            this.txtLtBlue.Text = "Lt. Blue";
            // 
            // txtPurple
            // 
            this.txtPurple.BackColor = System.Drawing.Color.Purple;
            this.txtPurple.ForeColor = System.Drawing.Color.White;
            this.txtPurple.Location = new System.Drawing.Point(15, 233);
            this.txtPurple.MaxLength = 255;
            this.txtPurple.Name = "txtPurple";
            this.txtPurple.Size = new System.Drawing.Size(196, 20);
            this.txtPurple.TabIndex = 10;
            this.txtPurple.Text = "Purple";
            // 
            // txtOrange
            // 
            this.txtOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtOrange.ForeColor = System.Drawing.Color.White;
            this.txtOrange.Location = new System.Drawing.Point(15, 212);
            this.txtOrange.MaxLength = 255;
            this.txtOrange.Name = "txtOrange";
            this.txtOrange.Size = new System.Drawing.Size(196, 20);
            this.txtOrange.TabIndex = 9;
            this.txtOrange.Text = "Orange";
            // 
            // txtPink
            // 
            this.txtPink.BackColor = System.Drawing.Color.Fuchsia;
            this.txtPink.ForeColor = System.Drawing.Color.White;
            this.txtPink.Location = new System.Drawing.Point(15, 191);
            this.txtPink.MaxLength = 255;
            this.txtPink.Name = "txtPink";
            this.txtPink.Size = new System.Drawing.Size(196, 20);
            this.txtPink.TabIndex = 8;
            this.txtPink.Text = "Pink";
            // 
            // txtLtGreen
            // 
            this.txtLtGreen.BackColor = System.Drawing.Color.Lime;
            this.txtLtGreen.ForeColor = System.Drawing.Color.Black;
            this.txtLtGreen.Location = new System.Drawing.Point(217, 128);
            this.txtLtGreen.MaxLength = 255;
            this.txtLtGreen.Name = "txtLtGreen";
            this.txtLtGreen.Size = new System.Drawing.Size(196, 20);
            this.txtLtGreen.TabIndex = 12;
            this.txtLtGreen.Text = "Lt. Green";
            // 
            // txtWhite
            // 
            this.txtWhite.BackColor = System.Drawing.Color.White;
            this.txtWhite.ForeColor = System.Drawing.Color.Black;
            this.txtWhite.Location = new System.Drawing.Point(217, 191);
            this.txtWhite.MaxLength = 255;
            this.txtWhite.Name = "txtWhite";
            this.txtWhite.Size = new System.Drawing.Size(196, 20);
            this.txtWhite.TabIndex = 15;
            this.txtWhite.Text = "White";
            // 
            // txtGrey
            // 
            this.txtGrey.BackColor = System.Drawing.Color.Gray;
            this.txtGrey.ForeColor = System.Drawing.Color.Black;
            this.txtGrey.Location = new System.Drawing.Point(217, 170);
            this.txtGrey.MaxLength = 255;
            this.txtGrey.Name = "txtGrey";
            this.txtGrey.Size = new System.Drawing.Size(196, 20);
            this.txtGrey.TabIndex = 14;
            this.txtGrey.Text = "Grey";
            // 
            // txtLtPink
            // 
            this.txtLtPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtLtPink.ForeColor = System.Drawing.Color.Black;
            this.txtLtPink.Location = new System.Drawing.Point(217, 149);
            this.txtLtPink.MaxLength = 255;
            this.txtLtPink.Name = "txtLtPink";
            this.txtLtPink.Size = new System.Drawing.Size(196, 20);
            this.txtLtPink.TabIndex = 13;
            this.txtLtPink.Text = "Lt. Pink";
            // 
            // txtBlack
            // 
            this.txtBlack.BackColor = System.Drawing.Color.Black;
            this.txtBlack.ForeColor = System.Drawing.Color.White;
            this.txtBlack.Location = new System.Drawing.Point(217, 212);
            this.txtBlack.MaxLength = 255;
            this.txtBlack.Name = "txtBlack";
            this.txtBlack.Size = new System.Drawing.Size(196, 20);
            this.txtBlack.TabIndex = 16;
            this.txtBlack.Text = "Black";
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 282);
            this.Controls.Add(this.txtBlack);
            this.Controls.Add(this.txtLtPink);
            this.Controls.Add(this.txtGrey);
            this.Controls.Add(this.txtWhite);
            this.Controls.Add(this.txtLtGreen);
            this.Controls.Add(this.txtLtBlue);
            this.Controls.Add(this.txtPurple);
            this.Controls.Add(this.txtOrange);
            this.Controls.Add(this.txtPink);
            this.Controls.Add(this.txtYellow);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.lblCustomLabels);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtImageName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.Label lblCustomLabels;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtYellow;
        private System.Windows.Forms.TextBox txtLtBlue;
        private System.Windows.Forms.TextBox txtPurple;
        private System.Windows.Forms.TextBox txtOrange;
        private System.Windows.Forms.TextBox txtPink;
        private System.Windows.Forms.TextBox txtLtGreen;
        private System.Windows.Forms.TextBox txtWhite;
        private System.Windows.Forms.TextBox txtGrey;
        private System.Windows.Forms.TextBox txtLtPink;
        private System.Windows.Forms.TextBox txtBlack;
    }
}