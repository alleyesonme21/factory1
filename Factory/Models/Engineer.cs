using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
    {
        public Engineer()
        {
            this.Machines = new HashSet<EngineerMachine>();
        }

        public int EngineerId { get; set; }
        public string Name { get; set; }
        public string Date {get; set;}
        public int Rate {get; set;}
        public virtual ICollection<EngineerMachine> Machines { get; set; }
    }
}