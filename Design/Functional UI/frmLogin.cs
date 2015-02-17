using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Messenger
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static void ThreadProc()
        {
            Application.Run(new frmMain());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Check the login details with another client
            if (true)
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
            }
            this.Close();
        }

        int intStageNum;
        int red;
        int green;
        int blue;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            red = 110;
            green = 110;
            blue = 175;

            pnlContainer.BackColor = Color.Transparent;
            lblLogin.ForeColor = Color.White;

            renderRound();

            lblLogin_MouseLeave(null, null);
        }

#region Rounded Image
        static public GraphicsPath createRoundRect(int x, int y, int width, int height, int radius)
        {
            GraphicsPath gp = new GraphicsPath();

            if (radius == 0)
                //gp.AddRectangle(new Rectangle(x, y, width, height));
                gp.AddEllipse(new Rectangle(0, 0, width - 1, height - 1));
            else
            {
                gp.AddLine(x + radius, y, x + width - radius, y);
                gp.AddArc(x + width - radius, y, radius, radius, 270, 90);
                gp.AddLine(x + width, y + radius, x + width, y + height - radius);
                gp.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90);
                gp.AddLine(x + width - radius, y + height, x + radius, y + height);
                gp.AddArc(x, y + height - radius, radius, radius, 90, 90);
                gp.AddLine(x, y + height - radius, x, y + radius);
                gp.AddArc(x, y, radius, radius, 180, 90);
                gp.CloseFigure();
            }
            return gp;
        }

        public static Brush createFluffyBrush(GraphicsPath gp,float[] blendPositions,float[] blendFactors)
        {
            PathGradientBrush pgb = new PathGradientBrush(gp);
            Blend blend = new Blend();
            blend.Positions = blendPositions;
            blend.Factors = blendFactors;
            pgb.Blend = blend;
            pgb.CenterColor = Color.White;
            pgb.SurroundColors = new Color[] { Color.Black };
            return pgb;
        }

        public enum ChannelARGB
        {
            Blue = 0,
            Green = 1,
            Red = 2,
            Alpha = 3
        }

        public static void transferOneARGBChannelFromOneBitmapToAnother(Bitmap source, Bitmap dest, ChannelARGB sourceChannel, ChannelARGB destChannel)
        {
            if (source.Size != dest.Size)
                throw new ArgumentException();
            Rectangle r = new Rectangle(Point.Empty, source.Size);
            BitmapData bdSrc = source.LockBits(r, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData bdDst = dest.LockBits(r, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            unsafe
            {
                byte* bpSrc = (byte*)bdSrc.Scan0.ToPointer();
                byte* bpDst = (byte*)bdDst.Scan0.ToPointer();
                bpSrc += (int)sourceChannel;
                bpDst += (int)destChannel;
                for (int i = r.Height * r.Width; i > 0; i--)
                {
                    *bpDst = *bpSrc;
                    bpSrc += 4;
                    bpDst += 4;
                }
            }
            source.UnlockBits(bdSrc);
            dest.UnlockBits(bdDst);
        }

        public Image roundImage(Image img, int radius)
        {
            Bitmap bmpFluffy = new Bitmap(img);
            Rectangle r = new Rectangle(Point.Empty, bmpFluffy.Size);

            using (Bitmap bmpMask = new Bitmap(r.Width, r.Height))
            using (Graphics g = Graphics.FromImage(bmpMask))
            using (GraphicsPath path = createRoundRect(r.X, r.Y, r.Width, r.Height, radius)) //Math.Min(r.Width, r.Height) / 5
            using (Brush brush = createFluffyBrush(path, new float[] { float.Parse(textBox1.Text), float.Parse(textBox2.Text), float.Parse(textBox3.Text) }, new float[] { float.Parse(textBox4.Text), float.Parse(textBox5.Text), float.Parse(textBox6.Text) }))
            {
                g.FillRectangle(Brushes.Black, r);
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.FillPath(brush, path);
                transferOneARGBChannelFromOneBitmapToAnother(bmpMask, bmpFluffy, ChannelARGB.Blue, ChannelARGB.Alpha);
            }
            return bmpFluffy;
        }

#endregion

        public void renderRound()
        {
            Image btnLog = new Bitmap(110, 35, PixelFormat.Format1bppIndexed);
            ColorPalette pal = btnLog.Palette;
            pal.Entries[0] = Color.FromArgb(80, 150, 255);
            btnLog.Palette = pal;
            pboxButton.BackgroundImage = btnLog;

            Image bgMain = new Bitmap(300, 320); //, PixelFormat.Format1bppIndexed
            Rectangle r = new Rectangle(Point.Empty, bgMain.Size);

            Graphics g = Graphics.FromImage(bgMain);
            Brush linearGradientBrush = new LinearGradientBrush(new Rectangle(r.X, r.Y, r.Width, r.Height), Color.FromArgb(240, 240, 240), Color.White, 270);
            g.FillRectangle(linearGradientBrush, new Rectangle(r.X, r.Y, r.Width, r.Height));
            linearGradientBrush.Dispose();
            
            //ColorPalette pal2 = bgMain.Palette;
            //pal2.Entries[0] = Color.FromArgb(240, 240, 240);
            //bgMain.Palette = pal2;
            pnlContainer.BackgroundImage = bgMain;

            Image bgUser = new Bitmap(129, 129, PixelFormat.Format1bppIndexed);
            ColorPalette pal3 = bgUser.Palette;
            pal3.Entries[0] = Color.FromArgb(255, 255, 255);
            bgUser.Palette = pal3;
            pictureBox1.BackgroundImage = bgUser;

            try
            {
                pnlUser.BackgroundImage = roundImage(pnlUser.BackgroundImage, 0);
                pictureBox1.BackgroundImage = roundImage(pictureBox1.BackgroundImage, 0);
                pboxButton.BackgroundImage = roundImage(pboxButton.BackgroundImage, 8);
                pnlContainer.BackgroundImage = roundImage(pnlContainer.BackgroundImage, 24);
                Text = "Success";
            }
            catch
            {
                Text = "Error";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //renderRound();
        }

        private void lblLogin_MouseEnter(object sender, EventArgs e)
        {
            Image btnLog = new Bitmap(110, 35, PixelFormat.Format1bppIndexed);
            ColorPalette pal = btnLog.Palette;
            pal.Entries[0] = Color.FromArgb(50, 120, 230);
            btnLog.Palette = pal;
            pboxButton.BackgroundImage = btnLog;

            pboxButton.BackgroundImage = roundImage(pboxButton.BackgroundImage, 8);
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            Image btnLog = new Bitmap(110, 35, PixelFormat.Format1bppIndexed);
            ColorPalette pal = btnLog.Palette;
            pal.Entries[0] = Color.FromArgb(80, 150, 255);
            btnLog.Palette = pal;
            pboxButton.BackgroundImage = btnLog;

            pboxButton.BackgroundImage = roundImage(pboxButton.BackgroundImage, 8);
        }

        private void lblLogin_MouseDown(object sender, MouseEventArgs e)
        {
            Image btnLog = new Bitmap(110, 35, PixelFormat.Format1bppIndexed);
            ColorPalette pal = btnLog.Palette;
            pal.Entries[0] = Color.FromArgb(40, 110, 220);
            btnLog.Palette = pal;
            pboxButton.BackgroundImage = btnLog;

            pboxButton.BackgroundImage = roundImage(pboxButton.BackgroundImage, 8);
        }

        private void lblLogin_MouseUp(object sender, MouseEventArgs e)
        {
            Image btnLog = new Bitmap(110, 35, PixelFormat.Format1bppIndexed);
            ColorPalette pal = btnLog.Palette;
            pal.Entries[0] = Color.FromArgb(50, 120, 230);
            btnLog.Palette = pal;
            pboxButton.BackgroundImage = btnLog;

            pboxButton.BackgroundImage = roundImage(pboxButton.BackgroundImage, 8);

            if (e.Location.X >= 0 && e.Location.X <= 109 && e.Location.Y >= 0 && e.Location.Y <= 35)
            {
                if (true)
                {
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                    t.Start();
                    this.Close();
                }
                else
                {
                    //Incorrect login
                }
            }
            //Text = e.Location.X + ":" + e.Location.Y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (intStageNum)
            {
                case 0:
                    //To change from Red to Yellow, just Green needs to go from 0 to 255 so we do this
                    green = green + 1;
                    if (green == 255)
                        intStageNum = intStageNum + 1;
                    break;
                case 1:
                    //we are now at (255, 255, 0) yellow, to go to green we need to reduce red to 0
                    red = red - 1;
                    if (red == 0)
                        intStageNum = intStageNum + 1;
                    break;
                case 2:
                    //now at (0, 255, 0)... to go to Cyan we need to go B to 255
                    blue = blue + 1;
                    if (blue == 255)
                        intStageNum = intStageNum + 1;
                    break;
                case 3:
                    //now at (0, 255, 255)... for blue reduce green to 0
                    green = green - 1;
                    if (green == 0)
                        intStageNum = intStageNum + 1;
                    break;
                case 4:
                    //now at (0, 0, 255)... for magenta increase red to 255
                    red = red + 1;
                    if (red == 255)
                        intStageNum = intStageNum + 1;
                    break;
                case 5:
                    //now at (255, 0, 255)... and back to red reduce B to 0
                    blue = blue - 1;
                    if (blue == 0)
                        intStageNum = intStageNum + 1;
                    break;
                default:
                    intStageNum = 0;
                    break;
            }
            this.BackColor = Color.FromArgb(red, green, blue);
            Text = "RGB: " + red + ", " + green + ", " + blue;
            // set form background
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) {
                timer1.Enabled = false;
                btnHue.Text = "Execute Phase Shift";
            }
            else
            {
                timer1.Enabled = true;
                btnHue.Text = "Release Phase Shift";
            }
        }

        Point mousePos;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                pictureBox1.Location = new Point(pictureBox1.Left + dx, pictureBox1.Top + dy);
            }
        }

    }
}
