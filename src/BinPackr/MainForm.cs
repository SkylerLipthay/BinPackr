using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BinPackr
{
  public partial class MainForm : Form
  {
    private BinList binList;
    private bool logVisible;

    private const int WINDOW_HEIGHT_LOG_HIDDEN = 518;
    private const int WINDOW_HEIGHT_LOG_SHOWN = 662;
    private const int PANEL_SIZE_MAX = 100000;
    private const int GENERATION_COUNT_MAX = 10000;
    private enum SizeSelection
    {
      SIZE_SELECT_SMALL = 0,
      SIZE_SELECT_MEDIUM,
      SIZE_SELECT_LARGE,
      SizeSelectionCount
    }
    private static readonly int[] SIZE_MIN = { 5, 5, 5 };
    private static readonly int[] SIZE_MAX = { 35, 70, 105 };

    public MainForm(ref BinList newBinList)
    {
      InitializeComponent();

      this.binList = newBinList;
      this.sizeSelect.SelectedIndex = (int)SizeSelection.SIZE_SELECT_MEDIUM;

      SetLogVisible(false);

      this.log.DataSource = Log.Instance;
      Log.Instance.ListChanged += LogListChanged;
    }

    public void LogListChanged(object sender, EventArgs arguments)
    {
      this.log.SelectedIndex = this.log.Items.Count - 1;
    }

    public void RefreshPanel()
    {
      this.panel.Invalidate();
    }

    private void SetLogVisible(bool visible)
    {
      this.Height = (visible ? WINDOW_HEIGHT_LOG_SHOWN : WINDOW_HEIGHT_LOG_HIDDEN);
      this.groupBoxLog.Visible = visible;
      this.buttonShowHideDebug.Text = (visible ? "Hide Log" : "Show Log");
      this.logVisible = visible;
    }

    private void PanelPaint(object sender, PaintEventArgs arguments)
    {
      Graphics graphics = arguments.Graphics;
      foreach (Bin bin in binList)
      {
        graphics.FillRectangle(bin.Brush, bin.DrawingRectangle);
      }
    }

    private void SetPanelSizeClick(object sender, EventArgs arguments)
    {
      int width;
      int height;

      bool result = Int32.TryParse(panelWidthInput.Text, out width);
      if (!result)
      {
        width = 0;
      }

      result = Int32.TryParse(panelHeightInput.Text, out height);
      if (!result)
      {
        height = 0;
      }

      if (width < 0)
      {
        width = 0;
      }
      else if (width > PANEL_SIZE_MAX)
      {
        width = PANEL_SIZE_MAX;
      }

      if (height < 0)
      {
        height = 0;
      }
      else if (height > PANEL_SIZE_MAX)
      {
        height = PANEL_SIZE_MAX;
      }

      this.panelWidthInput.Text = Convert.ToString(width);
      this.panelHeightInput.Text = Convert.ToString(height);

      this.panel.Width = width;
      this.panel.Height = height;

      Log.Instance.AddLine("Panel size set to " + width + "x" + height + " in pixels");
    }

    private void PopulateClick(object sender, EventArgs arguments)
    {
      int count = 0;
      bool result = Int32.TryParse(this.countInput.Text, out count);

      if (result)
      {
        if (count < 0)
        {
          count = 0;
        }
        else if (count > GENERATION_COUNT_MAX)
        {
          count = GENERATION_COUNT_MAX;
        }
      }

      this.countInput.Text = Convert.ToString(count);

      int sizeMin = SIZE_MIN[this.sizeSelect.SelectedIndex];
      int sizeMax = SIZE_MAX[this.sizeSelect.SelectedIndex];

      this.binList.Clear();

      DateTime startTime = DateTime.Now;
      
      this.binList.Randomize(count, sizeMin, sizeMax, this.panel.Width);

      DateTime endTime = DateTime.Now;
      long time = endTime.Subtract(startTime).Ticks / 10000;

      int width;
      int height;

      this.binList.GetBoundingBin(out width, out height);

      int area = width * height;

      Log.Instance.AddLine("Took " + time + "ms to generate " + count + " boxes bounded within " + width + "px by " + height + "px (area: " + area + "px)");

      this.RefreshPanel();
    }

    private void ToggleLogClick(object sender, EventArgs arguments)
    {
      this.SetLogVisible(!this.logVisible);
    }

    private void ScrambleClick(object sender, EventArgs e)
    {
      DateTime startTime = DateTime.Now;

      BinListSorterRandom.Sort(ref binList, this.panel.Width);

      DateTime endTime = DateTime.Now;
      long time = endTime.Subtract(startTime).Ticks / 10000;

      int width;
      int height;

      this.binList.GetBoundingBin(out width, out height);

      int area = width * height;

      Log.Instance.AddLine("Took " + time + "ms to scramble " + binList.Count + " boxes bounded within " + width + "px by " + height + "px (area: " + area + "px)");

      this.RefreshPanel();
    }

    private void SortClick(object sender, EventArgs arguments)
    {
      Rectangle panelRectangle = new Rectangle(0, 0, panel.Width, panel.Height);
      int unresolved;

      DateTime startTime = DateTime.Now;

      BinListSorterTree.Sort(ref binList, panelRectangle, out unresolved);

      DateTime endTime = DateTime.Now;
      long time = endTime.Subtract(startTime).Ticks / 10000;
      
      if (unresolved > 0)
      {
        Log.Instance.AddLine("Took " + time + "ms to sort " + binList.Count + " boxes, failing to place " + unresolved + " boxes");
      }
      else
      {
        Log.Instance.AddLine("Took " + time + "ms to sort " + binList.Count + " boxes, placed all boxes successfully");
      }

      int width;
      int height;

      this.binList.GetBoundingBin(out width, out height);

      int area = width * height;

      Log.Instance.AddLine("The newly sorted boxes are bounded within " + width + "px by " + height + "px (area: " + area + "px)");

      this.RefreshPanel();
    }
  }
}
