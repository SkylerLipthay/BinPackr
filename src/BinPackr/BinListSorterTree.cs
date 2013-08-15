using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinPackr
{
  public class BinListSorterTree
  {
    private class Node
    {
      private Node left;
      private Node right;
      private bool filled;
      public Rectangle Rectangle { get; set; }

      public Node()
      {
        left = null;
        right = null;
        filled = false;
        this.Rectangle = null;
      }

      public Node Insert(Rectangle rectangle)
      {
        // if this is not a leaf
        if (this.left != null)
        {
          Node nodeLeft = this.left.Insert(rectangle);
          if (nodeLeft != null)
          {
            return nodeLeft;
          }

          return this.right.Insert(rectangle);
        }

        // already a rectangle in this node
        if (this.filled)
        {
          return null;
        }

        // rectangle does not fit in bounds
        if (!rectangle.FitsIn(this.Rectangle))
        {
          return null;
        }

        // perfectly snug fit
        if (rectangle.Compare(this.Rectangle) == 0)
        {
          this.filled = true;
          return this;
        }

        // split this node into two children
        this.left = new Node();
        this.right = new Node();

        int diffWidth = this.Rectangle.Width - rectangle.Width;
        int diffHeight = this.Rectangle.Height - rectangle.Height;

        // either split horizontally or vertically
        if (diffWidth > diffHeight)
        {
          this.left.Rectangle = new Rectangle(this.Rectangle.X, this.Rectangle.Y, rectangle.Width, this.Rectangle.Height);
          this.right.Rectangle = new Rectangle(this.Rectangle.X + rectangle.Width, this.Rectangle.Y, this.Rectangle.Width - rectangle.Width, this.Rectangle.Height);
        }
        else
        {
          this.left.Rectangle = new Rectangle(this.Rectangle.X, this.Rectangle.Y, this.Rectangle.Width, rectangle.Height);
          this.right.Rectangle = new Rectangle(this.Rectangle.X, this.Rectangle.Y + rectangle.Height, this.Rectangle.Width, this.Rectangle.Height - rectangle.Height);
        }

        // insert into the left child node as a leaf
        return this.left.Insert(rectangle);
      }
    }

    public static void Sort(ref BinList binList, Rectangle panelRectangle, out int unresolved)
    {
      Node startNode = new Node();
      startNode.Rectangle = panelRectangle;

      unresolved = 0;

      int currentX = 0;
      int currentY = panelRectangle.Height;
      int currentHeight = 0;

      foreach (Bin bin in binList)
      {
        Node node = startNode.Insert(bin.Rectangle);
        if (node == null)
        {
          // since we cannot place the rectangle in a sorted position, place it
          // below the panel's view loosely fitted with the other unresolved
          // rectangles

          if (bin.Rectangle.Width + currentX > panelRectangle.Width)
          {
            currentX = 0;
            currentY += currentHeight;
            currentHeight = 0;
          }

          bin.Rectangle.X = currentX;
          currentX += bin.Rectangle.Width;
          bin.Rectangle.Y = currentY;

          if (bin.Rectangle.Height > currentHeight)
          {
            currentHeight = bin.Rectangle.Height;
          }

          unresolved++;
          continue;
        }

        bin.Rectangle = node.Rectangle;
      }
    }
  }
}
