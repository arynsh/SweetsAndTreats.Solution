using System.Collections.Generic;

namespace Pierre.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.Treats = new HashSet<FlavorTreat>();
        }
        public string Name { get; set; }
        public int FlavorId { get; set;}
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<FlavorTreat> Treats { get; set; }

    }
}