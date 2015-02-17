﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class RoundPictureBox : PictureBox
{
    public RoundPictureBox()
    {
        this.BackColor = Color.DarkGray;
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        //Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using (var gp = new GraphicsPath())
        {
            gp.AddEllipse(new Rectangle(0, 0, this.Width-1, this.Height-1));
            this.Region = new Region(gp);
        }
    }
}