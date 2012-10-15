using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Net;

namespace ImgNow
    {

    public partial class Form1 : Form
    {
        #region:::::::::::::::::::::::::::::::::::::::::::Form level declarations:::::::::::::::::::::::::::::::::::::::::::
        public bool LeftButtonDown = false;

        public Point ClickPoint = new Point();
        public Point CurrentTopLeft = new Point();
        public Point CurrentBottomRight = new Point();
        int relativeX = 0, relativeY = 0;

        Graphics g;
        Pen MyPen = new Pen(Color.Red, 1);
        Pen EraserPen = new Pen(Color.WhiteSmoke);
        SolidBrush eraseBrush = new SolidBrush(Color.WhiteSmoke);

        bool moveWithMouse = false;

        private ControlPanel m_InstanceRef = null;
        public ControlPanel InstanceRef
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

        #endregion

        #region:::::::::::::::::::::::::::::::::::::::::::Mouse Event Handlers & Drawing Initialization:::::::::::::::::::::::::::::::::::::::::::
        public Form1()
        {

            InitializeComponent();
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);
            this.MouseDown += new MouseEventHandler(mouse_Click);
            this.MouseUp += new MouseEventHandler(mouse_Up);
            this.MouseMove += new MouseEventHandler(mouse_Move);
            g = this.CreateGraphics();
        }

        #endregion

        #region:::::::::::::::::::::::::::::::::::::::::::Exit Button:::::::::::::::::::::::::::::::::::::::::::
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region:::::::::::::::::::::::::::::::::::::::::::Mouse Buttons:::::::::::::::::::::::::::::::::::::::::::
        private void mouse_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                moveWithMouse = moveWithMouse ^ true;
                if (moveWithMouse)
                {
                    relativeX = Cursor.Position.X - CurrentBottomRight.X;
                    relativeY = Cursor.Position.Y - CurrentBottomRight.Y;
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                g.Clear(Color.WhiteSmoke);
                LeftButtonDown = true;
                ClickPoint = new Point(System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y);
                CurrentTopLeft.X = ClickPoint.X - InstanceRef.lW;
                CurrentTopLeft.Y = ClickPoint.Y - InstanceRef.lH;
                CurrentBottomRight = ClickPoint;
                ClickPoint = CurrentTopLeft;
                moveWithMouse = false;

                drawRectangle();
            }
        }

        public Boolean done = false;

        private void mouse_Up(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            LeftButtonDown = false;
            if (!System.IO.Directory.Exists(InstanceRef.portraitPath))
            {
                System.IO.Directory.CreateDirectory(InstanceRef.portraitPath);
            }

            SaveScreen();

            this.Hide();
            InstanceRef.restore();
            string notifyText = "Image saved as";
            if ((InstanceRef.portraitType & 1) == 1)
            {
                notifyText += " " + InstanceRef.fileName + "L.bmp";
            }
            if ((InstanceRef.portraitType & 2) == 2)
            {
                notifyText += " " + InstanceRef.fileName + "S.bmp";
            }

            InstanceRef.notifyIcon2.BalloonTipText = notifyText;
            InstanceRef.notifyIcon2.ShowBalloonTip(10);
        }
        #endregion

        #region:::::::::::::::::::::::::::::::::::::::::::Drawing the rectangular selection window:::::::::::::::::::::::::::::::::::::::::::
        private void mouse_Move(object sender, MouseEventArgs e)
        {

            //Resize (actually delete then re-draw) the rectangle if the left mouse button is held down
            if (LeftButtonDown)
            {

                //Erase the previous rectangle
                g.DrawRectangle(EraserPen, CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X - CurrentTopLeft.X, CurrentBottomRight.Y - CurrentTopLeft.Y);
                g.FillRectangle(eraseBrush, CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X - CurrentTopLeft.X, CurrentBottomRight.Y - CurrentTopLeft.Y);

                Point CursorPos = Cursor.Position;

                if (moveWithMouse)
                {
                    int difX = CursorPos.X - relativeX - CurrentBottomRight.X;
                    int difY = CursorPos.Y - relativeY - CurrentBottomRight.Y;
                    /*if (CursorPos.X < ClickPoint.X)
                    {
                        difX = CursorPos.X - CurrentTopLeft.X;
                    }
                    else
                    {
                        difX = CursorPos.X - CurrentBottomRight.X;
                    }
                    if (CursorPos.Y < ClickPoint.Y)
                    {
                        difY = CursorPos.Y - CurrentTopLeft.Y;
                    }
                    else
                    {
                        difY = CursorPos.Y - CurrentBottomRight.Y;
                    }*/
                    CurrentTopLeft.X = Math.Max(0, CurrentTopLeft.X + difX);
                    CurrentTopLeft.Y = Math.Max(0, CurrentTopLeft.Y + difY);
                    CurrentBottomRight.X = Math.Min(this.Width, CurrentBottomRight.X + difX);
                    CurrentBottomRight.Y = Math.Min(this.Height, CurrentBottomRight.Y + difY);
                    ClickPoint.X = Math.Min(this.Width, Math.Max(0, ClickPoint.X + difX));
                    ClickPoint.Y = Math.Min(this.Height, Math.Max(0, ClickPoint.Y + difY));
                    relativeX = CursorPos.X - CurrentBottomRight.X;
                    relativeY = CursorPos.Y - CurrentBottomRight.Y;
                }
                else
                {
                    if (InstanceRef.forceRatio)
                    {
                        double x = (double)((CursorPos.Y - ClickPoint.Y) * InstanceRef.lW) / (double)InstanceRef.lH;
                        Math.Round(x);
                        x = ClickPoint.X + x;
                        CursorPos.X = Math.Min(Math.Max((int)x, 0), this.Width);
                    }
                    //Calculate X Coordinates
                    if (CursorPos.X < ClickPoint.X)
                    {
                        CurrentTopLeft.X = CursorPos.X;
                        CurrentBottomRight.X = ClickPoint.X;
                    }
                    else
                    {
                        CurrentTopLeft.X = ClickPoint.X;
                        CurrentBottomRight.X = CursorPos.X;
                    }

                    //Calculate Y Coordinates
                    if (CursorPos.Y < ClickPoint.Y)
                    {
                        CurrentTopLeft.Y = CursorPos.Y;
                        CurrentBottomRight.Y = ClickPoint.Y;
                    }
                    else
                    {
                        CurrentTopLeft.Y = ClickPoint.Y;
                        CurrentBottomRight.Y = CursorPos.Y;
                    }
                }
            }

            drawRectangle();
        }

        private void drawRectangle()
        {
            //Draw a new rectangle
            SolidBrush blueBrush = new SolidBrush(Color.Red);
            Rectangle rec = new Rectangle(CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X - CurrentTopLeft.X, CurrentBottomRight.Y - CurrentTopLeft.Y);
            g.DrawRectangle(MyPen, rec);
            g.FillRectangle(blueBrush, rec);

            labelDimensions.Text = "Origin: " + rec.X + ", " + rec.Y + "\nDim: " + rec.Width + ", " + rec.Height;

        }
        #endregion

        #region:::::::::::::::::::::::::::::::::::::::::::SaveScreen:::::::::::::::::::::::::::::::::::::::::::
        private void SaveScreen()
        {
            //Point StartPoint = new Point(CurrentTopLeft.X, CurrentTopLeft.Y);
            Rectangle bounds = new Rectangle(CurrentTopLeft.X, CurrentTopLeft.Y, CurrentBottomRight.X - CurrentTopLeft.X, CurrentBottomRight.Y - CurrentTopLeft.Y);
            if ((InstanceRef.portraitType & 1) == 1)
            {
                ScreenShot.CaptureImage(CurrentBottomRight.X >= this.Width, CurrentBottomRight.Y >= this.Height, bounds, InstanceRef.portraitPath + "\\" + InstanceRef.fileName + "L.bmp", InstanceRef.lW, InstanceRef.lH);
            }
            if ((InstanceRef.portraitType & 2) == 2)
            {
                ScreenShot.CaptureImage(CurrentBottomRight.X >= this.Width, CurrentBottomRight.Y >= this.Height, bounds, InstanceRef.portraitPath + "\\" + InstanceRef.fileName + "S.bmp", InstanceRef.sW, InstanceRef.sH);
            }
        }
        #endregion
    }
}