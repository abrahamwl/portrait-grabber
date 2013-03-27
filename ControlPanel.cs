using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;

namespace ImgNow
{

    public partial class ControlPanel : Form
    {
        public string portraitPath;
        public string fileName = "filname";
        public int portraitType = 1;
        public int lW = 210, lH = 330, sW = 54, sH = 84, mW = 169, mH = 266;
        public int sLW = 110, sLH = 170, sSW = 38, sSH = 60;
        public bool forceRatio = true;
        private Form m_InstanceRef = null;
        Form1 form1;

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
            this.Text = this.AssemblyTitle + " v" + this.AssemblyVersion;
            this.Resize += new EventHandler(ControlPanel_Resize);
            this.InstanceRef = this;
            form1 = new Form1(this);

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
            int temp;
            try
            {
                temp = Convert.ToInt16(textLargeWidth.Text);
            }
            catch (System.FormatException)
            {
                return;
            }
            lW = temp;
        }

        private void textLargeHeight_TextChanged(object sender, EventArgs e)
        {
            int temp;
            try
            {
                temp = Convert.ToInt16(textLargeHeight.Text);
            }
            catch (System.FormatException)
            {
                return;
            }
            lH = temp;
        }

        private void textSmallWidth_TextChanged(object sender, EventArgs e)
        {
            int temp;
            try
            {
                temp = Convert.ToInt16(textSmallWidth.Text);
            }
            catch (System.FormatException)
            {
                return;
            }
            sW = temp;
        }

        private void textSmallHeight_TextChanged(object sender, EventArgs e)
        {
            int temp;
            try
            {
                temp = Convert.ToInt16(textSmallHeight.Text);
            }
            catch (System.FormatException)
            {
                return;
            }
            sH = temp;
        }

        private void textMediumWidth_TextChanged(object sender, EventArgs e)
        {
            int temp;
            try
            {
                temp = Convert.ToInt16(textMediumWidth.Text);
            }
            catch (System.FormatException)
            {
                return;
            }
            mW = temp;
        }

        private void textMediumHeight_TextChanged(object sender, EventArgs e)
        {
            int temp;
            try
            {
                temp = Convert.ToInt16(textMediumHeight.Text);
            }
            catch (System.FormatException)
            {
                return;
            }
            mH = temp;
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

        private void bttCaptureMedium_Click(object sender, EventArgs e)
        {
            portraitType = 4;
            capturePortrait();
        }

        private void bttCaptureAll_Click(object sender, EventArgs e)
        {
            if (checkBGEE.Enabled)
            {
                portraitType = 7;
            }
            else
            {
                portraitType = 3;
            }
            capturePortrait();
        }

        private void capturePortrait()
        {
            this.Hide();
            form1.WindowState = FormWindowState.Maximized;
            form1.BringToFront();
            form1.TopMost = true;
            if (form1.CurrentBottomRight.X < 0)
            {
                form1.CurrentBottomRight = new Point(lW, lH);
            }
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

        private void checkBGEE_CheckedChanged(object sender, EventArgs e)
        {
            int temp;
            temp = lW;
            lW = sLW;
            sLW = temp;
            textLargeWidth.Text = lW.ToString();
            temp = lH;
            lH = sLH;
            sLH = temp;
            textLargeHeight.Text = lH.ToString();
            temp = sW;
            sW = sSW;
            sSW = temp;
            textSmallWidth.Text = sW.ToString();
            temp = sH;
            sH = sSH;
            sSH = temp;
            textSmallHeight.Text = sH.ToString();

            if (checkBGEE.CheckState == CheckState.Checked)
            {
                bttCaptureMedium.Enabled = true;
                groupMedium.Enabled = true;
                textMediumWidth.Enabled = true;
                textMediumHeight.Enabled = true;
            }
            else
            {
                bttCaptureMedium.Enabled = false;
                groupMedium.Enabled = false;
                textMediumWidth.Enabled = false;
                textMediumHeight.Enabled = false;
            }
        }
    }
}