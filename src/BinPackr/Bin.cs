using System;
using System.Drawing;
using System.Reflection;

namespace BinPackr
{
  public class Bin
  {
    private Rectangle rectangle;
    private Brush brush;

    private const int COLOR_ELEMENT_MIN = 0x20;
    private const int COLOR_ELEMENT_MAX = 0xD0;

    private static Random randomGenerator = new Random();

    public Rectangle Rectangle
    {
      get
      {
        return rectangle;
      }

      set
      {
        rectangle = value;
      }
    }

    public System.Drawing.Rectangle DrawingRectangle
    {
      get
      {
        return new System.Drawing.Rectangle(this.Rectangle.X, this.Rectangle.Y, this.Rectangle.Width, this.Rectangle.Height);
      }
    }

    public Brush Brush
    {
      get
      {
        return brush;
      }

      set
      {
        brush = value;
      }
    }

    public Bin()
    {
      this.Rectangle = new Rectangle(0, 0, 0, 0);
      this.Brush = RandomBrush();
    }

    public Bin(int x, int y, int width, int height)
    {
      this.Rectangle = new Rectangle(x, y, width, height);
      this.Brush = RandomBrush();
    }

    private static Brush RandomBrush()
    {
      int red = randomGenerator.Next(COLOR_ELEMENT_MIN, COLOR_ELEMENT_MAX);
      int green = randomGenerator.Next(COLOR_ELEMENT_MIN, COLOR_ELEMENT_MAX);
      int blue = randomGenerator.Next(COLOR_ELEMENT_MIN, COLOR_ELEMENT_MAX);

      return new SolidBrush(Color.FromArgb(red, green, blue));
    }
  }
}
