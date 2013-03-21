namespace TELMAGEN.GUI
{
    partial class Slideshow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slideshow));
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbcanvas = new System.Windows.Forms.PictureBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpColors = new System.Windows.Forms.GroupBox();
            this.lblLtPink = new System.Windows.Forms.Label();
            this.lblGrey = new System.Windows.Forms.Label();
            this.lblWhite = new System.Windows.Forms.Label();
            this.lblLtGreen = new System.Windows.Forms.Label();
            this.lblBlack = new System.Windows.Forms.Label();
            this.lblPurple = new System.Windows.Forms.Label();
            this.lblOrange = new System.Windows.Forms.Label();
            this.lblPink = new System.Windows.Forms.Label();
            this.lblLtBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbcanvas)).BeginInit();
            this.grpColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(81, 526);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            this.btnPrevious.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            this.btnPrevious.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bt_PreviewKeyDown);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.Enabled = false;
            this.btnFirst.Location = new System.Drawing.Point(0, 526);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            this.btnFirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            this.btnFirst.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bt_PreviewKeyDown);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlayPause.Location = new System.Drawing.Point(162, 526);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(75, 23);
            this.btnPlayPause.TabIndex = 2;
            this.btnPlayPause.Text = "Play";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            this.btnPlayPause.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            this.btnPlayPause.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bt_PreviewKeyDown);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(244, 526);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            this.btnNext.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bt_PreviewKeyDown);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLast.Enabled = false;
            this.btnLast.Location = new System.Drawing.Point(325, 526);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            this.btnLast.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            this.btnLast.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bt_PreviewKeyDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(714, 526);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            this.btnClose.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bt_PreviewKeyDown);
            // 
            // pbcanvas
            // 
            this.pbcanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbcanvas.Image = global::TELMAGEN.Properties.Resources.telmagen_splash;
            this.pbcanvas.Location = new System.Drawing.Point(0, 0);
            this.pbcanvas.Name = "pbcanvas";
            this.pbcanvas.Size = new System.Drawing.Size(704, 520);
            this.pbcanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcanvas.TabIndex = 0;
            this.pbcanvas.TabStop = false;
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(652, 531);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(34, 13);
            this.lblPosition.TabIndex = 8;
            this.lblPosition.Text = "0 of 0";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(599, 531);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 13);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpColors
            // 
            this.grpColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpColors.Controls.Add(this.lblLtPink);
            this.grpColors.Controls.Add(this.lblGrey);
            this.grpColors.Controls.Add(this.lblWhite);
            this.grpColors.Controls.Add(this.lblLtGreen);
            this.grpColors.Controls.Add(this.lblBlack);
            this.grpColors.Controls.Add(this.lblPurple);
            this.grpColors.Controls.Add(this.lblOrange);
            this.grpColors.Controls.Add(this.lblPink);
            this.grpColors.Controls.Add(this.lblLtBlue);
            this.grpColors.Controls.Add(this.lblGreen);
            this.grpColors.Controls.Add(this.lblYellow);
            this.grpColors.Controls.Add(this.lblRed);
            this.grpColors.Controls.Add(this.lblBlue);
            this.grpColors.Location = new System.Drawing.Point(705, 0);
            this.grpColors.Name = "grpColors";
            this.grpColors.Size = new System.Drawing.Size(94, 193);
            this.grpColors.TabIndex = 9;
            this.grpColors.TabStop = false;
            this.grpColors.Text = "Labels";
            // 
            // lblLtPink
            // 
            this.lblLtPink.AutoSize = true;
            this.lblLtPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblLtPink.Location = new System.Drawing.Point(5, 133);
            this.lblLtPink.Name = "lblLtPink";
            this.lblLtPink.Size = new System.Drawing.Size(43, 13);
            this.lblLtPink.TabIndex = 24;
            this.lblLtPink.Text = "Lt. Pink";
            // 
            // lblGrey
            // 
            this.lblGrey.AutoSize = true;
            this.lblGrey.BackColor = System.Drawing.Color.Gray;
            this.lblGrey.Location = new System.Drawing.Point(5, 146);
            this.lblGrey.Name = "lblGrey";
            this.lblGrey.Size = new System.Drawing.Size(29, 13);
            this.lblGrey.TabIndex = 22;
            this.lblGrey.Text = "Grey";
            // 
            // lblWhite
            // 
            this.lblWhite.AutoSize = true;
            this.lblWhite.BackColor = System.Drawing.Color.White;
            this.lblWhite.Location = new System.Drawing.Point(5, 159);
            this.lblWhite.Name = "lblWhite";
            this.lblWhite.Size = new System.Drawing.Size(35, 13);
            this.lblWhite.TabIndex = 20;
            this.lblWhite.Text = "White";
            // 
            // lblLtGreen
            // 
            this.lblLtGreen.AutoSize = true;
            this.lblLtGreen.BackColor = System.Drawing.Color.Lime;
            this.lblLtGreen.Location = new System.Drawing.Point(5, 120);
            this.lblLtGreen.Name = "lblLtGreen";
            this.lblLtGreen.Size = new System.Drawing.Size(51, 13);
            this.lblLtGreen.TabIndex = 18;
            this.lblLtGreen.Text = "Lt. Green";
            // 
            // lblBlack
            // 
            this.lblBlack.AutoSize = true;
            this.lblBlack.BackColor = System.Drawing.Color.Black;
            this.lblBlack.ForeColor = System.Drawing.Color.White;
            this.lblBlack.Location = new System.Drawing.Point(5, 172);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(34, 13);
            this.lblBlack.TabIndex = 16;
            this.lblBlack.Text = "Black";
            // 
            // lblPurple
            // 
            this.lblPurple.AutoSize = true;
            this.lblPurple.BackColor = System.Drawing.Color.Purple;
            this.lblPurple.ForeColor = System.Drawing.Color.White;
            this.lblPurple.Location = new System.Drawing.Point(5, 94);
            this.lblPurple.Name = "lblPurple";
            this.lblPurple.Size = new System.Drawing.Size(37, 13);
            this.lblPurple.TabIndex = 7;
            this.lblPurple.Text = "Purple";
            // 
            // lblOrange
            // 
            this.lblOrange.AutoSize = true;
            this.lblOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOrange.Location = new System.Drawing.Point(5, 81);
            this.lblOrange.Name = "lblOrange";
            this.lblOrange.Size = new System.Drawing.Size(42, 13);
            this.lblOrange.TabIndex = 6;
            this.lblOrange.Text = "Orange";
            // 
            // lblPink
            // 
            this.lblPink.AutoSize = true;
            this.lblPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPink.Location = new System.Drawing.Point(5, 68);
            this.lblPink.Name = "lblPink";
            this.lblPink.Size = new System.Drawing.Size(28, 13);
            this.lblPink.TabIndex = 5;
            this.lblPink.Text = "Pink";
            // 
            // lblLtBlue
            // 
            this.lblLtBlue.AutoSize = true;
            this.lblLtBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblLtBlue.Location = new System.Drawing.Point(5, 107);
            this.lblLtBlue.Name = "lblLtBlue";
            this.lblLtBlue.Size = new System.Drawing.Size(43, 13);
            this.lblLtBlue.TabIndex = 4;
            this.lblLtBlue.Text = "Lt. Blue";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.BackColor = System.Drawing.Color.Green;
            this.lblGreen.ForeColor = System.Drawing.Color.White;
            this.lblGreen.Location = new System.Drawing.Point(5, 42);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 3;
            this.lblGreen.Text = "Green";
            // 
            // lblYellow
            // 
            this.lblYellow.AutoSize = true;
            this.lblYellow.BackColor = System.Drawing.Color.Yellow;
            this.lblYellow.Location = new System.Drawing.Point(5, 55);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(38, 13);
            this.lblYellow.TabIndex = 2;
            this.lblYellow.Text = "Yellow";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(5, 29);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 13);
            this.lblRed.TabIndex = 1;
            this.lblRed.Text = "Red";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.BackColor = System.Drawing.Color.Blue;
            this.lblBlue.ForeColor = System.Drawing.Color.White;
            this.lblBlue.Location = new System.Drawing.Point(5, 16);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 13);
            this.lblBlue.TabIndex = 0;
            this.lblBlue.Text = "Blue";
            // 
            // Slideshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 553);
            this.Controls.Add(this.grpColors);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.pbcanvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Slideshow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Slideshow";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbcanvas)).EndInit();
            this.grpColors.ResumeLayout(false);
            this.grpColors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbcanvas;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpColors;
        private System.Windows.Forms.Label lblLtPink;
        private System.Windows.Forms.Label lblGrey;
        private System.Windows.Forms.Label lblWhite;
        private System.Windows.Forms.Label lblLtGreen;
        private System.Windows.Forms.Label lblBlack;
        private System.Windows.Forms.Label lblPurple;
        private System.Windows.Forms.Label lblOrange;
        private System.Windows.Forms.Label lblPink;
        private System.Windows.Forms.Label lblLtBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblBlue;
    }
}