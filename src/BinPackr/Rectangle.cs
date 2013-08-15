using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinPackr
{
  public class Rectangle
  {
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int x, int y, int width, int height)
    {
      this.X = x;
      this.Y = y;
      this.Width = width;
      this.Height = height;
    }

    public bool FitsIn(Rectangle outer)
    {
      return (outer.Width >= this.Width && outer.Height >= this.Height);
    }

    public int Compare(Rectangle other)
    {
      if (this.Width == other.Width && this.Height == other.Height)
      {
        return 0;
      }

      int areaThis = this.Width * this.Height;
      int areaOther = other.Width * other.Height;
      int difference = areaThis - areaOther;
      if (difference >= 0)
      {
        return 1;
      }
      return -1;
    }
  }
}
