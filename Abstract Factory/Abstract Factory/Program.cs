using System;
using System.Drawing;
using System.Windows.Forms;

public interface IShape
{
    void Draw(Graphics g, int x, int y);
}

public class RedCircle : IShape
{
    public void Draw(Graphics g, int x, int y)
    {
        using (Brush brush = new SolidBrush(Color.Red))
        {
            g.FillEllipse(brush, x, y, 50, 50);
        }
    }
}

public class BlueCircle : IShape
{
    public void Draw(Graphics g, int x, int y)
    {
        using (Brush brush = new SolidBrush(Color.Blue))
        {
            g.FillEllipse(brush, x, y, 50, 50);
        }
    }
}

public class YellowCircle : IShape
{
    public void Draw(Graphics g, int x, int y)
    {
        using (Brush brush = new SolidBrush(Color.Yellow))
        {
            g.FillEllipse(brush, x, y, 50, 50);
        }
    }
}

public class RedSquare : IShape
{
    public void Draw(Graphics g, int x, int y)
    {
        using (Brush brush = new SolidBrush(Color.Red))
        {
            g.FillRectangle(brush, x, y, 50, 50);
        }
    }
}

public class BlueSquare : IShape
{
    public void Draw(Graphics g, int x, int y)
    {
        using (Brush brush = new SolidBrush(Color.Blue))
        {
            g.FillRectangle(brush, x, y, 50, 50);
        }
    }
}

public class YellowSquare : IShape
{
    public void Draw(Graphics g, int x, int y)
    {
        using (Brush brush = new SolidBrush(Color.Yellow))
        {
            g.FillRectangle(brush, x, y, 50, 50);
        }
    }
}


public class RedTriangle : IShape
{
    public void Draw(Graphics g, int x, int y)
    {
        using (Brush brush = new SolidBrush(Color.Red))
        {
            Point[] points = { new Point(x + 25, y), new Point(x, y + 50), new Point(x + 50, y + 50) };
            g.FillPolygon(brush, points);
        }
    }
}

public class BlueTriangle : IShape
{
    public void Draw(Graphics g, int x, int y)
    {
        using (Brush brush = new SolidBrush(Color.Blue))
        {
            Point[] points = { new Point(x + 25, y), new Point(x, y + 50), new Point(x + 50, y + 50) };
            g.FillPolygon(brush, points);
        }
    }
}

public class YellowTriangle : IShape
{
    public void Draw(Graphics g, int x, int y)
    {
        using (Brush brush = new SolidBrush(Color.Yellow))
        {
            Point[] points = { new Point(x + 25, y), new Point(x, y + 50), new Point(x + 50, y + 50) };
            g.FillPolygon(brush, points);
        }
    }
}

public interface IShapeFactory
{
    IShape CreateCircle();
    IShape CreateSquare();
    IShape CreateTriangle();
}

public class RedFactory : IShapeFactory
{
    public IShape CreateCircle() => new RedCircle();
    public IShape CreateSquare() => new RedSquare();
    public IShape CreateTriangle() => new RedTriangle();
}

public class BlueFactory : IShapeFactory
{
    public IShape CreateCircle() => new BlueCircle();
    public IShape CreateSquare() => new BlueSquare();
    public IShape CreateTriangle() => new BlueTriangle();
}

public class YellowFactory : IShapeFactory
{
    public IShape CreateCircle() => new YellowCircle();
    public IShape CreateSquare() => new YellowSquare();
    public IShape CreateTriangle() => new YellowTriangle();
}
