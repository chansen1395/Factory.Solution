using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
      // this.JoinEntities2 = new HashSet<DepartmentEngineer>();
    }
    public int EngineerId { get; set; }
    public string Name { get; set; }
    // public DateTime RepairDate { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; }
    // public virtual ICollection<DepartmentEngineer> JoinEntities2 { get; }
  }
}