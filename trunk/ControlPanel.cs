using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;

namespace ImgNow
{

    public partial class ControlPanel : Form
    {
        public string portraitPath;
        public string fileName = "filname";
        public int portraitType = 1;
        public int lW = 110, lH = 170, sW = 38, sH = 60;
        public bool forceRatio = true;
        private Form m_InstanceRef = null;
        Form1 form1 = new Form1();       
        
        public Form InstanceRef
        {
            get
            {
                return m_InstanceRef;
            }
            set
            {
                m_InstanceRef = value;
            }
        }

        public ControlPanel()
        {
            InitializeComponent();
            this.Resize += new EventHandler(ControlPanel_Resize);
            this.InstanceRef = this;
            form1.InstanceRef = this;

            selectFolder();
        }

        protected override void OnLoad(System.EventArgs e)
        {
            restore();
        }

        private void ControlPanel_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
            }
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restore();
        }

        public void restore()
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
            Focus();
            textName.SelectAll();
            textName.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon2.Visible = false;
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            restore();
        }

        private void bttSelectFolder_Click(object sender, EventArgs e)
        {
            selectFolder();
        }

        private void selectFolder()
        {
            folderBrowserDialog1.ShowDialog();
            portraitPath = folderBrowserDialog1.SelectedPath;
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            fileName = textName.Text;
        }

        private void textLargeWidth_TextChanged(object sender, EventArgs e)
        {
            lW = Convert.ToInt16(textLargeWidth.Text);
        }

        private void textLargeHeight_TextChanged(object sender, EventArgs e)
        {
            lH = Convert.ToInt16(textLargeHeight.Text);
        }

        private void textSmallWidth_TextChanged(object sender, EventArgs e)
        {
            sW = Convert.ToInt16(textSmallWidth.Text);
        }

        private void textSmallHeight_TextChanged(object sender, EventArgs e)
        {
            sH = Convert.ToInt16(textSmallHeight.Text);
        }

        private void bttCaptureLarge_Click(object sender, EventArgs e)
        {
            portraitType = 1;
            capturePortrait();
        }
        private void bttCaptureSmall_Click(object sender, EventArgs e)
        {
            portraitType = 2;
            capturePortrait();
        }

        private void bttCaptureBoth_Click(object sender, EventArgs e)
        {
            portraitType = 3;
            capturePortrait();
        }

        private void capturePortrait()
        {
            this.Hide();
            form1.WindowState = FormWindowState.Maximized;
            form1.BringToFront();
            form1.TopMost = true;
            form1.Show();
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            notifyIcon2.Visible = false;
            Application.Exit();
        }

        private void checkForceRatio_CheckedChanged(object sender, EventArgs e)
        {
            forceRatio = checkForceRatio.Checked;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void aboutPortraitGrabberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.BringToFront();
            aboutBox.TopMost = true;
            aboutBox.Show();
        }

        private void ControlPanel_Click(object sender, MouseEventArgs e)
        {
            textName.SelectAll();
            textName.Focus();
        }
    }
}