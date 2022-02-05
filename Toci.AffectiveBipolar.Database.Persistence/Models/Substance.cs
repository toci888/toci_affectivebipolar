using System;
using System.Collections.Generic;

#nullable disable

namespace Toci.AffectiveBipolar.Database.Persistence.Models
{
    public partial class Substance
    {
        public Substance()
        {
            Medicaments = new HashSet<Medicament>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Medicament> Medicaments { get; set; }
    }
}
