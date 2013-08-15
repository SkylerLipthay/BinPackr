using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace BinPackr
{
  public class Log : BindingList<string>
  {
    private static Log instance = new Log();

    private const int LINES_MAX = 15;
    
    private Log()
    {
    }

    public static Log Instance
    {
      get
      {
        return instance;
      }
    }

    public void AddLine(string line)
    {
      if (this.Count >= LINES_MAX)
      {
        this.RemoveAt(0);
      }

      this.Add(line);
    }
  }
}
