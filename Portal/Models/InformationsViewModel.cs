using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
  public class InformationsViewModel
  {
    public string Date { get; set; }
    public string Key { get; set; }
    public int Sum { get; set; }
    public int VirtualMachines { get; set; }
    public int RequestsCounter { get; set; }

    public int GC0 { get; set; }
    public int GC1 { get; set; }
    public int GC2 { get; set; }
    public string CurrentMemory { get; set; }
    public string PrivateBytes { get; set; }
  }
}
