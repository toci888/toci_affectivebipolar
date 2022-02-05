using System;
using System.Collections.Generic;

#nullable disable

namespace Toci.AffectiveBipolar.Database.Persistence.Models
{
    public partial class Affectivebipolarstate
    {
        public Affectivebipolarstate()
        {
            Usercurrentstates = new HashSet<Usercurrentstate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Usercurrentstate> Usercurrentstates { get; set; }
    }
}
