using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BinPackr
{
  public class BinList : List<Bin>
  {
    private static Random randomGenerator = new Random();

    public void AddSerializedBins(string serializedBins)
    {
      // Takes input in form of "(X, Y, W, H), (X, Y, W, H)"

      Regex regex = new Regex("\\((.*?)\\)");
      MatchCollection binMatches = regex.Matches(serializedBins);

      foreach (Match binMatch in binMatches)
      {
        string serializedValues = binMatch.Groups[1].ToString();
        string[] stringValues = serializedValues.Split(',');

        if (stringValues.Length != 4)
        {
          continue;
        }

        int[] values = new int[4];
        bool success = true;

        for (int index = 0; index < 4; index++)
        {
          bool result = Int32.TryParse(stringValues[index], out values[index]);
          if (!result)
          {
            success = false;
            break;
          }
        }

        if (!success)
        {
          continue;
        }

        Bin bin = new Bin(values[0], values[1], values[2], values[3]);
        this.Add(bin);
      }
    }

    public void GetBoundingBin(out int width, out int height)
    {
      width = 0;
      height = 0;

      foreach (Bin bin in this)
      {
        int binRight = bin.Rectangle.X + bin.Rectangle.Width;
        int binBottom = bin.Rectangle.Y + bin.Rectangle.Height;

        if (binRight > width)
        {
          width = binRight;
        }

        if (binBottom > height)
        {
          height = binBottom;
        }
      }
    }

    public void Randomize(int count, int sizeMin, int sizeMax, int panelWidth)
    {
      if (count <= 0)
      {
        return;
      }

      sizeMin = (sizeMin < panelWidth ? sizeMin : panelWidth);
      sizeMax = (sizeMax < panelWidth ? sizeMax : panelWidth);

      int currentHeight = 0;
      int currentX = 0;
      int currentY = 0;

      for (int index = 0; index < count; index++)
      {
        int width = randomGenerator.Next(sizeMin, sizeMax);
        int height = randomGenerator.Next(sizeMin, sizeMax);

        if (currentX + width > panelWidth)
        {
          currentX = 0;
          currentY += currentHeight;
          currentHeight = 0;
        }

        if (height > currentHeight)
        {
          currentHeight = height;
        }

        Bin bin = new Bin(currentX, currentY, width, height);
        this.Add(bin);

        currentX += width;
      }
    }
  }
}
