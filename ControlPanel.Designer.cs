using System.Reflection;

namespace ImgNow
{
    partial class ControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.bttCaptureLarge = new System.Windows.Forms.Button();
            this.bttCaptureSmall = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutPortraitGrabberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.bttCaptureMedium = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.groupLarge = new System.Windows.Forms.GroupBox();
            this.textLargeWidth = new System.Windows.Forms.TextBox();
            this.textLargeHeight = new System.Windows.Forms.TextBox();
            this.groupSmall = new System.Windows.Forms.GroupBox();
            this.textSmallHeight = new System.Windows.Forms.TextBox();
            this.textSmallWidth = new System.Windows.Forms.TextBox();
            this.checkForceRatio = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bttSelectFolder = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.checkBGEE = new System.Windows.Forms.CheckBox();
            this.groupMedium = new System.Windows.Forms.GroupBox();
            this.textMediumHeight = new System.Windows.Forms.TextBox();
            this.textMediumWidth = new System.Windows.Forms.TextBox();
            this.tabCapture = new System.Windows.Forms.TabPage();
            this.bttCaptureAll = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.groupLarge.SuspendLayout();
            this.groupSmall.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupMedium.SuspendLayout();
            this.tabCapture.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttCaptureLarge
            // 
            this.bttCaptureLarge.BackColor = System.Drawing.Color.Gainsboro;
            this.bttCaptureLarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCaptureLarge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttCaptureLarge.Location = new System.Drawing.Point(0, 9);
            this.bttCaptureLarge.Name = "bttCaptureLarge";
            this.bttCaptureLarge.Size = new System.Drawing.Size(107, 32);
            this.bttCaptureLarge.TabIndex = 0;
            this.bttCaptureLarge.TabStop = false;
            this.bttCaptureLarge.Text = "Capture Large";
            this.bttCaptureLarge.UseVisualStyleBackColor = false;
            this.bttCaptureLarge.Click += new System.EventHandler(this.bttCaptureLarge_Click);
            // 
            // bttCaptureSmall
            // 
            this.bttCaptureSmall.BackColor = System.Drawing.Color.Gainsboro;
            this.bttCaptureSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCaptureSmall.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttCaptureSmall.Location = new System.Drawing.Point(0, 83);
            this.bttCaptureSmall.Name = "bttCaptureSmall";
            this.bttCaptureSmall.Size = new System.Drawing.Size(107, 32);
            this.bttCaptureSmall.TabIndex = 2;
            this.bttCaptureSmall.TabStop = false;
            this.bttCaptureSmall.Text = "Capture Small";
            this.bttCaptureSmall.UseVisualStyleBackColor = false;
            this.bttCaptureSmall.Click += new System.EventHandler(this.bttCaptureSmall_Click);
            // 
            // bttExit
            // 
            this.bttExit.BackColor = System.Drawing.Color.Gainsboro;
            this.bttExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttExit.Location = new System.Drawing.Point(16, 286);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(107, 32);
            this.bttExit.TabIndex = 3;
            this.bttExit.TabStop = false;
            this.bttExit.Text = "Exit";
            this.bttExit.UseVisualStyleBackColor = false;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.BalloonTipText = "Portrait Grabber";
            this.notifyIcon2.BalloonTipTitle = "Portrait Grabber";
            this.notifyIcon2.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "Portrait Grabber";
            this.notifyIcon2.Visible = true;
            this.notifyIcon2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutPortraitGrabberToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 70);
            this.contextMenuStrip1.Text = "Portrait Grabber";
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // aboutPortraitGrabberToolStripMenuItem
            // 
            this.aboutPortraitGrabberToolStripMenuItem.Name = "aboutPortraitGrabberToolStripMenuItem";
            this.aboutPortraitGrabberToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.aboutPortraitGrabberToolStripMenuItem.Text = "About Portrait Grabber";
            this.aboutPortraitGrabberToolStripMenuItem.Click += new System.EventHandler(this.aboutPortraitGrabberToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(16, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "Minimize to tray";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttCaptureMedium
            // 
            this.bttCaptureMedium.BackColor = System.Drawing.Color.Gainsboro;
            this.bttCaptureMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCaptureMedium.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttCaptureMedium.Location = new System.Drawing.Point(0, 46);
            this.bttCaptureMedium.Name = "bttCaptureMedium";
            this.bttCaptureMedium.Size = new System.Drawing.Size(107, 32);
            this.bttCaptureMedium.TabIndex = 2;
            this.bttCaptureMedium.TabStop = false;
            this.bttCaptureMedium.Text = "Capture Medium";
            this.bttCaptureMedium.UseVisualStyleBackColor = false;
            this.bttCaptureMedium.Click += new System.EventHandler(this.bttCaptureMedium_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(12, 12);
            this.textName.MaxLength = 7;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(54, 20);
            this.textName.TabIndex = 5;
            this.textName.Text = "filenam";
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // groupLarge
            // 
            this.groupLarge.Controls.Add(this.textLargeWidth);
            this.groupLarge.Controls.Add(this.textLargeHeight);
            this.groupLarge.Location = new System.Drawing.Point(0, 3);
            this.groupLarge.Name = "groupLarge";
            this.groupLarge.Size = new System.Drawing.Size(107, 42);
            this.groupLarge.TabIndex = 6;
            this.groupLarge.TabStop = false;
            this.groupLarge.Text = "Large Dimensions";
            // 
            // textLargeWidth
            // 
            this.textLargeWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLargeWidth.Location = new System.Drawing.Point(4, 16);
            this.textLargeWidth.Name = "textLargeWidth";
            this.textLargeWidth.Size = new System.Drawing.Size(50, 20);
            this.textLargeWidth.TabIndex = 0;
            this.textLargeWidth.Text = "210";
            this.textLargeWidth.TextChanged += new System.EventHandler(this.textLargeWidth_TextChanged);
            // 
            // textLargeHeight
            // 
            this.textLargeHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLargeHeight.Location = new System.Drawing.Point(55, 16);
            this.textLargeHeight.Name = "textLargeHeight";
            this.textLargeHeight.Size = new System.Drawing.Size(50, 20);
            this.textLargeHeight.TabIndex = 0;
            this.textLargeHeight.Text = "330";
            this.textLargeHeight.TextChanged += new System.EventHandler(this.textLargeHeight_TextChanged);
            // 
            // groupSmall
            // 
            this.groupSmall.Controls.Add(this.textSmallHeight);
            this.groupSmall.Controls.Add(this.textSmallWidth);
            this.groupSmall.Location = new System.Drawing.Point(0, 87);
            this.groupSmall.Name = "groupSmall";
            this.groupSmall.Size = new System.Drawing.Size(107, 42);
            this.groupSmall.TabIndex = 6;
            this.groupSmall.TabStop = false;
            this.groupSmall.Text = "Small Dimensions";
            // 
            // textSmallHeight
            // 
            this.textSmallHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSmallHeight.Location = new System.Drawing.Point(55, 18);
            this.textSmallHeight.Name = "textSmallHeight";
            this.textSmallHeight.Size = new System.Drawing.Size(50, 20);
            this.textSmallHeight.TabIndex = 0;
            this.textSmallHeight.Text = "84";
            this.textSmallHeight.TextChanged += new System.EventHandler(this.textSmallHeight_TextChanged);
            // 
            // textSmallWidth
            // 
            this.textSmallWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSmallWidth.Location = new System.Drawing.Point(4, 18);
            this.textSmallWidth.Name = "textSmallWidth";
            this.textSmallWidth.Size = new System.Drawing.Size(50, 20);
            this.textSmallWidth.TabIndex = 0;
            this.textSmallWidth.Text = "54";
            this.textSmallWidth.TextChanged += new System.EventHandler(this.textSmallWidth_TextChanged);
            // 
            // checkForceRatio
            // 
            this.checkForceRatio.AutoSize = true;
            this.checkForceRatio.Checked = true;
            this.checkForceRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkForceRatio.Location = new System.Drawing.Point(12, 38);
            this.checkForceRatio.Name = "checkForceRatio";
            this.checkForceRatio.Size = new System.Drawing.Size(81, 17);
            this.checkForceRatio.TabIndex = 7;
            this.checkForceRatio.Text = "Force Ratio";
            this.checkForceRatio.UseVisualStyleBackColor = true;
            this.checkForceRatio.CheckedChanged += new System.EventHandler(this.checkForceRatio_CheckedChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select the folder you want to save portraits to:";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.SelectedPath = "%home%\\Pictures";
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // bttSelectFolder
            // 
            this.bttSelectFolder.Image = global::ImgNow.Properties.Resources.pictures4icon;
            this.bttSelectFolder.Location = new System.Drawing.Point(75, 10);
            this.bttSelectFolder.Name = "bttSelectFolder";
            this.bttSelectFolder.Size = new System.Drawing.Size(41, 25);
            this.bttSelectFolder.TabIndex = 8;
            this.bttSelectFolder.UseVisualStyleBackColor = true;
            this.bttSelectFolder.Click += new System.EventHandler(this.bttSelectFolder_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabCapture);
            this.tabControl1.Location = new System.Drawing.Point(12, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(115, 182);
            this.tabControl1.TabIndex = 9;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.checkBGEE);
            this.tabSettings.Controls.Add(this.groupLarge);
            this.tabSettings.Controls.Add(this.groupSmall);
            this.tabSettings.Controls.Add(this.groupMedium);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(107, 156);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // checkBGEE
            // 
            this.checkBGEE.AutoSize = true;
            this.checkBGEE.Checked = true;
            this.checkBGEE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBGEE.Location = new System.Drawing.Point(4, 131);
            this.checkBGEE.Name = "checkBGEE";
            this.checkBGEE.Size = new System.Drawing.Size(88, 17);
            this.checkBGEE.TabIndex = 7;
            this.checkBGEE.Text = "BG:EE Mode";
            this.checkBGEE.UseVisualStyleBackColor = true;
            this.checkBGEE.CheckedChanged += new System.EventHandler(this.checkBGEE_CheckedChanged);
            // 
            // groupMedium
            // 
            this.groupMedium.Controls.Add(this.textMediumHeight);
            this.groupMedium.Controls.Add(this.textMediumWidth);
            this.groupMedium.Location = new System.Drawing.Point(0, 45);
            this.groupMedium.Name = "groupMedium";
            this.groupMedium.Size = new System.Drawing.Size(107, 42);
            this.groupMedium.TabIndex = 6;
            this.groupMedium.TabStop = false;
            this.groupMedium.Text = "Med Dimensions";
            // 
            // textMediumHeight
            // 
            this.textMediumHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMediumHeight.Location = new System.Drawing.Point(55, 18);
            this.textMediumHeight.Name = "textMediumHeight";
            this.textMediumHeight.Size = new System.Drawing.Size(50, 20);
            this.textMediumHeight.TabIndex = 0;
            this.textMediumHeight.Text = "266";
            this.textMediumHeight.TextChanged += new System.EventHandler(this.textMediumHeight_TextChanged);
            // 
            // textMediumWidth
            // 
            this.textMediumWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMediumWidth.Location = new System.Drawing.Point(4, 18);
            this.textMediumWidth.Name = "textMediumWidth";
            this.textMediumWidth.Size = new System.Drawing.Size(50, 20);
            this.textMediumWidth.TabIndex = 0;
            this.textMediumWidth.Text = "169";
            this.textMediumWidth.TextChanged += new System.EventHandler(this.textMediumWidth_TextChanged);
            // 
            // tabCapture
            // 
            this.tabCapture.Controls.Add(this.bttCaptureSmall);
            this.tabCapture.Controls.Add(this.bttCaptureAll);
            this.tabCapture.Controls.Add(this.bttCaptureMedium);
            this.tabCapture.Controls.Add(this.bttCaptureLarge);
            this.tabCapture.Location = new System.Drawing.Point(4, 22);
            this.tabCapture.Name = "tabCapture";
            this.tabCapture.Padding = new System.Windows.Forms.Padding(3);
            this.tabCapture.Size = new System.Drawing.Size(107, 156);
            this.tabCapture.TabIndex = 0;
            this.tabCapture.Text = "Capture";
            this.tabCapture.UseVisualStyleBackColor = true;
            // 
            // bttCaptureAll
            // 
            this.bttCaptureAll.BackColor = System.Drawing.Color.Gainsboro;
            this.bttCaptureAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCaptureAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCaptureAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttCaptureAll.Location = new System.Drawing.Point(0, 120);
            this.bttCaptureAll.Name = "bttCaptureAll";
            this.bttCaptureAll.Size = new System.Drawing.Size(107, 32);
            this.bttCaptureAll.TabIndex = 2;
            this.bttCaptureAll.TabStop = false;
            this.bttCaptureAll.Text = "Capture All";
            this.bttCaptureAll.UseVisualStyleBackColor = false;
            this.bttCaptureAll.Click += new System.EventHandler(this.bttCaptureAll_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(137, 328);
            this.ControlBox = false;
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttSelectFolder);
            this.Controls.Add(this.checkForceRatio);
            this.Controls.Add(this.textName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ControlPanel";
            this.ShowInTaskbar = false;
            this.Text = "Portrait Grabber";
            this.TopMost = true;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_Click);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupLarge.ResumeLayout(false);
            this.groupLarge.PerformLayout();
            this.groupSmall.ResumeLayout(false);
            this.groupSmall.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.groupMedium.ResumeLayout(false);
            this.groupMedium.PerformLayout();
            this.tabCapture.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private System.Windows.Forms.Button bttCaptureLarge;
        private System.Windows.Forms.Button bttCaptureSmall;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.Button bttCaptureMedium;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.GroupBox groupLarge;
        private System.Windows.Forms.TextBox textLargeWidth;
        private System.Windows.Forms.TextBox textLargeHeight;
        private System.Windows.Forms.GroupBox groupSmall;
        private System.Windows.Forms.TextBox textSmallHeight;
        private System.Windows.Forms.TextBox textSmallWidth;
        private System.Windows.Forms.CheckBox checkForceRatio;
        private System.Windows.Forms.Button bttSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem aboutPortraitGrabberToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCapture;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.CheckBox checkBGEE;
        private System.Windows.Forms.GroupBox groupMedium;
        private System.Windows.Forms.TextBox textMediumHeight;
        private System.Windows.Forms.TextBox textMediumWidth;
        private System.Windows.Forms.Button bttCaptureAll;
    }
}