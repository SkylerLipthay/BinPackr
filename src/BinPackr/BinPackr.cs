using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BinPackr
{
  class BinPackr
  {
    public static void Main()
    {
      BinList binList = new BinList();
      MainForm mainForm = new MainForm(ref binList);

      mainForm.RefreshPanel();

      Application.EnableVisualStyles();
      Application.Run(mainForm);
    }
  }
}
