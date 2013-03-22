namespace TELMAGEN
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideshowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.grpColors = new System.Windows.Forms.GroupBox();
            this.btnSetLabels = new System.Windows.Forms.Button();
            this.rbGrey = new System.Windows.Forms.RadioButton();
            this.lblLtPink = new System.Windows.Forms.Label();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.lblGrey = new System.Windows.Forms.Label();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.lblWhite = new System.Windows.Forms.Label();
            this.rbLtPink = new System.Windows.Forms.RadioButton();
            this.lblLtGreen = new System.Windows.Forms.Label();
            this.rbLtGreen = new System.Windows.Forms.RadioButton();
            this.lblBlack = new System.Windows.Forms.Label();
            this.rbYellow = new System.Windows.Forms.RadioButton();
            this.rbPurple = new System.Windows.Forms.RadioButton();
            this.rbOrange = new System.Windows.Forms.RadioButton();
            this.rbPink = new System.Windows.Forms.RadioButton();
            this.rbLtBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.lblPurple = new System.Windows.Forms.Label();
            this.lblOrange = new System.Windows.Forms.Label();
            this.lblPink = new System.Windows.Forms.Label();
            this.lblLtBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnClearPoints = new System.Windows.Forms.Button();
            this.pbcanvas = new System.Windows.Forms.PictureBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.grpPoints = new System.Windows.Forms.GroupBox();
            this.lstPoints = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.grpColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcanvas)).BeginInit();
            this.grpPoints.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeProjectToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeProjectToolStripMenuItem.Text = "&Close Project";
            this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.closeProjectToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slideshowToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // slideshowToolStripMenuItem
            // 
            this.slideshowToolStripMenuItem.Name = "slideshowToolStripMenuItem";
            this.slideshowToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.slideshowToolStripMenuItem.Text = "&Slideshow";
            this.slideshowToolStripMenuItem.Click += new System.EventHandler(this.slideshowToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "Project Files (*.xml)|*.xml";
            // 
            // grpColors
            // 
            this.grpColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpColors.Controls.Add(this.btnSetLabels);
            this.grpColors.Controls.Add(this.rbGrey);
            this.grpColors.Controls.Add(this.lblLtPink);
            this.grpColors.Controls.Add(this.rbWhite);
            this.grpColors.Controls.Add(this.lblGrey);
            this.grpColors.Controls.Add(this.rbBlack);
            this.grpColors.Controls.Add(this.lblWhite);
            this.grpColors.Controls.Add(this.rbLtPink);
            this.grpColors.Controls.Add(this.lblLtGreen);
            this.grpColors.Controls.Add(this.rbLtGreen);
            this.grpColors.Controls.Add(this.lblBlack);
            this.grpColors.Controls.Add(this.rbYellow);
            this.grpColors.Controls.Add(this.rbPurple);
            this.grpColors.Controls.Add(this.rbOrange);
            this.grpColors.Controls.Add(this.rbPink);
            this.grpColors.Controls.Add(this.rbLtBlue);
            this.grpColors.Controls.Add(this.rbGreen);
            this.grpColors.Controls.Add(this.rbRed);
            this.grpColors.Controls.Add(this.rbBlue);
            this.grpColors.Controls.Add(this.lblPurple);
            this.grpColors.Controls.Add(this.lblOrange);
            this.grpColors.Controls.Add(this.lblPink);
            this.grpColors.Controls.Add(this.lblLtBlue);
            this.grpColors.Controls.Add(this.lblGreen);
            this.grpColors.Controls.Add(this.lblYellow);
            this.grpColors.Controls.Add(this.lblRed);
            this.grpColors.Controls.Add(this.lblBlue);
            this.grpColors.Location = new System.Drawing.Point(689, 27);
            this.grpColors.Name = "grpColors";
            this.grpColors.Size = new System.Drawing.Size(116, 218);
            this.grpColors.TabIndex = 2;
            this.grpColors.TabStop = false;
            this.grpColors.Text = "Colors";
            // 
            // btnSetLabels
            // 
            this.btnSetLabels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetLabels.Location = new System.Drawing.Point(5, 192);
            this.btnSetLabels.Name = "btnSetLabels";
            this.btnSetLabels.Size = new System.Drawing.Size(68, 20);
            this.btnSetLabels.TabIndex = 13;
            this.btnSetLabels.Text = "Set Labels";
            this.btnSetLabels.UseVisualStyleBackColor = true;
            this.btnSetLabels.Click += new System.EventHandler(this.btnSetLabels_Click);
            this.btnSetLabels.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // rbGrey
            // 
            this.rbGrey.AutoSize = true;
            this.rbGrey.Location = new System.Drawing.Point(5, 146);
            this.rbGrey.Name = "rbGrey";
            this.rbGrey.Size = new System.Drawing.Size(14, 13);
            this.rbGrey.TabIndex = 10;
            this.rbGrey.UseVisualStyleBackColor = true;
            this.rbGrey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.rbGrey.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rb_PreviewKeyDown);
            // 
            // lblLtPink
            // 
            this.lblLtPink.AutoSize = true;
            this.lblLtPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblLtPink.Location = new System.Drawing.Point(22, 133);
            this.lblLtPink.Name = "lblLtPink";
            this.lblLtPink.Size = new System.Drawing.Size(43, 13);
            this.lblLtPink.TabIndex = 24;
            this.lblLtPink.Text = "Lt. Pink";
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.Location = new System.Drawing.Point(5, 159);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(14, 13);
            this.rbWhite.TabIndex = 11;
            this.rbWhite.UseVisualStyleBackColor = true;
            this.rbWhite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.rbWhite.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rb_PreviewKeyDown);
            // 
            // lblGrey
            // 
            this.lblGrey.AutoSize = true;
            this.lblGrey.BackColor = System.Drawing.Color.Gray;
            this.lblGrey.Location = new System.Drawing.Point(22, 146);
            this.lblGrey.Name = "lblGrey";
            this.lblGrey.Size = new System.Drawing.Size(29, 13);
            this.lblGrey.TabIndex = 22;
            this.lblGrey.Text = "Grey";
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(5, 172);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(14, 13);
            this.rbBlack.TabIndex = 12;
            this.rbBlack.UseVisualStyleBackColor = true;
            this.rbBlack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.rbBlack.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rb_PreviewKeyDown);
            // 
            // lblWhite
            // 
            this.lblWhite.AutoSize = true;
            this.lblWhite.BackColor = System.Drawing.Color.White;
            this.lblWhite.Location = new System.Drawing.Point(22, 159);
            this.lblWhite.Name = "lblWhite";
            this.lblWhite.Size = new System.Drawing.Size(35, 13);
            this.lblWhite.TabIndex = 20;
            this.lblWhite.Text = "White";
            // 
            // rbLtPink
            // 
            this.rbLtPink.AutoSize = true;
            this.rbLtPink.Location = new System.Drawing.Point(5, 133);
            this.rbLtPink.Name = "rbLtPink";
            this.rbLtPink.Size = new System.Drawing.Size(14, 13);
            this.rbLtPink.TabIndex = 9;
            this.rbLtPink.UseVisualStyleBackColor = true;
            this.rbLtPink.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.rbLtPink.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rb_PreviewKeyDown);
            // 
            // lblLtGreen
            // 
            this.lblLtGreen.AutoSize = true;
            this.lblLtGreen.BackColor = System.Drawing.Color.Lime;
            this.lblLtGreen.Location = new System.Drawing.Point(22, 120);
            this.lblLtGreen.Name = "lblLtGreen";
            this.lblLtGreen.Size = new System.Drawing.Size(51, 13);
            this.lblLtGreen.TabIndex = 18;
            this.lblLtGreen.Text = "Lt. Green";
            // 
            // rbLtGreen
            // 
            this.rbLtGreen.AutoSize = true;
            this.rbLtGreen.Location = new System.Drawing.Point(5, 120);
            this.rbLtGreen.Name = "rbLtGreen";
            this.rbLtGreen.Size = new System.Drawing.Size(14, 13);
            this.rbLtGreen.TabIndex = 8;
            this.rbLtGreen.UseVisualStyleBackColor = true;
            this.rbLtGreen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.rbLtGreen.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rb_PreviewKeyDown);
            // 
            // lblBlack
            // 
            this.lblBlack.AutoSize = true;
            this.lblBlack.BackColor = System.Drawing.Color.Black;
            this.lblBlack.ForeColor = System.Drawing.Color.White;
            this.lblBlack.Location = new System.Drawing.Point(22, 172);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(34, 13);
            this.lblBlack.TabIndex = 16;
            this.lblBlack.Text = "Black";
            // 
            // rbYellow
            // 
            this.rbYellow.AutoSize = true;
            this.rbYellow.Location = new System.Drawing.Point(5, 55);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.Size = new System.Drawing.Size(14, 13);
            this.rbYellow.TabIndex = 3;
            this.rbYellow.UseVisualStyleBackColor = true;
            this.rbYellow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.rbYellow.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rb_PreviewKeyDown);
            // 
            // rbPurple
            // 
            this.rbPurple.AutoSize = true;
            this.rbPurple.Location = new System.Drawing.Point(5, 94);
            this.rbPurple.Name = "rbPurple";
            this.rbPurple.Size = new System.Drawing.Size(14, 13);
            this.rbPurple.TabIndex = 6;
            this.rbPurple.UseVisualStyleBackColor = true;
            this.rbPurple.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.rbPurple.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rb_PreviewKeyDown);
            // 
            // rbOrange
            // 
            this.rbOrange.AutoSize = true;
            this.rbOrange.Location = new System.Drawing.Point(5, 81);
            this.rbOrange.Name = "rbOrange";
            this.rbOrange.Size = new System.Drawing.Size(14, 13);
            this.rbOrange.TabIndex = 5;
            this.rbOrange.UseVisualStyleBackColor = true;
            this.rbOrange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.rbOrange.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rb_PreviewKeyDown);
            // 
            // rbPink
            // 
            this.rbPink.AutoSize = true;
            this.rbPink.Location = new System.Drawing.Point(5, 68);
            this.rbPink.Name = "rbPink";
            this.rbPink.Size = new System.Drawing.Size(14, 13);
            this.rbPink.TabIndex = 4;
            this.rbPink.UseVisualStyleBackColor = true;
            this.rbPink.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.rbPink.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rb_PreviewKeyDown);
            // 
            // rbLtBlue
            // 
            this.rbLtBlue.AutoSize = true;
            this.rbLtBlue.Location = new System.Drawing.Point(5, 107);
            this.rbLtBlue.Name = "rbLtBlue";
            this.rbLtBlue.Size = new System.Drawing.Size(14, 13);
            this.rbLtBlue.TabIndex = 7;
            this.rbLtBlue.UseVisualStyleBackColor = true;
            this.rbLtBlue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.rbLtBlue.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rb_PreviewKeyDown);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(5, 42);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(14, 13);
            this.rbGreen.TabIndex = 2;
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.rbGreen.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rb_PreviewKeyDown);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(5, 29);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(14, 13);
            this.rbRed.TabIndex = 1;
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.rbRed.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rb_PreviewKeyDown);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Checked = true;
            this.rbBlue.Location = new System.Drawing.Point(5, 16);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(14, 13);
            this.rbBlue.TabIndex = 0;
            this.rbBlue.TabStop = true;
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_KeyDown);
            this.rbBlue.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rb_PreviewKeyDown);
            // 
            // lblPurple
            // 
            this.lblPurple.AutoSize = true;
            this.lblPurple.BackColor = System.Drawing.Color.Purple;
            this.lblPurple.ForeColor = System.Drawing.Color.White;
            this.lblPurple.Location = new System.Drawing.Point(22, 94);
            this.lblPurple.Name = "lblPurple";
            this.lblPurple.Size = new System.Drawing.Size(37, 13);
            this.lblPurple.TabIndex = 7;
            this.lblPurple.Text = "Purple";
            // 
            // lblOrange
            // 
            this.lblOrange.AutoSize = true;
            this.lblOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOrange.Location = new System.Drawing.Point(22, 81);
            this.lblOrange.Name = "lblOrange";
            this.lblOrange.Size = new System.Drawing.Size(42, 13);
            this.lblOrange.TabIndex = 6;
            this.lblOrange.Text = "Orange";
            // 
            // lblPink
            // 
            this.lblPink.AutoSize = true;
            this.lblPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPink.Location = new System.Drawing.Point(22, 68);
            this.lblPink.Name = "lblPink";
            this.lblPink.Size = new System.Drawing.Size(28, 13);
            this.lblPink.TabIndex = 5;
            this.lblPink.Text = "Pink";
            // 
            // lblLtBlue
            // 
            this.lblLtBlue.AutoSize = true;
            this.lblLtBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblLtBlue.Location = new System.Drawing.Point(22, 107);
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
            this.lblGreen.Location = new System.Drawing.Point(22, 42);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 3;
            this.lblGreen.Text = "Green";
            // 
            // lblYellow
            // 
            this.lblYellow.AutoSize = true;
            this.lblYellow.BackColor = System.Drawing.Color.Yellow;
            this.lblYellow.Location = new System.Drawing.Point(22, 55);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(38, 13);
            this.lblYellow.TabIndex = 2;
            this.lblYellow.Text = "Yellow";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(22, 29);
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
            this.lblBlue.Location = new System.Drawing.Point(22, 16);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 13);
            this.lblBlue.TabIndex = 0;
            this.lblBlue.Text = "Blue";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(622, 536);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "00:00";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(175, 530);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(62, 23);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            this.btnNext.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bt_PreviewKeyDown);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(107, 531);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(62, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            this.btnBack.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bt_PreviewKeyDown);
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(674, 535);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(34, 13);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "0 of 0";
            // 
            // btnClearPoints
            // 
            this.btnClearPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearPoints.Location = new System.Drawing.Point(729, 529);
            this.btnClearPoints.Name = "btnClearPoints";
            this.btnClearPoints.Size = new System.Drawing.Size(76, 26);
            this.btnClearPoints.TabIndex = 18;
            this.btnClearPoints.Text = "Clear";
            this.btnClearPoints.UseVisualStyleBackColor = true;
            this.btnClearPoints.Click += new System.EventHandler(this.btnClearPoints_Click);
            this.btnClearPoints.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            // 
            // pbcanvas
            // 
            this.pbcanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbcanvas.Image = ((System.Drawing.Image)(resources.GetObject("pbcanvas.Image")));
            this.pbcanvas.InitialImage = null;
            this.pbcanvas.Location = new System.Drawing.Point(0, 27);
            this.pbcanvas.Name = "pbcanvas";
            this.pbcanvas.Size = new System.Drawing.Size(683, 496);
            this.pbcanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcanvas.TabIndex = 1;
            this.pbcanvas.TabStop = false;
            this.pbcanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbcanvas_MouseUp);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.Location = new System.Drawing.Point(39, 531);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(62, 23);
            this.btnFirst.TabIndex = 14;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            this.btnFirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            this.btnFirst.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bt_PreviewKeyDown);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.Location = new System.Drawing.Point(243, 531);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(62, 23);
            this.btnLast.TabIndex = 17;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            this.btnLast.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            this.btnLast.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bt_PreviewKeyDown);
            // 
            // grpPoints
            // 
            this.grpPoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPoints.Controls.Add(this.lstPoints);
            this.grpPoints.Location = new System.Drawing.Point(689, 245);
            this.grpPoints.Name = "grpPoints";
            this.grpPoints.Size = new System.Drawing.Size(116, 278);
            this.grpPoints.TabIndex = 19;
            this.grpPoints.TabStop = false;
            this.grpPoints.Text = "Points";
            // 
            // lstPoints
            // 
            this.lstPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPoints.FormattingEnabled = true;
            this.lstPoints.Location = new System.Drawing.Point(3, 16);
            this.lstPoints.Name = "lstPoints";
            this.lstPoints.Size = new System.Drawing.Size(110, 259);
            this.lstPoints.TabIndex = 0;
            this.lstPoints.SelectedIndexChanged += new System.EventHandler(this.lstPoints_SelectedIndexChanged);
            this.lstPoints.DoubleClick += new System.EventHandler(this.lstPoints_DoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 562);
            this.Controls.Add(this.grpPoints);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnClearPoints);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.grpColors);
            this.Controls.Add(this.pbcanvas);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(798, 559);
            this.Name = "Main";
            this.Text = "TELMAGEN";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpColors.ResumeLayout(false);
            this.grpColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcanvas)).EndInit();
            this.grpPoints.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.PictureBox pbcanvas;
        private System.Windows.Forms.GroupBox grpColors;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblOrange;
        private System.Windows.Forms.Label lblPink;
        private System.Windows.Forms.Label lblLtBlue;
        private System.Windows.Forms.RadioButton rbPurple;
        private System.Windows.Forms.RadioButton rbOrange;
        private System.Windows.Forms.RadioButton rbPink;
        private System.Windows.Forms.RadioButton rbLtBlue;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.Label lblPurple;
        private System.Windows.Forms.RadioButton rbYellow;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnClearPoints;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideshowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.RadioButton rbGrey;
        private System.Windows.Forms.Label lblLtPink;
        private System.Windows.Forms.RadioButton rbWhite;
        private System.Windows.Forms.Label lblGrey;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.Label lblWhite;
        private System.Windows.Forms.RadioButton rbLtPink;
        private System.Windows.Forms.Label lblLtGreen;
        private System.Windows.Forms.RadioButton rbLtGreen;
        private System.Windows.Forms.Label lblBlack;
        private System.Windows.Forms.Button btnSetLabels;
        private System.Windows.Forms.GroupBox grpPoints;
        private System.Windows.Forms.ListBox lstPoints;
    }
}

