using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinPackr
{
  public class BinListSorterRandom
  {
    private static Random randomGenerator = new Random();
    private static Dictionary<Bin, int> randomBinding;

    public static void Sort(ref BinList binList, int panelWidth)
    {
      int binListCount = binList.Count;

      randomBinding = new Dictionary<Bin, int>(binListCount);
      foreach (Bin bin in binList)
      {
        randomBinding[bin] = randomGenerator.Next();
      }
      
      binList.Sort(CompareBins);

      int currentHeight = 0;
      int currentX = 0;
      int currentY = 0;

      foreach (Bin bin in binList)
      {
        if (currentX + bin.Rectangle.Width > panelWidth)
        {
          currentX = 0;
          currentY += currentHeight;
          currentHeight = 0;
        }

        if (bin.Rectangle.Height > currentHeight)
        {
          currentHeight = bin.Rectangle.Height;
        }

        bin.Rectangle.X = currentX;
        bin.Rectangle.Y = currentY;

        currentX += bin.Rectangle.Width;
      }
    }

    private static int CompareBins(Bin a, Bin b)
    {
      return randomBinding[a] - randomBinding[b];
    }
  }
}
