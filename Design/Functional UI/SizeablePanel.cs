using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class SizeablePanel : Panel
{
    private int cGripRange = 10;
    private bool mDragging;
    private Point mDragPos;

    [Description("Range of the grip to allow resizing of the control"), Category("Data"), DefaultValue("10")]
    public int GripRange
    {
        get { return cGripRange; }
        set { cGripRange = value; }
    }

    public SizeablePanel()
    {
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        this.SetStyle(ControlStyles.ResizeRedraw, true);
        this.BackColor = Color.White;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        //ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor,
        //  new Rectangle(this.ClientSize.Width - cGripSize, this.ClientSize.Height - cGripSize, cGripSize, cGripSize));
        base.OnPaint(e);
    }

    private bool IsResizing(Point pos)
    {
        return pos.X >= this.ClientSize.Width - cGripRange;
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        mDragging = IsResizing(e.Location);
        mDragPos = e.Location;
        base.OnMouseDown(e);
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        mDragging = false;
        base.OnMouseUp(e);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        if (mDragging)
        {
            if (e.X >= 10) this.Size = new Size(e.X, this.Height);
            else this.Size = new Size(10, this.Height);
        }
        else if (IsResizing(e.Location)) this.Cursor = Cursors.SizeWE;
        else this.Cursor = Cursors.Default;
        base.OnMouseMove(e);
    }
}